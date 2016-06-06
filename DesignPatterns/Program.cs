using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Number;
using OptionNoLambda;
using MusicLibrary;
using System.Threading;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //NumberVisitor n_visitor = new NumberVisitor();
            //Number n = new MyInt();
            //n.Visit(n_visitor);

            //MusicLibraryVisitor music_library_visitor = new MusicLibraryVisitor();
            //List<Song> songs = new List<Song>();
            //songs.Add(new HeavyMetal("Hallowed Be Thy Name"));
            //songs.Add(new Jazz("Autumn Leaves"));
            //songs.Add(new HeavyMetal("War Pigs"));
            //foreach (var song in songs) { song.Visit(music_library_visitor); }
            //Console.WriteLine("Amount of heavy metal music: " + music_library_visitor.heavyMetal.Count);
            //Console.WriteLine("Amount of jazz music: " + music_library_visitor.jazz.Count);

            //OPTION VISITOR version 1
            //IOptionVisitor<int, int> opt_visitor = new LambdaIOptionVisitor<int, int>(i => i + 1, () => { throw new Exception("Expecting a value..."); });
            //Option<int> opt = new Some<int>(5);
            //int res = opt.Visit(opt_visitor);
            //Console.WriteLine(res);

            //OPTION VISITOR version 2
            //Option<int> number = new Some<int>(5);
            //int inc_number = number.Visit(() => { throw new Exception("Expecting a value..."); }, i => i + 1);
            //Console.WriteLine(inc_number);
            //number = new None<int>();
            //inc_number = number.Visit(() => { throw new Exception("Expecting a value..."); }, i => i + 1);
            //Console.WriteLine(inc_number);

        }
    }

   
}