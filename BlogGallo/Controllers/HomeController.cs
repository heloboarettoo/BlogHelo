using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BlogGallo.Models;

namespace BlogGallo.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private List<Categoria> categorias;
    private List<Postagem> postagens;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
           categorias = [
            new() { Id = 1, Nome = "Dança"},
            new() { Id = 2, Nome = "Ballet"},
            new() { Id = 3, Nome = "Jazz"},
        ];
        postagens = [
                new() {
                    Id = 1,
                    Nome = "Dança: Movimento, Expressão e Cultura",
                    CategoriaId = 1,
                     Categoria = categorias.Find(c => c.Id == 1),
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = "Dança em Geral",
                    Texto = "A dança é uma forma de expressão corporal que combina movimento, ritmo e emoção. Presente em praticamente todas as culturas do mundo, ela pode ser uma manifestação artística, uma celebração social, um exercício físico ou até mesmo um ato espiritual.Existem diversos estilos de dança — como ballet, hip hop, samba, jazz, dança contemporânea, forró, entre outros — cada um com suas técnicas, histórias e significados. Além de ser uma arte visualmente rica, dançar também traz benefícios à saúde: melhora o condicionamento físico, a coordenação motora, a postura e contribui para o bem-estar mental e emocional. Mais do que passos coreografados, a dança é uma linguagem universal, capaz de conectar pessoas e contar histórias sem palavras. Seja nos palcos, nas ruas ou nas festas populares, ela é uma celebração do corpo em movimento.",
                    Thumbnail = "/img/tango.jpg",
                    Foto = "/img/tango.jpg"
                },
                
                new() {
                    Id = 2,
                    Nome = "Ballet: Técnica, Elegância e Emoção",
                    CategoriaId = 2,
                    Categoria = categorias.Find(c => c.Id == 2),
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = "Dança Clássica",
                    Texto = "O ballet é uma das formas mais clássicas e refinadas da dança, conhecido por sua técnica precisa, movimentos graciosos e forte carga emocional. Surgido nas cortes italianas e francesas entre os séculos XV e XVII, ele evoluiu ao longo do tempo e deu origem a diversos estilos, como o ballet clássico, o neoclássico e o contemporâneo.Caracterizado por passos delicados, giros, saltos e posições rigorosas, o ballet exige disciplina, força, flexibilidade e dedicação dos bailarinos. A formação geralmente começa na infância, com anos de treinamento para alcançar a leveza que vemos nos palcos. Além da técnica, o ballet também é uma forma poderosa de contar histórias — muitas vezes sem palavras — explorando temas que vão do amor e da fantasia até dramas humanos profundos. Espetáculos como O Lago dos Cisnes, O Quebra-Nozes e Giselle são exemplos consagrados da arte do ballet.Mais do que uma dança, o ballet é uma expressão de arte e sensibilidade, que une música, corpo e emoção em perfeita harmonia.",
                     Thumbnail = "/img/ballet.jpg",
                    Foto = "/img/ballet.jpg"
                },

                new() {
                    Id = 3,
                    Nome = "Jazz: Energia, Emoção e Movimento em Cada Passo",
                    CategoriaId = 3,
                     Categoria = categorias.Find(c => c.Id == 3),
                    DataPostagem = DateTime.Parse("13/08/2025"),
                    Descricao = ".",
                    Texto = "A dança jazz é um estilo cheio de energia, expressão e movimento! Com raízes nos Estados Unidos, ela surgiu no início do século XX, influenciada pelos ritmos africanos e pela música jazz, que dava o tom animado das performances. Com o tempo, o jazz foi se transformando e incorporando elementos de outros estilos, como o ballet clássico, o hip hop e a dança contemporânea. O resultado? Uma dança versátil, vibrante e super cênica, que você encontra desde palcos da Broadway até academias e videoclipes. O jazz se destaca pelos movimentos rápidos, saltos, giros e muita presença de palco. Mais do que técnica, ele valoriza a musicalidade, a expressividade e a conexão com o público. É uma dança que convida o corpo inteiro a se movimentar com intensidade — e o coração também!",
                    Thumbnail = "/img/jazz.jpg",
                    Foto = "/img/jazz.jpg"
                },

        ];
    }

    public IActionResult Index()
    { 
        return View(postagens);
    }
    
    public IActionResult Postagem(int id)
    {
        var postagem = postagens 
            .Where(p => p.Id == id)
            .SingleOrDefault();
        if (postagem == null)
            return NotFound();
        return View(postagem);
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
