// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*
//Incremento y decremento
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
*/

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");// Se recupera el valor de la variable value (actualmente 2) y se usa en la operación de interpolación de cadenas.LUEGO se incrementa su valor.
Console.WriteLine("Third: " + value);//por lo que aqui value ahora vale 3
Console.WriteLine("Fourth: " + (++value));//al estar antes de 'value' en este caso primero se incrementa dicho valor. el parentesis no es estrictamente necesario.