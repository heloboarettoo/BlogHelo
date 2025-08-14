using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogGallo.Models;

namespace BlogGallo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Categoria dança = new Categoria();
        dança.Id = 1;
        dança.Nome = "Dança";

        Categoria ballet= new()
        {
            Id = 2,
            Nome = "Dança"
        };

        Categoria jazz  = new(3, "Dança");

        List<Postagem> postagens = [
                new() {
                    Id = 1,
                    Nome = "Dança: Movimento, Expressão e Cultura",
                    CategoriaId = 1,
                    Categoria = dança,
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = "Dança em Geral",
                    Texto = "A dança é uma forma de expressão corporal que combina movimento, ritmo e emoção. Presente em praticamente todas as culturas do mundo, ela pode ser uma manifestação artística, uma celebração social, um exercício físico ou até mesmo um ato espiritual.Existem diversos estilos de dança — como ballet, hip hop, samba, jazz, dança contemporânea, forró, entre outros — cada um com suas técnicas, histórias e significados. Além de ser uma arte visualmente rica, dançar também traz benefícios à saúde: melhora o condicionamento físico, a coordenação motora, a postura e contribui para o bem-estar mental e emocional. Mais do que passos coreografados, a dança é uma linguagem universal, capaz de conectar pessoas e contar histórias sem palavras. Seja nos palcos, nas ruas ou nas festas populares, ela é uma celebração do corpo em movimento.",
                    Thumbnail = "/ima/1.png",
                    Foto = "/ima/1.png"
                },
                new() {
                    Id = 2,
                    Nome = "Ballet: Técnica, Elegância e Emoção",
                    CategoriaId = 2,
                    Categoria = ballet,
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = "Dança Clássica",
                    Texto = "O ballet é uma das formas mais clássicas e refinadas da dança, conhecido por sua técnica precisa, movimentos graciosos e forte carga emocional. Surgido nas cortes italianas e francesas entre os séculos XV e XVII, ele evoluiu ao longo do tempo e deu origem a diversos estilos, como o ballet clássico, o neoclássico e o contemporâneo.Caracterizado por passos delicados, giros, saltos e posições rigorosas, o ballet exige disciplina, força, flexibilidade e dedicação dos bailarinos. A formação geralmente começa na infância, com anos de treinamento para alcançar a leveza que vemos nos palcos. Além da técnica, o ballet também é uma forma poderosa de contar histórias — muitas vezes sem palavras — explorando temas que vão do amor e da fantasia até dramas humanos profundos. Espetáculos como O Lago dos Cisnes, O Quebra-Nozes e Giselle são exemplos consagrados da arte do ballet.Mais do que uma dança, o ballet é uma expressão de arte e sensibilidade, que une música, corpo e emoção em perfeita harmonia.",
                    Thumbnail = "/ima/1.png",
                    Foto = "/ima/1.png"
                },
                new() {
                    Id = 3,
                    Nome = "Saiu o chatGPT 5",
                    CategoriaId = 3,
                    Categoria = jazz,
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = "djldksjiflskd",
                    Texto = "akfjndskjhfkjdsh",
                    Thumbnail = "/ima/1.png",
                    Foto = "/ima/1.png"
                },

        ];
        return View(postagens);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
