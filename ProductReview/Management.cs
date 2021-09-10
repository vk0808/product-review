using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProductReview
{
    class Management
    {
        // uc-1
        public void DisplayRecords(IEnumerable<ProductReview> recordedData)
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

        // uc-2
        public void TopRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\nTop 3 records: ");
            var recordedData = (from productReviews in listProductReview
                                orderby productReviews.Rating descending
                                select productReviews).Take(3);
            DisplayRecords(recordedData);
        }

        // uc-3
        public void SelectedRecords(List<ProductReview> listProductReview)
        {
            Console.WriteLine("\nRecords with rating > 3 and productId 1/4/9: ");
            var recordedData = from productReviews in listProductReview
                               where (productReviews.ProducID == 1 || productReviews.ProducID == 4 || productReviews.ProducID == 9)
                               && productReviews.Rating > 3
                               select productReviews;
            DisplayRecords(recordedData);
        }
    }
}
