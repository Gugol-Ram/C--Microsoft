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

//Ejercicio. conmvertir F° a C°

int fahrenheit = 94;
int decr = 32;
float fraccion = 5F/9;
string msg1 = "The temperature is ";
string msg2 = " Celsius.";
Console.WriteLine(fraccion);

Console.WriteLine($@"First option: { msg1 + ((fahrenheit - decr) * fraccion) + msg2 }");
Console.WriteLine($@"First option: {msg1 + Math.Round(((fahrenheit - decr) * fraccion), 1) + msg2}");//Utilizando math.round para mostrar solo 2 decimales
Console.WriteLine($@"2nd option: { msg1 + ((fahrenheit -= 32) * fraccion) + msg2 }");
Console.WriteLine($@"2nd option: {msg1 + ((fahrenheit -= 0) * fraccion).ToString("0.0") + msg2}");//formateo la salida para mostrar solo un decimal. consideracion extra se modificó '-=0' ya que sino vuelve a restar

