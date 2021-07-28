using SpliceAtendimentoWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace SpliceAtendimentoWebAPI.Controllers
{
    public class Atendimento2Controller : ApiController
    {
        [HttpGet, ActionName("ListarAtendimento")]
        public IEnumerable<AtendimentoMOD> GetListaAtendimento() 
        {
            
            var dadosRecuperados = new List<AtendimentoMOD>();
            AtendimentoMOD at = new AtendimentoMOD();

            at.codigo = 1;
            at.dataInicio = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
            at.dataFim = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
            at.veiculo = "ABC1234";
            at.operador = "Operador Teste";
            at.finalizado = true;

            dadosRecuperados.Add(at);

            return dadosRecuperados;

            

        }

        [HttpGet, ActionName("BuscarAtendimentoPorCodigo")]
        public AtendimentoMOD BuscaAtendPorCodigo(int codigo)
        {
            AtendimentoMOD at = new AtendimentoMOD();

            at.codigo = 1;
            at.dataInicio = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
            at.dataFim = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
            at.veiculo = "ABC1234";
            at.operador = "Paulo";
            at.finalizado = true;

            

            return at;

        }

        [HttpPost, ActionName("Cadastrar")]
        public HttpResponseMessage CadastrarAtendimento(AtendimentoMOD at)
        {

            

            try
            {
                if(at.codigo == 1)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Dados já existentes no BD");
                }
                else { 

                at.codigo = 3;
                at.dataInicio = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
                at.dataFim = Convert.ToDateTime("2021-07-15T12:33:00.511Z");
                at.veiculo = "FFF0909";
                at.operador = "Pedro";
                at.finalizado = true;

                   
                } 
                
                return Request.CreateResponse(HttpStatusCode.OK);

            }
            catch (Exception)
            {

                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest));
            }

           



            

        }

        [HttpPut, ActionName("Atualizar")]
        public HttpResponseMessage AtualizarAtendimento(AtendimentoMOD dadosRecebido)
        {
            if (dadosRecebido.codigo != 0) { 

            dadosRecebido.codigo = 2;
            dadosRecebido.dataInicio = Convert.ToDateTime("20/07/2021");
            dadosRecebido.dataFim = Convert.ToDateTime("25/07/2021");
            dadosRecebido.veiculo = "FYD123";
            dadosRecebido.operador = "João";
            dadosRecebido.finalizado = false;
            
            }
            
            return Request.CreateResponse(HttpStatusCode.OK, "Dados atualizados com sucesso!");
        }
            

     }

 }

