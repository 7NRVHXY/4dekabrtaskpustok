using _4dekabrtask.Context;
using Microsoft.AspNetCore.Mvc;

namespace _4dekabrtask.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        PustokDbContext _context { get; }

        public SliderViewComponent(PustokDbContext context)
        {
            _context = context;
        }

        //public async Task<IViewComponentResult> InvokeAsync()
        //{

            //return View(await _context.Sliders.Select(s => new SliderListItemVM
            //{
            //    Id = s.Id,
            //    ImageUrl = s.ImageUrl,
            //    //IsLeft = s.IsLeft,
            //    Title = s.Title,
            //    Text = s.Text,
            //}).ToListAsync());
       // }
    }

    internal class SliderListItemVM
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
