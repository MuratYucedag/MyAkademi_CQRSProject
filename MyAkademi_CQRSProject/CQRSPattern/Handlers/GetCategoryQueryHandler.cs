using MyAkademi_CQRSProject.CQRSPattern.Results;
using MyAkademi_CQRSProject.DAL.Context;

namespace MyAkademi_CQRSProject.CQRSPattern.Handlers
{
    public class GetCategoryQueryHandler
    {
        private readonly SaleContext _context;
        public GetCategoryQueryHandler(SaleContext context)
        {
            _context = context;
        }
        public List<GetCategoryQueryResult> Handle()
        {
            var values = _context.Categories.Select(x => new GetCategoryQueryResult
            {
                CategoryID = x.CategoryID,
                CategoryName = x.CategoryName
            }).ToList();
            return values;
        }
    }
}
