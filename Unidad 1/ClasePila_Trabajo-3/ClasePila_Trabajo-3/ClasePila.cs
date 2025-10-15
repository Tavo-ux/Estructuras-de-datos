using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasePila_Trabajo_3
{
    internal class ClasePila<Tipo> where Tipo : IEquatable<Tipo>
    {
		private ClaseNodo<Tipo> _TopeLista;

		public ClaseNodo<Tipo> Topelista
		{
			get { return _TopeLista; }
			set { _TopeLista = value; }
		}

        public ClasePila()
        {
            _TopeLista = null;
        }

        public bool Vacia 
        {
            get
            {
                if ( Topelista == null)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
        }

        public void Push(Tipo Objeto)
        {
            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = Objeto;
                nodoNuevo.Siguiente = null;
                Topelista = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Topelista;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("El objeto ya existe en la pila");
                    }
                    else
                    {
                        nodoActual = nodoActual.Siguiente;
                    }
                }
                while (nodoActual != null);
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = Objeto;
                nodoNuevo.Siguiente = Topelista;
                Topelista = nodoNuevo;
                return;
            }

        }

        public Tipo Pop()
        {
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
            nodoActual = Topelista;
            if (Vacia)
            {
                throw new Exception("La pila esta vacia");
            }
            else
            {
                Topelista = nodoActual.Siguiente;
                nodoEliminado = nodoActual;
                nodoActual = null;
                return nodoEliminado.ObjetoConDatos;
            }
        }

        public Tipo Pop(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("La pila esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Topelista;
                nodoPrevio = Topelista;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        ClaseNodo<Tipo> nodoEliminado = new ClaseNodo<Tipo>();
                        nodoEliminado = nodoActual;
                        if (nodoActual == Topelista)
                        {
                            Topelista = nodoActual.Siguiente;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }
                        else
                        {
                            nodoPrevio.Siguiente = nodoActual.Siguiente;
                            nodoActual = null;
                            return nodoEliminado.ObjetoConDatos;
                        }

                    }
                    else
                    {
                        nodoPrevio = nodoActual;
                        nodoActual = nodoActual.Siguiente;
                    }
                }
                while (nodoActual != null);
                throw new Exception("El objeto no existe en la pila");
            }
        }

        public Tipo BuscarNodo(Tipo Objeto)
        {
            if (Vacia)
            {
                throw new Exception("La pila esta vacia");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Topelista;
                do
                {
                    if (Objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    else
                    {
                        nodoActual = nodoActual.Siguiente;
                    }
                }
                while (nodoActual != null);
                throw new Exception("El objeto no existe en la pila");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
                nodoActual = Topelista;
                nodoPrevio = Topelista;
                do
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                }
                while (nodoActual != null);
                Topelista = null;
                return;
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
            {
                yield break;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = Topelista;
                do
                {
                    yield return nodoActual.ObjetoConDatos;
                    nodoActual = nodoActual.Siguiente;
                }
                while (nodoActual != null);
                yield break;
            }
        }
    }
}
