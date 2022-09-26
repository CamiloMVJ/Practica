using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace pjTransporte
{
    internal abstract class Transporte
    {
        internal String Tipo { get; set; }
        internal String Estado { get; set; }
        internal int Codigo { get; set; }
        internal double Precio { get; set; }
        internal String Marca { get; set; }
        internal String Color { get; set; }

        public Transporte(string tipo, string estado, double precio)
        {
            this.Precio = precio;
            this.Tipo = tipo;
            this.Estado = estado;
        }

        public String ToString(String info)
        {
            info = "Tipo: " + this.Tipo + " Estado: " + this.Estado + " Codigo: " + this.Codigo + " Precio: " + this.Precio;
            return info;
        }

        public int GeneradorCodigo()
        {
            Random ran = new Random();
            return ran.Next(1000, 9999);
        }
        public double CalcuPrecio()
        {
            switch (this.Estado)
            {
                case "Nuevo": return 1000;
                case "Semi-Nuevo": return 500;
            }
            return 0;
        }
        internal enum Tipos
        {
            Moto = 1,
            Carro = 2,
            Tractor = 3,
            Bicicleta = 4
        }


    }
}
