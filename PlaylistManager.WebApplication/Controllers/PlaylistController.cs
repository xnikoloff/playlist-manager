using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistManager.WebApplication.Controllers
{
    public class PlaylistController : Controller
    {
        public IActionResult AllPlaylists()
        {
            return this.View();
        }

        public IActionResult CreatePlaylist(int id)
        {

            return this.View();
        }
    }
}
