using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Security;

/// <summary>
/// Summary description for BD
/// </summary>
public class BDRegisto
{
    SqlConnection cn;
    String connectionString;
	public BDRegisto()
	{
        this.connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        this.cn = new SqlConnection();
	}


    public void criaDono(string nome, string ncidadao, string ncontribuinte, string morada,string codPostal,string localidade, string dataNascimento,string contato, string id, byte[]b){
        this.cn.ConnectionString = this.connectionString;
        string StrInsert = "INSERT INTO PESSOA (NOME,NCIDADAO,NCONTRIBUINTE,MORADA,COD_POSTAL,LOCALIDADE,NTELEFONE,IDRegistado, FOTO,DATANASCIMENTO) VALUES(@nome,@cid,@nif,@mor,@cd,@loc,@tel,@id,@ft,@data)";
        SqlCommand cmd = new SqlCommand(StrInsert, cn);
        cmd.Parameters.AddWithValue("@nome", nome);
        cmd.Parameters.AddWithValue("@cid", Convert.ToInt32(ncidadao));
        cmd.Parameters.AddWithValue("@nif", Convert.ToInt32(ncontribuinte));
        cmd.Parameters.AddWithValue("@mor", morada);
        cmd.Parameters.AddWithValue("@cd", codPostal);
        cmd.Parameters.AddWithValue("@loc", localidade);
        cmd.Parameters.AddWithValue("@tel", contato);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.Parameters.AddWithValue("@ft", b);
        cmd.Parameters.AddWithValue("@data", Convert.ToDateTime(dataNascimento));

        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();

    }

    public string getConnectionString()
    {
        return this.connectionString;
    }

    public byte[] carregaImagem(Stream fs)
    {

        BinaryReader br = new BinaryReader(fs);
        Byte[] byt = br.ReadBytes((Int32)fs.Length);
        return byt;
    }

    public string MostraImagem(string id)
    {
        string sql = "Select FOTO From Pessoa where IDRegistado='" + id + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);
        byte[] bytes = (byte[])data.Rows[0]["FOTO"];
        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
        string url = "data:image/png;base64," + base64String;
        return url;
    }

    public DataTable getHorasEntrada()
    {
        DataTable data = new DataTable();
        string sql = "Select * from Horas";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
         SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);
        return data;
    }


    public void insertHora(string dis, DateTime data, DateTime he, DateTime hs)
    {
        this.cn.ConnectionString = this.connectionString;
      //  "INSERT INTO PESSOA (NOME,NCIDADAO,NCONTRIBUINTE,MORADA,COD_POSTAL,LOCALIDADE,NTELEFONE,IDRegistado, FOTO,DATANASCIMENTO) VALUES(@nome,@cid,@nif,@mor,@cd,@loc,@tel,@id,@ft,@data)";
        string sql = "Insert into HORARIO (DISTINTIVO,DATA_FIM_P,HORAENTRADA,HORASAIDA) VALUES(@DIS,@DATA,@HORA,@HORAS)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@DIS", Convert.ToDecimal(dis));
        cmd.Parameters.AddWithValue("@DATA", data);
        cmd.Parameters.AddWithValue("@HORA",he);
        cmd.Parameters.AddWithValue("@HORAS", hs);
               

        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
    }


    public DataTable getHorasSaida(int i)
    {
        
        DataTable data = new DataTable();
        string sql = "Select Id, HORA from Horas where Id > @hora ";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);

        cmd.Parameters.AddWithValue("@hora", i);

        cn.Open();
        //SqlDataReader dr = cmd.ExecuteReader();

        //while (dr.Read())
        //{
        //    //DataRow novaLinha = data.NewRow();
        //    //for (int i = 0; i < data.Columns.Count; i++)
        //    //{
        //    //    novaLinha[i] =  dr.GetValue(i);
        //    //}
        //    //data.Rows.Add(novaLinha);


        //}
        data.Load(cmd.ExecuteReader());

        cn.Close();

        return data;
    }



    public string getHoraioAgenteDia(DateTime a, string dis)
    {
        string info="";
        string sql = "Select count(*) FROM HORARIO H, AGENTE A WHERE H.DISTINTIVO = A.DISTINTIVO AND DATA_FIM_P=@data and A.DISTINTIVO='"+dis+"'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", a);


        cn.Open();
        int n = Convert.ToInt32(cmd.ExecuteScalar());
        cn.Close();

        if (n == 0)
            info = "Agente Fora de Serviço";
        else
        {
            sql="Select HORAENTRADA, HORASAIDAFROM HORARIO H, AGENTE A WHERE H.DISTINTIVO = A.DISTINTIVO AND DATA_FIM_P=@data and A.DISTINTIVO='"+dis+"'";
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", a);
            DataTable dados = new DataTable();
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                dados.Load(dr);
            }

            cn.Close();
        }

        return info;
    }


    public string carregaFotoAgente(string d)
    {
        string sql = "SELECT FOTO FROM PESSOA P, AGENTE A WHERE A.ID=P.ID AND DISTINTIVO='"+d+"'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);
        byte[] bytes = (byte[])data.Rows[0]["FOTO"];
        string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
        string url = "data:image/png;base64," + base64String;
        return url;
    }

    public bool procuraAgentePorNCidadao(string cc){
        string sql = "Select count(*) FROM PESSOA WHERE NCIDADAO='"+cc+"'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand Cmd = new SqlCommand(sql, cn);

        cn.Open();

        int n = Convert.ToInt32(Cmd.ExecuteScalar());
        cn.Close();

        if (n == 0)
            return false;
        else
        return true;
    }

    public bool verificaSeNaoExisteAgente(string cc)
    {
        string sql = "Select count(*) FROM PESSOA P ,Agente A  WHERE P.ID=A.ID AND P.NCIDADAO='" + cc + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand Cmd = new SqlCommand(sql, cn);

        cn.Open();

        int n = Convert.ToInt32(Cmd.ExecuteScalar());
        cn.Close();

        if (n == 0)
            return true;
        else
            return false;
    }

    public bool verificaSeNãoExisiteArma(string arma)
    {
        string sql = "Select count(*) FROM Armas where NARMA='" + arma + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand Cmd = new SqlCommand(sql, cn);

        cn.Open();

        int n = Convert.ToInt32(Cmd.ExecuteScalar());
        cn.Close();

        if (n == 0)
            return true;
        else
            return false;
    } 


   public DataTable carregaAgentes()
    {
        string sql = "Select NOME ,DISTINTIVO,FOTO FROM PESSOA P, AGENTE A WHERE A.ID = P.ID";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);



        return data;
    }


    public string getUserName(string cc)
    {
        DataTable pessoa = retornaPessoa(cc);
        
        string username="";
        

        string sql = "SELECT USERNAME FROM USERS U, PESSOA P WHERE P.IDRegistado=U.UserId AND P.NCIDADAO='" + cc + "'";

        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        pessoa = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(pessoa);
        username = (String)pessoa.Rows[0]["USERNAME"];
        return username;
    }

    

    public void MudaRoleParaAgente(string cc)
    {
        string username = getUserName(cc);
        Roles.RemoveUserFromRole(username, "Cidadao");
        Roles.AddUserToRole(username, "Agente");
        
    }


    public bool verificaSeNaoExisteDestintivo(string cc)
    {
        string sql = "Select count(*) FROM Agente WHERE Distintivo='" + cc + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand Cmd = new SqlCommand(sql, cn);

        cn.Open();

        int n = Convert.ToInt32(Cmd.ExecuteScalar());
        cn.Close();

        if (n == 0)
            return true;
        else
            return false;
    }

    public DataTable retornaPessoa(string cc)
    {
        string sql = "Select NOME,ID, NCONTRIBUINTE,DATANASCIMENTO,FOTO,IDRegistado From Pessoa where NCIDADAO='" + cc + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);



        return data;
    }

    public void InserAgente(string id,string destintivo, string funcao)
    {
        string sql = "Insert into Agente (DISTINTIVO, ID,FUNCAO) Values(@Dis, @id,@func)";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@Dis", destintivo);
        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id));
        cmd.Parameters.AddWithValue("@func", funcao);
        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();

        cn.Close();
    }

    public void InserArma(string destintivo, string modelo, string serial, string fabrincante, string bala)
    {
        string sql = "Insert into Armas (NARMA, DISTINTIVO, MODELO, FABRICANTE, TAM_BALA) Values(@arm, @dis,@mod,@fav,@bala)";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@arm", Convert.ToInt32(serial));
        cmd.Parameters.AddWithValue("@dis", destintivo);
        cmd.Parameters.AddWithValue("@mod", modelo);
        cmd.Parameters.AddWithValue("@fav", fabrincante);
         cmd.Parameters.AddWithValue("@bala",Convert.ToDecimal(bala));
        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();

        cn.Close();
    }

}