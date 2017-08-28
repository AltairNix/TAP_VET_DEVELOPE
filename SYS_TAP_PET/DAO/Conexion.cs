﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Conexion
    {
        //singleton
        private static Conexion objConexion = null;
        private SqlConnection con;

        private Conexion()
        {
            SqlConnection con = new SqlConnection("Data Source=RENATO;Initial Catalog=PET_BD_TAP;Integrated Security=True");
        }

        public static Conexion estadoConexion() 
        {
            if (objConexion == null)
            {
                objConexion = new Conexion();
            }
            return objConexion;
        }

        public SqlConnection getCon()
        {
            return con;
        }

        public void cerrarCon()
        {
            objConexion = null;
        }
    }
}
