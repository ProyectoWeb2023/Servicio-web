<?php

require __DIR__ . '/vendor/autoload.php'; // Biblioteca cargada mediante composer

use JsonRPC\Server;



// Iniciar sesión
session_start();

$server = new Server();

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
    $fileLines = file('words.txt', FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
    $words = [];

    foreach ($fileLines as $line) {
        $lineWords = explode("\r\n", $line);
        $words = array_merge($words, $lineWords);
    }

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
            $contador = $contador + 1;
        }
    }
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
        $_SESSION['elapsedTime'] = microtime(true) - $_SESSION['elapsedTime'];
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

function updateTopScores()
{
}

function getTopScores()
{
    $file = 'times.txt';  // Replace with the actual path to your file

    // Read the file and return its contents as an array of strings
    $lines = file($file, FILE_IGNORE_NEW_LINES | FILE_SKIP_EMPTY_LINES);
    $firstTenLines = array_slice($lines, 0, 10);
    return $firstTenLines;
}

$server->getProcedureHandler()
    ->withCallback('getWordLength', Closure::fromCallable('getWordLength'))
    ->withCallback('isWinner', Closure::fromCallable('isWinner'))
    ->withCallback('isLoser', Closure::fromCallable('isLoser'))
    ->withCallback('verifyCharacter', Closure::fromCallable('verifyCharacter'))
    ->withCallback('start', Closure::fromCallable('start'))
    ->withCallback('getName', Closure::fromCallable('getName'))
    ->withCallback('timeP', Closure::fromCallable('timeP'))
    ->withCallback('restartGame', Closure::fromCallable('restartGame'))
    ->withCallback('getTopScores', Closure::fromCallable('getTopScores'));

$request = file_get_contents('php://input');
$response = $server->execute($request);
header('Content-Type: application/json');
echo $response;
