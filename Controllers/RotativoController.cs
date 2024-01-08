using System.Linq;
using GestaoEstacionamentoRotativo.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestaoEstacionamentoRotativo.Models;
using GestaoEstacionamentoRotativo.ViewModels;

namespace GestaoEstacionamentoRotativo.Controllers
{
    [ApiController]
    [Route("rotativo")]
    public class RotativoController : ControllerBase
    {

        [Route("v1/novo-rotativo-existente/{placa}")]
        public async Task<IActionResult> setRotativoExistente([FromServices] AppDbContext context, string placa){
            
            placa = placa.Trim();

            var veiculoRegistrado = await context.Veiculo.Where(x => x.Placa == placa).FirstAsync();

            if(veiculoRegistrado != null){
                var Rotativo = new Rotativo(){
                    Id = 0,
                    Chegada = DateTime.Now,
                    VeiculoId = veiculoRegistrado.Id
                };

                context.Rotativo.Add(Rotativo);
                context.SaveChanges();

                return Ok();
                
            }else{
                return NotFound();
            }   
        }   


        // [Route("v1/novo-rotativo-sem-cadastro/")]
        // public async Task<IActionResult> setRotativoNovoCliente([FromServices] AppDbContext context, VeiculoViewModel Veiculo){

        //     if(Veiculo != null){
        //         var Rotativo = new Rotativo(){
        //             Id = 0,
        //             Chegada = DateTime.Now,
        //             VeiculoId = Veiculo.Id
        //         };

        //         context.Rotativo.Add(Rotativo);
        //         context.SaveChanges();

        //         var NovoVeiculo = new Veiculo(){
        //             Id = 0,
        //             Placa = Veiculo.Placa,
        //             Marca = Veiculo.Marca,
        //             Nome = Veiculo.Nome,
        //             CategoriaId = Veiculo.CategoriaId
        //         };

        //         return Ok();

        //     }else{
        //         return BadRequest();
        //     }
        // }  
    }
}