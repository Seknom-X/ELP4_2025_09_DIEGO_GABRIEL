using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoPaises : DAO<Paises>
    {
        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = $"delete from paises where id = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", oPais.Codigo);
                    cmd.ExecuteNonQuery();
                }
                return $"País '{oPais.Pais}' removido com sucesso!";
            }
            catch (Exception ex)
            {
                return $"ERRO: País '{oPais.Pais}' vinculado a um ou mais estados!";
            }
        }
        public override List<Paises> Listar()
        {
            string mSql = "select * from paises order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Paises> lista = new List<Paises>();
                while (reader.Read())
                {
                    Paises oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Pais"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                    lista.Add(oPais);
                }
                reader.Close();
                return lista;
            }
        }
        public override Object CarregaObj(int chave)
        {
            string mSql = $"select * from paises where id = {chave}";
            Paises oPais = null;

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Pais"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                }
                reader.Close();
            }
            return oPais;
        }
        public override List<Paises> Pesquisar(string chave)
        {
            string mSql = $"select * from paises where pais like '%{chave}%' or id like '%{chave}%' or sigla like '%{chave}%' or ddi like '%{chave}%' or moeda like '%{chave}%'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Paises> lista = new List<Paises>();
                while (reader.Read())
                {
                    Paises oPais = new Paises();
                    oPais.Codigo = Convert.ToInt32(reader["id"]);
                    oPais.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oPais.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oPais.Pais = reader["Pais"].ToString();
                    oPais.Sigla = reader["Sigla"].ToString();
                    oPais.Ddi = reader["DDI"].ToString();
                    oPais.Moeda = reader["Moeda"].ToString();
                    lista.Add(oPais);
                }
                reader.Close();
                return lista;
            }
        }

        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;
            string mSql = "", mOk = "";
            if (oPais.Codigo == 0)
            {
                mSql = "insert into paises(pais, sigla, ddi, moeda, datcad, ultalt) values(@pais, @sigla, @ddi, @moeda, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update paises set pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda, datcad = @datCad, ultalt = @ultAlt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@ddi", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@datCad", oPais.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", oPais.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
