# ProyectoBicicletas
Proyecto de alquiler de bicicletas

El diseño del proyecto es muy simple, se crearon dos clases llamadas ´personas´ y ´familyrental´. Estas clases dependenden de una
interfaz llamada ´IALquileres´.
Esta interfaz tiene dos métodos :´CalcularAlquleres´ y ´PersistirDatos´.
Estos métodos son implementados por las clases personas y familyrental.

El método CalcularAlquileres lo que hace es calcular el costo del alquiler por hora, día, semana; recibiendo como parámetros el 
precio, las horas y la cantidad de personas.

En la clase familyrental el método CalcularAlquileres filtra por cantidad de personas, entre 3 y 5 ; así de esta forma puede hacer
un descuento del 30% sobre el total.

El método persistirdatos lo que hace es insertar en un archivo de texto llamado PersistirDatos.txt, todos los movimientos de alquileres
que se están produciendo(con los parámetros que recibe que son mínimos, solo a modo de ejemplo).

En el archivo que se llama program, lo que se hace es crear una cola FIFO en la que se van guardando los movimientos de alquileres,
tanto de personas como de familyrental. 
Después que instanciamos las clases procedemos a cargar los mensajes en la cola.

Seguidamente recorremos la cola para mostrar los movimientos que hubo y finalmente mostramos la cantidad de mensajes que guardamos.

Es un proyecto a modo de ejemplo utilizando diversas técnicas. Podría ser más completos para poder sacar estadísticas, cantidad de
personas según la hora, etc, etc.

