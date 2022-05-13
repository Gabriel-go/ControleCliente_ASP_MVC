using Microsoft.AspNetCore.Mvc;
using ControleCliente_ASP_MVC.Models;
using ControleCliente_ASP_MVC.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;

namespace ControleCliente_ASP_MVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly Contexto _context;

        public ContatoController(Contexto context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Contato> contatoList  = _context.Contato.ToList();
            return View(contatoList);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _context.Contato.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var contato =  _context.Contato.FirstOrDefault<Contato>(m => m.Id == id);
            if (contato == null)
            {
                return NotFound();
            }

            return View(contato);
        }
        
        [HttpPost]        
        public async Task<IActionResult> Criar( Contato contato)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contato);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(contato);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(int id, Contato contato)
        {
            if (id != contato.Id)
            {
                return NotFound();
            }
            try
            {
                _context.Update(contato);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;                    
            }
            return RedirectToAction(nameof(Index));
            
            //return View(contato);
        }

        [HttpPost]
        public async Task<IActionResult> Deletar(int id)
        {
            var contato = await _context.Contato.FindAsync(id);
            _context.Contato.Remove(contato);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
