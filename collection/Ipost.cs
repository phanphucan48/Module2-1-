using System;
using System.Collections.Generic;
using System.Text;

namespace collection
{
    public interface IPost
    {
        public void Display();
        public void CalculatorRate();

    }
    public class Post :IPost
    {
        private static int autoI = 0;
        private int Id;

        public int Id1 { get => Id; set => Id = value; }
        public string Content1 { get => Content; set => Content = value; }
        public string Author1 { get => Author; set => Author = value; }
        public float AverageRate1 { get => AverageRate; set => AverageRate = value; }
        public string Title1 { get => Title; set => Title = value; }

        private string Title;
        private string Content;
        private string Author;
        private float AverageRate;
        public List<int> Rates = new List<int>();
        public Post()
        {
           Id1 = ++autoI;
        }

        public void Display()
        {
            Console.Write($"id : {Id}\t title: {Title1}\t content: {Content}\t author: {Author}\t averagerate: {AverageRate}\t");
        }

        public void CalculatorRate()
        {
            float total = 0;
            for ( int i = 0; i< Rates.Count; i++)
            {
                total += Rates[i];
            }
            AverageRate1 = total / Rates.Count;
        }
    }
}
