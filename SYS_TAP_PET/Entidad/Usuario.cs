using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        private int id_usuario;

        public int Id_usuario
        {
            get { return id_usuario; }
            set { id_usuario = value; }
        }
        private string nom_usuario;

        public string Nom_usuario
        {
            get { return nom_usuario; }
            set { nom_usuario = value; }
        }
        private string ape_paterno;

        public string Ape_paterno
        {
            get { return ape_paterno; }
            set { ape_paterno = value; }
        }
        private string ape_materno;

        public string Ape_materno
        {
            get { return ape_materno; }
            set { ape_materno = value; }
        }
        private string tel_fijo;

        public string Tel_fijo
        {
            get { return tel_fijo; }
            set { tel_fijo = value; }
        }
        private string tel_celular;

        public string Tel_celular
        {
            get { return tel_celular; }
            set { tel_celular = value; }
        }
        private string correo_elec;

        public string Correo_elec
        {
            get { return correo_elec; }
            set { correo_elec = value; }
        }
        private string dir_domicilio;

        public string Dir_domicilio
        {
            get { return dir_domicilio; }
            set { dir_domicilio = value; }
        }
        private int id_distrito;

        public int Id_distrito
        {
            get { return id_distrito; }
            set { id_distrito = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string est_usuario;

        public string Est_usuario
        {
            get { return est_usuario; }
            set { est_usuario = value; }
        }
        private DateTime fec_creacion;

        public DateTime Fec_creacion
        {
            get { return fec_creacion; }
            set { fec_creacion = value; }
        }
        private DateTime fec_actualizacion;

        public DateTime Fec_actualizacion
        {
            get { return fec_actualizacion; }
            set { fec_actualizacion = value; }
        }
        private int id_perfil;

        public int Id_perfil
        {
            get { return id_perfil; }
            set { id_perfil = value; }
        }
        private int id_vet;

        public int Id_vet
        {
            get { return id_vet; }
            set { id_vet = value; }
        }


        public Usuario()
        {

        }

        public Usuario(int id_usuario)
        {
            this.Id_usuario = id_usuario;
        }

        public Usuario(int id_usuario, string nom_usuario, string ape_paterno, string ape_materno, string tel_fijo, string tel_celular, string correo_elec,
            string dir_domicilio, int id_distrito, string username, string password, string est_usuario, DateTime fec_creacion, DateTime fec_actualizacion,
            int id_perfil, int id_vet)
        {
            this.Id_usuario = id_usuario;
            this.nom_usuario = nom_usuario;
            this.ape_paterno = ape_paterno;
            this.ape_materno = ape_materno;
            this.tel_fijo = tel_fijo;
            this.tel_celular = tel_celular;
            this.correo_elec = correo_elec;
            this.dir_domicilio = dir_domicilio;
            this.id_distrito = id_distrito;
            this.username = username;
            this.password = password;
            this.est_usuario = est_usuario;
            this.fec_creacion = fec_creacion;
            this.fec_actualizacion = fec_actualizacion;
            this.id_perfil = id_perfil;
            this.id_vet = id_vet;
        }

        
    }
}
