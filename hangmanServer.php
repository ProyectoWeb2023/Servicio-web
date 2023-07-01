<?php

require __DIR__ . '/vendor/autoload.php'; // Biblioteca cargada mediante composer

use JsonRPC\Server;

$server = new Server();

class MyService
{
    public function greet($name)
    {
        $greeting = 'Hello, ' . $name . '!';
        return $greeting;
    }

    public function addNumbers($a, $b)
    {
        $sum = $a + $b;
        return $sum;
    }
}

// Iniciar sesión
session_start();

// Verificar si es la primera llamada y establecer la palabra en la sesión
if (!isset($_SESSION['word'])) {
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
    return $randomWord;
}

// Función para obtener el tamaño de la palabra
function getWordLength()
{
    $word = $_SESSION['word'];
    return strlen($word);
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
            $contador++;
        }
    }

    if (!empty($positions)) {
        $_SESSION['winStatus'] += $contador;
        return $positions;
    } else {
        $failStatus[0] = 100;
        $_SESSION['failStatus']++;
        $failStatus[1] = $_SESSION['failStatus'];
        return $failStatus;
    }
}

function isWinner()
{
    $winStatus = $_SESSION['winStatus'];
    $wordLength = $_SESSION['word'];
    $isWinner = false;

    if ($winStatus === $wordLength - 1) {
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
    ->withCallback('getRandWord', Closure::fromCallable('getRandWord'));

// Define the greet function
function greet($params)
{
    $name = $params[0];
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
/*
$server->getProcedureHandler()
    ->withMethod('getWordLength')
    ->withCallback('getWordLength');

$server->getProcedureHandler()
    ->withMethod('verifyCharacter')
    ->withCallback('verifyCharacter')
    ->withParam('character');

$request = file_get_contents('php://input');
$response = $server->execute($request);

echo $response;
*/