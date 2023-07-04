<?php

require __DIR__ . '/vendor/autoload.php'; // Biblioteca cargada mediante composer

use JsonRPC\Server;



// Iniciar sesión
session_start();

$server = new Server();
// Verificar si es la primera llamada y establecer la palabra en la sesión
if (!isset($_SESSION['word'])) {
    $word = getRandWord();
    $_SESSION['word'] = getRandWord();
    $_SESSION['failStatus'] = 0;
    $_SESSION['winStatus'] = 0;
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
    $status = array();
    $status[] = $_SESSION['word'];
    $status[]= $_SESSION['failStatus'];
    $status[]=  $_SESSION['winStatus'];
    // return strlen($word);
    return $status;
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
            $contador = $contador+1;
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
    $winStatus = $_SESSION['winStatus'];
    $wordLength = strlen($_SESSION['word']);
    $isWinner = false;

    if ($winStatus === $wordLength) {
        $isWinner = true;
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

$server->getProcedureHandler()
    ->withCallback('greet', Closure::fromCallable('greet'))
    ->withCallback('addNumbers', Closure::fromCallable('addNumbers'))
    ->withCallback('getWordLength', Closure::fromCallable('getWordLength'))
    ->withCallback('isWinner', Closure::fromCallable('isWinner'))
    ->withCallback('isLoser', Closure::fromCallable('isLoser'))
    ->withCallback('verifyCharacter', Closure::fromCallable('verifyCharacter'));

// Define the greet function
function greet($params)
{
    $name = $params;
    $greeting = 'Hello, ' . $name . '!';
    return $greeting;
}

// Define the addNumbers function
function addNumbers($params)
{
    $a = $params[0];
    $b = $params[1];
    $sum = $a + $b;
    return $sum;
}

$request = file_get_contents('php://input');
$response = $server->execute($request);
header('Content-Type: application/json');
echo $response;
?>
