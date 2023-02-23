namespace ProductReviewManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Product Review Management System");
            List<ProductReviews> list = Management.AddProductsReview();
            Management.DisplayeProductsReview(list);
            Console.ReadLine();

        }
    }
}