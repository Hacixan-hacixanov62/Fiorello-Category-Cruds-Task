using Fiorello_Slider_Blog_Services_task.Data;
using Fiorello_Slider_Blog_Services_task.Models;
using Fiorello_Slider_Blog_Services_task.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_Slider_Blog_Services_task.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
          return await _context.Sliders.ToListAsync();
        }

        public async Task<SliderInfo> GetSliderInfoAsync()
        {
          return await _context.SliderInfo.Where(m=>!m.SoftDeleted).FirstOrDefaultAsync();
        }

    }
}


