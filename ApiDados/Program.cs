using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ApiDados
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    ReadView();
        //}

        static string url = "http://agamenon.emgea.ativos:8051";
        static string usuario = "x000417";
        static string senha = "Brasil07";
        static void Main(string[] args)
        {

            //ReadView();
            //ReadRecord();
            SaveRecord();
        }

        static public void ReadView()
        {
            // ajuste o nome o servidor e porta. Em caso de dúvidas, consulte o link abaixo:  
            // http://tdn.totvs.com/pages/releaseview.action?pageId=89620766    
            string url = "http://agamenon.emgea.ativos:8051";

            //importante passar no contexto o mesmo código de usuário usado para logar no webservice  
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO=x000417";

            //usuário e senha do aplicativo RM. O mesmo utilizado para logar no sistema e que tenha permissão de   
            //acesso ao cadastro que deseja utilizar             

            //string usuario = "x000417";
            //string senha = "Brasil07";

            //o filtro pode ser qualquer campo da visão, por exemplo CODCOLIGADA=1 AND CODFILIAL = 1  
            string filtro = "1=1";

            string recordData;

            // Retorna as credenciais para acesso ao WS  
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);
            // lê os dados da visão respeitando o filtro passado  
            DataSet ds = dataclient.ReadView("ImbImovelData", filtro, out recordData);
            // Pode utilizar o ds tipado para DataSet ou a variável recordData que possui o XML da solicitação   
            Console.WriteLine(recordData);

            Console.ReadLine();
        }

        static public void ReadRecord()
        {
            //importante passar no contexto o mesmo código de usuário usado para logar no webservice
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO={usuario}";

            string recordData;
            // Retorna as credenciais para acesso ao WS
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);
            //O ReadRecord retorna o registro da edição do cadastro RM respeitando a chave primária
            DataSet ds = dataclient.ReadRecord("ImbImovelContratoAdmData", "0;0;0;0;0", out recordData);
            // Pode utilizar o ds tipado para DataSet ou a variável recordData que possui o XML da solicitação
            Console.WriteLine(recordData);
            Console.Read();
        }

        static public void SaveRecord()
        {
            string xml = @"<ImbImovel xmlns='http://tempuri.org/ImbImovel.xsd\'>  
                          <XALGIMOVEL>
                            <CODCOLIMOVEL>1</CODCOLIMOVEL>
                            <CODIMOVEL>0</CODIMOVEL>
                            <SITUACAOIMOVEL>0</SITUACAOIMOVEL>
                            <IMOVELPROPRIO>0</IMOVELPROPRIO>
                            <TIPOAREA>1</TIPOAREA>
                            <VALORLOCACAOSUGERIDO>0.00000000</VALORLOCACAOSUGERIDO>
                            <ACEITANEGOCIACAO>0</ACEITANEGOCIACAO>
                            <DATACADASTRO>2021-05-19T00:00:00</DATACADASTRO>
                            <CEP>71692000</CEP>
                            <TIPOLOGRADOURO>1</TIPOLOGRADOURO>
                            <DESCRUA>RUA Henrique TEste</DESCRUA>
                            <LOGRADOURO>Henrique TEste </LOGRADOURO>
                            <NUMERO>1</NUMERO>
                            <BAIRRO>Centro Henrique TEste</BAIRRO>
                            <MUNICIPIO>00108</MUNICIPIO>
                            <NOMEMUNICIPIO>Brasília Henrique TEste</NOMEMUNICIPIO>
                            <ESTADO>DF</ESTADO>
                            <NOMEETD>Distrito Federal Henrique TEste</NOMEETD>
                            <PAIS>1</PAIS>
                            <DESCPAIS>Brasil</DESCPAIS>
                            <RECCREATEDBY>e000172</RECCREATEDBY>
                            <RECCREATEDON>2021-05-19T10:42:12</RECCREATEDON>
                            <RECMODIFIEDBY>e000172</RECMODIFIEDBY>
                            <RECMODIFIEDON>2021-05-19T10:42:22</RECMODIFIEDON>
                            <PERCENTPARTADM>100.0000</PERCENTPARTADM>
                            <TIPOLOCACAOAREA>0</TIPOLOCACAOAREA>
                            <CODCARTORIO>1</CODCARTORIO>
                            <INTEGRACAOPORTAIS>0</INTEGRACAOPORTAIS>
                            <METROQUADRADOLOCADO>0.0000</METROQUADRADOLOCADO>
                            <METROQUADRADODISPONIVEL>0.0000</METROQUADRADODISPONIVEL>
                            <METROQUADRADOLOCAVEL>0.0000</METROQUADRADOLOCAVEL>
                            <METROQUADRADORESERVADO>0.0000</METROQUADRADORESERVADO>
                          </XALGIMOVEL>  
                        </ImbImovel>";

            //importante passar no contexto o mesmo código de usuário usado para logar no webservice
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO={usuario}";

            // Retorna as credenciais para acesso ao WS
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);

            string[] retorno = dataclient.SaveRecord("ImbImovelData", xml);

            Console.WriteLine(retorno[0].ToString());
            Console.Read();
        }


    }
}



