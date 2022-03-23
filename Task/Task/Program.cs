using System;
using Task.Models;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Word word = new Word();
            PDF pdf = new PDF();
            Excel excel = new Excel();
            MainPrintFile<Word> main = new MainPrintFile<Word>(word);
            MainPrintFile<PDF> main1 = new MainPrintFile<PDF>(pdf);
            MainPrintFile<Excel> main2 = new MainPrintFile<Excel>(excel);
        }
    }
}
