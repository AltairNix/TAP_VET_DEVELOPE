using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;

namespace DAO
{
    public class DAO_Usuario:MVCFeature<Usuario>
    {
        private Conexion objConexion;
        private SqlCommand comando;

        public DAO_Usuario()
        {
            objConexion = Conexion.estadoConexion();
        }




        public void create(Usuario obj)
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
                comando = new SqlCommand(query, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarCon();
            }
        }

        public void update(Usuario obj)
        {
            try
            {
                string query =
                "UPDATE Usuario SET (" +
                "nom_usuario = '" + obj.Nom_usuario + "'" +
                "ape_paterno = '" + obj.Ape_paterno + "'" +
                "tel_fijo = '" + obj.Tel_fijo + "'" +
                "tel_celular = '" + obj.Tel_celular + "'" +
                "correo_elec = '" + obj.Correo_elec + "'" +
                "dir_domicilio = '" + obj.Dir_domicilio + "'" +
                "id_distrito = " + obj.Id_distrito +
                "username = '" + obj.Username + "'" +
                "password = '" + obj.Password + "'" +
                "est_usuario = '" + obj.Est_usuario + "'" +
                "fec_creacion = " + obj.Fec_creacion +
                "fec_actualizacion = " + obj.Fec_actualizacion +
                "id_perfil = " + obj.Id_perfil +
                "id_vet = " + obj.Id_vet +
                "WHERE id_usuario = " + obj.Id_usuario + "";

                comando = new SqlCommand(query, objConexion.getCon());
                objConexion.getCon().Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            finally
            {
                objConexion.getCon().Close();
                objConexion.cerrarCon();
            }
        }

        public void delete(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool find(Usuario obj)
        {
            bool valRegistro;
            string query = " SELECT * FROM Usuario WHERE id_usuario = " + obj.Id_usuario + "";
            comando = new SqlCommand(query, objConexion.getCon());
            objConexion.getCon().Open();
            SqlDataReader read = comando.ExecuteReader();
            valRegistro = read.Read();
            if(valRegistro)
            {
                obj.Id_usuario = Convert.ToInt32(read[0].ToString());

            }
            comando.ExecuteNonQuery();




        }

        public List<Usuario> findAll()
        {
            throw new NotImplementedException();
        }
    }
}
