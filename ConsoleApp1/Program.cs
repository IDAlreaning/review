using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            TempRecord tempRecord = new TempRecord();
            // 使用Indexer，取用物件的陣列裡的內容
            tempRecord[3] = 15.3F;
            tempRecord[5] = 19.1F;

            // 印出物件內陣列的所有內容
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Element #{0} = {1}", i, tempRecord[i]);
            }

            Console.WriteLine(tempRecord.Length);

        }
    }
    class TempRecord
    {
        //建立一個float的陣列(欄位)
        private float[] temps = new float[10] { 24.1F, 18.3F, 17.5F, 4.2F, -4.0F, 19.2F, 15.5F, 21.5F, 26.5F, 28.2F };

        // To enable client code to validate input 
        // when accessing your indexer.
        public int Length
        {
            get { return temps.Length; }
        }
        // 宣告 Indexer 
        //使用this和中括號來宣告
        //輸入索引值(int)，會回傳陣列索引值裡的內容(float)
        public float this[int index]
        {
            get
            {
                return temps[index];
            }

            set
            {
                temps[index] = value;
            }
        }
    }
}
