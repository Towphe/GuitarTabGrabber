using System;
using System.Collections.Generic;
using System.Text;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using System.IO;
using GuitarTabGrabber;

namespace GuitarTabGrabber
{
    static class DocumentFormatter
    {
        public static void Format(List<string> chords)
        {
            {/*
                using (WordprocessingDocument doc = WordprocessingDocument.Create("D://text.docx", DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = doc.AddMainDocumentPart();

                    mainPart.Document = new Document();
                    Body body = mainPart.Document.AppendChild(new Body());

                    foreach (string line in chords)
                    {
                        Paragraph para = body.AppendChild(new Paragraph());
                        Run run = para.AppendChild(new Run());
                        run.AppendChild(new Text(line));
                    }
                    Console.WriteLine("Copying done.");
                }
            */}
            WordprocessingDocument document = WordprocessingDocument.Open("D://text.docx", true);
            Body documentBody = document.MainDocumentPart.Document.Body;

            // Chord Info
            {/*
                Paragraph descPara = documentBody.AppendChild(new Paragraph());
                Run title = descPara.AppendChild(new Run());
                title.AppendChild(new Text(chordinfo.Title));
                Run artist = descPara.AppendChild(new Run());
                artist.AppendChild(new Text(chordinfo.Artist));
                Run author = descPara.AppendChild(new Run());
                author.AppendChild(new Text(chordinfo.Author));
            */}

            foreach(string line in chords)
            {
                Paragraph para = documentBody.AppendChild(new Paragraph());
                Run run = para.AppendChild(new Run());
                run.AppendChild(new Text(line));
            }
            document.Close();
            Console.WriteLine("Copying done.");
        }
    }
}
