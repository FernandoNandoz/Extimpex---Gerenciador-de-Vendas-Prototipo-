using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Extimpex
{
    public static class Usuario
    {
        public static string _Login = ("FERNANDO");
        private static string Login
        {
            get { return _Login; }
            set { _Login = value; }
        }
    }

    public static class Conexao
    {
        public static SqlConnection _conexao = new SqlConnection("Data Source=(local);Initial Catalog=BancoExtimpex;Integrated Security=True");
        private static SqlConnection conexao
        {
            get { return _conexao; }
            set { _conexao = value;}
        }
    }
}
