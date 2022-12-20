using eETC.Data;
using eETC.Data.Services;
using eETC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace eETC.Controllers
{
    public class StatesController : Controller
    {


        private readonly IStatesService _service;
        public StatesController(IStatesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index(int? page)
        {
            var states = await _service.GetAllAsync(page);
            return View(states);
        }

        //GET : States/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,FactoryName")] State state)
        {
            if (!ModelState.IsValid)
            {
                return View(state);
            }
            await _service.AddAsync(state);
            return RedirectToAction(nameof(Index));
        }

        //GET : States/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var state = await _service.GetByIdAsync(id);
            if (state == null) return View("NotFound");
            return View(state);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,FactoryName")] State state)
        {
         
            if (!ModelState.IsValid)
            {
                return View(state);
            }
            await _service.UpdateAsync(id,state);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var state = await _service.GetByIdAsync(id);
            if (state == null) return View("NotFound");
            return View(state);
        }

        [HttpPost ,ActionName("Delete")]

        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var state = await _service.GetByIdAsync(id);
            if (state == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
