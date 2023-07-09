<?php
// Iniciar sesión
session_start();

// Verificar si es la primera llamada y establecer la palabra en la sesión
if (!isset($_SESSION['word'])) {
    setInitialStatus();
}

function setInitialStatus()
{
    $word = getRandWord();
    $_SESSION['word'] = getRandWord();
    $_SESSION['failStatus'] = 0;
    $_SESSION['winStatus'] = 0;
    $_SESSION['elapsedTime'] = 0;
    $_SESSION['name'] = 0;
}

// Función para obtener una palabra aleatoria
function getRandWord()
{
    // $words = array('casa', 'canario', 'zanahoria', 'manteca', 'semilla');
    // return $words[array_rand($words)];
    // $fileLines = file('words.txt', FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
    $words = [];

    // foreach ($fileLines as $line) {
    //     $lineWords = explode("\r\n", $line);
    //     $words = array_merge($words, $lineWords);
    // }
    $words = ["FRUIT", "HOUSE", "BIRD", "AERIALS", "CAR"];

    $randomWord = $words[array_rand($words)];
    $randomWord = strtoupper($randomWord);
    return $randomWord;
}

// Función para obtener el tamaño de la palabra
function getWordLength()
{

    $_SESSION['elapsedTime'] = microtime(true);
    $word = $_SESSION['word'];
    // return strlen($word);
    return $word;
}

// Función para verificar el carácter en la palabra
function verifyCharacter($character)
{
    $word = $_SESSION['word'];
    $positions = array();
    $failStatus = array();
    $contador = 0;

    for ($i = 0; $i < strlen($word); $i++) {
        if ($word[$i] === $character) {
            $positions[] = $i;
        }
    }
    $contador += count($positions);
    if (!empty($positions)) {
        $_SESSION['winStatus'] += $contador;
        return $positions;
    } else {
        $failStatus[0] = 100;
        $_SESSION['failStatus'] += 1;
        $failStatus[1] = $_SESSION['failStatus'];
        return $failStatus;
    }
}

function isWinner()
{
    $winner = [];
    $winStatus = $_SESSION['winStatus'];
    $wordLength = strlen($_SESSION['word']);
    $isWinner = false;

    if ($winStatus === $wordLength) {
        $isWinner = true;
        $_SESSION['elapsedTime'] = (int) (microtime(true) - $_SESSION['elapsedTime']);
        updateTopScores($_SESSION['name'], $_SESSION['elapsedTime']);
    }

    return $isWinner;
}


function isLoser()
{
    $failStatus = $_SESSION['failStatus'];
    $fails = 6;
    $isLoser = false;

    if ($failStatus === $fails) {
        $isLoser = true;
    }

    return $isLoser;
}
function start($name)
{
    $_SESSION['name'] = $name;
    return  $_SESSION['name'];
}
function getName()
{
    $name = $_SESSION['name'];
    return $name;
}
function timeP()
{
    return  $_SESSION['elapsedTime'];
}

function restartGame()
{
    setInitialStatus();
    return true;
}

function getTopScores()
{
    $firstTenLines = array("1. Mauricio: 00 min 02 seconds", "2. Karen: 00 min 38 seconds", "3. William: 1 min 30 seconds");
    return $firstTenLines;
}


function updateTopScores($name, $givenTime)
{
    $givenTimeFormatted = formatTime($givenTime);
    $lines = getTopScores();

    // Remove line numbers from the lines array
    $linesWithoutNumbers = array_map(function ($line) {
        return preg_replace('/^\d+\.\s/', '', $line);
    }, $lines);

    // Sort the lines array in ascending order based on time values
    usort($linesWithoutNumbers, function ($a, $b) {
        // Extract the time values from the strings
        preg_match('/(\d+) min (\d+) seconds/', $a, $matchesA);
        preg_match('/(\d+) min (\d+) seconds/', $b, $matchesB);
        $minutesA = intval($matchesA[1]);
        $secondsA = intval($matchesA[2]);
        $minutesB = intval($matchesB[1]);
        $secondsB = intval($matchesB[2]);

        // Compare the time values
        if ($minutesA == $minutesB) {
            return $secondsA <=> $secondsB;
        } else {
            return $minutesA <=> $minutesB;
        }
    });

    // Check if the given time is shorter than any of the existing times
    $isShorter = false;
    foreach ($linesWithoutNumbers as $line) {
        preg_match('/(\d+) min (\d+) seconds/', $line, $matches);
        $minutes = intval($matches[1]);
        $seconds = intval($matches[2]);

        if ($givenTime < ($minutes * 60 + $seconds)) {
            $isShorter = true;
            break;
        }
    }

    if ($isShorter) {
        // Modify the given time if necessary
        $givenTimeFormatted = formatTime($givenTime);
    }

    // Add the new time to the lines array
    $linesWithoutNumbers[] = $name . ': ' . $givenTimeFormatted;

    // Sort the lines array again
    usort($linesWithoutNumbers, function ($a, $b) {
        // Extract the time values from the strings
        preg_match('/(\d+) min (\d+) seconds/', $a, $matchesA);
        preg_match('/(\d+) min (\d+) seconds/', $b, $matchesB);
        $minutesA = intval($matchesA[1]);
        $secondsA = intval($matchesA[2]);
        $minutesB = intval($matchesB[1]);
        $secondsB = intval($matchesB[2]);

        // Compare the time values
        if ($minutesA == $minutesB) {
            return $secondsA <=> $secondsB;
        } else {
            return $minutesA <=> $minutesB;
        }
    });

    // Truncate the array to keep only the top 10 scores
    $linesWithoutNumbers = array_slice($linesWithoutNumbers, 0, 10);

    // Add line numbers to each line
    $linesWithNumbers = array_map(function ($index, $line) {
        return ($index + 1) . '. ' . $line;
    }, array_keys($linesWithoutNumbers), $linesWithoutNumbers);

    // Write the updated lines back to the file
    file_put_contents('times.txt', implode(PHP_EOL, $linesWithNumbers), LOCK_EX);
}


function formatTime($timeInSeconds)
{
    $minutes = floor($timeInSeconds / 60);
    $seconds = (int)($timeInSeconds % 60);
    return sprintf("%02d", $minutes) . ' min ' . sprintf("%02d", $seconds) . ' seconds';
}

class hangmanServerTest extends \PHPUnit\Framework\TestCase
{
    public function testSetInitialStatus()
    {
        // Test setInitialStatus method
        // Assert that the session variables are set correctly

        // Call the method
        setInitialStatus();

        // Assert the expected values of session variables
        $this->assertArrayHasKey('word', $_SESSION);
        $this->assertArrayHasKey('failStatus', $_SESSION);
        $this->assertArrayHasKey('winStatus', $_SESSION);
        $this->assertArrayHasKey('elapsedTime', $_SESSION);
        $this->assertArrayHasKey('name', $_SESSION);
        $this->assertGreaterThan(0, $_SESSION['word']);
        $this->assertEquals(0, $_SESSION['failStatus']);
        $this->assertEquals(0, $_SESSION['winStatus']);
        $this->assertEquals(0, $_SESSION['elapsedTime']);
        $this->assertEquals(0, $_SESSION['name']);
    }
    public function testGetRandWord()
    {
        // Test getRandWord method
        // Assert that a random word is returned

        // Call the method
        $word = getRandWord();

        // Assert the type and length of the returned word
        $this->assertIsString($word);
        $this->assertGreaterThan(0, strlen($word));
    }
    public function testGetWordLength()
    {
        // Test getWordLength method
        // Assert that the word length is returned correctly

        // Set the word in the session
        $_SESSION['word'] = 'TESTWORD';

        // Call the method
        $wordLength = getWordLength();

        // Assert the expected word length
        $this->assertEquals(8, strlen($wordLength));
    }
    public function testVerifyCharacter()
    {
        // Test verifyCharacter method
        // Assert that character verification works correctly

        // Set the word in the session
        $_SESSION['word'] = 'TESTWORD';

        // Call the method with a character present in the word
        $positions = verifyCharacter('T');

        // Assert the expected positions array
        $this->assertEquals([0, 3], $positions);

        // Call the method with a character not present in the word
        $failStatus = verifyCharacter('A');

        // Assert the expected fail status
        $this->assertEquals([100, 1], $failStatus);
    }

    public function testIsWinner()
    {
        // Test isWinner method
        // Assert that the winner status is determined correctly

        // Set the word length and win status in the session
        $_SESSION['word'] = 'TEST';
        $_SESSION['winStatus'] = 4;

        // Call the method
        $isWinner = isWinner();

        // Assert the expected winner status
        $this->assertTrue($isWinner);
    }
    public function testIsLoser()
    {
        // Test isLoser method
        // Assert that the loser status is determined correctly

        // Set the fail status in the session
        $_SESSION['failStatus'] = 6;

        // Call the method
        $isLoser = isLoser();

        // Assert the expected loser status
        $this->assertTrue($isLoser);
    }
    public function testStart()
    {
        // Test start method
        // Assert that the name is set correctly in the session

        // Call the method
        $name = start('John');

        // Assert the expected name in the session
        $this->assertEquals('John', $_SESSION['name']);
        // Assert the expected name returned by the method
        $this->assertEquals('John', $name);
    }

    public function testGetName()
    {
        // Test getName method
        // Assert that the name is retrieved correctly from the session

        // Set the name in the session
        $_SESSION['name'] = 'John';

        // Call the method
        $name = getName();

        // Assert the expected name
        $this->assertEquals('John', $name);
    }
    public function testTimeP()
    {
        // Test timeP method
        // Assert that the elapsed time is retrieved correctly from the session

        // Set the elapsed time in the session
        $_SESSION['elapsedTime'] = 60;

        // Call the method
        $elapsedTime = timeP();

        // Assert the expected elapsed time
        $this->assertEquals(60, $elapsedTime);
    }
    public function testRestartGame()
    {
        // Test restartGame method
        // Assert that the session variables are reset correctly

        // Set some initial values in the session
        $_SESSION['word'] = 'TEST';
        $_SESSION['failStatus'] = 3;
        $_SESSION['winStatus'] = 2;
        $_SESSION['elapsedTime'] = 120;
        $_SESSION['name'] = 'John';

        // Call the method
        $result = restartGame();

        // Assert that the session variables are reset
        $this->assertArrayHasKey('word', $_SESSION);
        $this->assertArrayHasKey('failStatus', $_SESSION);
        $this->assertArrayHasKey('winStatus', $_SESSION);
        $this->assertArrayHasKey('elapsedTime', $_SESSION);
        $this->assertArrayHasKey('name', $_SESSION);

        // Assert the expected return value
        $this->assertTrue($result);
    }
    public function testFormatTime()
    {
        // Test formatTime method
        // Assert that the time is formatted correctly

        // Call the method with different time values
        $formattedTime1 = formatTime(150);
        $formattedTime2 = formatTime(3720);
        $formattedTime3 = formatTime(65);

        // Assert the expected formatted times
        $this->assertEquals('02 min 30 seconds', $formattedTime1);
        $this->assertEquals('62 min 00 seconds', $formattedTime2);
        $this->assertEquals('01 min 05 seconds', $formattedTime3);
    }
}
