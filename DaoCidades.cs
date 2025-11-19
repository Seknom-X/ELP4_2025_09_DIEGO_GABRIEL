using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoCidades : DAO<Cidades>
    {
        public override string Excluir(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = $"delete from cidades where id = @id";
            try
            {
                using (SqlCommand cmd = new SqlCommand(mSql, cnn))
                {
                    cmd.Parameters.AddWithValue("@id", aCidade.Codigo);
                    cmd.ExecuteNonQuery();
                }
                return $"Cidade '{aCidade.Cidade}' removido com sucesso!";
            }
            catch (Exception ex)
            {
                return $"ERRO: {ex.Message}";
            }
        }
        public override List<Cidades> Listar()
        {
            string mSql = "select * from cidades order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Cidades> lista = new List<Cidades>();
                while (reader.Read())
                {
                    Cidades aCidade = new Cidades();
                    aCidade.Codigo = Convert.ToInt32(reader["id"]);
                    aCidade.DatCad = Convert.ToDateTime(reader["datCad"]);
                    aCidade.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    aCidade.Cidade = reader["Cidade"].ToString();
                    aCidade.Ddd = reader["DDD"].ToString();
                    aCidade.OEstado.Estado = reader["Estado"].ToString();
                    aCidade.OEstado.Codigo = Convert.ToInt32(reader["Estado_id"]);
                    lista.Add(aCidade);
                }
                reader.Close();
                return lista;
            }
        }
        public override Object CarregaObj(int chave)
        {
            string mSql = $"select * from cidades where id = {chave}";
            Cidades aCidade = null;

            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    aCidade = new Cidades();
                    aCidade.Codigo = Convert.ToInt32(reader["id"]);
                    aCidade.DatCad = Convert.ToDateTime(reader["datCad"]);
                    aCidade.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    aCidade.Cidade = reader["Estado"].ToString();
                    aCidade.Ddd = reader["Ddd"].ToString();
                    aCidade.OEstado.Estado = reader["Estado"].ToString();
                    aCidade.OEstado.Codigo = Convert.ToInt32(reader["Estado_id"]);
                }
                reader.Close();
            }
            return aCidade;
        }
        public override List<Cidades> Pesquisar(string chave)
        {
            string mSql = $"select * from cidades where cidade like '%{chave}%' or id like '%{chave}%' or Ddd like '%{chave}%' or estado_id like '%{chave}%' or estado like '%{chave}%'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Cidades> lista = new List<Cidades>();
                while (reader.Read())
                {
                    Cidades aCidade = new Cidades();
                    aCidade.Codigo = Convert.ToInt32(reader["id"]);
                    aCidade.DatCad = Convert.ToDateTime(reader["datCad"]);
                    aCidade.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    aCidade.Cidade = reader["Cidade"].ToString();
                    aCidade.Ddd = reader["Ddd"].ToString();
                    aCidade.OEstado.Estado = reader["Estado"].ToString();
                    aCidade.OEstado.Codigo = Convert.ToInt32(reader["Estado_id"]);
                    lista.Add(aCidade);
                }
                reader.Close();
                return lista;
            }
        }

        public override string Salvar(object obj)
        {
            Cidades aCidade = (Cidades)obj;
            string mSql = "", mOk = "";
            if (aCidade.Codigo == 0)
            {
                mSql = "insert into cidades (Cidade, ddd, Estado_Id, Estado, datCad, ultAlt) values(@cidade, @ddd, @estado_id, @estado, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update cidades set cidade = @cidade, ddd = @ddd, estado_id = @estado_id, estado = @estado, datCad = @datCad, ultAlt = @ultAlt where codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@cidade", aCidade.Cidade);
                cmd.Parameters.AddWithValue("@ddd", aCidade.Ddd);
                cmd.Parameters.AddWithValue("@estado_id", aCidade.OEstado.Codigo);
                cmd.Parameters.AddWithValue("@estado", aCidade.OEstado.Estado);
                cmd.Parameters.AddWithValue("@datCad", aCidade.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", aCidade.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", aCidade.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
