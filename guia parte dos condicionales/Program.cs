using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Xsl;

namespace guia_parte_dos_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PUNTO UNO, CACLCULADORA BASICA

            Console.WriteLine("ingrese dos numeros y el tpo de caracter, (+,-,*,/)");

            Console.WriteLine("ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(" ingrese la operacion que desea realizar");
            char funcion = Convert.ToChar(Console.ReadLine());

            double resultado = 0;

            switch (funcion)
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                   if ( num2 != 0 )
                    {
                        resultado = num1 / num2;
                    }
                       
                   else 
                    {
                        Console.WriteLine(" no se puede dividir por cero");
                    }
                    break;

            }
            Console.WriteLine($" el resultado es: {resultado}");

            //PUNTO DOS, DIAS DE LA SEMANA.

            Console.WriteLine("ingrese un numero para elegir el dia de la semana");

            Console.WriteLine(" 1 ");
            Console.WriteLine(" 2 ");
            Console.WriteLine(" 3 ");
            Console.WriteLine(" 4 ");
            Console.WriteLine(" 5 ");
            Console.WriteLine(" 6 ");
            Console.WriteLine(" 7 ");

            int opcion = int.Parse(Console.ReadLine());

            switch (opcion) 
            {
                case 1: 
                    Console.WriteLine("lunes");
                    break;
                case 2:
                    Console.WriteLine("martes");
                    break;
                case 3:
                    Console.WriteLine("miercoles");
                    break;
                case 4:
                    Console.WriteLine("jueves");
                    break;
                case 5:
                    Console.WriteLine("viernes");
                    break;
                 case 6:
                    Console.WriteLine("sabado");
                    break;
                 case 7:
                    Console.WriteLine("domingo");
                    break;
                 default:
                    Console.WriteLine(" opcion incorrecta");
                    break;
          }

            // PUNTO TRES, CONVERSION DE CALIFICACIONES A LETRAS

            Console.WriteLine(" ingrese su calificacion ");
           int cal = int.Parse(Console.ReadLine());
            if (cal == 10)
            {
                Console.WriteLine(" su nota es E ( EXTELENTE ) ");

            }

            else if (cal >= 7 && cal < 10)
            {
                Console.WriteLine(" su nota es MB (MUY BIEN)");

            }
            else if (cal >= 4 && cal < 7)
            {
                Console.WriteLine("su nota es B ( BIEN) ");
            }
            else if (cal <= 3 && cal > 0)
            {
                Console.WriteLine(" su nota es M ( MAL ) ");
            }
            else if (cal > 10 || cal <= 0) 
            {
                Console.WriteLine(" la calificacion ingresada es invalida");
            }




            // PUNTO 4 CLASIFICACION DE TRIANGULOS 

            Console.WriteLine(" ingrese las medidas de su triangulo");
            Console.WriteLine(" medida numero uno ");
            double med1 = double.Parse(Console.ReadLine());
            Console.WriteLine(" medida numero dos");
            double med2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" medida numero tres");
            double med3 = double.Parse(Console.ReadLine());

            if ( med1 ==med2)

            {

            if ( med1==med3)

                {
                    Console.WriteLine(" SU TRIANGULO ES EQUILATERO");
                }
            else
                {
                    Console.WriteLine(" SU TRIANGULO ES ISOSCELES");
                }
            }
            else
            {
                Console.WriteLine(" SU TRIANGULO ES ESCALENO");
            }

            // PUNTO CINCO, ESTACIONES DEL AÑO

            Console.WriteLine(" ingrese el numero de mes ");
            int numM = int.Parse(Console.ReadLine());

            if (numM >= 9 && numM <= 12)
            {
                Console.WriteLine(" LA ESTACION ES PRIMAVERA ");
            }
            else if (numM >= 1 && numM <= 3)
            {
                    Console.WriteLine(" LA ESTACION ES VERANO ");
            }
            else if (numM >= 4 && numM < 6)
            {
                Console.WriteLine(" LA ESTACION ES OTOÑO");
            }
            else if (numM >= 6 && numM < 9)
            {
                Console.WriteLine(" LA ESTACION ES INVIERNO ");
            }
            else
            {
                Console.WriteLine(" el numero es invalido");
            }

            //OTRA FORMA DE HACERLO EXCLUSIVAMENTE CON SWITCH

            Console.WriteLine(" ingrese el numero de mes ");

            int mes = int.Parse(Console.ReadLine());

            switch (mes)
            {
                case 1: Console.WriteLine("la estacion es verano"); break;
                case 2: Console.WriteLine("la estacion es verano"); break;
                case 3: Console.WriteLine("la estacion es verano"); break;
                case 4: Console.WriteLine("la estacion es otoño"); break;
                case 5: Console.WriteLine("la estacion es otoño"); break;
                case 6: Console.WriteLine("la estacion es otoño"); break;
                case 7: Console.WriteLine("la estacion es invierno"); break;
                case 8: Console.WriteLine("la estacion es invierno"); break;
                case 9: Console.WriteLine("la estacion es invierno"); break;
                case 10: Console.WriteLine("la estacion es primavera"); break;
                case 11: Console.WriteLine("la estacion es primavera"); break;
                case 12: Console.WriteLine("la estacion es primavera"); break;
                default: Console.WriteLine(" numero invalido"); break;

            }

            //PUNTO SEIS, DIAS EN UN MES 

            Console.WriteLine(" ingrese el numero del mes para saber su cantidad de dias");
            int numMes = int.Parse(Console.ReadLine());

            switch (numMes) 
            {

                case 1: Console.WriteLine("enero tiene 31 dias"); break;
                case 2: Console.WriteLine("febrero tiene 29 dias"); break;
                case 3: Console.WriteLine("marzo tiene 31 dias"); break;
                case 4: Console.WriteLine("abril tiene 30"); break;
                case 5: Console.WriteLine("mayo tiene 31 dias"); break;
                case 6: Console.WriteLine("junio tiene 30 dias"); break;
                case 7: Console.WriteLine("julio tiene 31 dias"); break;
                case 8: Console.WriteLine("agosto tiene 31 dias"); break;
                case 9: Console.WriteLine("septiembre tiene 30 dias"); break;
                case 10: Console.WriteLine("octubre tiene 31 dias"); break;
                case 11: Console.WriteLine("noviembre tiene 30 dias"); break;
                case 12: Console.WriteLine("diciembre tiene 31 dias"); break;
                default: Console.WriteLine(" numero invalido"); break;
            }

            //PUNTO SIETE CONVERSION DE UNIDADES DE MEDIDA

            Console.WriteLine(" ingrese los centimetros");
            double centim = double.Parse(Console.ReadLine());
            Console.WriteLine(" a que medida desea convertirlo");

            Console.WriteLine(" 1) metros");

            Console.WriteLine(" 2) kilometros");

            int op = int.Parse(Console.ReadLine());

            
            switch (op) 
            {
                case 1: Console.WriteLine(" su medida convertida a metros es " + centim /100); break;
                case 2: Console.WriteLine(" su medida convertida a kilometros es " + centim / 100000); break;
                default : Console.WriteLine(" numero invalido"); break;
            }

            // PUNTO OCHO, DESCUENTO SEGUN CANTIDAD COMPRADA


            Console.WriteLine(" segun su cantidad de alrticulos ingrese una opcion");
            Console.WriteLine(" 1) mas de 5 ariculos");
            Console.WriteLine(" 2) mas de 10 ariculos");
            Console.WriteLine(" 3) mas de 15 ariculos");
            Console.WriteLine(" 4) mas de 20 ariculos ");
            double art = double.Parse(Console.ReadLine());

            if (art == 1)
            {
                Console.WriteLine(" el valor de su compra es 1000 y tiene un 5% de descuento");
            }
            else if (art == 2)
            {
                Console.WriteLine(" el valor de su compra de es 2000 y tiene el 10% de descuento");
            }
            else if (art == 3)
            {
                Console.WriteLine(" el valor de su compra de es 3000 y tiene el 15% de descuento");
            }
            else if (art == 4)
            {
                Console.WriteLine(" el valor de su compra de es 4000 y tiene el 20% de descuento");
            }
            else
                Console.WriteLine(" tecla invalida");
            

            switch ( art )
            {
                case 1: Console.WriteLine("  el valor final es de 950 "); break;
                case 2: Console.WriteLine(" el valor final es de 1800"); break;
                case 3: Console.WriteLine(" el valor final es de 2550"); break;
                case 4: Console.WriteLine(" el valor final es de 3200"); break;
            }


            //PUNTO NUEVE, CLASIFICACION DE NUMEROS POSITIVOS, NEGATIVOS O CERO 

            Console.WriteLine(" ingrese un numero para determinar si es positivo, negativo o cero");
            double numero = double.Parse(Console.ReadLine());

            if (numero == 0 ) { Console.WriteLine(" su numero es CERO");   }
            else if ( numero > 0 ) { Console.WriteLine(" su numero es positivo"); }
            else if ( numero < 0 ) { Console.WriteLine(" su numero es negativo");  }

            //PUNTO DIEZ, CLASIFICACION PARA EL JUEGO ACUATICO EN EL PARQUE DE DIVERSIONES

            
            Console.WriteLine (" segun su edad elija una opcion ");
            Console.WriteLine(" 1) menor de 12 años");
            Console.WriteLine(" 2) entre 12 y 17 años");
            Console.WriteLine(" 3) entre 18 y 64 años");
            Console.WriteLine(" 4) 65 años o mas");

            int selec = int.Parse(Console.ReadLine());

            switch (selec) 
            {
                case 1: Console.WriteLine(" usted es un niño"); break;
                case 2: Console.WriteLine(" usted es un adolecente "); break;
                case 3: Console.WriteLine(" usted es un adulto"); break;
                case 4: Console.WriteLine(" usted es un adulto mayo "); break;
                default: Console.WriteLine(" numero invalido"); return;
            }

            Console.WriteLine(" ingrese su peso");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine(" ingrese su altura ");
            double altura = double.Parse(Console.ReadLine());

            if ( peso <= 120 && altura >= 1.50 ) 
            {
                Console.WriteLine(" felicidades cumplis con los requisitos podes subir al juego");
            }
            else
            {
                Console.WriteLine(" lo sineto no podes ingresar el juago");
            }








































        }
    }
}






