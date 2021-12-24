using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MedicineStockApi.Models;

namespace MedicineStockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineStockInformationController : ControllerBase
    {
        private readonly StockContext _context;

        public MedicineStockInformationController(StockContext context)
        {
            _context = context;
        }

        // GET: api/Stocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks()
        {
            return await _context.Stocks.ToListAsync();
        }





        //// GET: api/Stocks/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Stock>> GetStock(string id)
        //{
        //    var stock = await _context.Stocks.FindAsync(id);

        //    if (stock == null)
        //    {
        //        return NotFound();
        //    }

        //    return stock;
        //}

        //// PUT: api/Stocks/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStock(string id, Stock stock)
        //{
        //    if (id != stock.name)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(stock).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StockExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Stocks
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Stock>> PostStock(Stock stock)
        //{
        //    _context.Stocks.Add(stock);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (StockExists(stock.name))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetStock", new { id = stock.name }, stock);
        //}

        //// DELETE: api/Stocks/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStock(string id)
        //{
        //    var stock = await _context.Stocks.FindAsync(id);
        //    if (stock == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Stocks.Remove(stock);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool StockExists(string id)
        //{
        //    return _context.Stocks.Any(e => e.name == id);
        //}
    }
}
