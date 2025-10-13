using Core.Entity;
using Core.Inputs;
using Core.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace FiapStoreApi.Controllers
{
    [ApiController]
    [Route("/[controller]")]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _livroRepository;

        public LivroController(ILivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

/*        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_livroRepository.ObterTodos());
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_livroRepository.ObterPorId(id));
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
*/
        [HttpPost]
        public IActionResult Post([FromBody] LivroInput input)
        {
            try
            {
                var livro = new Livro()
                {
                    Nome = input.Nome,
                    Editora = input.Editora
                };
                _livroRepository.Cadastrar(livro);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /*
                [HttpPut]
                public IActionResult Put([FromBody] LivroUpdateInput input)
                {
                    try
                    {
                        var livro = _livroRepository.ObterPorId(input.Id);
                        livro.Nome = input.Nome;
                        livro.Editora = input.Editora;
                        _livroRepository.Alerar(livro);
                        return Ok();
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e);
                    }
                }

                [HttpDelete("{id:int}")]
                public IActionResult Delete([FromRoute] int id)
                {
                    try
                    {
                        _livroRepository.Deletar(id);
                        return Ok();
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e);
                    }
                }

                [HttpPost("Cadastro-em-massa")]
                public IActionResult CadastrarEmMassa()
                {
                    try
                    {
                        var livros = new List<Livro>()
                        {
                            new Livro() { Nome = "Livro 1", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 2", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 3", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 4", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 5", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 6", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 7", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 8", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 9", Editora = "Editora", DataCriacao = DateTime.Now},
                            new Livro() { Nome = "Livro 10", Editora = "Editora", DataCriacao = DateTime.Now}
                        };

                        _livroRepository.CadastrarEmMassa(livros);
                        return Ok();
                    }
                    catch (Exception e)
                    {
                        return BadRequest(e);
                    }
                }*/
    }
}
