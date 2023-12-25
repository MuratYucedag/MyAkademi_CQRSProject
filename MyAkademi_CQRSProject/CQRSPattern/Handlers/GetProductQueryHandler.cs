using MyAkademi_CQRSProject.CQRSPattern.Results;
using MyAkademi_CQRSProject.DAL.Context;

namespace MyAkademi_CQRSProject.CQRSPattern.Handlers
{
    public class GetProductQueryHandler
    {
        private readonly SaleContext _context;
        public GetProductQueryHandler(SaleContext context)
        {
            _context = context;
        }

        public List<GetProductQueryResult> Handle()
        {
            var values = _context.Products.Select(x => new GetProductQueryResult
            {
                Price = x.Price,
                ProductName = x.ProductName,
                ProductId = x.ProductId,
                Stock = x.Stock,
                CategoryID = x.CategoryID
            }).ToList();
            return values;
        }
    }
}
