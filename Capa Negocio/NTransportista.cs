using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NTransportista
    {
        public static string Insertar(string razonsocial, string chofer, int ruc,
              string placa, string marcavehiculo, string confvehicular, string inscripcion, string numlicencia)
        {
            DTransportista Obj = new DTransportista();
            Obj.Razonsocial = razonsocial;
            Obj.Chofer= chofer;
            Obj.Ruc= ruc;
            Obj.Placa = placa;
            Obj.MarcaVehiculo = marcavehiculo;
            Obj.ConfVehicular = confvehicular;
            Obj.Inscripcion= inscripcion;
            Obj.NumLicencia = numlicencia;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idtransportista, string razonsocial, string chofer, int ruc,
              string placa, string marcavehiculo, string confvehicular, string inscripcion, string numlicencia)
        {
            DTransportista Obj = new DTransportista();
            Obj.Idtransportista = idtransportista;
            Obj.Razonsocial = razonsocial;
            Obj.Chofer = chofer;
            Obj.Ruc = ruc;
            Obj.Placa = placa;
            Obj.MarcaVehiculo = marcavehiculo;
            Obj.ConfVehicular = confvehicular;
            Obj.Inscripcion = inscripcion;
            Obj.NumLicencia = numlicencia; 
            
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idtransportista)
        {
            DTransportista Obj = new DTransportista();
            Obj.Idtransportista = idtransportista;
            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DTransportista().Mostrar();
        }

        public static DataTable BuscarApellidos(string textobuscar)
        {
            DTransportista Obj = new DTransportista();
            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarApellidos(Obj);
        }
    }
}
