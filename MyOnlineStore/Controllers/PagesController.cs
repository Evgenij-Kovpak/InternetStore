using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyOnlineStore.Infrastructure;
using MyOnlineStore.Models;
using System.Linq;
using System.Threading.Tasks;

namespace MyOnlineStore.Controllers
{
    public class PagesController : Controller
    {
        private readonly MyOnlineStoreContext context;

        public PagesController(MyOnlineStoreContext context)
        {
            this.context = context;
        }

        //GET/or/slug
        public async Task<IActionResult> Page(string slug)
        {
            if(slug == null)
            {
                return View(await context.Pages.Where(x => x.Slug == "home").FirstOrDefaultAsync());
            }
            Page page = await context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if(page == null)
            {
                return NotFound();
            }

            return View(page);
        }
    }
}
