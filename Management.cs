using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {


        public static List<ProductReviews> AddProductsReview()
        {
            List<ProductReviews> list = new List<ProductReviews>()
            {
                new ProductReviews(){ ProductID=1,UserID=34,Review="Good",IsLike=true,Rating=4.5 },
                new ProductReviews(){ ProductID=4,UserID=23,Review="Bad",IsLike=false,Rating=1.5 },
                new ProductReviews(){ ProductID=5,UserID=39,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReviews(){ ProductID=8,UserID=57,Review="Average",IsLike=true,Rating=3.5 },
                new ProductReviews(){ ProductID=1,UserID=78,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReviews(){ ProductID=7,UserID=22,Review="Average",IsLike=true,Rating=3.0 },
                new ProductReviews(){ ProductID=9,UserID=11,Review="Good",IsLike=true,Rating=3.9 },
                new ProductReviews(){ ProductID=3,UserID=45,Review="Bad",IsLike=false,Rating=2.5 },
                new ProductReviews(){ ProductID=6,UserID=89,Review="Good",IsLike=true,Rating=3.5 },
                new ProductReviews(){ ProductID=2,UserID=24,Review="Good",IsLike=true,Rating=4.8 },
                new ProductReviews(){ ProductID=7,UserID=10,Review="Bad",IsLike=false,Rating=2.0 }
            };

            return list;
        }
        public static void DisplayeProductsReview(List<ProductReviews> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Top3HighRatedProduct(List<ProductReviews> list)
        {
            Console.WriteLine("Retrieving Top 3 products based on rating");
            //Query Syntax
            var sortedProduct = from product in list orderby product.Rating descending select product;
            var top3 = sortedProduct.Take(3).ToList();
            DisplayeProductsReview(top3);
        }
        public static void ProductsRatingGreaterThan3(List<ProductReviews> list)
        {
            //Query Syntax
            Console.WriteLine("Retrieving products based on rating greater than 3 and having ProductID as 1/4/9");
            var res = list.Where(p => p.Rating > 3 && (p.ProductID == 1 || p.ProductID == 4 || p.ProductID == 9)).ToList();
            DisplayeProductsReview(res);


        }
    }
}
