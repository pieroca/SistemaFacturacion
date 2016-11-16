using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DTransportista
    {
        private int _Idtransportista;
        private string _Razonsocial;
        private string _Chofer;
        private int _Ruc;
        private string _Placa;
        private string _MarcaVehiculo;
        private string _ConfVehicular;
        private string _Inscripcion;
        private string _NumLicencia;
        private string _TextoBuscar;

        public int Idtransportista
        {
            get { return _Idtransportista; }
            set { _Idtransportista = value; }
        }

        public string Razonsocial
        {
            get { return _Razonsocial; }
            set { _Razonsocial = value; }
        }

        public string Chofer
        {
            get { return _Chofer; }
            set { _Chofer = value; }
        }

        public int Ruc
        {
            get { return _Ruc; }
            set { _Ruc = value; }
        }

        public string Placa
        {
            get { return _Placa; }
            set { _Placa = value; }
        }

        public string MarcaVehiculo
        {
            get { return _MarcaVehiculo; }
            set { _MarcaVehiculo = value; }
        }

        public string ConfVehicular
        {
            get { return _ConfVehicular; }
            set { _ConfVehicular = value; }
        }

        public string Inscripcion
        {
            get { return _Inscripcion; }
            set { _Inscripcion = value; }
        }

        public string NumLicencia
        {
            get { return _NumLicencia; }
            set { _NumLicencia = value; }
        }

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }
          public DTransportista() 
        {
        
        }

          public DTransportista(int idtransportista, string razonsocial, string chofer, int ruc,
              string placa,string marcavehiculo, string confvehicular, string inscripcion, string numlicencia ,string textobuscar)
        {
            this.Idtransportista= idtransportista;
            this.Razonsocial = razonsocial;
            this.Chofer = chofer;
            this.Ruc = ruc;
            this.Placa = placa;
            this.MarcaVehiculo = marcavehiculo;
            this.ConfVehicular= confvehicular;
            this.Inscripcion = inscripcion;
            this.NumLicencia= numlicencia;
            this.TextoBuscar = textobuscar;
        }

          public string Insertar(DTransportista Transportista)
        {
            string rpta = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinsertar_transportista";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIdtransportista = new SqlParameter();
                ParIdtransportista.ParameterName = "@IdTransportista";
                ParIdtransportista.SqlDbType = SqlDbType.Int;
                ParIdtransportista.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIdtransportista);

                SqlParameter ParRazonsocial= new SqlParameter();
                ParRazonsocial.ParameterName = "@razon_social";
                ParRazonsocial.SqlDbType = SqlDbType.VarChar;
                ParRazonsocial.Size = 50;
                ParRazonsocial.Value = Transportista.Razonsocial;
                SqlCmd.Parameters.Add(ParRazonsocial);

                SqlParameter ParChofer= new SqlParameter();
                ParChofer.ParameterName = "@chofer";
                ParChofer.SqlDbType = SqlDbType.VarChar;
                ParChofer.Size = 50;
                ParChofer.Value = Transportista.Chofer;
                SqlCmd.Parameters.Add(ParChofer);

                SqlParameter ParRuc= new SqlParameter();
                ParRuc.ParameterName = "@ruc";
                ParRuc.SqlDbType = SqlDbType.Int;
                ParRuc.Value = Transportista.Ruc;
                SqlCmd.Parameters.Add(ParRuc);

                SqlParameter ParPlaca= new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 7;
                ParPlaca.Value = Transportista.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParMarcaVehiculo = new SqlParameter();
                ParMarcaVehiculo.ParameterName = "@marcavehiculo";
                ParMarcaVehiculo.SqlDbType = SqlDbType.VarChar;
                ParMarcaVehiculo.Size = 15;
                ParMarcaVehiculo.Value = Transportista.MarcaVehiculo;
                SqlCmd.Parameters.Add(ParMarcaVehiculo);

                SqlParameter ParConfVenicular= new SqlParameter();
                ParConfVenicular.ParameterName = "@conf_vehicular";
                ParConfVenicular.SqlDbType = SqlDbType.VarChar;
                ParConfVenicular.Size = 15;
                ParConfVenicular.Value = Transportista.ConfVehicular;
                SqlCmd.Parameters.Add(ParConfVenicular);

                SqlParameter ParInscripcion= new SqlParameter();
                ParInscripcion.ParameterName = "@inscripcion";
                ParInscripcion.SqlDbType = SqlDbType.VarChar;
                ParInscripcion.Size = 15;
                ParInscripcion.Value = Transportista.Inscripcion;
                SqlCmd.Parameters.Add(ParInscripcion);

                SqlParameter ParNumLicencia= new SqlParameter();
                ParNumLicencia.ParameterName = "@num_licencia";
                ParNumLicencia.SqlDbType = SqlDbType.VarChar;
                ParNumLicencia.Size = 15;
                ParNumLicencia.Value = Transportista.NumLicencia;
                SqlCmd.Parameters.Add(ParNumLicencia);

                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se ingreso el registro";
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

          public string Editar(DTransportista Transportista)
         {
             string rpta = "";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speditar_transportista";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                
                SqlParameter ParIdtrabajador= new SqlParameter();
                ParIdtrabajador.ParameterName = "@IdTransportista";
                ParIdtrabajador.SqlDbType = SqlDbType.Int;
                ParIdtrabajador.Value = Transportista.Idtransportista;
                SqlCmd.Parameters.Add(ParIdtrabajador);


                SqlParameter ParRazonsocial = new SqlParameter();
                ParRazonsocial.ParameterName = "@razon_social";
                ParRazonsocial.SqlDbType = SqlDbType.VarChar;
                ParRazonsocial.Size = 50;
                ParRazonsocial.Value = Transportista.Razonsocial;
                SqlCmd.Parameters.Add(ParRazonsocial);

                SqlParameter ParChofer = new SqlParameter();
                ParChofer.ParameterName = "@chofer";
                ParChofer.SqlDbType = SqlDbType.VarChar;
                ParChofer.Size = 50;
                ParChofer.Value = Transportista.Chofer;
                SqlCmd.Parameters.Add(ParChofer);

                SqlParameter ParRuc = new SqlParameter();
                ParRuc.ParameterName = "@ruc";
                ParRuc.SqlDbType = SqlDbType.Int;
                ParRuc.Value = Transportista.Ruc;
                SqlCmd.Parameters.Add(ParRuc);

                SqlParameter ParPlaca = new SqlParameter();
                ParPlaca.ParameterName = "@placa";
                ParPlaca.SqlDbType = SqlDbType.VarChar;
                ParPlaca.Size = 7;
                ParPlaca.Value = Transportista.Placa;
                SqlCmd.Parameters.Add(ParPlaca);

                SqlParameter ParMarcaVehiculo = new SqlParameter();
                ParMarcaVehiculo.ParameterName = "@marcavehiculo";
                ParMarcaVehiculo.SqlDbType = SqlDbType.VarChar;
                ParMarcaVehiculo.Size = 15;
                ParMarcaVehiculo.Value = Transportista.MarcaVehiculo;
                SqlCmd.Parameters.Add(ParMarcaVehiculo);

                SqlParameter ParConfVenicular = new SqlParameter();
                ParConfVenicular.ParameterName = "@conf_vehicular";
                ParConfVenicular.SqlDbType = SqlDbType.VarChar;
                ParConfVenicular.Size = 15;
                ParConfVenicular.Value = Transportista.ConfVehicular;
                SqlCmd.Parameters.Add(ParConfVenicular);

                SqlParameter ParInscripcion = new SqlParameter();
                ParInscripcion.ParameterName = "@inscripcion";
                ParInscripcion.SqlDbType = SqlDbType.VarChar;
                ParInscripcion.Size = 15;
                ParInscripcion.Value = Transportista.Inscripcion;
                SqlCmd.Parameters.Add(ParInscripcion);

                SqlParameter ParNumLicencia = new SqlParameter();
                ParNumLicencia.ParameterName = "@num_licencia";
                ParNumLicencia.SqlDbType = SqlDbType.VarChar;
                ParNumLicencia.Size = 15;
                ParNumLicencia.Value = Transportista.NumLicencia;
                SqlCmd.Parameters.Add(ParNumLicencia);
          
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
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

          public string Eliminar(DTransportista Transportista)
         {
             string rpta = " ";
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCon.Open();
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "speliminar_transportista";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParIdtrabajador= new SqlParameter();
                 ParIdtrabajador.ParameterName = "@IdTransportista";
                 ParIdtrabajador.SqlDbType = SqlDbType.Int;
                 ParIdtrabajador.Value = Transportista.Idtransportista;
                 SqlCmd.Parameters.Add(ParIdtrabajador);

                 rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el registro";
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
             DataTable DtResultado = new DataTable("transportista");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spmostrar_transportista";
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

         public DataTable BuscarApellidos(DTransportista Trabajador)
         {

             DataTable DtResultado = new DataTable("transportista");
             SqlConnection SqlCon = new SqlConnection();
             try
             {
                 SqlCon.ConnectionString = Conexion.Cn;
                 SqlCommand SqlCmd = new SqlCommand();
                 SqlCmd.Connection = SqlCon;
                 SqlCmd.CommandText = "spbuscar_transportista";
                 SqlCmd.CommandType = CommandType.StoredProcedure;

                 SqlParameter ParTextoBuscar = new SqlParameter();
                 ParTextoBuscar.ParameterName = "@textobuscar";
                 ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                 ParTextoBuscar.Size = 50;
                 ParTextoBuscar.Value = Trabajador.TextoBuscar;
                 SqlCmd.Parameters.Add(ParTextoBuscar);

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
