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
            /*IMOVEL*/
            //ReadView();
            ReadRecord();          
            //SalvarImovel();

            /*Lançamentos Financeiros*/
            VisualizarLancamentosFinanceiros();
            SalvarLacamentoFinanceiro();
            AtualizaRecordLancamentoFinanceiro();

        }       

        static public void VisualizarLancamentosFinanceiros()
        {          
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO=x000417";
           
            string filtro = "1=1";

            string recordData;
          
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);          
        
            DataSet ds = dataclient.ReadView("FinLanDataBR", filtro, out recordData);
           
            Console.WriteLine(recordData);

            Console.ReadLine();
        }
               
        /// SALVANDO O CADASTRO E DADOS DO IMOVEL 
        

        //CADASTRO DE LANÇAMENTOS FUNCIONANDO ALTERAR <NUMERODOCUMENTO>
        static public void SalvarLacamentoFinanceiro()
        {
            string xml = @"<FinLAN>  
              <FLAN>  
                <CODCOLIGADA>1</CODCOLIGADA>  
                <IDLAN>0</IDLAN>  
                <NUMERODOCUMENTO>00006485</NUMERODOCUMENTO> 
                <IPTE>27593344243334673000600000013557842760000015000</IPTE>  
                <CNABNOSSONUMERO>00013550001355</CNABNOSSONUMERO>  
                <NFOUDUP>0</NFOUDUP>  
                <CLASSIFICACAO>0</CLASSIFICACAO>  
                <PAGREC>1</PAGREC>  
                <STATUSLAN>1</STATUSLAN>  
                <CODAPLICACAO>S</CODAPLICACAO>  
                <CODCOLXCX>1</CODCOLXCX>  
                <CODCCUSTO>03.00.00</CODCCUSTO>  
                <DATACRIACAO>2009-06-22T00:00:00</DATACRIACAO>  
                <DATAVENCIMENTO>2009-06-22T17:24:00</DATAVENCIMENTO>  
                <DATAEMISSAO>2009-06-22T13:18:26</DATAEMISSAO>  
                <DATABAIXA>2009-06-22T00:00:00</DATABAIXA>  
                <DATACONTABILIZBX>2009-06-22T00:00:00</DATACONTABILIZBX>  
                <DATAPAG>2009-06-22T00:00:00</DATAPAG>  
                <VALORORIGINAL>150.0000</VALORORIGINAL>  
                <VALORBAIXADO>150.0000</VALORBAIXADO>  
                <VALORCAP>0.0000</VALORCAP>  
                <VALORJUROS>0.0000</VALORJUROS>  
                <VALORDESCONTO>0.0000</VALORDESCONTO>  
                <VALORCHEQUE>0.0000</VALORCHEQUE>  
                <VALOROP1>0.0000</VALOROP1>  
                <VALOROP2>0.0000</VALOROP2>  
                <VALOROP3>0.0000</VALOROP3>  
                <VALOROP4>0.0000</VALOROP4>  
                <VALOROP5>0.0000</VALOROP5>  
                <VALOROP6>0.0000</VALOROP6>  
                <VALOROP7>0.0000</VALOROP7>  
                <VALOROP8>0.0000</VALOROP8>  
                <VALORMULTA>0.0000</VALORMULTA>  
                <VALORAUXILIAR>1.0000</VALORAUXILIAR>  
                <VALORBASEIRRF>100.0000</VALORBASEIRRF>  
                <VALORIRRF>0.0000</VALORIRRF>  
                <VALORREPASSE>0.0000</VALORREPASSE>  
                <VALORVENCIMENTOANTECIP>0.0000</VALORVENCIMENTOANTECIP>  
                <VALORNOTACREDITO>0.0000</VALORNOTACREDITO>  
                <VALORADIANTAMENTO>0.0000</VALORADIANTAMENTO>  
                <VALORDEVOLUCAO>0.0000</VALORDEVOLUCAO>  
                <JUROSDIA>0.0000</JUROSDIA>  
                <CAPMENSAL>0.0000</CAPMENSAL>  
                <TAXASVENDOR>0.0000</TAXASVENDOR>  
                <JUROSVENDOR>0.0000</JUROSVENDOR>  
                <CODCOLCFO>1</CODCOLCFO>  
                <CODCFO>C00003</CODCFO>  
                <CODCOLCXA>1</CODCOLCXA>  
                <CODCXA>106</CODCXA>  
                <IDPGTO>1</IDPGTO>  
                <CODTDO>01</CODTDO>  
                <CODFILIAL>1</CODFILIAL>  
                <SERIEDOCUMENTO>@@@</SERIEDOCUMENTO>  
                <TIPOCONTABILLAN>0</TIPOCONTABILLAN>  

                <HISTORICO>CADASTRO WENDER</HISTORICO>

                <CODMOEVALORORIGINAL>R$</CODMOEVALORORIGINAL>  
                <LIBAUTORIZADA>0</LIBAUTORIZADA>  
                <STATUSEXPORTACAO>0</STATUSEXPORTACAO>  
                <NUMLOTECONTABIL>0</NUMLOTECONTABIL>  
                <STATUSEXTRATO>0</STATUSEXTRATO>  
                <CNABCARTEIRA>21</CNABCARTEIRA>  
                <CNABACEITE>0</CNABACEITE>  
                <CNABSTATUS>0</CNABSTATUS>  
                <CNABBANCO>275</CNABBANCO>  
                <REEMBOLSAVEL>0</REEMBOLSAVEL>  
                <CODBAIXA>2</CODBAIXA>  
                <USUARIO>Kenya</USUARIO>  
                <BAIXAAUTORIZADA>1</BAIXAAUTORIZADA>  
                <TEMCHEQUEPARCIAL>0</TEMCHEQUEPARCIAL>  
                <JAIMPRIMIU>0</JAIMPRIMIU>  
                <NUMBLOQUEIOS>0</NUMBLOQUEIOS>  
                <NUMCONTABILBX>00006497</NUMCONTABILBX>  
                <COTACAOINCLUSAO>0.000000000</COTACAOINCLUSAO>  
                <COTACAOBAIXA>0.000000000</COTACAOBAIXA>  
                <CARENCIAJUROS>0</CARENCIAJUROS>  
                <TIPOJUROSDIA>0</TIPOJUROSDIA>  
                <USUARIOCRIACAO>UsrProcSel</USUARIOCRIACAO>  
                <DATAALTERACAO>2009-06-22T00:00:00</DATAALTERACAO>  
                <ALTERACAOBLOQUEADA>0</ALTERACAOBLOQUEADA>  
                <MULTADIA>0.0000</MULTADIA>  
                <DESCONTADO>0</DESCONTADO>  
                <VALORINSS>0.0000</VALORINSS>  
                <VALORDEDUCAO>0.0000</VALORDEDUCAO>  
                <APLICFORMULA>F</APLICFORMULA>  
                <INSSEMOUTRAEMPRESA>0.0000</INSSEMOUTRAEMPRESA>  
                <PERCENTBASEINSS>100.0000</PERCENTBASEINSS>  
                <PERCBASEINSSEMPREGADO>100.0000</PERCBASEINSSEMPREGADO>  
                <INSSEDITADO>0</INSSEDITADO>  
                <IRRFEDITADO>0</IRRFEDITADO>  
                <REUTILIZACAO>0</REUTILIZACAO>  
                <VALORSESTSENAT>0.0000</VALORSESTSENAT>  
                <CONVENIO>123321</CONVENIO>  
                <DIGCONVENIO>2</DIGCONVENIO>  
                <PERCJUROS>0</PERCJUROS>  
                <PERCDESCONTO>0</PERCDESCONTO>  
                <PERCMULTA>0</PERCMULTA>  
                <PERCCAP>0</PERCCAP>  
                <PERCOP1>0</PERCOP1>  
                <PERCOP2>0</PERCOP2>  
                <PERCOP3>0</PERCOP3>  
                <PERCOP4>0</PERCOP4>  
                <PERCOP5>0</PERCOP5>  
                <PERCOP6>0</PERCOP6>  
                <PERCOP7>0</PERCOP7>  
                <PERCOP8>0</PERCOP8>  
                <VALORINSSEMPREGADOR>0</VALORINSSEMPREGADOR>  
                <VALORBASEINSSEMPREGADOR>0</VALORBASEINSSEMPREGADOR>  
                <VRBASEINSS>0</VRBASEINSS>  
                <VRBASEIRRF>0</VRBASEIRRF>  
                <VALORSERVICO>150.0000</VALORSERVICO>  
                <VRBASEINSSOUTRAEMPRESA>0.0000</VRBASEINSSOUTRAEMPRESA>  
                <IDHISTORICO>0</IDHISTORICO>  
                <PreencherRatCCusto>true</PreencherRatCCusto>  
                <PreencherRatDepto>true</PreencherRatDepto>  
                <VRPERDAFINANCEIRA>0.0000</VRPERDAFINANCEIRA>  
                <MODELOCONTABILIZACAO>1</MODELOCONTABILIZACAO>  
                <MODELOCONTABILIZACAOBAIXA>1</MODELOCONTABILIZACAOBAIXA>  
                <IDCONVENIO>0</IDCONVENIO>  
                <VALORORIGINALBX>0</VALORORIGINALBX>  
                <VALORDESCONTOBX>0</VALORDESCONTOBX>  
                <VALORJUROSBX>0</VALORJUROSBX>  
                <VALORMULTABX>0</VALORMULTABX>  
                <VALORCAPBX>0</VALORCAPBX>  
                <VALOROP1BX>0,0000</VALOROP1BX>  
                <VALOROP2BX>0,0000</VALOROP2BX>  
                <VALOROP3BX>0,0000</VALOROP3BX>  
                <VALOROP4BX>0,0000</VALOROP4BX>  
                <VALOROP5BX>0,0000</VALOROP5BX>  
                <VALOROP6BX>0,0000</VALOROP6BX>  
                <VALOROP7BX>0,0000</VALOROP7BX>  
                <VALOROP8BX>0,0000</VALOROP8BX>  
                <VALORINSSBX>0</VALORINSSBX>  
                <VALORIRRFBX>0</VALORIRRFBX>  
                <VALORSESTSENATBX>0</VALORSESTSENATBX>  
                <VALORDEVOLUCAOBX>0</VALORDEVOLUCAOBX>  
                <VALORNOTACREDITOBX>0</VALORNOTACREDITOBX>  
                <VALORADIANTAMENTOBX>0</VALORADIANTAMENTOBX>  
                <VALORJUROSVENDORBX>0</VALORJUROSVENDORBX>  
                <VALORRETENCOESBX>0</VALORRETENCOESBX>  
                <STATUSORCAMENTO>0</STATUSORCAMENTO>  
                <BAIXAPENDENTE>0</BAIXAPENDENTE>  
                <VALORDESCONTOACORDO>0.0000</VALORDESCONTOACORDO>  
                <VALORJUROSACORDO>0.0000</VALORJUROSACORDO>  
                <VALORACRESCIMOACORDO>0.0000</VALORACRESCIMOACORDO>  
                <VALORDEDUCAOVARIAVEL>0.0000</VALORDEDUCAOVARIAVEL>  
                <STATUSLIQDUVIDOSA>0</STATUSLIQDUVIDOSA>  
                <CODCOLPGTO>1</CODCOLPGTO>  
              </FLAN>  
              <FLANRATCCU>  
                <IDRATCCU>0</IDRATCCU>  
                <CODCOLIGADA>1</CODCOLIGADA>  
                <IDLAN>0</IDLAN>  
                <CODCCUSTO>03.00.00</CODCCUSTO>
                <CODCOLNATFINANCEIRA>1</CODCOLNATFINANCEIRA>
                <CODNATFINANCEIRA>1001</CODNATFINANCEIRA>
                <NOME>Administrativo</NOME>  
                <VALOR>150.0000</VALOR>  
                <PERCENTUAL>100.0000</PERCENTUAL>  
              </FLANRATCCU>  
              <FLANCOMPL>  
                <CODCOLIGADA>1</CODCOLIGADA>  
                <IDLAN>0</IDLAN>  
              </FLANCOMPL>   
            </FinLAN>";
            
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO={usuario}";
           
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);

            string[] retorno = dataclient.SaveRecord("FinLanDataBR", xml);

            Console.WriteLine(retorno[0].ToString());
            Console.Read();
        }

        //Metodo que está salvando os Lançamentos de distrato 
        //ATUALIZANDO FUNCIONANDO  IDENTIFICADOR PARA ALTERAÇÃO REFERENCIA <IDLAN>329274</IDLAN>
        static public void AtualizaRecordLancamentoFinanceiro()
        {
            string xml = @"<FinLAN>  
             <FLAN>
             <IDLAN>329285</IDLAN>
             <CODCOLIGADA>1</CODCOLIGADA>
             <CODFILIAL>1</CODFILIAL>
             <CODCOLCFO>1</CODCOLCFO>
             <CODCFO>C00003</CODCFO>
             <CODTDO>01</CODTDO>
              <CODCCUSTO>03.02.01</CODCCUSTO>  
             <VRPERDAFINANCEIRA>0.0000</VRPERDAFINANCEIRA>
             <MESDECOMPETENCIA>2002-06-01T00:00:00</MESDECOMPETENCIA>
             <DATAEMISSAO>2002-06-25T00:00:00</DATAEMISSAO>
             <DATAVENCIMENTO>2002-06-25T00:00:00</DATAVENCIMENTO> 
             <CODCOLXCX>1</CODCOLXCX>  
             <VALORBAIXADO>12737.7900</VALORBAIXADO>
             <DATABAIXA>2002-06-25T00:00:00</DATABAIXA>
             <TIPOCONTABILLAN>2</TIPOCONTABILLAN>
             <HISTORICO>ATUALIZAÇÃO WENDER</HISTORICO>
             <BAIXAAUTORIZADA>1</BAIXAAUTORIZADA>
             <CODCOLCXA>1</CODCOLCXA>
             <CODCXA>106</CODCXA>
             <DESCRICAOCXA>CAIXA ECONOMICA FEDERAL - OP 003</DESCRICAOCXA>
             <VALORDESCONTO>0.0000</VALORDESCONTO>
             <VALOROP1>0.0000</VALOROP1>
             <VALOROP2>0.0000</VALOROP2>
             <VALOROP3>0.0000</VALOROP3>
             <VALOROP4>0.0000</VALOROP4>
             <VALOROP5>0.0000</VALOROP5>
             <VALOROP6>0.0000</VALOROP6>
             <VALOROP7>0.0000</VALOROP7>
             <VALOROP8>0.0000</VALOROP8>
             <CLASSIFICACAO>0</CLASSIFICACAO>
             <CNABSTATUS>0</CNABSTATUS>
             <NUMBLOQUEIOS>0</NUMBLOQUEIOS>
             <CODAPLICACAO>F</CODAPLICACAO>
             <USUARIOCRIACAO>marise</USUARIOCRIACAO>
             <DATACRIACAO>2002-12-11T00:00:00</DATACRIACAO>
             <USUARIO>x000417</USUARIO>
             <DATAALTERACAO>2021-05-24T00:00:00</DATAALTERACAO>
             <PAGREC>1</PAGREC>
             <STATUSLAN>1</STATUSLAN>
             <STATUSEXPORTACAO>2</STATUSEXPORTACAO>
             <STATUSEXTRATO>0</STATUSEXTRATO>
             <TEMCHEQUEPARCIAL>0</TEMCHEQUEPARCIAL>
             <NFOUDUP>0</NFOUDUP>
             <IDHISTORICO>0</IDHISTORICO>
             <CODMOEVALORORIGINAL>R$</CODMOEVALORORIGINAL>
             <DESCONTADO>0</DESCONTADO>
             <MODELOCONTABILIZACAO>1</MODELOCONTABILIZACAO>
             <MODELOCONTABILIZACAOBAIXA>1</MODELOCONTABILIZACAOBAIXA>
             <VALORORIGINALBX>12737.7900</VALORORIGINALBX>
             <VALORDESCONTOBX>0.0000</VALORDESCONTOBX>
             <VALORJUROSBX>0.0000</VALORJUROSBX>
             <VALORMULTABX>0.0000</VALORMULTABX>
             <VALORCAPBX>0.0000</VALORCAPBX>
             <VALOROP1BX>0.0000</VALOROP1BX>
             <VALOROP2BX>0.0000</VALOROP2BX>
             <VALOROP3BX>0.0000</VALOROP3BX>
             <VALOROP4BX>0.0000</VALOROP4BX>
             <VALOROP5BX>0.0000</VALOROP5BX>
             <VALOROP6BX>0.0000</VALOROP6BX>
             <VALOROP7BX>0.0000</VALOROP7BX>
             <VALOROP8BX>0.0000</VALOROP8BX>
             <VALORINSSBX>0.0000</VALORINSSBX>
             <VALORIRRFBX>0.0000</VALORIRRFBX>
             <VALORSESTSENATBX>0.0000</VALORSESTSENATBX>
             <VALORDEVOLUCAOBX>0.0000</VALORDEVOLUCAOBX>
             <VALORNOTACREDITOBX>0.0000</VALORNOTACREDITOBX>
             <VALORADIANTAMENTOBX>0.0000</VALORADIANTAMENTOBX>
             <VALORJUROSVENDORBX>0.0000</VALORJUROSVENDORBX>
             <VALORRETENCOESBX>0.0000</VALORRETENCOESBX>
             <VALORPERDAFINANCEIRABX>0.0000</VALORPERDAFINANCEIRABX>
             <ALTERACAOBLOQUEADA>0</ALTERACAOBLOQUEADA>
             <BAIXAPENDENTE>0</BAIXAPENDENTE>
             <SERIEDOCUMENTO>@@@</SERIEDOCUMENTO>
             <NOME>CAIXA ECONOMICA FEDERAL</NOME>
             <NOMEFANTASIA>CAIXA</NOMEFANTASIA>
             <PESSOAFISOUJUR>J</PESSOAFISOUJUR>
             <VALORMULTA>0.0000</VALORMULTA>
             <MULTADIA>0.0000</MULTADIA>
             <JUROSDIA>0.0000</JUROSDIA>
             <TIPOJUROSDIA>0</TIPOJUROSDIA>
             <CARENCIAJUROS>0</CARENCIAJUROS>
             <VALORJUROS>0.0000</VALORJUROS>
             <DATAPAG>2002-12-12T00:00:00</DATAPAG>
             <STATUSORCAMENTO>0</STATUSORCAMENTO>
             <LIBAUTORIZADA>0</LIBAUTORIZADA>
             <VALORDESCONTOACORDO>0.0000</VALORDESCONTOACORDO>
             <VALORJUROSACORDO>0.0000</VALORJUROSACORDO>
             <VALORACRESCIMOACORDO>0.0000</VALORACRESCIMOACORDO>
             <VALORINSS>0.0000</VALORINSS>
             <VALORIRRF>0.0000</VALORIRRF>
             <VALORDEVOLUCAO>0.0000</VALORDEVOLUCAO>
             <VALORDEDUCAOVARIAVEL>0.0000</VALORDEDUCAOVARIAVEL>
             <STATUSLIQDUVIDOSA>0</STATUSLIQDUVIDOSA>
             <JAIMPRIMIU>0</JAIMPRIMIU>
             <VALORVINCULADO>0.0000</VALORVINCULADO>
             <STATUSNEGATIVACAO>0</STATUSNEGATIVACAO>
             <CNABBANCO>104</CNABBANCO>
             <VALORLIQUIDO>12737.7900</VALORLIQUIDO>
             <VALORTOTALALGEBRICO>12737.7900</VALORTOTALALGEBRICO>
             <VALORJUROSFOR>0.0000</VALORJUROSFOR>
             <VALORMULTAFOR>0.0000</VALORMULTAFOR>
             <DIASATRASO>0</DIASATRASO>
             <Imagem_x0020_-_x0020_Natureza>1</Imagem_x0020_-_x0020_Natureza>
             <Imagem_x0020_-_x0020_Status>3</Imagem_x0020_-_x0020_Status>
  </FLAN>   
  <FLANRATCCU>  
             <IDRATCCU>0</IDRATCCU>  
             <CODCOLIGADA>1</CODCOLIGADA>  
             <IDLAN>329285</IDLAN>  
             <CODCCUSTO>03.02.01</CODCCUSTO>
             <CODCOLNATFINANCEIRA>1</CODCOLNATFINANCEIRA>
             <CODNATFINANCEIRA>1001</CODNATFINANCEIRA>
             <NOME>ADM ATUALIZACAO</NOME>  
             <VALOR>150.0000</VALOR>  
             <PERCENTUAL>100.0000</PERCENTUAL>  
             </FLANRATCCU>  
             <FLANCOMPL>  
             <CODCOLIGADA>1</CODCOLIGADA>  
             <IDLAN>329285</IDLAN>  
            </FLANCOMPL>   

 </FinLAN>";

            //importante passar no contexto o mesmo código de usuário usado para logar no webservice
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO={usuario}";

            // Retorna as credenciais para acesso ao WS
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);

            string[] retorno = dataclient.SaveRecord("FinLanDataBR", xml);

            Console.WriteLine(retorno[0].ToString());
            Console.Read();
        }


        /*============================================ IMOVEL ====================================================================*/
        ///LEITURA DOS DADOS
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

            //Imovel
            //DataSet ds = dataclient.ReadView("ImbImovelData", filtro, out recordData);

            //Lançamentos Financeiros
            DataSet ds = dataclient.ReadView("FinLanDataBR", filtro, out recordData);


            //Pode utilizar o ds tipado para DataSet ou a variável recordData que possui o XML da solicitação   
            Console.WriteLine(recordData);

            Console.ReadLine();
        }
        static public void SalvarImovel()
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
                            <DATACADASTRO>2021-05-25T00:00:00</DATACADASTRO>
                            <CEP>71692000</CEP>
                            <TIPOLOGRADOURO>1</TIPOLOGRADOURO>
                            <DESCRUA>Novo 4Teste 25052021</DESCRUA>
                            <LOGRADOURO>Novo Teste4 25052021</LOGRADOURO>
                            <NUMERO>1</NUMERO>
                            <BAIRRO>Novo Teste 25052021</BAIRRO>
                            <MUNICIPIO>00108</MUNICIPIO>
                            <NOMEMUNICIPIO>Novo Teste 25052021</NOMEMUNICIPIO>
                            <ESTADO>DF</ESTADO>
                            <NOMEETD>Novo Teste 25052021</NOMEETD>
                            <PAIS>1</PAIS>
                            <DESCPAIS>Brasil</DESCPAIS>
                            <RECCREATEDBY>e000172</RECCREATEDBY>
                            <RECCREATEDON>2021-05-25T10:42:12</RECCREATEDON>
                            <RECMODIFIEDBY>e000172</RECMODIFIEDBY>
                            <RECMODIFIEDON>2021-05-25T10:42:22</RECMODIFIEDON>
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

    }
}


