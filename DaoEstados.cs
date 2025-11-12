using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaisEstadoCidade
{
    internal class DaoEstados : DAO<Estados>
    {
        public override string Excluir(object obj)
        {
            string mSql = "delete paises where id = codigo";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {

            }
                return null;
        }
        public override List<Estados> Listar()
        {
            string mSql = "select * from estados order by id";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();
                while (reader.Read())
                {
                    Estados oEstado = new Estados();
                    oEstado.Codigo = Convert.ToInt32(reader["id"]);
                    oEstado.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oEstado.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oEstado.Estado = reader["Estado"].ToString();
                    oEstado.Uf = reader["UF"].ToString();
                    oEstado.OPais.Pais = reader["Pais"].ToString();
                    oEstado.OPais.Codigo = Convert.ToInt32(reader["Pais_id"]);
                    lista.Add(oEstado);
                }
                reader.Close();
                return lista;
            }
        }
        public override Object CarregaObj(int chave)
        {
            return null;
        }
        public override List<Estados> Pesquisar(string chave)
        {
            string mSql = $"select * from estados where estado like '%{chave}%' or id like '%{chave}%' or Uf like '%{chave}%' or pais_id like '%{chave}%' or pais like '%{chave}%'";
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                List<Estados> lista = new List<Estados>();
                while (reader.Read())
                {
                    Estados oEstado = new Estados();
                    oEstado.Codigo = Convert.ToInt32(reader["id"]);
                    oEstado.DatCad = Convert.ToDateTime(reader["datCad"]);
                    oEstado.UltAlt = Convert.ToDateTime(reader["ultAlt"]);
                    oEstado.Estado = reader["Estado"].ToString();
                    oEstado.Uf = reader["UF"].ToString();
                    oEstado.OPais.Pais = reader["Pais"].ToString();
                    oEstado.OPais.Codigo = Convert.ToInt32(reader["Pais_id"]);
                    lista.Add(oEstado);
                }
                reader.Close();
                return lista;
            }
        }

        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;
            string mSql = "", mOk = "";
            if (oEstado.Codigo == 0)
            {
                mSql = "insert into estados(estado, uf, pais_id, pais, datcad, ultalt) values(@estado, @uf, @pais_id, @pais, @datCad, @ultAlt)";
            }
            else
            {
                mSql = "update estados set estado = @estado, uf = @uf, pais_id= @pais_id, pais = @pais, datcad = @datCad, ultalt = @ultAlt where id = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(mSql, cnn))
            {
                cmd.Parameters.AddWithValue("@estado", oEstado.Estado);
                cmd.Parameters.AddWithValue("@uf", oEstado.Uf);
                cmd.Parameters.AddWithValue("@pais_id", oEstado.OPais == null ? 0 : oEstado.OPais.Codigo);
                cmd.Parameters.AddWithValue("@pais", oEstado.OPais.Pais);
                cmd.Parameters.AddWithValue("@datCad", oEstado.DatCad);
                cmd.Parameters.AddWithValue("@ultAlt", oEstado.UltAlt);
                cmd.Parameters.AddWithValue("@codigo", oEstado.Codigo);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "select @@IDENTITY";
                mOk = cmd.ExecuteScalar()?.ToString();
                return mOk;
            }
        }
    }
}
