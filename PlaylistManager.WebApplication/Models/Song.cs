using PlaylistManager.WebApplication.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistManager.WebApplication.Models
{ 
    public class Song
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ModelConstraints.SongTitleMaxLength)]
        public string Title { get; set; }

        [MaxLength(ModelConstraints.SongDescriptionMaxLength)]
        public string Description { get; set; }

        [MaxLength(ModelConstraints.SongLyricsMaxLength)]
        public string Lyrics { get; set; }

        [Required]
        public string  Url { get; set; }

        [ForeignKey(nameof(PerformingArtist))]
        public int ArtistId { get; set; }

        public Artist PerformingArtist{ get; set; }
    }
}
