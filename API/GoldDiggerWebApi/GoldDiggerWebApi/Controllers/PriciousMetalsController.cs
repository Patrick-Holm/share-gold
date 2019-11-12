using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GoldDiggerWebApi.Models;

namespace GoldDiggerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriciousMetalsController : ControllerBase
    {
        private readonly GoldDiggerDbContext _context;

        public PriciousMetalsController(GoldDiggerDbContext context)
        {
            _context = context;
        }

        // GET: api/PriciousMetals
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PriciousMetals>>> GetPriciousMetals()
        {
            return await _context.PriciousMetals.ToListAsync();
        }
        
        [HttpGet("web")]
        public async Task<ActionResult<string>> GetPriciousMetalsAsHTML()
        {
           

            var MetalData = await _context.PriciousMetals.ToListAsync();       
  


            string myHTML = $"<html><body><form><h2>Metal</h2>";
            myHTML += String.Format(" <table> <tr> <th> Metal </th>  <th> Price in DKK </th>  <th> Price in USD </th>  </tr>");
            foreach(var countryItem in MetalData)
            {
                myHTML += String.Format("<tr>");
                myHTML += String.Format($"<td> {countryItem.Name}</td>");
                myHTML += String.Format($"<td>{countryItem.PriceInDKK} </td>");
                myHTML += String.Format($"<td> {countryItem.PriceInUSD} </ td >");
                //myHTML += String.Format("<td style = text-align:right > @row.Price </td>");
                myHTML += String.Format("</tr>");
           
                //myHTML += String.Format($"<td>{countryItem.Name}</td><td></td><td></td>");

               
                
            }
            myHTML += String.Format("</table>");
            return base.Content(myHTML, "text/html");
        }
        // GET: api/PriciousMetals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PriciousMetals>> GetPriciousMetals(int id)
        {
            var priciousMetals = await _context.PriciousMetals.FindAsync(id);

            if (priciousMetals == null)
            {
                return NotFound();
            }

            return priciousMetals;
        }

        // PUT: api/PriciousMetals/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPriciousMetals(int id, PriciousMetals priciousMetals)
        {
            if (id != priciousMetals.Id)
            {
                return BadRequest();
            }

            _context.Entry(priciousMetals).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriciousMetalsExists(id))
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

        // POST: api/PriciousMetals
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<PriciousMetals>> PostPriciousMetals(PriciousMetals priciousMetals)
        {
            _context.PriciousMetals.Add(priciousMetals);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPriciousMetals", new { id = priciousMetals.Id }, priciousMetals);
        }

        // DELETE: api/PriciousMetals/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PriciousMetals>> DeletePriciousMetals(int id)
        {
            var priciousMetals = await _context.PriciousMetals.FindAsync(id);
            if (priciousMetals == null)
            {
                return NotFound();
            }

            _context.PriciousMetals.Remove(priciousMetals);
            await _context.SaveChangesAsync();

            return priciousMetals;
        }

        private bool PriciousMetalsExists(int id)
        {
            return _context.PriciousMetals.Any(e => e.Id == id);
        }
    }
}
