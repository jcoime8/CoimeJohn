

# Programas en c++
-----------------
## Informacion del autor 
> **Nombre del estudiante:** Coime Bone John Jayron

> **Correo electronico:** john.coime.bone@utelvt.edu.ec

Video de la ACTIVIDAD B1. (https://youtu.be/1uzDcERmaNE)

-------------------------------------------------

## Programas desarrollados

1. **Comparacion de dos numeros** 

Es un programa que ayuda al usuario a comparar entre dos numero de cuan es mayor o menor. Por ejemplo:
Si A == B entoses presentar "Son iguales" caso contrario si se genera otra condicio de Si A > B entonses se presenta "A es el mayor" caso contrario se presentara que "B es mayor".

2. **Suma de dos numeros**

Este programa sirve para sumar dos numeros utilisando bucles contadores y acumuladores. Por ejemplo :
Se ingresa el numero de veses q se va a sumar el numero "N" se ingresa tsmbien la cantidad de la suma C se incrementa el contador i++ y se suma la cantidad con el acumulador A=A+C y si el contador es menor que el numero de veses sumadas "i < N"  entonses se repite el proseso caso contrario se muestra el acumulador" A".

3. **Punto de venta**

Este programa busca saber cual es el valor de una compra cuando el valor es en bruto, con el IVA, eldescuento, y el valor final.Por ejemplo:
Primero se debe de agregar el numero de producto yel valor de cada producto "vp"  tambien se le pondra un contador i++ y un acumulador que se sumara con el valor de cada producto "A = A + vp" y si el contador es menor a la cantidad de productos se repetira el proseso caso contrario se sacara el valor de IVA "vIVA = vb * IVA" tambien se sacara el valor del descuento "vdes = vb * des" y por ultimo el valor final de la compra "vf = vp + vIVA - vdes'.

4. **Calculador de Edades**

En este programa se busca calcular la edad de una persona a traves de la fecha actual y su fecha de nacimiento. Por ejemplo:
Primero se debe de ingresar la fecha actual y luego la fecha de nacimiento y si "da < dn" entonses le restas al mes 1 y le sumas al dia actual 30 y luego se realisa la operacion de "d = da -dn". Y si "ma < mn" entonses se le resta 1 al año y se le suma 12 al mes y se realisa la operacion "m = ma - mn". Y por ultimo se realisa la operacion de los años "a = aa - an" y se presenta a, m, d.

5. **Cuenta moneda**

Este programa busca saaber cuales son las monedas de 0.10, 0.25. Por ejemplo: 
Se ingresa el numero de monedas que vas a ingresarN despues se ingresa la cantidad de monedas "x" e contador i++ y tambien el acumulador que se sumaracon la cantidad de monedas "A = A + x". si x = 0.10 entonses "c1 = c1 +1 y a1 = x + a1" caso contrario " c2 = c2 + 1 y a2 = a2 + x" y si el contador es menor que el numero de monedas entonses se repetira el proseso caso contrario se mostrara a1, c1, a2, c2.

----------------------------------------

## Pasos para descargar los programas y ejecutarlos.

- En termux crearemos un directorio donde guardaras los programas con el comando (mkdir)

- Dentro del directorio ejecutas el comando git clone al lado el link del repositorio para clonarlo.*Ejemplo: git clone https://github.com/jcoime8/CoimeJohn.git*

- Luego entras al repositorio y directorio recien clonados en donde estaran los programas. *Ejemplo:cd CoimeJohn/ACTIVIDAD-E2* 

- Luego crearemos un archivo ejecutable con los programas del directorio. *Por ejemplo: g++ Nombredel archivonq vas a convertir -o nuevo nombre que le pondras al archivo ejecutable*

- Luego ejecutaremos ese archivo. *Por ejemplo: ./nombre del archivo ejecutable*

**(*Aqui termina la explicacion espero que te aya servido :+1*)**
