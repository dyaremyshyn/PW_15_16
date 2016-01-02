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


    public void criaDono(string nome, string ncidadao, string ncontribuinte, string morada,string codPostal,string localidade, string dataNascimento,string contato, string id, byte[]b,string s){
        this.cn.ConnectionString = this.connectionString;
        string StrInsert = "INSERT INTO PESSOA (NOME,NCIDADAO,NCONTRIBUINTE,MORADA,COD_POSTAL,LOCALIDADE,NTELEFONE,IDRegistado, FOTO,DATANASCIMENTO,SEXO) VALUES(@nome,@cid,@nif,@mor,@cd,@loc,@tel,@id,@ft,@data,@sex)";
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
        cmd.Parameters.AddWithValue("@sex", s);

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

    public int calculaIdade(DateTime DataNascimento)
    {
        int anos = DateTime.Now.Year - DataNascimento.Year;
        if (DateTime.Now.Month < DataNascimento.Month || (DateTime.Now.Month == DataNascimento.Month && DateTime.Now.Day < DataNascimento.Day))
            anos--;
        return anos;
    }

    public DataTable getAgentedadosNaoPolicias(string distintivo)
    {
        string sql = "Select * from Pessoa p, Agente a where p.id=a.id and a.distintivo='" + distintivo + "'";
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

    public void inserAgenteOperacao(string destintivo, int codope)
    {
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO REALIZADAPOR (DISTINTIVO,CODOPERACAO) VALUES(@AGENTE,@OPERACAO)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@AGENTE", Convert.ToDecimal(destintivo));
        cmd.Parameters.AddWithValue("@OPERACAO", codope);
        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
    }

    public void inserViaturaOperacao(string codviatura, int opercao)
    {
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO VICULOOPE (COD_VEICULO,CODOPERACAO) VALUES(@V,@O)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@V", Convert.ToInt32(codviatura));
        cmd.Parameters.AddWithValue("@O", opercao);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public int insertPatrulha(string res,string desc, DateTime data, DateTime hora, string local)
    {
        string nome = "Patrulha no local: " + local;
        string tipo = "PATRULHAMENTO";
        
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO OPERACOES (AGE_RESPONS,NOMEOPERACAO,TIPOOPERACAO,DESCRICAOOPERACAO,DATAOPERA,HORAINICIOOPE,LOCAL) VALUES(@RES,@NOME,@TIPO,@DIS,@DATA,@HORA,@LOCAL); SELECT CAST(scope_identity() AS int);";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@RES", Convert.ToDecimal(res));
        cmd.Parameters.AddWithValue("@NOME", nome);
        cmd.Parameters.AddWithValue("@TIPO", tipo);
        cmd.Parameters.AddWithValue("@DIS", desc);
        cmd.Parameters.AddWithValue("@DATA", data);
        cmd.Parameters.AddWithValue("@HORA", hora);
        cmd.Parameters.AddWithValue("@LOCAL", local);




        cn.Open();
        int idOperacao = (int)cmd.ExecuteScalar();
        //cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
        return idOperacao;
    }


    public int insertOperacao(string nome, string tipo,string res,string desc, DateTime data, DateTime hora, string local)
    {
       
        
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO OPERACOES (AGE_RESPONS,NOMEOPERACAO,TIPOOPERACAO,DESCRICAOOPERACAO,DATAOPERA,HORAINICIOOPE,LOCAL) VALUES(@RES,@NOME,@TIPO,@DIS,@DATA,@HORA,@LOCAL); SELECT CAST(scope_identity() AS int);";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@RES", Convert.ToDecimal(res));
        cmd.Parameters.AddWithValue("@NOME", nome);
        cmd.Parameters.AddWithValue("@TIPO", tipo);
        cmd.Parameters.AddWithValue("@DIS", desc);
        cmd.Parameters.AddWithValue("@DATA", data);
        cmd.Parameters.AddWithValue("@HORA", hora);
        cmd.Parameters.AddWithValue("@LOCAL", local);




        cn.Open();
        int idOperacao = (int)cmd.ExecuteScalar();
        //cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
        return idOperacao;
    }

    public DataTable getViaturaLivre()
    {
        DataTable datatable = new DataTable();
        
      //  string sql = "SELECT MARCA, MODELO, MATRICULO FROM VEICULOS V, VICULOOPE VI, OPERACOES O WHERE V.COD_VEICULO=VI.COD_VEICULO AND VI.CODOPERACAO <>O.CODOPERACAO AND O.HORAINICIOOPE"
        string sql = "SELECT COD_VEICULO, MARCA, MODELO, MATRICULO FROM VEICULOS";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(datatable);
        return datatable;
    }

    public DataTable getAgentesDisponiveis(DateTime DATA, DateTime HORAE)
    {
        DataTable data = new DataTable();
       // string sql = "Select NOME, A.DISTINTIVO FROM AGENTE A, PESSOA P, OPERACOES O,REALIZADAPOR R  WHERE P.ID=A.ID AND O.CODOPERACAO=R.CODOPERACAO AND R.DISTINTIVO<>A.DISTINTIVO AND DATAOPERA=@data";
       // string sql = "Select NOME, DISTINTIVO FROM AGENTE A, PESSOA P WHERE P.ID = A.ID";
       // string sql = "Select NOME, A.DISTINTIVO FROM AGENTE A, PESSOA P, HORARIO H,OPERACOES O,REALIZADAPOR R WHERE P.ID = A.ID AND H.DISTINTIVO = A.DISTINTIVO AND O.CODOPERACAO=R.CODOPERACAO AND  R.DISTINTIVO<>A.DISTINTIVO AND DATAOPERA=@data  AND DATA_FIM_P=@data AND HORAENTRADA<@h";
        string sql = "Select NOME, A.DISTINTIVO FROM AGENTE A, PESSOA P, HORARIO H WHERE P.ID = A.ID AND H.DISTINTIVO = A.DISTINTIVO AND DATA_FIM_P=@data AND HORAENTRADA<=@h";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", DATA);
        cmd.Parameters.AddWithValue("@h", HORAE);
        DataTable dados = new DataTable();
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    
    }


    public DataTable getPatrulha(string codPatrulha)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select CODOPERACAO, NOME, HORAINICIOOPE,LOCAL From Operacoes O, AGENTE A, PESSOA P Where O.AGE_RESPONS=A.DISTINTIVO AND A.ID = P.ID  AND CODOPERACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(codPatrulha));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

   
   

    public DataTable getFormcaoes(string cod)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select CODFORMACAO, TITULOFORMACAO, AMBITOFORMACAO,FORMADOR From FORMACOES Where  CODFORMACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(cod));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getTreinos()
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select * From TREINOS  Where DATA_TREINO>@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", d);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }


    public DataTable getTreinos(string cod)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select COD_TREINO,TIPOTREINO, TITULOFORMACAO,NOME, HORA_INICIO_TREINO TREINOS T, PESSOA P, AGENTE A Where p.ID=A.id and A.DISTINTIVO=T.DISTINTIVO  CODFORMACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(cod));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public int marcarTreino(DateTime data, DateTime h, DateTime hs,string treinador,string tema)
    {
        int n = -1;
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO TREINOS (DISTINTIVO,TITULOTREINO,DATA_TREINO,HORA_INICIO_TREINO,HORA_FIM_TREINO) VALUES(@TREINADOR,@TIPO,@DATA,@HORAINICIAL,@HORAFIM); SELECT CAST(scope_identity() AS int);";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@TREINADOR", Convert.ToDecimal(treinador));
        cmd.Parameters.AddWithValue("@TIPO", tema);
        cmd.Parameters.AddWithValue("@DATA", data);
        cmd.Parameters.AddWithValue("@HORAINICIAL", h);
        cmd.Parameters.AddWithValue("@HORAFIM", hs);
        cn.Open();
        n = (int)cmd.ExecuteScalar();
        //cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
        return n;
    }

    public void inserAgenteTreino(string agente, int id){
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO TREINADOS (COD_TREINO,DISTINTIVO) VALUES(@treino,@agente)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@treino", id);
        cmd.Parameters.AddWithValue("@agente", agente);
        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
       
    }

    public DataTable getOperacao(string codPatrulha)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select CODOPERACAO, NOME, HORAINICIOOPE,LOCAL,TIPOOPERACAO From Operacoes O, AGENTE A, PESSOA P Where O.AGE_RESPONS=A.DISTINTIVO AND A.ID = P.ID  AND CODOPERACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(codPatrulha));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getViatura(string cod)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select * From VEICULOS Where COD_VEICULO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(cod));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getViaturasNaOperacao(string codPatrulha)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select V.MATRICULO, V.COD_VEICULO From VEICULOS V, VICULOOPE VI, OPERACOES O Where V.COD_VEICULO=VI.COD_VEICULO AND VI.CODOPERACAO=O.CODOPERACAO  AND O.CODOPERACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(codPatrulha));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getAgentesPatrulha(string codPatrulha)
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select NOME, FOTO From Operacoes O, REALIZADAPOR R, AGENTE A, PESSOA P Where O.AGE_RESPONS=A.DISTINTIVO AND R.CODOPERACAO=O.CODOPERACAO AND R.DISTINTIVO=A.DISTINTIVO AND A.ID = P.ID  AND O.CODOPERACAO=@cod";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@cod", Convert.ToInt32(codPatrulha));
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getPatrulhas()
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select CODOPERACAO, AGE_RESPONS, HORAINICIOOPE,LOCAL From Operacoes Where TIPOOPERACAO like 'PATRULHAMENTO' AND DATAOPERA>=@data  ";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", d);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
        
    }

    public DataTable getOperacoes()
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select CODOPERACAO, AGE_RESPONS, HORAINICIOOPE,LOCAL From Operacoes Where TIPOOPERACAO not like 'PATRULHAMENTO' AND DATAOPERA>=@data  ";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", d);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;

    }


    public DataTable getFormacoes()
    {
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        string sql = "Select * From FORMACOES Where  DATAFORMACAO>=@data  ";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", d);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;

    }



    public int MarcarFormacao(DateTime data, DateTime hora, string formador, string tema,string descricao,string ambito)
    {
        int n = -1;
        try
        {
            

            this.cn.ConnectionString = this.connectionString;
            string sql = "Insert INTO FORMACOES (TITULOFORMACAO,AMBITOFORMACAO,FORMADOR,DESCRICAOFORMACAO,DATAFORMACAO,HORAFORMACAO) VALUES(@TITULO,@ambito,@formador,@descr,@DATA,@HORA); SELECT CAST(scope_identity() AS int);";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@TITULO", tema);
            cmd.Parameters.AddWithValue("@ambito", ambito);
            cmd.Parameters.AddWithValue("@descr", descricao);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@formador",formador);
            cn.Open();
            n = (int)cmd.ExecuteScalar();
            //cmd.ExecuteNonQuery();
            cmd.Dispose();
            cn.Close();
            return n;
        }
        catch (Exception e)
        {
            n = -1;
        }
        return -1;
    }


    public DataTable Trabalha(DateTime Dia)
    {
      
        DataTable data = new DataTable();
        
        string sql = "Select Distinct A.DISTINTIVO From AGENTE A, (SELECT DISTINTIVO FROM HORARIO WHERE DATA_FIM_P =@data)h Where A.DISTINTIVO!=H.DISTINTIVO";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", Dia);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;
    }

    public DataTable getAgentesFolga(DateTime dia)
    {
        this.cn.ConnectionString = this.connectionString;
        DataTable data = new DataTable();
        string sql = "SELECT count(*) FROM HORARIO WHERE DATA_FIM_P =@data";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", dia);
        cn.Open();
        int n = Convert.ToInt32(cmd.ExecuteScalar());
        cn.Close();
        if(n>0){
            sql = "Select Distinct A.DISTINTIVO, NOME From Pessoa p, AGENTE A, (SELECT DISTINTIVO FROM HORARIO WHERE DATA_FIM_P =@data)h Where A.DISTINTIVO!=H.DISTINTIVO and p.ID=a.id";
            this.cn.ConnectionString = this.connectionString;
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", dia);
            cn.Open();
            data.Load(cmd.ExecuteReader());
            cn.Close();
        }
        else
        {
            sql = "Select NOME, DISTINTIVO from PESSOA p, AGENTE a WHERE a.ID=p.ID";
            this.cn.ConnectionString = this.connectionString;
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", dia);
            cn.Open();
            data.Load(cmd.ExecuteReader());
            cn.Close();
        }
            
        return data;
    }

    public DataTable getAgentesFolga(DateTime dia, string distintivo)
    {
        this.cn.ConnectionString = this.connectionString;
        DataTable data = new DataTable();
        string sql = "SELECT count(*) FROM HORARIO WHERE DATA_FIM_P =@data";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@data", dia);
        cn.Open();
        int n = Convert.ToInt32(cmd.ExecuteScalar());
        cn.Close();
        if (n > 0)
        {
            sql = "Select Distinct A.DISTINTIVO, NOME From Pessoa p, AGENTE A, (SELECT DISTINTIVO FROM HORARIO WHERE DATA_FIM_P =@data)h Where A.DISTINTIVO!=H.DISTINTIVO and p.ID=a.id and a.DISTINTIVO <>@dis";
            this.cn.ConnectionString = this.connectionString;
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", dia);
            cmd.Parameters.AddWithValue("@dis", Convert.ToDecimal(distintivo));
            cn.Open();
            data.Load(cmd.ExecuteReader());
            cn.Close();
        }
        else
        {
            sql = "Select NOME, DISTINTIVO from PESSOA p, AGENTE a WHERE a.ID=p.ID and a.DISTINTIVO !=@dis";
            this.cn.ConnectionString = this.connectionString;
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", dia);
            cmd.Parameters.AddWithValue("@dis", Convert.ToDecimal(distintivo));
            cn.Open();
            data.Load(cmd.ExecuteReader());
            cn.Close();
        }

        return data;
    }
        
        

    public void InserAlunos(int f,decimal d)
    {
        this.cn.ConnectionString = this.connectionString;
        string sql = "Insert INTO ALUNOS (DISTINTIVO,CODFORMACAO) VALUES(@D,@C)";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@D", Convert.ToInt32(d));
        cmd.Parameters.AddWithValue("@C", f);

        cn.Open();
        cmd.ExecuteNonQuery();
        cn.Close();
    }

    public void agentesFormacao(int n, DateTime data)
    {
        DataTable AGENTES = Trabalha(data);
        decimal d;
        for (int i=0; i< AGENTES.Rows.Count; i++)
        {
           d=(decimal)AGENTES.Rows[i]["DISTINTIVO"];
           InserAlunos(n, d);
        }

    }

    public void updateHoraTrabalho(string dis, DateTime data, DateTime he, DateTime hs)
    {

        this.cn.ConnectionString = this.connectionString;
        //  "INSERT INTO PESSOA (NOME,NCIDADAO,NCONTRIBUINTE,MORADA,COD_POSTAL,LOCALIDADE,NTELEFONE,IDRegistado, FOTO,DATANASCIMENTO) VALUES(@nome,@cid,@nif,@mor,@cd,@loc,@tel,@id,@ft,@data)";
        string sql = "UPDATE HORARIO SET HORAENTRADA = @HORA,HORASAIDA = @HORAS WHERE DISTINTIVO = @DIS AND DATA_FIM_P = @DATA";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@DIS", Convert.ToDecimal(dis));
        cmd.Parameters.AddWithValue("@DATA", data);
        cmd.Parameters.AddWithValue("@HORA", he);
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
            sql="Select HORAENTRADA, HORASAIDA FROM HORARIO H, AGENTE A WHERE H.DISTINTIVO = A.DISTINTIVO AND DATA_FIM_P=@data and A.DISTINTIVO='"+dis+"'";
            cmd = new SqlCommand(sql, cn);
            cmd.Parameters.AddWithValue("@data", a);
            DataTable dados = new DataTable();
            cn.Open();
            dados.Load(cmd.ExecuteReader());

            cn.Close();
            DateTime entrada, saida;
            entrada = (DateTime)dados.Rows[0]["HORAENTRADA"];
            saida = (DateTime)dados.Rows[0]["HORASAIDA"];
            info = "Agente de Serviço das " + entrada.Hour.ToString() + "h" + entrada.Minute.ToString() + "m ate as " + saida.Hour.ToString() + "h" + saida.Minute.ToString() + "m";
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

    public string carregaFotoCidadao(string d)
    {
        string sql = "SELECT FOTO FROM PESSOA WHERE id='" + d + "'";
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

    public string carregaFotoUser(string d)
    {
        string sql = "SELECT FOTO FROM PESSOA WHERE IDRegistado='" + d + "'";
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

    public DataTable getArmasAgente(string agente)
    {
        string sql = "Select * FROM ARMAS WHERE DISTINTIVO = '" + agente + "'";
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

    public string getDescricaoArma(string serial)
    {
        string sql = "Select * FROM ARMAS WHERE NARMA = '" + serial + "'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);
        string desc = "Modelo: " + ((string)data.Rows[0]["MODELO"]) + "\n" + "Fabricante: " + ((string)data.Rows[0]["FABRICANTE"])+"\n";
        desc = desc + "Nº ARMA: " + ((int)data.Rows[0]["NARMA"]).ToString()+"\n";
        desc = desc + "Calibre: " + ((double)data.Rows[0]["TAM_BALA"]).ToString();
        return desc;

    }

    public string getFuncao(string Distintivo)
    {
        string sql = "Select FUNCAO FROM AGENTE WHERE DISTINTIVO = '"+Distintivo+"'";
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        DataTable data = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter();
        cmd.CommandType = CommandType.Text;
        cmd.Connection = cn;
        da.SelectCommand = cmd;
        da.Fill(data);

        return ((string)data.Rows[0]["FUNCAO"]);

    }


   public DataTable carregaAgentes()
    {
        string sql = "Select NOME ,DISTINTIVO,FOTO,FUNCAO FROM PESSOA P, AGENTE A WHERE A.ID = P.ID";
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


   public DataTable pesquisaCidadaoPorNome(string nome){
        string sql = "Select * From Pessoa where NOME like '%" + nome + "%'";
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

   public DataTable pesquisaCidadaoPorNCIDADAO(string cc)
   {
       string sql = "Select * From Pessoa where NCIDADAO='" + cc + "'";
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

   public DataTable pesquisaCidadaoPorNIF(string NIF)
   {
       string sql = "Select * From Pessoa where NCONTRIBUINTE='" + NIF + "'";
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

   public DataTable pesquisaCidadaoPorMorada(string morada)
   {
       string sql = "Select * From Pessoa where MORADA like '%" + morada + "%'";
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

   public DataTable pesquisaCidadaoPorContato(string contato)
   {
       string sql = "Select * From Pessoa where NTELEFONE='" + contato + "'";
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

   public DataTable pesquisaCidadaoPorLocalidade(string Localidade)
   {
       string sql = "Select * From Pessoa where LOCALIDADE like '%" + Localidade + "%'";
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

   public DataTable pesquisaCidadaoPorCP(string cp)
   {
       string sql = "Select * From Pessoa where COD_POSTAL = '" + cp + "'";
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

   public DataTable getCidadaoPorId(string id)
   {
       string sql = "Select * From Pessoa where id = '" + id+ "'";
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

   public DataTable getUser(string user)
   {
       string sql = "Select * From Pessoa where IDRegistado = '" + user + "'";
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

   public DataTable getInfos()
   {
       string sql = "Select * From Noticias";
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

   public string getFotoNocia(string cod)
   {
       string sql = "Select IMAGEMN From NOTICIAS where COD_NOTICIA='" + cod + "'";
       this.cn.ConnectionString = this.connectionString;
       SqlCommand cmd = new SqlCommand(sql, cn);
       DataTable data = new DataTable();
       SqlDataAdapter da = new SqlDataAdapter();
       cmd.CommandType = CommandType.Text;
       cmd.Connection = cn;
       da.SelectCommand = cmd;
       da.Fill(data);
       byte[] bytes = (byte[])data.Rows[0]["IMAGEMN"];
       string base64String = Convert.ToBase64String(bytes, 0, bytes.Length);
       string url = "data:image/png;base64," + base64String;
       return url;
   }
   public void upateNoticia(string id,string distintivo,string titulo, string noticia)
   {
       this.cn.ConnectionString = this.connectionString;
       DateTime data=DateTime.Today;
       DateTime hora = DateTime.Now;
       string sql = "UPDATE NOTICIAS SET DISTINTIVO = @dist, TITULONOTICIA = @tnoticia, NOTICIA=@noticia, DATANOTICIA=@data, HORA=@hora WHERE  COD_NOTICIA ='"+id+"' ";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cmd.Parameters.AddWithValue("@dist", Convert.ToDecimal(getDisintivoUser(distintivo)));
       cmd.Parameters.AddWithValue("@tnoticia", titulo);
       cmd.Parameters.AddWithValue("@noticia", noticia);
       cmd.Parameters.AddWithValue("@data", data);
       cmd.Parameters.AddWithValue("@hora", hora);

       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }

   public void DeleteNocia(string id)
   {
       this.cn.ConnectionString = this.connectionString;
       string sql = "DELETE from NOTICIAS WHERE  COD_NOTICIA ='" + id + "' ";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }


   public DataTable getTextNocia(string cod)
   {
       string sql = "Select * From NOTICIAS where COD_NOTICIA='" + cod + "'";
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

    public string getDisintivoUser(string user)
   {
       string sql = "Select A.DISTINTIVO From PESSOA P, AGENTE A where A.ID=P.ID AND P.IDRegistado='"+user+"'";
       this.cn.ConnectionString = this.connectionString;
       DataTable data = new DataTable();
       SqlCommand cmd = new SqlCommand(sql, cn);
      // cmd.Parameters.AddWithValue("@a", user);
       cn.Open();
       data.Load(cmd.ExecuteReader());
       cn.Close();
       string distintivo =( (decimal)data.Rows[0]["DISTINTIVO"]).ToString();
        return distintivo;
       
   }

    public void updateUserWithFoto(string user,string nome, string cidadao, string nif, string morada,string localidade,string cd, string tel,string sex,DateTime data, byte[] b)
    {
    
       this.cn.ConnectionString = this.connectionString;
       
       string sql = "UPDATE PESSOA SET NOME = @nome, FOTO=@ft, NCIDADAO = @cidadao, NCONTRIBUINTE=@contribuinte, DATANASCIMENTO=@data, MORADA=@morada, COD_POSTAL=@cp, LOCALIDADE=@loc,NTELEFONE=@telf,SEXO=@sex WHERE  IDRegistado ='" + user + "' ";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cmd.Parameters.AddWithValue("@nome", nome);
       cmd.Parameters.AddWithValue("@cidadao", cidadao);
       cmd.Parameters.AddWithValue("@contribuinte", nif);
       cmd.Parameters.AddWithValue("@morada", morada);
       cmd.Parameters.AddWithValue("@data", data);
       cmd.Parameters.AddWithValue("@cp",cd );
       cmd.Parameters.AddWithValue("@loc", localidade);
       cmd.Parameters.AddWithValue("@telf", tel);
       cmd.Parameters.AddWithValue("@sex", sex);
       cmd.Parameters.AddWithValue("@ft", b);

       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();

    }

    public void updateUserNofoto(string user,string nome, string cidadao, string nif, string morada,string localidade,string cd, string tel,string sex,DateTime data)
    {
       this.cn.ConnectionString = this.connectionString;
       
       string sql = "UPDATE PESSOA SET NOME = @nome, NCIDADAO = @cidadao, NCONTRIBUINTE=@contribuinte, DATANASCIMENTO=@data, MORADA=@morada, COD_POSTAL=@cp, LOCALIDADE=@loc,NTELEFONE=@telf,SEXO=@sex WHERE  IDRegistado ='" + user + "' ";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cmd.Parameters.AddWithValue("@nome", nome);
       cmd.Parameters.AddWithValue("@cidadao", cidadao);
       cmd.Parameters.AddWithValue("@contribuinte", nif);
       cmd.Parameters.AddWithValue("@morada", morada);
       cmd.Parameters.AddWithValue("@data", data);
       cmd.Parameters.AddWithValue("@cp",cd );
       cmd.Parameters.AddWithValue("@loc", localidade);
       cmd.Parameters.AddWithValue("@telf", tel);
       cmd.Parameters.AddWithValue("@sex", sex);
       

       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();

    

    }

   public void inserNoticia(string titulo, string texto, byte[] b,string user)
   {
       DateTime hora = DateTime.Now;
       this.cn.ConnectionString = this.connectionString;
       string StrInsert = "INSERT INTO NOTICIAS (DISTINTIVO,TITULONOTICIA,NOTICIA,IMAGEMN,DATANOTICIA,HORA) VALUES(@disti,@titulo,@noticia,@img,@data,@hora)";
       SqlCommand cmd = new SqlCommand(StrInsert, cn);
       cmd.Parameters.AddWithValue("@disti", getDisintivoUser(user));
       cmd.Parameters.AddWithValue("@titulo", titulo);
       cmd.Parameters.AddWithValue("@noticia", texto);
       cmd.Parameters.AddWithValue("@img", b);
       cmd.Parameters.AddWithValue("@data", DateTime.Today);
       cmd.Parameters.AddWithValue("@hora", hora);
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }


   public string getIdUser(string user)
   {
       string sql = "Select id From PESSOA P WHERE P.IDRegistado='" + user + "'";
       this.cn.ConnectionString = this.connectionString;
       DataTable data = new DataTable();
       SqlCommand cmd = new SqlCommand(sql, cn);
       // cmd.Parameters.AddWithValue("@a", user);
       cn.Open();
       data.Load(cmd.ExecuteReader());
       cn.Close();
       string distintivo = ((int)data.Rows[0]["ID"]).ToString();
       return distintivo;

   }

   public void InserQUeixa(string id,string titulo, string descricao)
   {
       
       this.cn.ConnectionString = this.connectionString;
       string strinsert = "INSERT INTO QUEIXA (IDQUEIXOSO,TITULOQUEIXA,DESCRICAOQUEIXA,ESTADOQUEIXA,SITUACAOQUEIXA,DATAQUEIXA) VALUES(@id,@titulo,@dis,@estado,@situacao,@data)";
       SqlCommand cmd = new SqlCommand(strinsert, cn);
       cmd.Parameters.AddWithValue("@id", Convert.ToInt32(getIdUser(id)));
       cmd.Parameters.AddWithValue("@titulo", titulo);
       cmd.Parameters.AddWithValue("@dis", descricao);
       cmd.Parameters.AddWithValue("@estado", "NAO VISTO");
       cmd.Parameters.AddWithValue("@situacao", "AGUARDAR");
       cmd.Parameters.AddWithValue("@data", DateTime.Now);
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }

   public void InserPedido(string id, string titulo, string descricao,DateTime inicio, DateTime fim)
   {

       this.cn.ConnectionString = this.connectionString;
       string strinsert = "INSERT INTO PEDIDO (IDQUEIXOSO,TITULOPEDIDO,DESCRISSAOPEDIDO,ESTADOPEDIDO,SITUACAOPEDIDO,DATA_INICIO_P,DATA_FIM_P) VALUES(@id,@titulo,@dis,@estado,@situacao,@data,@datafim)";
       SqlCommand cmd = new SqlCommand(strinsert, cn);
       cmd.Parameters.AddWithValue("@id", Convert.ToInt32(getIdUser(id)));
       cmd.Parameters.AddWithValue("@titulo", titulo);
       cmd.Parameters.AddWithValue("@dis", descricao);
       cmd.Parameters.AddWithValue("@estado", "NAO VISTO");
       cmd.Parameters.AddWithValue("@situacao", "POR COMECAR");
       cmd.Parameters.AddWithValue("@data", inicio);
       cmd.Parameters.AddWithValue("@datafim", fim);
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }

   public void InserDepoimento(string id, string titulo, string descricao)
   {

       this.cn.ConnectionString = this.connectionString;
       string strinsert = "INSERT INTO DEPOIMENTO (IDQUEIXOSO,TITULODEPOIMENTO,TEXTODEPOIMENTO,SITUACAODEP,DATADEP) VALUES(@id,@titulo,@dis,@situacao,@data)";
       SqlCommand cmd = new SqlCommand(strinsert, cn);
       cmd.Parameters.AddWithValue("@id", Convert.ToInt32(getIdUser(id)));
       cmd.Parameters.AddWithValue("@titulo", titulo);
       cmd.Parameters.AddWithValue("@dis", descricao);
       cmd.Parameters.AddWithValue("@situacao", "POR APROVAR");
       cmd.Parameters.AddWithValue("@data", DateTime.Now);
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }

   public DataTable getQueixas(string id)
   {
       id = getIdUser(id);
       string sql = "Select * From Queixa where IDQUEIXOSO='" + id + "'";
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
   public DataTable getQueixa(string id)
   {

       string sql = "Select * From Queixa, PESSOA  where ID=IDQUEIXOSO and COD_QUEIXA='" + id + "'";
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

   public DataTable getPedidos(string id)
   {
       id = getIdUser(id);
       string sql = "Select * From PEDIDO where IDQUEIXOSO='" + id + "'";
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


   public DataTable getPedido(string id)
   {
      
       string sql = "Select * From PEDIDO where COD_PEDIDO='" + id + "'";
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

   public DataTable getDepoimentos(string id)
   {
       id = getIdUser(id);
       string sql = "Select * From DEPOIMENTO where IDQUEIXOSO='" + id + "'";
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

   public DataTable getDepoimento(string id)
   {

       string sql = "Select * From DEPOIMENTO, PESSOA where id=IDQUEIXOSO AND COD_DEPOIMENTO='" + id + "'";
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

   public DataTable getDepoimentosPorAprovar()
   {

       string sql = "Select * From DEPOIMENTO where SITUACAODEP like 'POR APROVAR' ";
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

   public DataTable getQueixasVistas()
   {

       string sql = "Select * From QUEIXA where ESTADOQUEIXA like 'VISTO' ";
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

   public DataTable getQueixasNaoVistas()
   {

       string sql = "Select * From QUEIXA where ESTADOQUEIXA like 'NAO VISTO' ";
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
   public DataTable getQueixasFinalizadas()
   {

       string sql = "Select * From QUEIXA where ESTADOQUEIXA like 'FINALIZADA' ";
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
   public DataTable getQueixasAtribuidas()
   {

       string sql = "Select * From QUEIXA where SITUACAOQUEIXA like 'ATRIBUIDO' ";
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

   public DataTable getQueixasNaoAtribuidas()
   {

       string sql = "Select * From QUEIXA where SITUACAOQUEIXA like 'NAO ATRIBUIDO' ";
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

   public int abrirProcesso(string destintivo, string des, string titu)
   {
       this.cn.ConnectionString = this.connectionString;
       string sql = "Insert Into PROCESSO (AGE_R_P,DESCRICAOPROCESSO,TITULOPROCESSO,DataAbertura) Values(@AGENTE,@descricao,@titulo,@data); SELECT CAST(scope_identity() AS int);";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cmd.Parameters.AddWithValue("@AGENTE", Convert.ToDecimal(destintivo));
       cmd.Parameters.AddWithValue("@descricao", des);
       cmd.Parameters.AddWithValue("@titulo", titu);
       cmd.Parameters.AddWithValue("@data", DateTime.Now);
       cn.Open();
       int idprocesso = (int)cmd.ExecuteScalar();
       //cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
       return idprocesso;
     
   }

   public DataTable getAgentes()
   {
       string sql = "Select * From Agente a, Pessoa p where a.id=p.id";
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


   public DataTable getPedidosNaoVisto()
   {
       string sql = "Select * From Pedido where ESTADOPEDIDO like 'NAO VISTO'";
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



    public void updatePedido(string idpedido, string situacao, string datai, string datafim){

        this.cn.ConnectionString = this.connectionString;
        DateTime datainicial = Convert.ToDateTime(datai);
        DateTime datafinal = Convert.ToDateTime(datafim);
        string sql = "UPDATE PEDIDO SET ESTADOPEDIDO = 'VISTO', SITUACAOPEDIDO = @sit, DATA_INICIO_P = @di, DATA_FIM_P=@df  Where COD_PEDIDO ='" + idpedido + "'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@sit", situacao);
        cmd.Parameters.AddWithValue("@di", datainicial);
        cmd.Parameters.AddWithValue("@df", datafinal);

        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
    }

   public DataTable getPedidosVisto()
   {
       string sql = "Select * From Pedido where ESTADOPEDIDO like 'VISTO'";
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

   public int getNQueixasNaoVistas()
   {
       this.cn.ConnectionString = this.connectionString;
       DataTable data = new DataTable();
       string sql = "SELECT count(*) FROM QUEIXA WHERE ESTADOQUEIXA like 'NAO VISTO'";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cn.Open();
       int n = Convert.ToInt32(cmd.ExecuteScalar());
       cn.Close();
       return n;
   }


   public DataTable getProcessos()
   {
       string sql = "Select * From PROCESSO ";
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

   public void updateQueixaParaVista(string codqueixa)
   {
       

        this.cn.ConnectionString = this.connectionString;
        
        string sql = "UPDATE QUEIXA SET ESTADOQUEIXA = 'VISTO', SITUACAOQUEIXA = 'PROCESSO ABERTO' Where COD_QUEIXA='"+codqueixa+"'";
        SqlCommand cmd = new SqlCommand(sql, cn);
        


        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
    
   }

   public void addQueixaProcesso(string queixa, string processo)
   {
       this.cn.ConnectionString = this.connectionString;
       string sql = "Insert Into QUEIXA_PROCESSO (COD_QUEIXA, IDPROCESSO) Values(@QUEIXA,@PROCESSO) ";
       SqlCommand cmd = new SqlCommand(sql, cn);
       cmd.Parameters.AddWithValue("@QUEIXA", Convert.ToInt32(queixa));
       cmd.Parameters.AddWithValue("@PROCESSO", Convert.ToInt32(processo));
       
       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }

   public void updateDepoimento(string processo, string codDep)
   {
       this.cn.ConnectionString = this.connectionString;

       string sql = "UPDATE DEPOIMENTO SET IDPROCESSO = '" + processo + "', SITUACAODEP='APROVADO' Where COD_DEPOIMENTO='" + codDep + "'";
       SqlCommand cmd = new SqlCommand(sql, cn);



       cn.Open();
       cmd.ExecuteNonQuery();
       cmd.Dispose();
       cn.Close();
   }


   public DataTable getProcessoQueixa(string queixa)
   {
       string sql = "Select * From PROCESSO P, QUEIXA_PROCESSO QP, QUEIXA Q Where P.IDPROCESSO=QP.IDPROCESSO AND QP.COD_QUEIXA=Q.COD_QUEIXA AND Q.COD_QUEIXA ='"+queixa+"' ";
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

    public string getNomeAgente(string dist){
       string sql = "Select * From AGENTE A , PESSOA P Where P.ID=A.ID AND A.DISTINTIVO ='"+dist+"' ";
       this.cn.ConnectionString = this.connectionString;
       SqlCommand cmd = new SqlCommand(sql, cn);
       DataTable data = new DataTable();
       SqlDataAdapter da = new SqlDataAdapter();
       cmd.CommandType = CommandType.Text;
       cmd.Connection = cn;
       da.SelectCommand = cmd;
       da.Fill(data);

       string nome = (string)data.Rows[0]["NOME"];

       return nome;
    }

    public DataTable getQueixaProcesso(string processo)
    {
        string sql = "Select * From PROCESSO P, QUEIXA_PROCESSO QP, QUEIXA Q Where P.IDPROCESSO=QP.IDPROCESSO AND QP.COD_QUEIXA=Q.COD_QUEIXA AND P.IDPROCESSO ='" + processo + "' ";
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

    public DataTable getProcesso(string process)
    {
        string sql = "Select * From PROCESSO P WHERE IDPROCESSO ='" + process + "'";
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

    public DataTable getDepoimentoProcesso(string process)
    {
        string sql = "Select * From DEPOIMENTO P WHERE IDPROCESSO ='" + process + "'";
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

    public void actualizarProcesso(string processo, string info)
    {
        this.cn.ConnectionString = this.connectionString;

        string sql = "UPDATE PROCESSO SET DESCRICAOPROCESSO = '" + info + "' Where IDPROCESSO='" + processo + "'";
        SqlCommand cmd = new SqlCommand(sql, cn);



        cn.Open();
        cmd.ExecuteNonQuery();
        cmd.Dispose();
        cn.Close();
    }

    public DataTable getProcessoAgente(string agente){
        agente = getDisintivoUser(agente);

        string sql = "Select * From PROCESSO P WHERE AGE_R_P ='" + agente + "'";
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

    public DataTable getHorarioLaboral(string datainicio, string datafim, string distintivo){
        DateTime horainicial = Convert.ToDateTime(datainicio);
        DateTime horafinal = Convert.ToDateTime(datafim);

        string sql = "Select DATA_FIM_P, HORAENTRADA, HORASAIDA FROM HORARIO WHERE DISTINTIVO =@DIS AND DATA_FIM_P >= @DATA1 AND DATA_FIM_P <=@DATA2";
        DataTable data = new DataTable();
        DateTime d = DateTime.Today;
        this.cn.ConnectionString = this.connectionString;
        SqlCommand cmd = new SqlCommand(sql, cn);
        cmd.Parameters.AddWithValue("@DIS", distintivo);
        cmd.Parameters.AddWithValue("@DATA1", horainicial);
        cmd.Parameters.AddWithValue("@DATA2", horafinal);
        cn.Open();
        data.Load(cmd.ExecuteReader());
        cn.Close();
        return data;

    }
}