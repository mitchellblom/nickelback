using System;
using System.Collections.Generic;

namespace nickelback
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<(string, string)> goodSongs = new List<(string, string)>();

            HashSet<(string, string)> songs = new HashSet<(string, string)>();
            songs.Add(("Photograph", "Nickelback"));
            songs.Add(("Far Away", "Nickelback"));
            songs.Add(("Savin Me", "Nickelback"));
            songs.Add(("Blood in the Sand", "Thrice"));
            songs.Add(("Stranger than Earth", "Purity Ring"));
            songs.Add(("Hit Parade", "Mutemath"));
            songs.Add(("Disappear", "Code Machine"));

            foreach ((string, string) song in songs) {
                if (song.Item2 != "Nickelback") {
                    goodSongs.Add(song);
                }
            }

            foreach ((string, string) song in goodSongs) {
                Console.WriteLine($"{song.Item1} by {song.Item2}");
            }

        }
    }
}