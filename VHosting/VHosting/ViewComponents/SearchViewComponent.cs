using Microsoft.AspNetCore.Mvc;

namespace VHosting.ViewComponents
{
    [ViewComponent(Name = "Search")]
    public class SearchViewComponent : ViewComponent
    {
        private readonly DBVideoHostingContext _context;

        public SearchViewComponent(DBVideoHostingContext applicationDbContext)
        {
            _context = applicationDbContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var list = new List<object>();

            foreach (var user in _context.Users)
            {
                list.Add(user);
            }

            foreach (var video in _context.Videos)
            {
                list.Add(video);
            }

            return View("Index", list);
        }
    }
}
