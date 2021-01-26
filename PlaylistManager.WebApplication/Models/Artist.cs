using PlaylistManager.WebApplication.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistManager.WebApplication.Models
{
    public class Artist
    {
        public Artist()
        {
            this.Songs = new HashSet<Song>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.ArtistNameMaxLength)]
        public string Name { get; set; }

        public ICollection<Song> Songs { get; set; }
    }
}
