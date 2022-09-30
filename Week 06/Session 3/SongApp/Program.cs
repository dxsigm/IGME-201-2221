using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SongLib;

namespace SongApp
{
    internal class Program
    {
        struct SongStruct
        {
            public string name;   
        }

        static void Main(string[] args)
        {
            // class and interface variables are reference variables which act like pointers
            Song song;
            ISong iSong;
            Object myObject;

            // structures can be created without the new operator
            // and they are value variables
            SongStruct mySongStruct;
            mySongStruct.name = "Happy";

            SongStruct anotherSongStruct;
            anotherSongStruct = mySongStruct;

            // I now have 2 SongStruct variables which are independent of each other

            // when creating class objects, we only have as many objects as we have "new" commands
            TapeSong tapeSong = new TapeSong();

            // we have 1 TapeSong object
            tapeSong.artist = "Pharrel Williams";
            tapeSong.Name = "Happy";
            tapeSong.counter = 54;
            tapeSong.side = 1;
            tapeSong.Play();

            // we can use any parent of TapeSong as a handle for it
            // so we can use a Song variable to point to it
            song = tapeSong;

            // we still only have 1 TapeSong object
            // tapeSong and song are pointing to the same object

            // we can use the Song pointer to access any fields, properties or methods defined by the Song class
            // note that we cannot access any fields or methods that are specific to the TapeSong class
            // however calling any overriden methods, WILL call the overriden implementation in the child class
            song.Play();

            song.nRating = 1;
            

            // create a TapeSong reference variable
            TapeSong tapeSongPtr;

            // point it at tapeSong
            // now we have 3 variables pointing at the same TapeSone object: tapeSong, song and tapeSongPtr
            tapeSongPtr = tapeSong;

            // because tapeSong inherits from the ISong interface
            // we can set the iSong variable to point to tapeSong and use it to access anything defined in the interface
            iSong = tapeSong;

            // we can use iSong to call the Play() method
            iSong.Play();

            // now we have 4 variables pointing at the same TapeSone object: tapeSong, song, tapeSongPtr and iSong

            // create another TapeSong object
            TapeSong copyTapeSong = new TapeSong();

            // if we set this variable to tapeSong, then we orphan the object we created at line #76
            // and have no way to access it again
            copyTapeSong = tapeSong;

            // now we have 5 variables pointing at the same TapeSone object: tapeSong, song, tapeSongPtr, iSong, and copyTapeSong
            copyTapeSong.artist = "Will.I.Am";

            // the Object class is the great-great-great-great-grandparent of every data type in C#
            // and we can use Object variables to point at any variable
            myObject = tapeSong;

            // so we can create a list of objects
            List<Object> objectList = new List<object>();
            // and add any data type to our list
            objectList.Add(tapeSong);
            objectList.Add("David");
            objectList.Add(2);
            
            // so how do we make a copy of a class object if we can't just use a = b like we can with structures or ints or strings, etc?
            // stay tuned!
        }
    }
}
