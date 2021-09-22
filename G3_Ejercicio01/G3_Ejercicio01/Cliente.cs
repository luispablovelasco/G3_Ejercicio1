using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Ejercicio01
{
    class Cliente
    {
        private string dui;
        private string nombre;
        private string apellido;
        private string nit;
        private string codigocuenta;
        private string numerocuenta;
        private double montocuenta;
        private string sucursal;

        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nit
        {
            get { return nit; }
            set { nit = value; }
        }
        public string Numerocuenta
        {
            get { return numerocuenta; }
            set { numerocuenta = value; }
        }

        public string Codigocuenta
        {
            get { return codigocuenta; }
            set { codigocuenta = value; }
        } 
        public double Montoduenta
        {
            get { return montocuenta; }
            set { montocuenta = value; }
        }
        public string Sucursal
        {
            get { return sucursal; }
            set { sucursal = value; }
        }

    }
}
