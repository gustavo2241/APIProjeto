using System;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class EstoqueController : ControllerBase
    {
        private readonly DataContext _context;

        public EstoqueController(DataContext context) {
            this._context = context;
        }

        [HttpGet("GetEstoque")]
        public async Task<ActionResult> GetEstoque(){
            var estoque = await _context.TB_PRODUTOS.ToListAsync();
            return Ok(estoque);
        }

        [HttpGet("{codProduto}")]
        public async Task<ActionResult<Estoque>> GetProdutoId(string codProduto)
        {
            var produto = await _context.TB_PRODUTOS.Where(x => x.codProduto == codProduto).ToListAsync();

            if (produto == null)
            {
                return NotFound();
            }

            return Ok(produto);
        }
    }
}