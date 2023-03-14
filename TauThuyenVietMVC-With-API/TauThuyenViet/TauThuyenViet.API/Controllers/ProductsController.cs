using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TauThuyenViet.Models;

namespace TauThuyenViet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DBContext _context;

        public ProductsController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);

                if (product == null)
                {
                    return NotFound();
                }

                return product;
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        // PUT: api/Products/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProductID)
            {
                return BadRequest();
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    return BadRequest();
                }
            }

            return Ok();
        }

        // POST: api/Products
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Products.Add(product);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return NoContent();
            }

            return CreatedAtAction("GetProduct", new { id = product.ProductID }, product);
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    return NotFound();
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                return NotFound();
            }

            return NoContent();
        }


        [HttpGet("related/{catID}/{ID}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetByCateID(int catID, int ID)
        {
            try
            {
                var query = _context.Products.Where(x => x.Status == true).
                                    OrderBy(x => Guid.NewGuid()).AsQueryable();


                if (ID > 0)
                {
                    query = query.Where(x => x.ProductID != ID);
                }

                if (catID > 0)

                {
                    query = query.Where(x => x.ProductCategoryID == catID);
                }

                var data = await query.Take(9).ToListAsync();

                return Ok(data);
            }
            catch (Exception)
            {

                return NotFound();
            }
        }

        // GET: api/Products
        [HttpGet("getlist/{mid}/{cid}")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts(int? mid, int? cid)
        {
            try
            {
                var data = _context.Products
                             .Where(x => x.Status == true)
                             .OrderByDescending(x => x.CreateTime)
                             .AsQueryable();

                //Thêm điều kiện cho truy vấn
                if (mid > 0)
                    data = data.Where(x => x.ProductCategory.ProductMainCategoryID == mid);

                //Thêm điều kiện cho truy vấn
                if (cid > 0)
                    data = data.Where(x => x.ProductCategoryID == cid);

                var result = await data.ToListAsync();

                return result;
            }
            catch (Exception)
            {
                return NotFound();
            }
        }

        private bool ProductExists(int id)
        {
            try
            {
                return _context.Products.Any(e => e.ProductID == id);
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
