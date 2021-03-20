using ConsoleApp2.Clases.ArbolBinarioOrdenado;
using ConsoleApp2.Clases.JuegoAnimal;
using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {


        //NUMERO DE NODOS
        public static int numNodos(Nodo raiz)
        {
            if (raiz == null)
            {
                return 0;
            }
            else
            {
                return 1 + numNodos(raiz.subarbolIzquierdo())
                        + numNodos(raiz.subarbolDerecho());
            }
        }

        /// RECORRIDOS DE LOS NODOS
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en inorden
        public static void inorden(Nodo r)
        {
            if (r != null)
            {
                inorden(r.subarbolIzquierdo());
                r.visitar();
                inorden(r.subarbolDerecho());
            }
        }

        // Recorrido de un árbol binario en postorden
        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }

        static void juegoAnimales()
        {
            Console.WriteLine("Juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("Jugamos otra vez?");
                otroJuego = juego.respuesta();
            } while (otroJuego);
        }

        public static void prueba_arbol_normal()
        {
            try
            {
                // TODO code application logic here
                ArbolBinario arbol;
                Nodo a1, a2, a;
                Stack pila = new Stack();
                a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
                a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
                a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
                pila.Push(a);
                a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
                a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
                a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
                pila.Push(a); // apilamos
                //desapilamos las ramas
                a2 = (Nodo)pila.Pop(); //desapilamos
                a1 = (Nodo)pila.Pop();


                a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
                arbol = new ArbolBinario(a);

                Console.WriteLine("Preorden:");
                preorden(a);

                Console.WriteLine("inorden:");
                inorden(a);


                Console.WriteLine("postorden:");
                postorden(a);

                // pausa para debug
                int pausa;
                pausa = 0;


            }
            catch (Exception ex)
            {
                Console.WriteLine("Ups error " + ex.Message);
            }
        }

        public static void pruebaOrden()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            int[] datos = { 30, 5, 2, 40, 36, 85 };
            SoloNumeros es = new SoloNumeros();
            foreach (int d in datos)
            {
                es.numero = d;
                es.descripcion = $"insertar No.{d}";
                ArBus.insertar(es);
                es = new SoloNumeros();
            }
            int pausa;
            pausa = 0;
            es = new SoloNumeros();
            es.numero = 36;
            es.descripcion = "cualquier cosa";
            ArBus.eliminar(es);
            pausa = 0;

        }
       
        public static void pruebanombre()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            string[] datos = { "Pablo", "Mario", "Ruben", "Carlos", "Karina", "Franco" }; //creaccion del arreglo de nuestros datos

            Estudiante es = new Estudiante(); //hacemos la instancia de la clase Estudiante

            //Hacemos la iteracion
            foreach (string d in datos)
            {
                es.nombre = d; //Insertamos el valor de d
                es.descripcion = $"insertar Nodo {d}";
                ArBus.insertar(es); //Le mandamos es para que inserte el valor de es
                es = new Estudiante(); //Limpiamos el objeto para que no nos siga enviando la misma referencia
            }
            int pausa;
            pausa = 0;

            //Para la parte de eliminar
            es = new Estudiante();
            es.nombre = "Karina"; //Dato a eliminar
            es.descripcion = "Eliminando ";
            ArBus.eliminar(es);//Le mandamos es que es el dato que se va a eliminar
            pausa = 0;

        }



        static void Main(string[] args)
        {
            // prueba_arbol_normal();
            // juegoAnimales();
            //pruebaOrden();
            pruebanombre();


        }
    }
}
