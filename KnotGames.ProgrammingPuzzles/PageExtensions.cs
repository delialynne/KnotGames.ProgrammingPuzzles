using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KnotGames.ProgrammingPuzzles.Pages
{
    public static class PageExtensions
    {
        public static string GetPlayerName(this PageModel pageModel) =>
            pageModel.HttpContext.Session.GetString("Name");

        public static void SetPlayerName(this PageModel pageModel, string name)
        {
            pageModel.HttpContext.Session.SetString("Name", name ?? "");
            pageModel.HttpContext.Session.CommitAsync().Wait();
        }
    }
}
