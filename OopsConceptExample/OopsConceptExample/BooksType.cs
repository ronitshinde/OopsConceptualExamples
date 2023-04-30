using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConceptExample
{
    public class BooksType
    {
        private string novel;
        private int rating;
        public string Novel
        {
            get { return novel; }
            set { novel = value; }
        }
        public string Comics
        {
            get; set;
        }
        public int Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public void NovelMethod()
        {
            Console.WriteLine("Novel name : " + novel);
            Console.WriteLine("Comics name : " + Comics);
            Console.WriteLine($"Rating for comics {Comics} is : " + Rating);
        }
    }
}
