using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_14.Task2
{
    static class GetClass
    {
        public static object GetSongData(Song song)
        {
            var resSong = new { name = song.SongName, time = song.SongTime, 
                                author = song.SongAuthor, year = song.SongYear };
            return resSong;
        }
    }
}
