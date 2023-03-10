namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Welcome To Product Review Management System\n");
                List<ProductReviews> list = Management.AddProductsReview();
                Console.WriteLine("Choose Option or press 0 for exit" +
                    "\n1:Add review to the list\n2:Top 3 high Rated product\n" +
                    "3:Products with Rating greater than 3"+ "\n4:Count of products for each ProductID\n" +
                    "5:Only ProductID with Review"+
                    "\n6:Skipping top 5 records and displaying remaining records" +
                    "\n7:Only Retrieving ProductID with Rating");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Management.DisplayeProductsReview(list);
                        break;
                    case 2:
                       Management.Top3HighRatedProduct(list);
                        break;
                    case 3:
                       Management.ProductsRatingGreaterThan3(list);
                        break;
                    case 4:
                        Management.CountofReviewForEachProductID(list);
                        break;
                    case 5:
                        Management.RetrieveProductIDWithReview(list);
                        break;
                    case 6:
                        Management.SkipTop5Records(list);
                        break;
                }
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}