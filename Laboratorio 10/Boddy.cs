using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_10
{
    internal class Boddy
    {
        public static int inicio()
        {
            Console.Clear();
            print("================================\n" +
                  "Productos de mPhone\n" +
                  "================================\n" +
                  "1: Ventas de mPhone 3000\n" +
                  "2: Ventas de mPad 3500\n" +
                  "3: Ventas de MAPBrook 3800\n" +
                  "4: Ventas de mWatch 8000\n" +
                  "5: Salir\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            return getOpcion();
        }
        public static int ventasMPhone3000()
        {
            Console.Clear();
            print("================================\n" +
                  "Registrar Venta de mPhone 3000\n" +
                  "================================\n" +
                  "1: Registrar Venta\n" +
                  "2: Registrar Devolución\n" +
                  "3: Menu Principal\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            int opcionMPhone3000 = Convert.ToInt32(Console.ReadLine());
            switch (opcionMPhone3000)
            {
                case 1: registarVentaMPhone3000(); break;
                case 2: registarDevolucionMPhone3000(); break;
            }
            return opcionMPhone3000;
        }
        public static int registarVentaMPhone3000() {
            Console.Clear();
            print("================================\n" +
                  "Registrar venta de: \n" +
                  "================================\n" +
                  "Se va a registrar la venta de un\n" +
                  "mPhone 3000 ¿Desea Continuar?\n" +
                  "1: Sí\n" +
                  "2: No\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            int MPhone3000Venta = Convert.ToInt32(Console.ReadLine());
            switch (MPhone3000Venta)
            {
                case 1: registarVentaMPhone3000(); break;
                case 2: ventasMPhone3000(); break;
            }
            return MPhone3000Venta;
        }
        public static int registarDevolucionMPhone3000() {
            Console.Clear();
            print("================================\n" +
                  "Registrar devolución de: \n" +
                  "================================\n" +
                  "Se va a registrar la devolución de\n" +
                  "un mPhone 3000 ¿Desea Continuar?\n" +
                  "1: Sí\n" +
                  "2: No\n" +
                  "================================\n" +
                  "Ingrese una opción: ");
            int MPhone3000Dev = Convert.ToInt32(Console.ReadLine());

            switch (MPhone3000Dev) {
                case 1:
                    registarDevolucionMPhone3000(); break;
                case 2: ventasMPhone3000(); break;
            }
            return MPhone3000Dev;
        }
        public static int ventasMPhone3500()
        {
            Console.Clear();
            print("================================\n" +
                  "Registrar Venta de mPad 3500\n" +
                  "================================\n" +
                  "1: Registrar Venta\n" +
                  "2: Registrar Devolución\n" +
                  "3: Menu Principal\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) {
                case 1: RegistrarVentasMPhone3500(); break;
                case 2: RegistarDevolucionMPhone3500(); break;
                case 3: inicio(); break;
            }
            return opcion;
        }
        public static int RegistrarVentasMPhone3500() {
            Console.Clear();
            print("================================\n" +
                  "Registrar venta de: \n" +
                  "================================\n" +
                  "Se va a registrar la venta de un\n" +
                  "mPad 3500 ¿Desea Continuar?\n" +
                  "1: Sí\n" +
                  "2: No\n" +
                  "===============================\n" +
                  "Ingrese una opción: \n");
            int MPhone3500Ventas = Convert.ToInt32(Console.ReadLine());
            switch (MPhone3500Ventas)
            {
                case 1: RegistrarVentasMPhone3500(); break;
                case 2: ventasMPhone3500(); break;
            }
            return MPhone3500Ventas;
        }
        public static int RegistarDevolucionMPhone3500()
        {
            Console.Clear();
            print("================================\n" + "" +
                  "Registrar devolución de: \n" +
                  "================================\n" +
                  "Se va a registrar la devolución de\n" +
                  "un mPad 3500 ¿Desea Continuar?\n" +
                  "1: Sí\n" +
                  "2: No\n" +
                  "================================\n" +
                  "Ingrese una opción: ");
            int MPhone3500Dev = Convert.ToInt32(Console.ReadLine());
            switch (MPhone3500Dev) {
                case 1: RegistrarVentasMPhone3500(); break;
                case 2: ventasMPhone3500(); break;
            }
            return MPhone3500Dev;
        }
        public static int ventasMPhone3800()
        {
            Console.Clear();
            print("================================\n" +
                  "Registrar Venta de MAPBrook 3800\n" +
                  "================================\n" +
                  "1: Registrar Venta\n" +
                  "2: Registrar Devolución\n" +
                  "3: Menu Principal\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion) {
                case 1: RegistrarVentasMPhone3800(); break;
                case 2: RegistrarDevolucionMPhone3800();break;
                case 3: inicio(); break;
            }
            return opcion;
        }
        public static int RegistrarVentasMPhone3800(){
            Console.Clear() ;
            print("================================\n"+
                  "Registrar venta de: \n"+
                  "================================\n"+
                  "Se va a registrar la venta de un\n"+
                  "MAPBrook 3800 ¿Desea Continuar?\n"+
                  "1: Sí\n"+
                  "2: No\n"+
                  "================================\n"+
                  "Ingrese una opción: ");
            int MPhone3800= Convert.ToInt32(Console.ReadLine());
            switch (MPhone3800){
                case 1: RegistrarVentasMPhone3800();break;
                case 2: ventasMPhone3800(); break;
            }
            return MPhone3800;
        }
        public static int RegistrarDevolucionMPhone3800() {
            Console.Clear() ;
            print("================================\n"+
                  "Registrar devolución de: \n"+
                  "================================\n"+
                  "Se va a registrar la devolución de\n"+
                  "un MAPBrook 3800 ¿Desea Continuar?\n"+
                  "1: Sí\n"+
                  "2: No\n+"+
                  "================================\n"+
                  "Ingrese una opción: \n");
            int MPhone3800=Convert.ToInt32(Console.ReadLine());
            switch (MPhone3800) { case 1: RegistrarDevolucionMPhone3800();break;
                case 2: ventasMPhone3800();break;
            }
            return MPhone3800;
        }
        public static int ventasMPhone8000()
        {
            Console.Clear();
            print("================================\n" +
                  "Registrar Venta de mWatch 8000\n" +
                  "================================\n" +
                  "1: Registrar Venta\n" +
                  "2: Registrar Devolución\n" +
                  "3: Menu Principal\n" +
                  "================================\n" +
                  "Ingrese una opción: \n");
            int opcion=Convert.ToInt32(Console.ReadLine());
            switch (opcion){
                case 1: RegistrarVentasMPhone8000(); break;
                case 2: RegistrarDevolucionMPhone8000(); break;
                case 3: inicio(); break;
            }
            return opcion;
        }
        public static int RegistrarVentasMPhone8000(){
            Console.Clear();
            print("================================\n"+
                  "Registrar venta de: \n"+
                  "================================\n"+
                  "Se va a registrar la venta de un\n"+
                  "mWatch 8000 ¿Desea Continuar?\n"+
                  "1: Sí\n"+
                  "2: No\n"+
                  "================================\n"+
                  "Ingrese una opción: ");
            int MPhone8000ventas=Convert.ToInt32(Console.ReadLine());
            switch (MPhone8000ventas){
                case 1: RegistrarVentasMPhone8000();break;
                case 2: ventasMPhone8000();break;
            }
            return MPhone8000ventas;
        }
        public static int RegistrarDevolucionMPhone8000(){
            Console.Clear();
            print("================================\n"+
                  "Registrar devolución de: \n"+
                  "================================\n"+
                  "Se va a registrar la devolución de\n"+
                  "un mWatch 8000 ¿Desea Continuar?\n"+
                  "1: Sí\n"+
                  "2: No\n"+
                  "================================\n"+
                  "Ingrese una opción: \n");
            int MPhone8000=Convert.ToInt32(Console.ReadLine());
            switch (MPhone8000) { case 1: RegistrarDevolucionMPhone8000();break;
                case 2: ventasMPhone8000();break;
            }
            return MPhone8000;
        }
        public static int five()
        {
            Console.Clear();
            Boddy.print("================================\n" +
                        "Reporte Final\n" +
                        "================================\n" + "" +
                        "Productos Vendidos | Cantidad\n" +
                        "--------------------------------\n" + "" +
                        "mPhones | 15\n" +
                        "mPads | 2\n" +
                        "MAPBrooks | 5\n" +
                        "mWatches | 3\n" +
                        "--------------------------------\n" +
                        "Total | 25\n" +
                        "================================\n" +
                        "¡Hasta Luego!\n" +
                        "Diseñado tristemente Por: [Oscar Jair Cuadros Núñez]");
            return getOpcion();
        }
        public static void print(string text)
        {
            Console.WriteLine(text);
        }
        public static int getOpcion()
        {
            string opcion = Console.ReadLine();
            return int.Parse(opcion);
        }
        
    }
}
