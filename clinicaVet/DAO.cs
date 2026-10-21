using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clinicaVet
{
    internal class DAO
    {
        public MySqlConnection conexao;

        public DAO()
        {
            
            this.conexao = new MySqlConnection("server=localhost;Database=clinicaVet;Uid=root;password=");
            try
            {
                this.conexao.Open();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao conectar com o banco de dados!\n\n" + erro.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } // fim do construtor
    }
}