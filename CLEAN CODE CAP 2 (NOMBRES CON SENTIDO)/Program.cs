using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLEAN_CODE_CAP_2__NOMBRES_CON_SENTIDO_
{
    public class Program
    {
        static void Main(string[] args)
        
        {

            // "USAR NOMBRES QUE SE PUEDAN BUSCAR"

            /* LO QUE NO SE QUIERE VS LO QUE SE QUIERE*/

            double a = 20.50; 
            double b = 5.00;  
            double c = 8.75;  
            double d = 2.00;  

            double total = a + b + c + d;

            Console.WriteLine("Total de la factura: $" + total);

            
            double costoComida = 20.50;
            double costoBebida = 5.00;
            double impuestos = 8.75;
            double propina = 2.00;

            double totalFactura = costoComida + costoBebida + impuestos + propina;

            Console.WriteLine("Total de la factura: $" + totalFactura);

            // EVITAR CODIFICACIONES

            /* LO QUE NO SE QUIERE VS LO QUE SE QUIERE*/

            int velVeh = 60; 
            Console.WriteLine("Velocidad del vehículo: " + velVeh + " km/h");


            int velocidadVehiculo = 60; 

            Console.WriteLine("Velocidad del vehículo: " + velocidadVehiculo + " km/h");

            

        }
        // NOTACIÓN HUNGARA

        /* LO QUE NO SE QUIERE VS LO QUE SE QUIERE*/
        public class Producto
        {
            private string strNombre; // Notación húngara para cadena
            private int nCantidadDisponible; // Notación húngara para número entero
            private double dPrecioUnitario; // Notación húngara para número decimal

            public Producto(string nombre, int cantidad, double precio)
            {
                strNombre = nombre;
                nCantidadDisponible = cantidad;
                dPrecioUnitario = precio;
            }

            public void ImprimirDetalles()
            {
                Console.WriteLine("Nombre: " + strNombre);
                Console.WriteLine("Cantidad disponible: " + nCantidadDisponible);
                Console.WriteLine("Precio unitario: " + dPrecioUnitario);
            }
        }
        public class Producto2
        {
            private string nombre;
            private int cantidadDisponible;
            private double precioUnitario;

            public Producto2(string nombre, int cantidad, double precio)
            {
                this.nombre = nombre;
                cantidadDisponible = cantidad;
                precioUnitario = precio;
            }

            public void ImprimirDetalles()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Cantidad disponible: " + cantidadDisponible);
                Console.WriteLine("Precio unitario: " + precioUnitario);
            }
        }

        //PREFIJOS Y MIEMBROS

        /* LO QUE NO SE QUIERE VS LO QUE SE QUIERE*/
        public class Empleado
        {
            private string m_strNombre; // Prefijo "m_" para indicar miembro privado
            private int m_nEdad; // Prefijo "m_" para indicar miembro privado

            public Empleado(string nombre, int edad)
            {
                m_strNombre = nombre;
                m_nEdad = edad;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine("Nombre: " + m_strNombre);
                Console.WriteLine("Edad: " + m_nEdad);
            }
        }

        public class Empleado2
        {
            private string nombre;
            private int edad;

            public Empleado2(string nombre, int edad)
            {
                this.nombre = nombre;
                this.edad = edad;
            }

            public void MostrarDetalles()
            {
                Console.WriteLine("Nombre: " + nombre);
                Console.WriteLine("Edad: " + edad);
            }
        }

        //Interfaces e Implementaciones

        public interface IAni
        {
            void Comer();
            void Moverse();
        }

        public class gato : IAni
        {
            public void Comer()
            {
                Console.WriteLine("El gato come");
            }

            public void Moverse()
            {
                Console.WriteLine("El gato se mueve");
            }
        }

        public interface IAnimal
        {
            void Alimentarse();
            void Desplazarse();
        }

        public class Gato : IAnimal
        {
            public void Alimentarse()
            {
                Console.WriteLine("El gato está comiendo.");
            }

            public void Desplazarse()
            {
                Console.WriteLine("El gato está caminando.");
            }
        }


    }

}
