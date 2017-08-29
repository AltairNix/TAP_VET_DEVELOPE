using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace DAO
{
    public class DaoUsuario:MVCFeature<Usuario>
    {
        private Conexion objConexion;
        private SqlCommand comando;

        public DaoUsuario()
        {
            objConexion = Conexion.EstadoConexion();
        }




        public void create(Usuario obj)
        {
            try
            {

                OperationDataContext OdContext = new OperationDataContext();




                string query =
                    "INSERT INTO Usuario (nom_usuario, ape_paterno, ape_materno, tel_fijo, tel_celular, correo_elec, dir_domicilio, id_distrito, username, password, est_usuario, fec_creacion, fec_actualizacion, id_perfil, id_vet)" +
                    "VALUES ('" + obj.Nom_usuario + "','" + obj.Ape_paterno + "','" + obj.Ape_materno + "','" +
                    obj.Tel_fijo + "','" + obj.Tel_celular + "','" + obj.Correo_elec + "','" + obj.Dir_domicilio +
                    "'," + obj.Id_distrito + "," +
                    ",'" + obj.Username + "','" + obj.Password + "','" + obj.Est_usuario + "'," + obj.Fec_creacion +
                    "'," + obj.Fec_creacion + "," + obj.Fec_actualizacion + "," + obj.Id_perfil + "," + obj.Id_vet +
                    ")";
                comando = new SqlCommand(query, objConexion.GetCon());
                objConexion.GetCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                objConexion.GetCon().Close();
                objConexion.CerrarCon();
            }
        }

        public void update(Usuario obj)
        {
            try
            {
                string query =
                    "INSERT INTO Usuario (nom_usuario, ape_paterno, ape_materno, tel_fijo, tel_celular, correo_elec, dir_domicilio, id_distrito, username, password, est_usuario, fec_creacion, fec_actualizacion, id_perfil, id_vet)" +
                    "VALUES ('" + obj.Nom_usuario + "','" + obj.Ape_paterno + "','" + obj.Ape_materno + "','" +
                    obj.Tel_fijo + "','" + obj.Tel_celular + "','" + obj.Correo_elec + "','" + obj.Dir_domicilio +
                    "'," + obj.Id_distrito + "," +
                    ",'" + obj.Username + "','" + obj.Password + "','" + obj.Est_usuario + "'," + obj.Fec_creacion +
                    "'," + obj.Fec_creacion + "," + obj.Fec_actualizacion + "," + obj.Id_perfil + "," + obj.Id_vet +
                    ")";
                comando = new SqlCommand(query, objConexion.GetCon());
                objConexion.GetCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                objConexion.GetCon().Close();
                objConexion.CerrarCon();
            }
        }

        public void delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public Usuario find(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> findAll()
        {
            throw new NotImplementedException();
        }
    }
}
