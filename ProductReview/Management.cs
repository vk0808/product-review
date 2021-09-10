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

        // uc-4
        public void RetrieveCountOfRecords(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.GroupBy(y => y.ProducID).Select(x => new { ProductID = x.Key, Count = x.Count() });

            Console.WriteLine("\nCount of reviews for each product:");
            Console.WriteLine($"{new string('-', 30)}");
            Console.WriteLine($"| {"ProductID", 13} | {"Count", 10} |");
            Console.WriteLine($"{new string('-', 30)}");
            foreach (var list in recordedData)
            {
                Console.WriteLine($"| {list.ProductID, 13} | {list.Count, 10} |");
            }
            Console.WriteLine($"{new string('-', 30)}");
        }

        // uc-5
        public void RetrieveIDAndReview(List<ProductReview> listProductReview)
        {
            var recordedData = listProductReview.Select(x => new { ProductID = x.ProducID, ProductReview = x.Review });

            Console.WriteLine("\nReviews for each product:");
            Console.WriteLine($"{new string('-', 30)}");
            Console.WriteLine($"| {"ProductID",13} | {"Review",10} |");
            Console.WriteLine($"{new string('-', 30)}");
            foreach (var list in recordedData)
            {
                Console.WriteLine($"| {list.ProductID,13} | {list.ProductReview,10} |");
            }
            Console.WriteLine($"{new string('-', 30)}");
        }
    }
}
