using GerenciamentoDeContatosMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace GerenciamentoDeContatosMVC.Controllers
{
    public class ContactController : Controller
    {
        private static ContactRepository contactRepository = new ContactRepository();
        public IActionResult Index()
        {
            var contatos = contactRepository.GetAllContatos();
            return View(contatos);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Contato contato)
        {
            if (ModelState.IsValid)
            {
                contactRepository.AddContato(contato);
                return RedirectToAction("Index");
            }
            return View(contato);
        }

        public IActionResult Delete(int id)
        {
            contactRepository.RemoveContato(id);
            return RedirectToAction("Index");
        }
    }
}
