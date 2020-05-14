using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KnotGames.ProgrammingPuzzles.Pages
{
    public class OptionPage2Model : PageModel
    {
        [BindProperty]
        public bool UnicornMode { get; set; }

        public void OnGet()
        {
            UnicornMode = this.GetUnicornMode();
        }

        public ActionResult OnPost()
        {
            this.SetUnicornMode(UnicornMode);
            return RedirectToPage("StartMenu");
        }
    }
}