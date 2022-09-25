using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace pjTransporte
{
    internal class Moto : Transporte
    {
        
        internal int Motor { get; set; }
        internal double Precio { get; set; }

        public Moto(int motor, String tipo, String estado, double precio) : base(tipo, estado, precio)
        {   
            this.Motor = motor;
            this.Precio = 800;
            precio = this.Precio;
            
        }
        public double DeterPrecio()
        {
            switch (this.Motor)
            {
                case (int)Motores.Motor_S: this.Precio += 150; break;
                case (int)Motores.Motor_M: this.Precio += 250; break;
                case (int)Motores.Motor_B: this.Precio += 350; break;
            }
            this.Precio += base.CalcuPrecio();
            return this.Precio;
        }
        public enum Motores
        {
            Motor_S = 1,
            Motor_M = 2,
            Motor_B = 3
        }
    }
}
