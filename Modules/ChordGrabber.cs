using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Text;

namespace GuitarTabGrabber
{
    // Set this up
    public class ChordInfo
    {
    }
    static class ChordGrabber
    {
        public static List<string> GrabChords(IWebDriver driver)
        {
            List<string> Chords = new List<string>();
            IWebElement ChordDiv = driver.FindElement(By.ClassName("TQL5l"));
            IReadOnlyList<IWebElement> chordsSpans = ChordDiv.FindElements(By.ClassName("_2jIGi"));
            foreach (var n in chordsSpans)
            {
                IReadOnlyList<IWebElement> TempChordLineContainer = n.FindElements(By.ClassName("_3rlxz"));
                foreach (var m in TempChordLineContainer)
                {
                    Chords.Add(m.Text);
                }
            }
            return Chords;
        }
    }
}
