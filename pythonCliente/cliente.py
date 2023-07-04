import json
import requests
import copy
# URL del servidor PHP
url = 'https://titanic.ecci.ucr.ac.cr/~eb78169/tercerproyecto/hangmanServer.php'
session = requests.Session()

session.get('https://titanic.ecci.ucr.ac.cr/~eb78169/tercerproyecto/hangmanServer.php')
def make_request(method, params=None):
    headers = {'Content-Type': 'application/json'}
    payload = {
        'jsonrpc': '2.0',
        'method': method,
        'params': params,
        'id': 1
    }
    response = session.post(url, headers=headers, data=json.dumps(payload))
    # la respuesta siempre va a ser un objeto json es como un diccionario, hay que acceder por la clave result a las elementos
    return response.json()

def game_loop():
    #Arreglo de las posiciones de la letra que el usuari ha adivinado
    correctPositions =[]
    failStatus = 0
    print("Su palabra es ")
    word_length = make_request('getWordLength')
    print(word_length)
    make_request('start', ["Karen"])
    while(True):
        # Siempre comprueba si es ganador o perdedor
        isWinner = make_request('isWinner')['result']
        isLoser = make_request('isLoser')['result'] 
        if(isWinner == True):
            name = make_request('getName')['result']
            print("Congratulations,"  + str( name) +" You have won")
            print(correctPositions)
            print("El tiempo empleado fue de:  ")
            print(make_request('timeP')['result'])
            break 
        if(isLoser==True):
            print("Terrible! you lost")
            break
        #Digita el caracter despues de las comprobaciones
        character = input('Digite Caracter: ')
        
        #Manda al server a digitar el caracter ingresado
        verifyEnteredCharacter= make_request('verifyCharacter',[character])
        #obtiene el tamano de la respuesta del server 
        characterRespondLenght = len(verifyEnteredCharacter['result']) 
        #en caso de que el caracter si este, es decir la primera posicion del arreglo es diferente de 100
        if (verifyEnteredCharacter['result'][0]!=100):
           print("Good!")
           print("The typed character is in the following positions")
           print(verifyEnteredCharacter['result'])
           # Anade las posiciones donde esta el caracter a correctPositions
           for i in range (0, characterRespondLenght):
               correctPositions.append(verifyEnteredCharacter['result'][i])
        else:
            failStatus = verifyEnteredCharacter['result'][1]
            print("You failed, you have "+ str( failStatus) + " out of  6 attempts")
        

# Iniciar el juego
game_loop()
