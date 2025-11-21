using System;
using System.Collections.Generic;
#region USINGS NECESARIOS PARA PROBAR LOS EJEMPLOS ANTERIORES
/*using Practica_patrones_en_CSharp.Decorator;
using Practica_patrones_en_CSharp.Composite;
//using Practica_patrones_en_CSharp.AbstractFactory;
//using Practica_patrones_en_CSharp.AbstractFactory.AbstractClasses;*/
#endregion
/*using Practica_patrones_en_CSharp.Factory_Method;
using Practica_patrones_en_CSharp.Factory_Method.AbstractClasses;*/
using Practica_patrones_en_CSharp.Builder;
using Practica_patrones_en_CSharp.Builder.Core;
namespace Practica_patrones_en_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region DECORATOR
            /*BebidaComponent cafe = new CafeSolo();    
              cafe = new Leche(cafe);
              cafe = new Azucar(cafe);

            Console.WriteLine($"Producto : {cafe.descripcion} tiene un costo de : ${cafe.Costo}");
            Console.ReadKey();*/
            #endregion
            #region COMPOSITE
            /*// creamos un directorio raiz
            Componente root = new Directorio("raiz");
            // creamos unos cuantos archivos
            Componente archivo1 = new Archivo("archivo1.txt", 10);
            Componente archivo2 = new Archivo("archivo2.txt", 206);
            Componente archivo3 = new Archivo("archivo3.txt", 304);
            Componente archivo4 = new Archivo("archivo4.txt", 403);
            Componente archivo5 = new Archivo("archivo5.txt", 504);
            // creamos otros directorios
            Componente dir1 = new Directorio("dir1");
            Componente dir2 = new Directorio("dir2");
            Componente dir3 = new Directorio("dir3");
            // vamos agregando a los directorios los archivos creados
            dir1.agregarHijo(archivo1);
            dir2.agregarHijo(archivo2);
            dir3.agregarHijo(archivo3);
            dir1.agregarHijo(archivo4);
            dir3.agregarHijo(archivo5);
            // agregamos los directorios al directorio raiz asi como un archivo suelto 
            root.agregarHijo(dir1);
            root.agregarHijo(dir2);
            root.agregarHijo(archivo5);

            Console.WriteLine($"el tamaño del directorio es : {root.Nombre} es {root.ObtenerTamaño}");
            Console.WriteLine($"el tamaño del directorio es : {dir1.Nombre} es {dir1.ObtenerTamaño}");
            Console.WriteLine($"el tamaño del directorio es : {dir2.Nombre} es {dir2.ObtenerTamaño}");
            Console.WriteLine($"el tamaño del directorio es : {dir3.Nombre} es {dir3.ObtenerTamaño}");*/



            #endregion
            #region OBSERVER

            #endregion
            #region AbstractFactory
            /*Pizzeria fabrica;
            fabrica = new PizzeriaArgentina();
            Pizza pizza = fabrica.crearPizza();
            Console.WriteLine(pizza);
            fabrica = new PizzeriaItaliana();
            Pizza pizza1 = fabrica.crearPizza();*/
            #endregion
            #region FACTORY METHOD
            /*Pizzeria pizzeriaArg = new PizzeriaArgentina();
            Pizza p1 = pizzeriaArg.crearPizza("napo");
            Console.WriteLine(p1);
            Pizza p2 = pizzeriaArg.crearPizza("cancha");
            Console.WriteLine(p2);

            Pizzeria pizzeriaIta = new PizzeriaItaliana();
            Pizza p3 = pizzeriaIta.crearPizza("napo");
            Console.WriteLine(p3);
            Pizza p4 = pizzeriaIta.crearPizza("cancha");
            Console.WriteLine(p4);

            Console.ReadKey();*/
            #endregion
            #region BUILDER
            /*// aqui en el main aremos que se comporte como
            // nuestro director
            List<PizzaBuilder> lineas = new List<PizzaBuilder>();
            lineas.Add(new PizzaNapolitanaBuilder());
            Pizza unaPizza;
            foreach (PizzaBuilder item in lineas)
            {
                unaPizza = item.buildPizza();
            }*/
            #endregion
            #region SINGLETON
            // aqui ejemplo de como trabajar con este patron singleton
            #endregion
        }
    }
}
