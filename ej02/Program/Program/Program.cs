using Program;
using System;

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de lectura de un archivo de texto linea a linea

            string ruta = "C:\\Users\\rojas\\Desktop\\csharp\\classroom\\ej02\\Program\\Program\\assets\\usuarios.cvs";



            using (StreamReader lector = new StreamReader(ruta))
            {
                string linea;

                // Leer línea por línea hasta que no haya más (null)
                while ((linea = lector.ReadLine()) != null)
                {
                    string[] campos = linea.Split(',');
                    // Usuario usuario = new Usuario(campos[0], campos[1], int.Parse(campos[2]), campos[3], campos[4], int.Parse(campos[5]));
                    // Cliente cliente = new Cliente(campos[0], campos[1], int.Parse(campos[2]), campos[3], campos[4], int.Parse(campos[5]), 65, 23, 26);
                    Empleado empleado = new Empleado(campos[0], campos[1], int.Parse(campos[2]), campos[3], campos[4], int.Parse(campos[5]), 65, 23, "marketing");
                    Console.WriteLine(empleado.ToString());
                }
            }

            Console.WriteLine("Lectura finalizada.");


            /*
            //Ejercicio 1: operaciones enteras basicas
            //suma
            int add = 428 + 593;
            Console.WriteLine("1a. El resultado de " + 428 + " mas " + 593 + " es: " + add);

            //resta
            int subtraction = 1000 - 357;
            Console.WriteLine("1b. El resultado de " + 1000 + " menos " + 357 + " es: " + subtraction);

            //multiplicacion
            int product = 27 * 34;
            Console.WriteLine("1c. El producto de " + 27 + " por " + 34 + " es: " + product);

            //division
            int quotient = 587 / 9;
            int rest = 587 % 9;
            Console.WriteLine("1d. El cociente de " + 587 + " dividido " + 9 + " es: " + quotient + " y el resto es: " + rest);


            //Ejercicio 2: precedencia y agrupacion
            int result = (25 + 7) * 3 - 18 / 2 + (4 * 5) - 6;
            Console.WriteLine("2. El resultado es " + result);


            //Ejercicio 3: conversion de unidades
            float convertion = 732 / 2.54f;
            Console.WriteLine("3. 732 centimetros son: " + convertion.ToString("N2") + " pulgadas");


            //Ejercicio 4: media aritmetica sin bucles
            double average = (7.5 + 8 + 9 + 6.5 + 10) / 5;
            Console.WriteLine("4. La media es: " + average);


            //Ejercicio 5: intercambio de valores
            int a = 12;
            int b = 35;
            a = a + 23;
            b = b - 23;
            Console.WriteLine("5. Ahora a vale: " + a + " y b vale: " + b);


            //Ejercicio 6: descomposicion de un numero
            int num = 834;
            int hundreds = num / 100;
            int tens = (num % 100) / 10;
            int units = num % 10;
            Console.WriteLine("6. El numero " + num + " tiene: " + hundreds + " centenas, " + tens + " decenas y " + units + " unidades.");


            //Ejercicio 7: precio con IVA y descuento
            float price = 199.99f;
            float iva = price * 0.21f;
            float discount = (price + iva) * 0.15f;
            float finalPrice = price + iva - discount;
            Console.WriteLine("7. El precio final es: " + finalPrice.ToString("N2") + " euros.");


            //Ejercicio 8: suma de duraciones
            int seconds = 35 + 50 + 40;
            int mins = 12 + 45 + 28;
            int totalSeconds = seconds + (mins * 60); // total 5225s
            int finalSecs = totalSeconds % 60; // 5s

            int totalMins = totalSeconds / 60; // total 87min
            int finalMins = totalMins % 60; // 27min

            int finalHours = totalMins / 60; // 1h

            string time = $"0{finalHours}:{finalMins}:0{finalSecs}";
            Console.WriteLine("8. La duracion total es: " + time);
            */

        }
    }
}
