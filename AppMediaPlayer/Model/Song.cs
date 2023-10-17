using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMediaPlayer.Model
{
    public class Song
    {
        public static bool Playing = false;
        public static string Name { get; set; }
        public static string Artist { get; set; }
        public static string Album { get; set; }
        public static string Cover { get; set; }
    }
}
