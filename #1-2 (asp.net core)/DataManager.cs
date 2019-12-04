using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class DataManager:IDataManager
    {
        public int[] GenerateNumber()
        {
            int[] numbers = new int[100];
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                numbers[i] = random.Next(100);
            }
            return numbers;
        }

    }
}
