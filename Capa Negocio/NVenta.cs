using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos; 


namespace CapaNegocio
{
    public class NVenta
    {
        public static string Insertar( int idcliente, int idtrabajador, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv, string estado, 
            string consignado, string lugar_entrega,string orden,string letras, DataTable dtDetalles)  
        {  
            DVenta Obj = new DVenta();  
            Obj.Idcliente = idcliente;  
            Obj.Idtrabajador = idtrabajador;  
            Obj.Fecha = fecha;  
            Obj.Tipo_Comprobante = tipo_comprobante;  
            Obj.Serie = serie;  
            Obj.Correlativo = correlativo;  
            Obj.Igv = igv;
            Obj.Estado = estado;
            Obj.Consignado = consignado;
            Obj.LugarEntrega = lugar_entrega;
            Obj.Orden = orden;
            Obj.Letras= letras;

            List<DDetalle_Ventas> detalles = new List<DDetalle_Ventas>();  
            foreach (DataRow row in dtDetalles.Rows)  
            {  
                DDetalle_Ventas detalle = new DDetalle_Ventas();  
                detalle.Codigo = row["codigo"].ToString();  
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());  
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());  
                detalle.Descripcion = row["descripcion"].ToString();
                detalle.CostoTraslado = row["costotaslado"].ToString();
                detalle.Peso = row["peso"].ToString();
                detalle.UnidadMedida= row["unidadmedida"].ToString();
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
  

        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)  
        {  
            DVenta Obj = new DVenta();  
            return Obj.BuscarFechas(textobuscar, textobuscar2);  
        }  
        public static DataTable MostrarDetalle(string textobuscar)  
        {  
            DVenta Obj = new DVenta();  
            return Obj.MostrarDetalle(textobuscar);  
        }  
    }  
}
