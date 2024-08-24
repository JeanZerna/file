import random
def generar_clave(longitud):
    caracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789+-.@"
    clave = ""
    for i in range(longitud):
        clave += random.choice(caracteres)
    return clave

Longitud = int(input("De que tamano deseas tu contrasena: "))

nueva_clave = generar_clave(Longitud)
print("la nueva clave es:", nueva_clave)
