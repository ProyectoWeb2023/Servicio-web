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
    
    return response.json()

def game_loop():
    correctPositions =[]
    failStatus = 0
    print("Su palabra es ")
    
    word_length = make_request('getWordLength')
    print(word_length)
    while(True):
        isWinner = make_request('isWinner')['result']
        isLoser = make_request('isLoser')['result'] 
        if(isWinner == True):
            print("Congratulations, You have won")
            print(correctPositions)
            break 
        if(isLoser==True):
            print("Terrible! you lost")
            break
        character = input('Digite Caracter: ')
        #Esto es un objeto json, se accede como un diccionarioI
        verifyEnteredCharacter= make_request('verifyCharacter',[character])
        characterRespondLenght = len(verifyEnteredCharacter['result']) 
        if (verifyEnteredCharacter['result'][0]!=100):
           print("Good!")
           print("The typed character is in the following positions")
           print(verifyEnteredCharacter['result'])
           for i in range (0, characterRespondLenght):
               
               correctPositions.append(verifyEnteredCharacter['result'][i])
               print(correctPositions)
        else:
            failStatus = verifyEnteredCharacter['result'][1]
            print("You failed, you have "+ str( failStatus) + " out of  6 attempts")
        
    # Obtener la longitud de la palabra
    # word_length = make_request('getWordLength')
    
    # print('Adivina la palabra. La palabra tiene', word_length, 'letras.')

    # while True:
    #     character = input('Ingresa un caracter: ')

    #     # Verificar el carácter en la palabra
    #     result = make_request('verifyCharacter', [character])
    #     print(result)
    #     print( make_request('getWordLength'))
    #     if isinstance(result, list):
    #         if result[0] != 100:
    #             positions = result
    #             print('El caracter', character, 'está en las posiciones:', positions)
    #         else:
    #             print('El caracter', character, 'no está en la palabra.')

    #             # Verificar si ha perdido
    #             if result[1] >= 5:
    #                 print('Has perdido. La palabra era:', make_request('getWordLength'))
    #                 break

            
    #     ganador = make_request('isWinner')
    #     if (ganador ==True):
    #         print('¡Has ganado!')
    #         break

# Iniciar el juego
make_request('greet', 'Usuario')
game_loop()
