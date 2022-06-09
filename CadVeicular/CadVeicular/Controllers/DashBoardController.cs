using CadVeicular.Application.Services.Interfaces;
using CadVeicular.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace CadVeicular.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashBoardController : ControllerBase
    {
        private readonly IMarcaAppService _marcaAppService;
        private readonly IVeiculoAppService _veiculoAppService;
        private readonly IProprietarioAppService _proprietarioAppService;

        public DashBoardController(IMarcaAppService marcaAppService, IVeiculoAppService veiculoAppService, IProprietarioAppService proprietarioAppService)
        {
            _marcaAppService = marcaAppService;
            _veiculoAppService = veiculoAppService;
            _proprietarioAppService = proprietarioAppService;
        }

        [HttpGet]
        [Route("by/listarProprietario")]
        public async Task<IActionResult> ListarProprietario() 
        {
            var proprietario = await _proprietarioAppService.ListarProprietario();
            if(proprietario == null) return NotFound("Nenhum proprietario encontrado");
            return Ok(proprietario);
        }
        [HttpGet]
        [Route("by/ListarVeiculo")]
        public async Task<IActionResult> ListarVeiculo()
        {
            var Veiculo = await _veiculoAppService.ListarVeiculo();
            if (Veiculo == null) return NotFound("Nenhum Veiculo encontrado");
            return Ok(Veiculo);
        }
        [HttpGet]
        [Route("by/ListarMarca")]
        public async Task<IActionResult> ListarMarca()
        {
            var marca = await _marcaAppService.ListarMarca();
            if (marca == null) return NotFound("Nenhum Veiculo encontrado");
            return Ok(marca);
        }

        [HttpPost]
        [Route("by/CadastroProprietario")]
        public async Task<IActionResult> CadastrarProprietario([FromBody] NovoProprietarioViewModel vm) 
        {
            var result = await _proprietarioAppService.CadastrarProprietario(vm);
            if(result == null) return BadRequest("Não foi possivel Cadastrar o Proprietario");
            return Ok(result);
        }
        [HttpPost]
        [Route("by/CadastroVeiculo")]
        public async Task<IActionResult> CadastrarVeiculo([FromBody] NovoVeiculoViewModel vm)
        {
            var result = await _veiculoAppService.CadastrarVeiculo(vm);
            if (result == null) return BadRequest("Não foi possivel Cadastrar o Veiculo");
            return Ok(result);
        }
        [HttpPost]
        [Route("by/CadastroMarca")]
        public async Task<IActionResult> CadastrarMarca([FromBody] NovaMarcaViewModel vm)
        {
            var result = await _marcaAppService.CadastrarMarca(vm);
            if (result == null) return BadRequest("Não foi possivel Cadastrar a Marca");
            return Ok(result);
        }
    }
}
