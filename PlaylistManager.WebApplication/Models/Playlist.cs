using PlaylistManager.WebApplication.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistManager.WebApplication.Models
{
    public class Playlist
    {
        public Playlist()
        {
            this.Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.PlaylistTitleMaxLength)]
        public string Title { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
