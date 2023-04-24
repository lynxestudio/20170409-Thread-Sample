# Threading: Programa que muestra la creación y ejecución de subprocesos

Todos los sistemas operativos modernos permiten el uso de la concurrencia para hacer varias operaciones de manera simultánea o en paralelo, una manera actual de realizar la concurrencia es con el concepto de threads (hilos).

Un thread es un proceso ligero o un subproceso que tiene un simple flujo de control secuencial, el programa principal siempre tiene un simple flujo de control.

Un programa en C# empieza en un único Thread creado automáticamente por el CLR y el sistema operativo. Los métodos que son comúnmente utilizados por los Threads son:

Start: Inicia la ejecución y el hilo pasa al estado Running.
Suspend: Interrumpe la ejecución, puede reanudarse la ejecución si se invoca al método Resume del hilo que está en estado suspendido.
Sleep: Se invoca con un argumento que recibe la cantidad de milisegundos que el thread que se encuentra en estado Running debe dormir. Al terminarse este tiempo el thread vuelve al estado running
Resume: Reanuda la ejecución de un Thread en estado suspendido y lo pasa al estado running.
Una vez que un thread termina, no puede ser reiniciado.

Para mostrar estos conceptos escribí un programa para demostrar las técnicas básicas de creación de subprocesos llamado SimpleThreadSample, este programa crea un par de subprocesos (threads) que correrán simultáneamente dentro del thread principal del programa.

Cada subproceso corre con una prioridad normal, imprimiendo un mensaje en la consola dentro de un ciclo, invocando al método Sleep para permanecer inactivo.

El primer subproceso tendrá una inactividad de 300 milisegundos y el segundo subproceso tendrá una inactividad de 600 milisegundos.

Fig 1. El código fuente del programa



El programa crea cada subproceso con la clase ThreadStart pasando como argumento para el primer subproceso el método PrintLog10 que imprime el logaritmo del numero 10 y para el segundo subproceso el método Squared que imprime el cuadrado. Una vez creados ambos subprocesos se invoca el método Start() de cada uno de ellos, para pasarlos al estado Running.

Fig 2 la salida del programa en ejecución



Al terminar la ejecución de cada uno de los subprocesos, imprime los milisegundos que tardo en ejecutarse.



Download el código fuente
