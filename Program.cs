using System;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using GuitarTabGrabber;


// add exceptions and error finders
// make object oriented
namespace GuitarTabGrabber
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = PageGrabber.InitiateConnectionChrome();
            
            Console.WriteLine("Enter URL here: ");
            string url = Console.ReadLine();
            PageGrabber.ConnectUrl(driver, url);

            List<string> chords = ChordGrabber.GrabChords(driver);
            //ChordInfo chordInfo = new ChordInfo(driver);

            if (chords.Count > 0)
            {
                Console.WriteLine($"Data found.\nNumber of lines: {chords.Count}");
                //Console.WriteLine($"Title: {chordInfo.Title}\nArtist: {chordInfo.Artist}\nAuthor: {chordInfo.Author}");
                //DocumentFormatter.Format(chordInfo, chords);
            }
            else
            {
                Console.WriteLine("Not found");
            }
            driver.Quit();
        }
    }
}
