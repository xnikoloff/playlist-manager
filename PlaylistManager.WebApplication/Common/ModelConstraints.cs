using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlaylistManager.WebApplication.Common
{
    public static class ModelConstraints
    {
        //Song
        public const int SongTitleMaxLength = 100;
        public const int SongDescriptionMaxLength = 800;
        public const int SongLyricsMaxLength = 20000;

        //Artist
        public const int ArtistNameMaxLength = 100;

        //Playlist
        public const int PlaylistTitleMaxLength = 50;
    }
}
