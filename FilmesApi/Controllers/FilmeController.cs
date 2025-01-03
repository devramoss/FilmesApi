using FilmesApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmesApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FilmeController : ControllerBase
{
    private static int Id = 0;
    private static List<Filme> filmes = new List<Filme>();

    [HttpPost]
    public void AdicionaFilme([FromBody] Filme filme)
    {
        filme.Id = Id++;
        filmes.Add(filme);

        Console.WriteLine(filme.Titulo);
        Console.WriteLine(filme.Duracao);
    }

    [HttpGet]

    public IEnumerable<Filme> RecuperaFilmes()
    {
        return  filmes;
    }

    [HttpGet("{id}")]
    public Filme ? RecuperaFilmePorId(int id)
    {
       return filmes.FirstOrDefault(filme => filme.Id == id);
    }

}
