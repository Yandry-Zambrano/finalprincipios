using System;
namespace CarritoDeCompras
{
    public class Impresora
    {
        public Impresora()
        {
        }
		//se crea una clase solo para imprimir los datos
        //poniendo en practica el primer principio de responsabilidad unica
        public void ImprimirDatosCliente(Cliente cliente)
        {
            
            Console.WriteLine(cliente.Apellidos + cliente.Nombres);

            
            
        }
    }
}
