using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture_14.Task2
{
    class Song
    {
        public string SongName { get; set; }
        public double SongTime { get; set; }
        public string SongAuthor { get; set; }
        public int SongYear { get; set; }
        public Song()
        {
        }
        public Song(string name, double time, string author, int year)
        {
            SongName = name;
            SongTime = time;
            SongAuthor = author;
            SongYear = year;
        }
    }
}
