using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DGuia
    {
        private int _IdGuia;
        private int _Idcliente;
        private int _Idtrabajador;
        private int _Idtransportista;
        private DateTime _FechaEimsion;
        private DateTime _FechaLlegada;
        private string _TipoComprobante;
        private string _Serie;
        private string _Correaltivo;
        private string _DirPartida;
        private string _DirLlegada;
        private string _DistritoP;
        private string _ProvinciaP;
        private string _DepartamentoP;
        private string _DistritoL;
        private string _ProvinciaL;
        private string _DepartamentoL;
        private string _CostoMinTraslado;
        private string _Guia;
        private string _NumComPago;
        private string _FormaPago;
        private string _Motivo;

        public string Motivo
        {
            get { return _Motivo; }
            set { _Motivo = value; }
        }

        public int IdGuia
        {
          get { return _IdGuia; }
          set { _IdGuia = value; }
        }

        public int Idcliente
        {
          get { return _Idcliente; }
          set { _Idcliente = value; }
        }        

        public int Idtrabajador
        {
          get { return _Idtrabajador; }
          set { _Idtrabajador = value; }
        }
               
        public int Idtransportista
        {
          get { return _Idtransportista; }
          set { _Idtransportista = value; }
        }

        public DateTime FechaEimsion
        {
          get { return _FechaEimsion; }
          set { _FechaEimsion = value; }
        }
 
        public DateTime FechaLlegada
        {
          get { return _FechaLlegada; }
          set { _FechaLlegada = value; }
        }
                
        public string TipoComprobante
        {
          get { return _TipoComprobante; }
          set { _TipoComprobante = value; }
        }
                
        public string Serie
        {
          get { return _Serie; }
          set { _Serie = value; }
        }
                
        public string Correaltivo
        {
          get { return _Correaltivo; }
          set { _Correaltivo = value; }
        }
                
        public string DirPartida
        {
          get { return _DirPartida; }
          set { _DirPartida = value; }
        }
                
        public string DirLlegada
        {
          get { return _DirLlegada; }
          set { _DirLlegada = value; }
        }
                
        public string DistritoP
        {
          get { return _DistritoP; }
          set { _DistritoP = value; }
        }
                
        public string ProvinciaP
        {
          get { return _ProvinciaP; }
          set { _ProvinciaP = value; }
        }
                
        public string DepartamentoP
        {
          get { return _DepartamentoP; }
          set { _DepartamentoP = value; }
        }
                
        public string DistritoL
        {
          get { return _DistritoL; }
          set { _DistritoL = value; }
        }
                
        public string ProvinciaL
        {
          get { return _ProvinciaL; }
          set { _ProvinciaL = value; }
        }

        public string DepartamentoL
        {
          get { return _DepartamentoL; }
          set { _DepartamentoL = value; }
        }

        public string CostoMinTraslado
        {
          get { return _CostoMinTraslado; }
          set { _CostoMinTraslado = value; }
        }

        public string Guia
        {
          get { return _Guia; }
          set { _Guia = value; }
        }

        public string NumComPago
        {
          get { return _NumComPago; }
          set { _NumComPago = value; }
        }

        public string FormaPago
        {
         get { return _FormaPago; }
         set { _FormaPago = value; }
        }
        

            //Constructores  
        public DGuia()
        {

        }
        public DGuia(int idguia, int idcliente, int idtrabajador, int idtransportista, DateTime fechaemi, DateTime fechalleg, string tipo_comprobante, string serie, string correlativo, 
            string dirpar, string dirlleg, string distrp,string provinp,string departp, string distrl,string provil,string departl,string costomin,string guia,
            string numcompago, string formpag, string motivo)
        {
            this.IdGuia= idguia;
            this.Idcliente = idcliente;
            this.Idtrabajador = idtrabajador;
            this.Idtransportista= idtransportista;
            this.FechaEimsion = fechaemi;
            this.FechaLlegada= fechalleg;
            this.TipoComprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correaltivo = correlativo;
            this.DirPartida = dirpar;
            this.DirLlegada= dirlleg;
            this.DistritoP = distrp;
            this.ProvinciaP = provinp;
            this.DepartamentoP = departp;
            this.DistritoL = distrl;
            this.ProvinciaL = provil;
            this.DepartamentoL = departl;
            this.CostoMinTraslado = costomin;
            this.Guia = guia;
            this.NumComPago = numcompago;
            this.FormaPago = formpag;
            this.Motivo = motivo;

        }
        //Métodos  
        public string Insertar(DGuia Guia, List<DDetalle_Guia> Detalles)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                //Código  
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //Establecer la transacción  
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //Establecer el Comando  
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_guia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                //Parámtros  
                SqlParameter ParIdguia = new SqlParameter();
                ParIdguia.ParameterName = "@idguia";
                ParIdguia.SqlDbType = SqlDbType.Int;
                ParIdguia.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdguia);

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";
                ParIdcliente.SqlDbType = SqlDbType.Int;
                ParIdcliente.Value = Guia.Idcliente;
                SqlCmd.Parameters.Add(ParIdcliente);

                SqlParameter ParIdTrabajador = new SqlParameter();
                ParIdTrabajador.ParameterName = "@idtrabajador";
                ParIdTrabajador.SqlDbType = SqlDbType.Int;
                ParIdTrabajador.Value = Guia.Idtrabajador;
                SqlCmd.Parameters.Add(ParIdTrabajador);

                SqlParameter ParIdTransportista = new SqlParameter();
                ParIdTransportista.ParameterName = "@idtransportista";
                ParIdTransportista.SqlDbType = SqlDbType.Int;
                ParIdTransportista.Value = Guia.Idtransportista;
                SqlCmd.Parameters.Add(ParIdTransportista);

                SqlParameter ParFecha = new SqlParameter();
                ParFecha.ParameterName = "@fecha_emision";
                ParFecha.SqlDbType = SqlDbType.Date;
                ParFecha.Value = Guia.FechaEimsion;
                SqlCmd.Parameters.Add(ParFecha);

                SqlParameter ParFechall = new SqlParameter();
                ParFechall.ParameterName = "@fecha_llegada";
                ParFechall.SqlDbType = SqlDbType.Date;
                ParFechall.Value = Guia.FechaLlegada;
                SqlCmd.Parameters.Add(ParFechall);

                SqlParameter ParTipo_Comprobante = new SqlParameter();
                ParTipo_Comprobante.ParameterName = "@tipo_comprobante";
                ParTipo_Comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_Comprobante.Size = 10;
                ParTipo_Comprobante.Value = Guia.TipoComprobante;
                SqlCmd.Parameters.Add(ParTipo_Comprobante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.Int;
                ParSerie.Value = Guia.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.Int;
                ParCorrelativo.Value = Guia.Correaltivo;
                SqlCmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParDireccionLL = new SqlParameter();
                ParDireccionLL.ParameterName = "@dirrecion_llegada";
                ParDireccionLL.SqlDbType = SqlDbType.VarChar;
                ParDireccionLL.Size = 75;
                ParDireccionLL.Value = Guia.DirLlegada;
                SqlCmd.Parameters.Add(ParDireccionLL);

                SqlParameter ParDireccionP = new SqlParameter();
                ParDireccionP.ParameterName = "@direccion_partida";
                ParDireccionP.SqlDbType = SqlDbType.VarChar;
                ParDireccionP.Size = 75;
                ParDireccionP.Value = Guia.DirPartida;
                SqlCmd.Parameters.Add(ParDireccionP);

                SqlParameter ParDistritol = new SqlParameter();
                ParDistritol.ParameterName = "@distritollegada";
                ParDistritol.SqlDbType = SqlDbType.VarChar;
                ParDistritol.Size = 25;
                ParDistritol.Value = Guia.DistritoL;
                SqlCmd.Parameters.Add(ParDistritol);

                SqlParameter ParProvincial = new SqlParameter();
                ParProvincial.ParameterName = "@provinciallegada";
                ParProvincial.SqlDbType = SqlDbType.VarChar;
                ParProvincial.Size = 25;
                ParProvincial.Value = Guia.ProvinciaL;
                SqlCmd.Parameters.Add(ParProvincial);

                SqlParameter ParDepartamentol = new SqlParameter();
                ParDepartamentol.ParameterName = "@departamentollegada";
                ParDepartamentol.SqlDbType = SqlDbType.VarChar;
                ParDepartamentol.Size = 25;
                ParDepartamentol.Value = Guia.DepartamentoL;
                SqlCmd.Parameters.Add(ParDepartamentol);

                SqlParameter ParDistritop = new SqlParameter();
                ParDistritop.ParameterName = "@distritopartida";
                ParDistritop.SqlDbType = SqlDbType.VarChar;
                ParDistritop.Size = 25;
                ParDistritop.Value = Guia.DistritoP;
                SqlCmd.Parameters.Add(ParDistritop);

                SqlParameter ParProvinciap = new SqlParameter();
                ParProvinciap.ParameterName = "@provinciapartida";
                ParProvinciap.SqlDbType = SqlDbType.VarChar;
                ParProvinciap.Size = 25;
                ParProvinciap.Value = Guia.ProvinciaP;
                SqlCmd.Parameters.Add(ParProvinciap);

                SqlParameter ParDepartamentop = new SqlParameter();
                ParDepartamentop.ParameterName = "@departamentopartida";
                ParDepartamentop.SqlDbType = SqlDbType.VarChar;
                ParDepartamentop.Size = 25;
                ParDepartamentop.Value = Guia.DepartamentoP;
                SqlCmd.Parameters.Add(ParDepartamentop);

                SqlParameter ParCosto = new SqlParameter();
                ParCosto.ParameterName = "@costominimotraslado";
                ParCosto.SqlDbType = SqlDbType.VarChar;
                ParCosto.Size = 15;
                ParCosto.Value = Guia.CostoMinTraslado;
                SqlCmd.Parameters.Add(ParCosto);

                SqlParameter Parguia = new SqlParameter();
                Parguia.ParameterName = "@guia";
                Parguia.SqlDbType = SqlDbType.VarChar;
                Parguia.Size = 25;
                Parguia.Value = Guia.Guia;
                SqlCmd.Parameters.Add(Parguia);

                SqlParameter ParNumComp = new SqlParameter();
                ParNumComp.ParameterName = "@numerocomprobante";
                ParNumComp.SqlDbType = SqlDbType.VarChar;
                ParNumComp.Size = 15;
                ParNumComp.Value = Guia.NumComPago;
                SqlCmd.Parameters.Add(ParNumComp);

                SqlParameter ParFormaPago = new SqlParameter();
                ParFormaPago.ParameterName = "@formapago";
                ParFormaPago.SqlDbType = SqlDbType.VarChar;
                ParFormaPago.Size = 10;
                ParFormaPago.Value = Guia.FormaPago;
                SqlCmd.Parameters.Add(ParFormaPago);

                SqlParameter ParFormaP = new SqlParameter();
                ParFormaP.ParameterName = "@motivo";
                ParFormaP.SqlDbType = SqlDbType.VarChar;
                ParFormaP.Size = 50;
                ParFormaP.Value = Guia.Motivo;
                SqlCmd.Parameters.Add(ParFormaP);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";
                if (rpta.Equals("OK"))
                {


                    this.IdGuia = Convert.ToInt32(SqlCmd.Parameters["@idguia"].Value);
                    foreach (DDetalle_Guia det in Detalles)
                    {
                        //Establecemos el codigo del ingreso que se autogenero  
                        det.Idguia = this.IdGuia;
                        //Llamamos al metodo insertar de la clase DetalleIngreso  
                        //y le pasamos la conexion y la transaccion que debe de usar  
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);

                    }
                }
                if (rpta.Equals("OK"))
                {
                    //Se inserto todo los detalles y confirmamos la transaccion  
                    SqlTra.Commit();
                }
                else
                {
                    //Algun detalle no se inserto y negamos la transaccion  
                    SqlTra.Rollback();
                }

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }
        public string Eliminar(DGuia Guia)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speliminar_guia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idguia";
                ParIdventa.SqlDbType = SqlDbType.Int;
                ParIdventa.Value = Guia.IdGuia;
                SqlCmd.Parameters.Add(ParIdventa);


                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "OK";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return rpta;
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("guia");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_guia";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
