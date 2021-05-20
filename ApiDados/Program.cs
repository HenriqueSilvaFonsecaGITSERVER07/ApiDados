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
        static void Main(string[] args)
        {
            ReadView();
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

            string usuario = "x000417";
            string senha = "Brasil07";

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


    }
}
