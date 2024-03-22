using Microsoft.Win32;
using System.Diagnostics.CodeAnalysis;

namespace ejercicio_lamparitas
{
    internal class lamparitas
    {
        static void Main(string[] args)
        {
            //            Una empresa que se dedica a la comercialización de lamparitas de bajo consumo, registra de sus ventas, los siguientes datos: marca y cantidad.El precio de cada lamparita es de $150(Sin importar la marca).
            //El programa deberá calcular el precio total de la venta, aplicando un descuento si es que corresponde.
            //A.Si compra 6 lamparitas o más, tiene un descuento del 50 %.
            //B.Si compra 5 lamparitas marca “ArgentinaLuz” se aplica un 40 % y si es de otra marca, el descuento es del 30 %.
            //C.Si compra 4 lamparitas marca “ArgentinaLuz” o “FelipeLamparas” se hace un descuento del 25 %, y si es de otra marca el descuento es del 20 %.
            //D.Si compra 3 lamparitas marca “ArgentinaLuz” el descuento es del 15 %, si es “FelipeLamparas se hace un descuento del 10 % y si es otra marca, 5 %.
            //E.Si el importe final con descuento suma más de $950, se debe agregar el 10 % de ingresos brutos.
            //Informar: cantidad de lamparitas, marca, total sin descuento, descuento, total con descuento, y si corresponde total de ingresos brutos y total a pagar.

            int precio = 150;
            string marca;
            int cantidad;         
            double subtotal;
            double descuento;
            double porcentajeDescuento=0;
            double precioConDescuento;
            double precioConIngresosBrutos;
            double valorIngresosBrutos;

            Console.Write("Ingrese la marca de lamparitas a comprar: ");
            marca= Console.ReadLine();

            Console.Write("Ingrese la cantidad de lamparitas: ");
            cantidad=int.Parse(Console.ReadLine());

            if (cantidad>=6)
            {
                porcentajeDescuento = 0.5;
            }
            else
            {
                if (cantidad>=5) 
                { 
                if (marca == "argentinaluz")
                    {
                        porcentajeDescuento = 0.4;
                    }
                    else
                    {
                        porcentajeDescuento = 0.3;
                    }
                }
                else
                {
                    if (cantidad >= 4)
                    {
                        if (marca =="argentinaluz" || marca == "felipelamparas")
                        {
                            porcentajeDescuento = 0.25;
                        }
                        else
                            {
                                porcentajeDescuento = 0.2;
                            }

                    }
                    else
                    {
                        if(cantidad >= 3)
                        {
                            if (marca == "argentinaluz")
                            {
                                porcentajeDescuento = 0.15;
                            }
                            else
                            {
                                if (marca == "felipelamparas")
                                {
                                    porcentajeDescuento = 0.10;
                                }
                                else
                                {
                                    porcentajeDescuento = 0.05;
                                }
                            }
                        }
                    }
                }
                    
            }
            subtotal = cantidad * precio;
            descuento = porcentajeDescuento * subtotal;
            precioConDescuento = subtotal - descuento;

            Console.WriteLine($"marca = {marca}");
            Console.WriteLine($"cantidad = {cantidad}");
            Console.WriteLine($"precio sin descuento = {subtotal}");
            Console.WriteLine($"Descuento = {descuento}");
            Console.WriteLine($"precio con descuento = {precioConDescuento}");

            if (precioConDescuento > 950)
            {
                valorIngresosBrutos = precioConDescuento * 0.1;
                precioConIngresosBrutos = precioConDescuento + valorIngresosBrutos;

                Console.WriteLine($"valor recargo ingresos brutos = {valorIngresosBrutos}");
                Console.WriteLine($"precio final con ingresos brutos = {precioConIngresosBrutos}");
            }
        }
    }
}
