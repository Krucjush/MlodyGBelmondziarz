using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MlodyGBelmondziak.Data;
using MlodyGBelmondziak.Models;

namespace MlodyGBelmondziak.Pages
{
	public class IndexModel : PageModel
	{
		private readonly AppDbContext _context;

		public IndexModel(AppDbContext context)
		{
			_context = context;
		}

		public List<Sound> Sounds { get; set; }

		public async Task OnGetAsync()
		{
			Sounds = await _context.Sounds.ToListAsync();
		}
	}
}