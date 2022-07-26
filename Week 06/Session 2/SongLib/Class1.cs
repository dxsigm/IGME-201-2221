﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongLib
{
// the inheritances from the yuml file
//[+A:Song]<-.-[+TapeSong]
//[+A:Song]<-.-[+VinylSong]
//[+A:Song]<-.-[+CDSong]
//[+A:Song]<-.-[+MP3Song]
//
//[+ISong]^[+A:Song]
//[+IPlay]^[+A:Song]
//
//[+IPlay]^[+Game]

    public class Artist : ICloneable
    {
        public string homeTown;
        public DateTime dateofbirth;
        public List<string> albumTitles = new List<string>();

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public Object DeepCopy()
        {
            Artist copyArtist = (Artist)this.MemberwiseClone();

            // albumTitles is a reference variable, so we need to copy the list of strings into copyArtist.albumTitles
            // GetRange() returns a new copy of the list
            copyArtist.albumTitles = this.albumTitles.GetRange(0, this.albumTitles.Count);

            return copyArtist;
        }

    }

    //[+A:Song|+year:int;+lyrics:string;+composer:string;+artist:string|+Name:string;+Play():a;+Copy():v;+Dance();+Sing()]
    public abstract class Song : ISong, IPlay, ICloneable
    {
        public int year;
        public string lyrics;
        public string composer;
        public string artist;
        public int nRating;

        Artist artistDetails = new Artist();

        public string Name
        {
            get;
            set;
        }

        public abstract void Play();

        public virtual void Copy()
        {
            // default code to copy a song
        }

        public void Dance()
        {
            // bust out my moves
        }

        public void Sing()
        {
            // la la la
        }

        public Object Clone()
        {
            // make a shallow copy
            // this calls the new command to create a new object, and it copies all of the value data types from the first level of the class
            return this.MemberwiseClone();
        }

        // this does deep copy
        public Song DeepCopySongObject()
        {
            // this calls the new command to create a new object, and it copies all of the value data types from the first level of the class
            Song newObject = (Song)this.MemberwiseClone();

            // we can implement a DeepCopy() method in each child class
            newObject.artistDetails = (Artist)this.artistDetails.DeepCopy();

            // or do a shallow copy 
            //newObject.artistDetails = (Artist)this.artistDetails.Clone();
            
            // or manually copy the contained class object
            //newObject.artistDetails = new Artist();
            //newObject.artistDetails.dateofbirth = this.artistDetails.dateofbirth;
            //newObject.artistDetails.homeTown = this.artistDetails.homeTown;

            return newObject;
        }

    }


    //[+TapeSong|+tapeName:string;+side:int;+counter:int|+Play():o]
    public class TapeSong : Song
    {
        public string tapeName;
        public int side;
        public int counter;

        public override void Play()
        {
            // load the tape on the correct side
            // fast forward to the counter
            // press the play button
        }

    }

    //[+VinylSong|+recordName:string;+side:int;+track:int|+Play():o]
    public class VinylSong : Song
    {
        public string recordName;
        public int side;
        public int track;
        public override void Play()
        {
            // turn on the turntable
            // put the record on the correct side
            // drop the needle on the correct track
        }
    }

    //[+CDSong|+cdName:string;+track:int|+Play():o]
    public class CDSong : Song
    {
        public string cdName;
        public int track;
        public override void Play()
        {
            // insert cd
            // forward to the track
            // press the play button
        }
    }

    //[+MP3Song|+fileName:string|+Play():o;+Copy():o]
    public class MP3Song : Song
    {
        public string fileName;
        public override void Play()
        {
            // double click the filename
        }

        public override void Copy()
        {
            // base.Copy(); execute parent's copy method first (optional)
            // if you don't call base.Copy(), then you are totally overriding the Copy() method

            // copy and paste the mp3 file

        }

    }

    //[+Game|+players:int|+Name:string;+Play()]
    public class Game : IPlay
    {
        public int players;

        public string Name
        {
            get;
            set;
        }

        public void Play()
        {
            // how to play the game
        }
    }

    //[+ISong|Name:string;Play();Sing();Dance();Copy()]
    public interface ISong
    {
        string Name
        {
            get;
            set;
        }

        void Play();
        void Sing();
        void Dance();
        void Copy();
    }

    //[+IPlay|Name:string;Play()]
    public interface IPlay
    {
        string Name
        {
            get;
            set;
        }

        void Play();
    }
}
