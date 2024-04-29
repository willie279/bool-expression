
using System.Dynamic;

Console.Clear();
//operador de igualdad.
Console.WriteLine('a' == 'a');
Console.WriteLine("a" == "a "); // tener un caracter de espacio antes o despues podria ser aceptable, no es igual
Console.WriteLine('A' == 'a');
Console.WriteLine(1 == 2);
string myValue = "a";
Console.WriteLine("a" == myValue);
string value1 = "a ";
string value2 = " A";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());// covierte todo a minusculas y quita espacion en blanco

// operador de desigualadad

Console.WriteLine('a' != 'a');
Console.WriteLine("a" != "a "); // tener un caracter de espacio antes o despues podria ser aceptable, no es igual
Console.WriteLine('A' != 'a');
Console.WriteLine(1 != 2);
string myValue1 = "a";
Console.WriteLine("a" != myValue1);

// uso de los operadores de comparacion
Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);

// devolver un valor booleano de una cadena. si contiene una frase o una palabra. 
string words = "The quick brown fox jump over the lazy dog";
Console.WriteLine(words.Contains("fox"));
Console.WriteLine(words.Contains("The quick brown"));
Console.WriteLine(!words.Contains("jump"));
Console.WriteLine(!words.Contains("cows"));

//operador condicional ?:
int amount = 100;
int discountAmount1 = amount > 1000 ? 100 : 50;// me evalua si es true impreme 100 sies false 50
Console.WriteLine($"\n\rYour Discount is: {discountAmount1}");
Console.WriteLine($"\n\rYour Discount is: {(amount > 1000 ? 100 : 50)}");// otra forma de hacerlo, operador condicional insertado  

// juego de cara o sello
Random headOrTail = new Random();
int head = headOrTail.Next(0, 2);
string game = head == 0 ? "Head" : "tails";
Console.WriteLine($"\n\rthe result is : {game}");
//otra manera de hacerlo
Random coin = new Random();
int flip = coin.Next(0, 2);
Console.WriteLine((flip == 0) ? "head" : "tail");
//Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails"); elimnando la variable intermedia

/* Actividad de desaifio con expresiones booleanas*/
string permission = "Admin";
int level = 20;

if (permission.Contains("Admin"))
{
    Console.WriteLine((level <= 55) ? "Welcome, Amdin user." : "Welcome, Super Admin user");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine((level <= 20) ? " You dont have sufficient privileges" : "Contact an Admin for access");

}
else
{
    Console.WriteLine("You dont have sufficient privileges");
}
// otra manera de hacer la actividad anterior.
string permission1 = "Admin";
int level1 = 20;

if (permission1.Contains("Admin"))
{
    if (level1 > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission1.Contains("Manager"))
{
    if (level1 >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("\n\rYou do not have sufficient privileges.");
}

//creacion de una variable dentro de un bloque de codigo
bool flag = true;
if (flag)
{
    int value3 = 5;
    Console.WriteLine($"\n\rInside of the code block: {value3}");
}
// Console.WriteLine($"\n\rInside of the code block: {value3}"); da error porque la variable solo puede accederse dentro del if

/* Acceder a una variable
desde un bloque interno como externo*/
bool flag1 = true;
int value = 0; /* debo incializar la variable para que no me de error, si solo la declaro 
y no la inicio me dara error, puede que el bloque if no se ejecute y la variable nunca tenga ese valor*/
if (flag1)
{
    value = 20;
    Console.WriteLine($"\n\rInside of the code block: " + value);
}
Console.WriteLine($"\n\rOutside of the code block: {value}");

// Ejercicio de ambito de variables
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = true;
if (found)
{
    foreach (int number in numbers)
    {
        total += number;
        if (number == 42)
        {
            Console.WriteLine("Set Contain 42");
        }
    }
}
Console.WriteLine($"Total: {total}");

// switch case

int employeeLevel = 200;
string employeeName = "Willie Andres";
string title = "";

switch (employeeLevel)
{
    case 100: // para el caso que ambas etiquetas generan el mismo resultado, se puede agurpar etiquetas
    case 200:
        title = "Senior associate";
        break;

    // case 200:
    // title = "Senior associate";
    // break;

    case 300:
        title = "Manager";
        break;

    case 400:
        title = "senior Manager";
        break;

    default:
        title = "Associate";
        break;
}
Console.WriteLine($"\n\r{employeeName}, {title}");

// ejericio con Switch case
string sku = "02-MN-L";
string[] product = sku.Split('-'); // .split convierte la cadena de arriba en caracteres individuales (01, MN, L)

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default:
        type = "Other";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;

    default:
        color = "white";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "Once Size First all";
        break;
}

Console.WriteLine($"product: {size} {color} {type}");

// instruccion if

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}

for (int i = 10; i >= 0; i--) // recorrido regresivo
{
    Console.WriteLine(i);
}
for (int i = 0; i < 10; i += 3) // omitir valores en el iterados, aqui se incrementa de 3 en 3
{
    Console.WriteLine($"\n\r{i}");
}
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) // corta la iteracion al momento de cumplir la condicion y se sale del ciclo for
        break;
}
// recorrido de una matriz con la instruccion for
/* Restamos 1 del valor porque el número de índice de los elementos 
de matriz es de base cero (los números de índice de los cuatro elementos son 0-3).
i = names2.Length -1 es solamente para inicialiizar la variable */

string[] names2 = { "willie", "Sabina", "Gillary", "Carolina" }; // cadena de 4 elementos

for (int i = names2.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names2[i]);
}

// acutalizacion de un valor en la matriz con la instruccion foreach

//  string[] names = { "Alex", "Eddie", "David", "Michael" };
//  foreach (var name in names)
//  {
//     // Can't do this: assign to 'name' because it is a 'foreach iteration variable
//     if (name == "David") name = "Sammy";
//  } esto da error al correrse, para hacerlo se uso un ciclo for, mirar a continuacion



string[] names3 = { "willie", "Sabina", "Gillary", "Carolina" }; // cadena de 4 elementos
for (int i = 0; i < names3.Length; i++)
{
    if (names3[i] == "Carolina")
    {
        names3[i] = "Serrat";
    }
}
foreach (var name in names3)
{
    Console.WriteLine(name);
}

for (int i = 1; i < 101; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i}-FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i}-Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i}-BUzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}


// // do-while 
Random rolled = new();
/* numero, debe delacrarse antes del bloque do-while, dado que la expresion para salir del bucle
 esta fuera bloque*/
int numero = 0;
do
{
    numero = rolled.Next(1, 10);
    Console.WriteLine(numero);

} while (numero != 7);

// estrucruta while
Random random = new();
int current = random.Next(1, 7);

while (current > 3) // esto puede que nunca se ejecute
{
    Console.WriteLine(current);
    current = random.Next(1, 7);

}
Console.WriteLine($"the last number : {current}");

//instruccion continue
Random ramdom1 = new();
int current1 = 0;

do
{
    current1 = ramdom1.Next(1, 11);

    if (current1 >= 8) continue;

    Console.WriteLine(current1);
} while (current1 != 7);

Random juego = new();
int ataque = 0;
int heroe = 10;
int monstruo = 10;

do
{
    ataque = juego.Next(1, 11);
    monstruo -= ataque;
    Console.WriteLine($"Monstruo has damage and lost {ataque} of blood , and now has {monstruo} healht");
    if (monstruo <= 0) continue; // esto me corta el ciclo si el mosntruo pierde toda su sanrgre (true) en el primer ataque
    { // preguntarle a luis sobre esta logica, 
        ataque = juego.Next(1, 11);
        heroe -= ataque;
        Console.WriteLine($"Heroe has damage and lost {ataque} of blod , and now has {heroe} healht");

    }

} while (monstruo > 0 && heroe > 0); // si me da true, se repite el ciclo, ambos tiene sangre aun

if (heroe > monstruo)
{
    Console.WriteLine("Heroe WINS");
}
else
{
    Console.WriteLine("Mosntruo WINS");
}


