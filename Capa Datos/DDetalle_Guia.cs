using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DDetalle_Guia
    {
        private int _Iddetalle_guia;  
        private int _Idguia;  
        private int _Cantidad;  
        private decimal _Precio_Venta;
        private string _Descripcion;
        private string _Codigo;
        private string _UnidadMedida;
        private string _Peso;
        private string _CostoTraslado;

        public string CostoTraslado
        {
            get { return _CostoTraslado; }
            set { _CostoTraslado = value; }
        }

        public string Peso
        {
            get { return _Peso; }
            set { _Peso = value; }
        }
        

        public string UnidadMedida
        {
            get { return _UnidadMedida; }
            set { _UnidadMedida = value; }
        }
        

        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }
        

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        } 
 
        public int Iddetalle_guia
        {  
            get { return _Iddetalle_guia; }  
            set { _Iddetalle_guia = value; }  
        }  
          
        public int Idguia
        {  
            get { return _Idguia; }  
            set { _Idguia = value; }  
        }  
          
        public int Cantidad  
        {  
            get { return _Cantidad; }  
            set { _Cantidad = value; }  
        }  
          
        public decimal Precio_Venta  
        {  
            get { return _Precio_Venta; }  
            set { _Precio_Venta = value; }  
        }  
          
        //Constructores  
        public DDetalle_Guia()  
        {  
  
        }  
        public DDetalle_Guia(int iddetalle_guia,int idguia, int cantidad,decimal precio_venta,
            string descripcion, string codigo, string unidadmedida, string peso, string costotraslado)  
        {  
            this.Iddetalle_guia = iddetalle_guia;  
            this.Idguia= idguia;
            this.Descripcion = descripcion;  
            this.Cantidad = cantidad;  
            this.Precio_Venta = precio_venta;  
            this.Codigo = codigo;
            this.UnidadMedida = unidadmedida;
            this.Peso = peso;
            this.CostoTraslado = costotraslado;
              
        }  
  
        //Método Insertar  
        public string Insertar(DDetalle_Guia Detalle_Guia, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)  
        {  
            string rpta = "";  
            try  
            {  
                  
                SqlCommand SqlCmd = new SqlCommand();  
                SqlCmd.Connection = SqlCon;  
                SqlCmd.Transaction = SqlTra;  
                SqlCmd.CommandText = "spinsertar_detalle_guia";  
                SqlCmd.CommandType = CommandType.StoredProcedure;  
  
                SqlParameter ParIddetalle_venta= new SqlParameter();  
                ParIddetalle_venta.ParameterName = "@iddetalle_guia";  
                ParIddetalle_venta.SqlDbType = SqlDbType.Int;  
                ParIddetalle_venta.Direction = ParameterDirection.Output;  
                SqlCmd.Parameters.Add(ParIddetalle_venta);  
  
                SqlParameter ParIdventa= new SqlParameter();  
                ParIdventa.ParameterName = "@idguia";  
                ParIdventa.SqlDbType = SqlDbType.Int;  
                ParIdventa.Value = Detalle_Guia.Idguia;  
                SqlCmd.Parameters.Add(ParIdventa);    
  
                SqlParameter ParCantidad = new SqlParameter();  
                ParCantidad.ParameterName = "@cantidad";  
                ParCantidad.SqlDbType = SqlDbType.Int;  
                ParCantidad.Value = Detalle_Guia.Cantidad;  
                SqlCmd.Parameters.Add(ParCantidad);  
  
                SqlParameter ParPrecio_Venta = new SqlParameter();  
                ParPrecio_Venta.ParameterName = "@precio_venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Venta.Precision = 5;
                ParPrecio_Venta.Scale = 2;
                ParPrecio_Venta.Value = Detalle_Guia.Precio_Venta;  
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParDescripcion= new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 75;
                ParDescripcion.Value = Detalle_Guia.Descripcion;
                SqlCmd.Parameters.Add(ParDescripcion);
                
                SqlParameter ParCodigo= new SqlParameter();
                ParCodigo.ParameterName = "@codigo";
                ParCodigo.SqlDbType = SqlDbType.VarChar;
                ParCodigo.Size = 5;
                ParCodigo.Value = Detalle_Guia.Codigo;
                SqlCmd.Parameters.Add(ParCodigo);

                SqlParameter ParUnidadMedida= new SqlParameter();
                ParUnidadMedida.ParameterName = "@unidad_medida";
                ParUnidadMedida.SqlDbType = SqlDbType.VarChar;
                ParUnidadMedida.Size = 5;
                ParUnidadMedida.Value = Detalle_Guia.UnidadMedida;
                SqlCmd.Parameters.Add(ParUnidadMedida);

                SqlParameter ParPeso= new SqlParameter();
                ParPeso.ParameterName = "@peso";
                ParPeso.SqlDbType = SqlDbType.VarChar;
                ParPeso.Size = 10;
                ParPeso.Value = Detalle_Guia.Peso;
                SqlCmd.Parameters.Add(ParPeso);

                SqlParameter ParCostoTraslado= new SqlParameter();
                ParCostoTraslado.ParameterName = "@costo_min_traslado";
                ParCostoTraslado.SqlDbType = SqlDbType.VarChar;
                ParCostoTraslado.Size = 25;
                ParCostoTraslado.Value = Detalle_Guia.CostoTraslado;
                SqlCmd.Parameters.Add(ParCostoTraslado); 
           
                //Ejecutamos nuestro comando  
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : Convert.ToString(Idguia)+Convert.ToString(Descripcion)+Convert.ToString(Cantidad)+Convert.ToString(Precio_Venta)+Convert.ToString(Peso);  
  
            }  
            catch (Exception ex)  
            {  
                rpta = ex.Message;  
            }  
              
            return rpta;  
  
        }  
    }
}
