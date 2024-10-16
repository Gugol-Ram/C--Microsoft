﻿// See https://aka.ms/new-console-template for more information
//EJECUTAR CODIGO: dotnet run
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

int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");// Se recupera el valor de la variable value (actualmente 2) y se usa en la operación de interpolación de cadenas.LUEGO se incrementa su valor.
Console.WriteLine("Third: " + value);//por lo que aqui value ahora vale 3
Console.WriteLine("Fourth: " + (++value));//al estar antes de 'value' en este caso primero se incrementa dicho valor. el parentesis no es estrictamente necesario.

//##############################################################
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

//Solucion sugerida
int fahrenheit2 = 94;
decimal celsius = (fahrenheit2 - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");

*/
//##############################################################
/*
int result = 3 + 1 * 5 / 2;
Console.WriteLine(result); //resultado = 5
Primero se evalúan la multiplicación y la división, ya que tienen la mayor precedencia:

    1 * 5 = 5
    Luego, se divide ese resultado por 2: 5 / 2.

División entre enteros:

    Como estamos trabajando con enteros (int), la división truncará la parte decimal. Entonces, 5 / 2 = 2 (en lugar de 2.5, se trunca a 2).

Finalmente, se suma 3:

    3 + 2 = 5.
*/
// Console.WriteLine($"Windows " + 7 + 4);  

//##############################################################
//Proyecto 1. Aplicacion calificaciones.

//1.-Inicializar variables - graded assignment. ordeno la calificacion de cada tarea/materia en una variable int
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

//2.-Declaracion de variable 'en 0' para poder sumar las calificaciones. Aunque la asignación de valores no es necesaria al declarar variables, puede hacer que el código sea más eficaz.
// int sophiaSum = 0;
// int nicolasSum = 0;
// int zahirahSum = 0;
// int jeongSum = 0;

//cargamos los valores:
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
//declaracion de promedios(agregar decimal delante de sophiaSum sino devolvera enteros)
decimal sophiaScore = (decimal) sophiaSum / currentAssignments;
decimal nicolasScore = (decimal) nicolasSum / currentAssignments;
decimal zahirahScore = (decimal) zahirahSum / currentAssignments;
decimal jeongScore = (decimal) jeongSum / currentAssignments;

//3.-Mostrar alumno y su calificacion global(suma de ellas, a modo de testeo)luego de hacer promedios ya no lo requiero como salida
// Console.WriteLine("Sophia: " + sophiaSum);
// Console.WriteLine("Nicolas: " + nicolasSum);
// Console.WriteLine("Zahirah: " + zahirahSum);
// Console.WriteLine("Jeong: " + jeongSum);
/*
Console.WriteLine("Student\t\tCalification\n"); //5.-(nueva linea)
Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA"); //5.- t: tabulacion/alinear columna
Console.WriteLine("Nicolas:\t" + nicolasScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahScore + "\tB");
Console.WriteLine("Jeong:\t\t" + jeongScore + "\tA");
*/
// 4.- Obtener el promedio para c/u
// declaro las variables tipo decimal, HACERLO POR ENCIMA del Console.Writeline anterior
// 5.-Darle formato mediante secuenciasde escape

//########################################################
//Proyecto 2. calificacion y promedio creditos cursos
//cursos del alumno 1
string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

//Creditos que otorga cada curso
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

//equivalente en letras del numero de creditos(A=4,B=3)
int gradeA = 4;
int gradeB = 3;

//Variables para almacenar las calificaciones de c/curso
int course1Grade = gradeA;//4
int course2Grade = gradeB;//3
int course3Grade = gradeB;//3
int course4Grade = gradeB;//3
int course5Grade = gradeA;//4

//inicializando hs credito
int totalCreditHours = 0;

//sumando todas las hs creditos
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

//inicializando total puntos obtenidos
int totalGradePoints = 0;

// Los puntos de calificación obtenidos para un curso equivalen a:número de créditos de ese curso * calificación obtenida
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;


//Promedio
decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;
//Ajuste decimal. Un poco rebuscado
//obtener el primer digito
int leadingDigit = (int) gradePointAverage;
//obtener 1er digito luego de la coma
int firstDigit = (int) ( gradePointAverage * 10) % 10;
//obtener 2do digito luego de la coma
int secondDigit = (int) ( gradePointAverage * 100) % 10;

//Agregar nombre del estudiante a las salidas
Console.WriteLine($"Student: {studentName}\n");//\n para agregar una linea vacia
//encabezado info del curso:
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
//nombre del curso + calificacion obtenida + hs credito que otorga cada curso de cada curso. Actualizado con secuencias de escape
Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");
/*
Console.WriteLine($"{course1Name} {course1Grade} {course1Credit}");
Console.WriteLine($"{course2Name} {course2Grade} {course2Credit}");
Console.WriteLine($"{course3Name} {course3Grade} {course3Credit}");
Console.WriteLine($"{course4Name} {course4Grade} {course4Credit}");
Console.WriteLine($"{course5Name} {course5Grade} {course5Credit}\n");
*/
// Console.WriteLine("");

Console.WriteLine($"puntos de Grado:\t\t{totalGradePoints}\n");
Console.WriteLine($"creditos totales:\t\t\t\t{totalCreditHours}\n");
Console.WriteLine($"\nFinal GPA(full decimal):\t\t\t {gradePointAverage}");
Console.WriteLine($"Final GPA(2 decimal hard way): {leadingDigit}.{firstDigit}{secondDigit}");
Console.WriteLine($"Final GPA(2 decimal easy way): {gradePointAverage.ToString("0.00")} ");