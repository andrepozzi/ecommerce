using Microsoft.AspNetCore.Mvc;

public class ClienteController : Controller
{
    IClienteRepository clienteRepository;

     public ClienteController(IClienteRepository clienteRepository)
    {
        this.clienteRepository = clienteRepository;
    }


    public ActionResult Index()
    {

        return View(clienteRepository.Read());
    }

  [HttpPost]
  public ActionResult Search(IFormCollection form)
    {
        string filtronome = form["filtronome"];
       var lista = clienteRepository.Search(filtronome);
        return View("Index", lista);
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(Cliente model)
    {
        clienteRepository.Create(model);
        return RedirectToAction("Index");
    }

    public ActionResult Details(int id)
    {
        Cliente c = clienteRepository.Read(id);

        if (c != null)
            return View(c);

        return NotFound();
    }

    public ActionResult Delete(int id) {

        clienteRepository.Delete(id);
        return RedirectToAction("Index");
    }

    public ActionResult Update(int id) {
        
        Cliente c = clienteRepository.Read(id);
        if (c != null)
            return View(c);
        return NotFound();
    }

    [HttpPost]
    public ActionResult Update(int id, Cliente model)
    {
        clienteRepository.Update(model);
        return RedirectToAction("Index");
    }

}