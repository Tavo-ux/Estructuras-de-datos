using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila_Trabajo_3
{
    public class Edificio : IEquatable<Edificio>
    {
        private string _strNombre;

        public string Nombre
        {
            get { return _strNombre; }
            set { _strNombre = value; }
        }

        private DateTime _dtmFechaConstruccion;

        public DateTime FechaConstruccion
        {
            get { return _dtmFechaConstruccion; }
            set { _dtmFechaConstruccion = value; }
        }

        private double _dblAltura;

        public double Altura
        {
            get { return _dblAltura; }
            set { _dblAltura = value; }
        }

        private int _intClave;

        public int Clave
        {
            get { return _intClave; }
            set { _intClave = value; }
        }

        private char _chrEstilo;

        public char Estilo
        {
            get { return _chrEstilo; }
            set { _chrEstilo = value; }
        }

        private bool _blnRenovado;

        public bool Renovado
        {
            get { return _blnRenovado; }
            set { _blnRenovado = value; }
        }

        private string _strEpoca;

        public string Epoca
        {
            get { return _strEpoca; }
            set { _strEpoca = value; }
        }


        private string _strImagen;

        public string Imagen
        {
            get { return _strImagen; }
            set { _strImagen = value; }
        }

        public bool Equals(Edificio otroEdificio)
        {
            if (this.Clave == otroEdificio.Clave)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
