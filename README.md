fecha: 29/8/24
Objetivo del programa: Generar contraseñas mas seguras.

Explicacion: 
import random <--- se importa la libreria Random.
def generar_clave(longitud): <--- se define la funcion "Generar Clave" y se genera el parametro longitud, para determinar cuantos carácteres queremos en nuestra clave.
    caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+-.@"
    clave = "" <--- luego se crean dos variables, una de caracteres, la que tendra todos los caracteres que querramos que esten a elegir  y otra de clave.
    for i in range(longitud):
        clave += random.choice(caracteres) <--- los caracteres elegidos se concatenaran a la clave 
    return clave <--- se retorna clave

Longitud = int(input("De que tamano deseas tu clave: ")) <--- se da la opcion de elegir al usuario el tamano de la clave y guardamos esto en la variable Longitud

nueva_clave = generar_clave(Longitud) y la funcion generar clave y le damos la longitud que desee el usuario
print("la nueva clave es:", nueva_clave)
 
Al ejecutar el programa, el programa pregunta el tamano de la clave, luego de digitar la cantidad, el programa muetra la clave en base al numero digitado.
