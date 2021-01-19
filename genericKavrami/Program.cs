using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematik<int> mat1 = new Matematik<int>();
            mat1.s2 = 45;
            mat1.s3 = 50;
            Console.WriteLine(mat1.s2 + mat1.s3);

            Matematik<string> mat2 = new Matematik<string>();
            mat2.s2 = "abc";
            mat2.s3 = "def";
            Console.WriteLine(mat2.s2 + mat2.s3);

            Fizik<int, string> nesne = new Fizik<int, string>();
            nesne.s1 = 12;
            nesne.s2 = "selam";
        }
    }
    class Matematik<T>
    {
        public int s1 { get; set; }
        public T s2 { get; set; }
        public T s3 { get; set; }
    }
    class Fizik<T,Y>
    {
        public T s1 { get; set; }
        public Y s2 { get; set; }
    }
}
