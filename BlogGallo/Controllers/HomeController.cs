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
            new() { Id = 4, Nome = "Hip Hop"},
            new() { Id = 5, Nome = "Samba"},
            new() { Id = 6, Nome = "Funk"},
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
            new() {
                Id = 4,
                Nome = "Hip Hop: Ritmo e Movimento nas Ruas",
                CategoriaId = 4,
                Categoria = categorias.Find(c => c.Id == 4),
                DataPostagem = DateTime.Parse("24/08/2025"),
                Descricao = ".",
                Texto = "O hip hop é mais do que um estilo de dança; é uma cultura que se originou nas ruas e se espalhou pelo mundo. Com raízes na música rap e na dança de rua, o hip hop é conhecido por seus movimentos enérgicos e expressivos. Os dançarinos de hip hop muitas vezes incorporam elementos de improvisação e estilo pessoal em suas performances, tornando cada apresentação única. O hip hop também é uma forma de autoexpressão e resistência, abordando questões sociais e culturais por meio da dança. Se você está procurando uma dança que combine ritmo, criatividade e atitude, o hip hop é a escolha perfeita!",
                Thumbnail = "/img/hiphop.jpg",
                Foto = "/img/hiphop.jpg"
            },
            new() {
                Id = 5,
                Nome = "Samba: Alegria e Movimento do Brasil",
                CategoriaId = 5,
                Categoria = categorias.Find(c => c.Id == 5),
                DataPostagem = DateTime.Parse("24/08/2025"),
                Descricao = ".",
                Texto = "O samba é uma dança que exala alegria e celebra a cultura brasileira. Com suas raízes na música afro-brasileira, o samba é conhecido por seus ritmos contagiantes e movimentos fluidos. Os dançarinos de samba muitas vezes se apresentam em grupos, criando uma atmosfera festiva e vibrante. O samba é uma dança que convida à improvisação e à expressão pessoal, permitindo que cada dançarino traga seu próprio estilo para a performance. Se você quer aprender uma dança que capture a essência do Brasil, o samba é a escolha ideal!",
                Thumbnail = "/img/samba.jpg",
                Foto = "/img/samba.jpg"
            },
            new() {
                Id = 6,
                Nome = "Funk: Movimento e Estilo nas Pistas",
                CategoriaId = 6,
                Categoria = categorias.Find(c => c.Id == 6),
                DataPostagem = DateTime.Parse("24/08/2025"),
                Descricao = ".",
                Texto = "O funk é um estilo de dança que surgiu nas comunidades urbanas e rapidamente ganhou popularidade em todo o mundo. Com seus ritmos contagiantes e movimentos ousados, o funk é uma dança que celebra a individualidade e a autoexpressão. Os dançarinos de funk muitas vezes incorporam elementos de dança de rua, hip hop e até mesmo dança contemporânea em suas performances. Se você está procurando uma dança que seja divertida, enérgica e cheia de estilo, o funk é a escolha perfeita!",
                Thumbnail = "/img/funk.jpg",
                Foto = "/img/funk.jpg"
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
        ViewData["Categorias"] = categorias;
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
