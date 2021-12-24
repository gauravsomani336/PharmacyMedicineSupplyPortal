using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineStockApi.Models;
using Medicine_stock.Model;

namespace Medicine_stock.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStocksController : ControllerBase
    {
        private readonly StockContext _context;

        public MedicineStocksController(StockContext context)
        {
            _context = context;
        }

        // GET: api/MedicineStocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedicineStock>>> GetStocks()
        {
            return await _context.Stocks.ToListAsync();
        }

       /* // GET: api/MedicineStocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedicineStock>> GetMedicineStock(string id)
        {
            var medicineStock = await _context.Stocks.FindAsync(id);

            if (medicineStock == null)
            {
                return NotFound();
            }

            return medicineStock;
        }*/

       /* // PUT: api/MedicineStocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedicineStock(string id, MedicineStock medicineStock)
        {
            if (id != medicineStock.Name)
            {
                return BadRequest();
            }

            _context.Entry(medicineStock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedicineStockExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MedicineStocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MedicineStock>> PostMedicineStock(MedicineStock medicineStock)
        {
            _context.Stocks.Add(medicineStock);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (MedicineStockExists(medicineStock.Name))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetMedicineStock", new { id = medicineStock.Name }, medicineStock);
        }

        // DELETE: api/MedicineStocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedicineStock(string id)
        {
            var medicineStock = await _context.Stocks.FindAsync(id);
            if (medicineStock == null)
            {
                return NotFound();
            }

            _context.Stocks.Remove(medicineStock);
            await _context.SaveChangesAsync();

            return NoContent();
        }*/

        private bool MedicineStockExists(string id)
        {
            return _context.Stocks.Any(e => e.Name == id);
        }
    }
}
