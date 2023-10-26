using Microsoft.AspNetCore.Mvc;

public class ProdutoController : Controller
{

    IProdutoRepository produtoRepository;

    public ProdutoController(IProdutoRepository produtoRepository)
    {
        this.produtoRepository = produtoRepository;
    }

    // http://locahost:1234/produto/index
    public ActionResult Index()
    {
        // /Views/Produto/Index.cshtml
        return View(produtoRepository.Read());
    }

    

    // http://locahost:1234/produto/create
    [HttpGet]
    public ActionResult Create()
    {
        // /Views/Produto/Create.cshtml
        return View();
    }

    [HttpPost]
    public ActionResult Create(Produto model)
    {

        produtoRepository.Create(model);
        return RedirectToAction("Index");
    }

    //  [HttpPost]
    // public ActionResult Create(IFormCollection form)
    // {
    //     string nome = form["nome"];
    //     string preco = form["preco"];

    //     Produto p = new Produto();
    //     p.Nome = nome;
    //     p.Preco = decimal.Parse(preco);

    //     lista.Add(p);

    //     return RedirectToAction("Index");
    // }

    public ActionResult Details(int id)
    {
        Produto p = produtoRepository.Read(id);

        if(p != null)
            return View(p);

        return NotFound();
    }

    public ActionResult Delete(int id) {

        produtoRepository.Delete(id);
        return RedirectToAction("Index");
    }

    public ActionResult Update(int id) {
        
        Produto p = produtoRepository.Read(id);

        if(p != null)
            return View(p);

        return NotFound();
        
    }

    [HttpPost]
    public ActionResult Update(int id, Produto model)
    {
       
        
        produtoRepository.Update(model);
        return RedirectToAction("Index");
    }
}