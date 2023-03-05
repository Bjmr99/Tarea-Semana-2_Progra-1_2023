//EJERCICIO 1
Console.WriteLine("Ingrese su Edad: ");
int edad = int.Parse(Console.ReadLine());
Console.WriteLine("No aparentas " + edad + "años");
Console.ReadKey();

//EJERCICIO 2
byte num1, num2;
ushort resultado;
Console.WriteLine("Ingrese el primer numero");
num1 = Byte.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = Byte.Parse(Console.ReadLine());
resultado = Convert.ToUInt16(num1 * num2);
Console.WriteLine("El resultado es: " + resultado);

//EJERCICIO 3
long num1, num2;
long suma, resta, producto;
Console.WriteLine("\t\tINGRESE NUMEROS EN FORMATO LARGO, EJ: 12500000255874625 \n");
Console.WriteLine("Ingrese el primer numero ");
num1 = long.Parse(Console.ReadLine());
Console.WriteLine("Ingrese el segundo numero");
num2 = long.Parse(Console.ReadLine());
suma = num1 + num2;
resta = num1 - num2;
producto = num1 * num2;
Console.WriteLine("El resultado de la SUMA: " + suma);
Console.WriteLine("El resultado de la RESTA: " + resta);
Console.WriteLine("El resultado de su PRODUCTO: " + producto);

