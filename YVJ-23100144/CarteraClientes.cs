using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YVJ_23100144
{
    public partial class Cliente
    {
        private string _strNombreCliente;
        private string _intTelefono;
        private string _strCorreo;

        public string NombreCliente
        {
            get { return _strNombreCliente; }
            set { _strNombreCliente = value; }
        }
        public string Telefono
        {
            get { return _intTelefono; }
            set { _intTelefono = value; }
        }
        public string CorreoElectronico
        {
            get { return _strCorreo; }
            set { _strCorreo = value; }
        }
        
        //private List<Cliente> _listaClientes = new List<Cliente>();

        //public void InsertarCliente(Cliente miCliente)
        //{
        //    _listaClientes.Add(miCliente);
        //}

        
        //public IEnumerator<Cliente> GetEnumerator()
        //{
        //    foreach (Cliente miCliente in _listaClientes)
        //    {
        //        yield return (miCliente);
        //    }
        //    yield break;
        //}
        
        //~Cliente()
        //{
        //    _listaClientes.Clear();
        //    object Cliente = null;
        //}
    }
}
