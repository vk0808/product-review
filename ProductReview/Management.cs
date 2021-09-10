using System;
using System.Collections.Generic;
using System.Text;

namespace ProductReview
{
    public class Management
    {
        // uc-1
        void DisplayRecords(IEnumerable<ProductReview> recordedData)
        {
            Console.WriteLine($"{new string('-', 70)}");
            Console.WriteLine($"|{"ProductID",15} | {"UserID",10} | {"Rating",10} | {"Review",10} | {"isLike",10} |");
            Console.WriteLine($"{new string('-', 70)}");
            foreach (var list in recordedData)
            {
                Console.WriteLine($"|{list.ProducID,15} | {list.UserID,10} | {list.Rating,10} | {list.Review,10} | {list.isLike,10} |");
            }
            Console.WriteLine($"{new string('-', 70)}\n");
        }
    }
}
