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
                "WHERE id_usuario = " + obj.Id_usuario;

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
            string query = "DELETE FROM Usuario WHERE id_usuario = " + obj.Id_usuario;
            try
            {
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

        public bool find(Usuario obj)
        {
            bool valRegistro;
            string query = "SELECT * FROM Usuario WHERE id_usuario = " + obj.Id_usuario;

            try
            {
                comando = new SqlCommand(query, objConexion.GetCon());
                objConexion.GetCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                valRegistro = read.Read();
                if (valRegistro)
                {
                    obj.Id_usuario = Convert.ToInt32(read[0].ToString());
                    obj.Nom_usuario = read[1].ToString();
                    obj.Ape_paterno = read[2].ToString();
                    obj.Ape_materno = read[3].ToString();
                    obj.Tel_fijo = read[4].ToString();
                    obj.Tel_celular = read[5].ToString();
                    obj.Correo_elec = read[6].ToString();
                    obj.Dir_domicilio = read[7].ToString();
                    obj.Id_distrito = Convert.ToInt32(read[8].ToString());
                    obj.Username = read[9].ToString();
                    obj.Password = read[10].ToString();
                    obj.Est_usuario = read[11].ToString();
                    obj.Fec_creacion = Convert.ToDateTime(read[12].ToString());
                    obj.Fec_actualizacion = Convert.ToDateTime(read[13].ToString());
                    obj.Id_perfil = Convert.ToInt32(read[14].ToString());
                    obj.Id_vet = Convert.ToInt32(read[15].ToString());
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return valRegistro;
        }

        public List<Usuario> findAll()
        {
            List<Usuario> listaUsuario = new List<Usuario>();
            string query = "SELECT * FROM Usuario";

            try
            {
                comando = new SqlCommand(query, objConexion.GetCon());
                objConexion.GetCon().Open();
                SqlDataReader read = comando.ExecuteReader();
                while (read.Read())
                {
                    Usuario obj = new Usuario();
                    obj.Id_usuario = Convert.ToInt32(read[0].ToString());
                    obj.Nom_usuario = read[1].ToString();
                    obj.Ape_paterno = read[2].ToString();
                    obj.Ape_materno = read[3].ToString();
                    obj.Tel_fijo = read[4].ToString();
                    obj.Tel_celular = read[5].ToString();
                    obj.Correo_elec = read[6].ToString();
                    obj.Dir_domicilio = read[7].ToString();
                    obj.Id_distrito = Convert.ToInt32(read[8].ToString());
                    obj.Username = read[9].ToString();
                    obj.Password = read[10].ToString();
                    obj.Est_usuario = read[11].ToString();
                    obj.Fec_creacion = Convert.ToDateTime(read[12].ToString());
                    obj.Fec_actualizacion = Convert.ToDateTime(read[13].ToString());
                    obj.Id_perfil = Convert.ToInt32(read[14].ToString());
                    obj.Id_vet = Convert.ToInt32(read[15].ToString());
                    listaUsuario.Add(obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return listaUsuario;
        }
    }
}
