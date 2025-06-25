using System.Collections.Generic;
using System.Linq;
using ProductListChallenge.Models;

namespace ProductListChallenge.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        void Add(Product product);
    }

    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;
        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
    }
}