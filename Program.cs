using Series.Controller;
using System;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            var lController = new SerieController();
            Utility.programRunner(lController);
        }
    }
}
