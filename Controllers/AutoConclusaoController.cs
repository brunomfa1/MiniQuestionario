using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TesteInsereAutoConclusao.Models;
using System;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TesteInsereAutoConclusao.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AutoConclusaoController : ControllerBase
    {
        private ApplicationDbContext _db;
        private readonly IConfiguration _configuration;
        private readonly DbSet<AutoConcluEdifica> _dbAutoConcluEdifica;
        private readonly DbSet<AutoConcluHabita> _dbAutoConcluHabita;
        private readonly DbSet<AutoConcluMensoes> _dbAutoConcluMensoes;
        private readonly DbSet<AutoConcluInfra> _dbAutoConcluInfra;
        private readonly DbSet<AutoConcluAssiFoto> _dbAutoConcluAssiFoto;

       
        public AutoConclusaoController(ApplicationDbContext db, IConfiguration configuration)
        {
            _db = db;
            _configuration = configuration;
            _dbAutoConcluEdifica = db.Set<AutoConcluEdifica>();
            _dbAutoConcluHabita = db.Set<AutoConcluHabita>();
            _dbAutoConcluMensoes = db.Set<AutoConcluMensoes>();
            _dbAutoConcluInfra = db.Set<AutoConcluInfra>();
            _dbAutoConcluAssiFoto = db.Set<AutoConcluAssiFoto>();
        }

        [HttpPost]
        [Route("insere/AutoConcluHabita")]
        public  async Task<IActionResult> RegisterHabita([FromBody] AutoConcluHabita model)
        {
            var protocoloExists = await _dbAutoConcluHabita.FirstOrDefaultAsync(x => x.ProtocoloN == model.ProtocoloN);
            if(protocoloExists != null)
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest, "Protocolo já existente ");
            }
            AutoConcluHabita fiscaAutoConcluHabita = new AutoConcluHabita()
            {
                ProtocoloN = model.ProtocoloN,
                AutoConclu = model.AutoConclu,
                ProjetoN = model.ProjetoN,
                Requerente = model.Requerente,
                Quadra = model.Quadra,
                Lote = model.Lote,
                Endereco = model.Endereco,
                DataLicenca = model.DataLicenca,
                ConclusaoObra = model.ConclusaoObra,

            };
            try
            {
                await _dbAutoConcluHabita.AddRangeAsync(fiscaAutoConcluHabita);
                await _db.SaveChangesAsync();
            }
            catch(Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dados da Habitação não adicionados na tabela");
            }
            Response.StatusCode = 200;
            return Ok(new { Status = "Sucess", Message = "Dados de Habitação cadastrado com sucesso na tabela" });
        }

        [HttpPost]
        [Route("insere/AutoConcluEdifica")]
        public async Task<IActionResult> RegisterEdifica([FromBody] AutoConcluEdifica model)
        {
            var protocoloExists = await _dbAutoConcluEdifica.FirstOrDefaultAsync(x => x.ProtocoloN == model.ProtocoloN);
            if (protocoloExists != null)
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest, "Protocolo já existente ");
            }
            AutoConcluEdifica fiscaAutoConcluEdifica = new AutoConcluEdifica()
            {
                ProtocoloN = model.ProtocoloN,
                TipoUnidade = model.TipoUnidade,
                Material = model.Material,
                RevestimentoExterno = model.RevestimentoExterno,
                RevestimentoInterno = model.RevestimentoInterno,
                Esquadria = model.Esquadria,
                Estrutura = model.Estrutura,
                Cobertura = model.Cobertura,   
                InstalacaoSanitaria = model.InstalacaoSanitaria,    
                Forro = model.Forro,   
                InstalacaoEletrica = model.InstalacaoEletrica,
                Piso = model.Piso,
                Limitacao = model.Limitacao,

            };
            try
            {
                await _dbAutoConcluEdifica.AddRangeAsync(fiscaAutoConcluEdifica);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dados da Edificação não adicionados na tabela");
            }
            Response.StatusCode = 200;
            return Ok(new { Status = "Sucess", Message = "Dados de Edificação cadastrado com sucesso na tabela" });
        }

        [HttpPost]
        [Route("insere/AutoConcluMensoes")]
        public async Task<IActionResult> RegisterMensoes([FromBody] AutoConcluMensoes model)
        {
            var protocoloExists = await _dbAutoConcluMensoes.FirstOrDefaultAsync(x => x.ProtocoloN == model.ProtocoloN);
            if (protocoloExists != null)
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest, "Protocolo já existente ");
            }
            AutoConcluMensoes fiscaAutoConcluMensoes = new AutoConcluMensoes()
            {
                ProtocoloN = model.ProtocoloN,
                AreaTerreno = model.AreaTerreno,
                AreaConstruida = model.AreaConstruida,  
                QtdPecasInternas = model.QtdPecasInternas,
                QtdPecasExternas = model.QtdPecasExternas, 
                NPavimentos = model.NPavimentos,   
                NUnidadeResidenciais = model.NUnidadeResidenciais,
                NUnidadeComerciais = model.NUnidadeComerciais,
                AreaTotalEdificacao = model.AreaTotalEdificacao,
                RecuoFrontal = model.RecuoFrontal, 
                TaxaOcupacao = model.TaxaOcupacao,

            };
            try
            {
                await _dbAutoConcluMensoes.AddRangeAsync(fiscaAutoConcluMensoes);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dados de Mensoes não adicionados na tabela");
            }
            Response.StatusCode = 200;
            return Ok(new { Status = "Sucess", Message = "Dados de Mensões cadastrado com sucesso na tabela" });
        }
        
        [HttpPost]
        [Route("insere/AutoConcluInfra")]
        public async Task<IActionResult> RegisterInfra([FromBody] AutoConcluInfra model)
        {
            var protocoloExists = await _dbAutoConcluInfra.FirstOrDefaultAsync(x => x.ProtocoloN == model.ProtocoloN);
            if (protocoloExists != null)
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest, "Protocolo já existente ");
            }
            AutoConcluInfra fiscaAutoConcluInfra = new AutoConcluInfra()
            {
                ProtocoloN = model.ProtocoloN,
                Esgoto = model.Esgoto,
                AguaRede = model.AguaRede,
                FossaSepticaSumidouro = model.FossaSepticaSumidouro,
                EnergiaEletrica = model.EnergiaEletrica,
                Iluminacao = model.Iluminacao, 
                Telefone = model.Telefone,
                GuiasSarjetas = model.GuiasSarjetas,   
                GaleriaPluvial = model.GaleriaPluvial, 
                Pavimentacao = model.Pavimentacao, 
                Calcamento = model.Calcamento,
                Arborizacao = model.Arborizacao,
                LimpezaPublica = model.LimpezaPublica,
                ColetaLixo = model.ColetaLixo, 
                TransporteColetivo = model.TransporteColetivo,

            };
            try
            {
                await _dbAutoConcluInfra.AddRangeAsync(fiscaAutoConcluInfra);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Dados de Infraestrtura não adicionados na tabela");
            }
            Response.StatusCode = 200;
            return Ok(new { Status = "Sucess", Message = "Dados de Infraestrutura cadastrado com sucesso na tabela" });
        }

        [HttpPost]
        [Route("insere/AutoConcluAssiFoto")]
        public async Task<IActionResult> RegisterAssiFoto([FromBody] AutoConcluAssiFoto model)
        {
            var protocoloExists = await _dbAutoConcluInfra.FirstOrDefaultAsync(x => x.ProtocoloN == model.ProtocoloN);
            if (protocoloExists != null)
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest, "Protocolo já existente ");
            }
            AutoConcluAssiFoto fiscaAutoConcluAssiFoto = new AutoConcluAssiFoto()
            {
                ProtocoloN = model.ProtocoloN,
                Foto1 = model.Foto1,
                Foto2 = model.Foto2,
                Assinatura = model.Assinatura,
            };
            try
            {
                await _dbAutoConcluAssiFoto.AddRangeAsync(fiscaAutoConcluAssiFoto);
                await _db.SaveChangesAsync();
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Fotos e Assinatura não adicionados na tabela");
            }
            Response.StatusCode = 200;
            return Ok(new { Status = "Sucess", Message = "Fotos e Assinatura cadastrado com sucesso na tabela" });
        }

        [HttpPost]
        [Route("buscaProtocolo/AutoConcluTodos")]
        public async Task<JsonResult> AutoConcluHabitaBuscaProtocolo([FromBody] string protocolo)
        {
            var listaResultado = new List<AutoConcluGeralDadosDTO>();
            var queryHabita = _dbAutoConcluHabita.Where(x => x.ProtocoloN == protocolo);

            var dbAutoConcluEdificaTodos = _dbAutoConcluEdifica.ToList();
            var dbAutoConcluMensoesTodos = _dbAutoConcluMensoes.ToList();
            var dbAutoConcluInfraTodos = _dbAutoConcluInfra.ToList();
            foreach (var AutoConcluHabita in queryHabita)
            {
                var AutoConcluEdifica = dbAutoConcluEdificaTodos.FirstOrDefault(x => x.ProtocoloN == AutoConcluHabita.ProtocoloN);
                var AutoConcluMensoes = dbAutoConcluMensoesTodos.FirstOrDefault(x => x.ProtocoloN == AutoConcluHabita.ProtocoloN);
                var AutoConcluInfra = dbAutoConcluInfraTodos.FirstOrDefault(x => x.ProtocoloN == AutoConcluHabita.ProtocoloN);
                listaResultado.Add(new AutoConcluGeralDadosDTO()
                {
                    Id = AutoConcluHabita.Id,
                    ProtocoloN = AutoConcluHabita.ProtocoloN,
                    AutoConclu = AutoConcluHabita.AutoConclu,
                    ProjetoN = AutoConcluHabita.ProjetoN,
                    Requerente = AutoConcluHabita.Requerente,
                    Quadra  =  AutoConcluHabita.Quadra,
                    Lote = AutoConcluHabita.Lote,
                    Endereco = AutoConcluHabita.Endereco,
                    DataLicenca = AutoConcluHabita.DataLicenca,
                    ConclusaoObra   = AutoConcluHabita.ConclusaoObra,
                    //---------------------------------------------------
                    TipoUnidade = AutoConcluEdifica.TipoUnidade,
                    Material = AutoConcluEdifica.Material,
                    RevestimentoExterno = AutoConcluEdifica.RevestimentoExterno,
                    RevestimentoInterno = AutoConcluEdifica.RevestimentoInterno,
                    Esquadria = AutoConcluEdifica.Esquadria,
                    Estrutura = AutoConcluEdifica.Estrutura,
                    Cobertura = AutoConcluEdifica.Cobertura,
                    InstalacaoSanitaria = AutoConcluEdifica.InstalacaoSanitaria,
                    Forro = AutoConcluEdifica.Forro,
                    InstalacaoEletrica = AutoConcluEdifica.InstalacaoEletrica,
                    Piso = AutoConcluEdifica.Piso,
                    Limitacao = AutoConcluEdifica.Limitacao,
                    //---------------------------------------------------
                    AreaTerreno = AutoConcluMensoes.AreaTerreno,
                    AreaConstruida = AutoConcluMensoes.AreaConstruida,
                    QtdPecasInternas = AutoConcluMensoes.QtdPecasInternas,
                    QtdPecasExternas = AutoConcluMensoes.QtdPecasExternas,
                    NPavimentos = AutoConcluMensoes.NPavimentos,
                    NUnidadeResidenciais = AutoConcluMensoes.NUnidadeResidenciais,
                    NUnidadeComerciais = AutoConcluMensoes.NUnidadeComerciais,
                    AreaTotalEdificacao = AutoConcluMensoes.AreaTotalEdificacao,
                    RecuoFrontal = AutoConcluMensoes.RecuoFrontal,
                    TaxaOcupacao = AutoConcluMensoes.TaxaOcupacao,
                    //---------------------------------------------------
                    Esgoto = AutoConcluInfra.Esgoto,
                    AguaRede = AutoConcluInfra.AguaRede,
                    FossaSepticaSumidouro = AutoConcluInfra.FossaSepticaSumidouro,
                    EnergiaEletrica = AutoConcluInfra.EnergiaEletrica,
                    Iluminacao = AutoConcluInfra.Iluminacao,
                    Telefone = AutoConcluInfra.Telefone,
                    GuiasSarjetas = AutoConcluInfra.GuiasSarjetas,
                    GaleriaPluvial = AutoConcluInfra.GaleriaPluvial,
                    Pavimentacao = AutoConcluInfra.Pavimentacao,
                    Calcamento = AutoConcluInfra.Calcamento,
                    Arborizacao = AutoConcluInfra.Arborizacao,
                    LimpezaPublica = AutoConcluInfra.LimpezaPublica,
                    ColetaLixo = AutoConcluInfra.ColetaLixo,
                    TransporteColetivo = AutoConcluInfra.TransporteColetivo
                });
            }
            return new JsonResult(listaResultado);
        }

        [HttpGet]
        [Route("busca/AutoConcluHabitaBuscaTodos")]
        public async Task<JsonResult> AutoConcluHabitaBuscaTodos()
        {
            return new JsonResult(_dbAutoConcluHabita);
        }

        
    }

}
