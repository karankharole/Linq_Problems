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
                Console.WriteLine("Choose Option or press 0 for exit\n1:Add review to the list\n2:Top 3 high Rated product\n" +
                    "3:Products with Rating greater than 3");
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