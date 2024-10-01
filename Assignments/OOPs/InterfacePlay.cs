using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments.OOPs
{
    public interface IPlayable
    {
        public void Play();
    }
    public class derivedClass : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing....");
        }
    }
    public class VideoPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing video....");
        }
    }
    public class MusicPlayer : IPlayable
    {
        public void Play()
        {
            Console.WriteLine("Playing music....");
        }
    }
    internal class InterfacePlay
    {
        public static void Main(string[] args)
        {
            derivedClass d = new derivedClass();
            d.Play();
            VideoPlayer v = new VideoPlayer();
            v.Play();
            MusicPlayer m = new MusicPlayer();
            m.Play();
        }
    }
}
