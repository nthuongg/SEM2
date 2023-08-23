using Exam;

class Program
{
    public static void Main(string[] args)
    {
        ProductController productController = new ProductController();
        do
        {
            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Add product records");
            Console.WriteLine("2. Display product records");
            Console.WriteLine("3. Delete product by Id");
            Console.WriteLine("4. Exit");

            Console.Write("Please enter your selection: ");
            int choose = Convert.ToInt32(Console.ReadLine());
            
            switch (choose)
            {
                case 1:
                    Console.WriteLine("Add product records");
                    Console.WriteLine("Enter Id: ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter price: ");
                    double price = Double.Parse(Console.ReadLine());

                    Product product = new Product(id, name, price);


                    productController.AddNewProduct(product);
                    break;

                case 2:
                    productController.DisplayProducts();
                    break;

                case 3:
                    Console.WriteLine("Delete product records");
                    Console.Write("Enter Id: ");
                    id = Console.ReadLine();

                    productController.DeleteProduct(id);
                    break;

                case 4:
                    return;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }
        } while (true);


    }
}