<?php

// Iniciar sesión
session_start();

// Verificar si es la primera llamada y establecer la palabra en la sesión
if (!isset($_SESSION['word'])) {
    $_SESSION['word'] = getRandWord();
    $_SESSION['failStatus'] = 0;
    $_SESSION['winStatus'] = 0;
}
// Función para obtener una palabra aleatoria
function getRandWord() {
    $words = array('casa', 'canario', 'zanahoria', 'manteca', 'semilla');
    return $words[array_rand($word)];
}

// Función para obtener el tamaño de la palabra
function getWordLenght() {
    $word = $_SESSION['word'];
    return strlen($word);
}

// Función para verificar el carácter en la palabra
function verifyCharacter($character) {
    $word = $_SESSION['word'];
    $positions = array();
    $failStatus = array();
    $contador = 0;
    for ($i = 0; $i < strlen($word); $i++) {
        if ($word[$i] === $character) {
            $positions[] = $i;
            $contador=$contador+1;
        }
    }
    if(!empty($positions)){
        $_SESSION['winStatus']+=$contador;
        return $positions;
        
    }else {
        $failStatus[0] =100 ;
        $_SESSION['failStatus']++ ;
        $failStatus[1]= $_SESSION['failStatus'];
        return $failStatus;
    }
}
function isWinner(){
 $winStatus = $_SESSION['winStatus'];
 $wordLenght = $_SESSION['word'];
 $isWinner = false;
 if($winStatus === $wordLenght-1){
    $isWinner = true;
 }
 return $isWinner;
}
function isLoser(){
    $failStatus = $_SESSION['failStatus'];
    $fails = 6;
    $isLoser = false;
    if($failStatus === $fails){
       $isLoser = true;
    }
    return $isLoser;
}
// Obtener el método y los parámetros de la solicitud JSON-RPC
$request = json_decode(file_get_contents('php://input'), true);
$method = $request['method'];
$params = $request['params'];

// Verificar el método y ejecutar la función correspondiente
if ($method === 'getWordLenght') {
    $response = array(
        'jsonrpc' => '2.0',
        'result' => getWordLenght(),
        'id' => $request['id']
    );
} elseif ($method === 'verifyCharacter') {
    if (!isset($params['caracter'])) {
        $response = array(
            'jsonrpc' => '2.0',
            'error' => array(
                'code' => -32600,
                'message' => 'Se requiere un carácter en el método verificarCaracter.'
            ),
            'id' => $request['id']
        );
    } else {
        $caracter = $params['caracter'];
        $response = array(
            'jsonrpc' => '2.0',
            'result' => verifyCharacter($caracter),
            'id' => $request['id']
        );
    }
} else {
    $response = array(
        'jsonrpc' => '2.0',
        'error' => array(
            'code' => -32601,
            'message' => 'Método no válido.'
        ),
        'id' => $request['id']
    );
}

// Codificar la respuesta JSON
echo json_encode($response);


