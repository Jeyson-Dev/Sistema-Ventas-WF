using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVentas
{
    internal class Ventas
    {
        public string Producto { get; set; }
        public decimal Cantidad { get; set; }

        // Asignacion de precio de los productos
        public decimal AsignarPrecio()
        {
            switch (Producto)
            {
                case "Teclado": return 35;
                case "Impresora": return 350;
                case "Monitor": return 550;
                case "Bocinas": return 50;
                case "Mouse": return 20;
                case "Laptop HP": return 1000;

                default:
                    throw new NotImplementedException("ARTICULO NO IMPLEMENTADO");
            }
        }

        // Calcular SubTotal
        public decimal CalcularSubtotal()
        {
            return AsignarPrecio() * Cantidad;
        }

        // Calcular descuento
        public decimal CalcularDescuento()
        {
            decimal subTotal = CalcularSubtotal();

            if (subTotal <= 300)
                return 0.05m * subTotal;

            else if (subTotal > 300 && subTotal <= 500)
                return 0.1m * subTotal;

            else if (subTotal > 500)
                return 0.125m * subTotal;

            else
                throw new ArgumentOutOfRangeException("No se puede colocar ese precio");
        }

        public decimal CalcularNeto()
        {
            return CalcularSubtotal() - CalcularDescuento();
        }
    }
}
