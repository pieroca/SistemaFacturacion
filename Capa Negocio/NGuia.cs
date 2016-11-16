using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocio
{
    public class NGuia
    {
        public static string Insertar(int idcliente, int idtrabajador, int idtransportista, DateTime fechaemi, DateTime fechalleg, string tipo_comprobante, string serie, string correlativo,
            string dirpar, string dirlleg, string distrp, string provinp, string departp, string distrl, string provil, string departl, string costomin, string guia,
            string numcompago, string formpag, string motivo ,DataTable dtDetalles)
        {
            DGuia Obj = new DGuia();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Idtransportista = idtransportista;
            Obj.FechaEimsion = fechaemi;
            Obj.FechaLlegada = fechalleg;
            Obj.TipoComprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correaltivo = correlativo;
            Obj.DirPartida = dirpar;
            Obj.DirLlegada = dirlleg;
            Obj.DistritoL = distrl;
            Obj.ProvinciaL= provil;
            Obj.DepartamentoL = departl;
            Obj.DistritoP = distrp;
            Obj.DepartamentoP = departp;
            Obj.ProvinciaP = provinp;
            Obj.CostoMinTraslado = costomin;
            Obj.Guia = guia;
            Obj.NumComPago = numcompago;
            Obj.FormaPago = formpag;
            Obj.Motivo = motivo;

            List<DDetalle_Guia> detalles = new List<DDetalle_Guia>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                DDetalle_Guia detalle = new DDetalle_Guia();
                detalle.Codigo = row["codigo"].ToString();
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descripcion = row["descripcion"].ToString();
                detalle.CostoTraslado = row["costotaslado"].ToString();
                detalle.Peso = row["peso"].ToString();
                detalle.UnidadMedida = row["unidadmedida"].ToString();
                detalles.Add(detalle);
            }


            return Obj.Insertar(Obj, detalles);
        }



        public static string Eliminar(int idventa)
        {
            DVenta Obj = new DVenta();
            Obj.Idventa = idventa;
            return Obj.Eliminar(Obj);
        }


        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }  

    }
}
