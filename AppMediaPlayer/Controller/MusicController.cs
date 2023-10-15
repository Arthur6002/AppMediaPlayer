using AppMediaPlayer.Model;
using NAudio.Wave;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Net;
using System.Numerics;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppMediaPlayer.Controller
{
    public class MusicController
    {
        public static bool Song_Playing = false;
        static MediaFoundationReader MFR;
        static WasapiOut wo;

        public void Play(string Name, string Artist, string album, string url, string cover)
        {
            if (Song.Playing)
            {
                Console.WriteLine("Debug | Parando musica");
                wo.Stop();
                wo.Dispose();
                Console.WriteLine("Debug | Trocando de musica");
            }


            Console.WriteLine("Debug | Iniciando...");



            Song.Name = Name;
            Song.Artist = Artist;
            Song.Album = album;
            Song.Cover = cover;
            Song.Playing = true;



            wo = new WasapiOut();
            MFR = new MediaFoundationReader(url);

            wo.Init(MFR);
            wo.Play();

            Console.WriteLine($"Tocando {Name}, Album {album}, Artista {Artist}");
        }
        public void Stop()
        {
            if (!Song.Playing)
                return;

            Console.WriteLine("Debug | Parando...");
            wo.Stop();
            Song_Playing = false;
        }

        public void Pause()
        {
            Console.WriteLine("Debug | Pausando...");
            wo.Pause();
        }
        public void Resume()
        {
            Console.WriteLine("Debug | Retomando...");
            wo.Play();


        }
        public void Back()
        {

        }

    }
}
