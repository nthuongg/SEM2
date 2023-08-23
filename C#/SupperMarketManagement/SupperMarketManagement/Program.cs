using SupperMarketManagement.Controllers;
using SupperMarketManagement.Models;
using System.Transactions;

class Program
{
    public static void Main(string[] args)
    {
		try
		{
			do
			{
                Console.WriteLine("\n ===== MANAGEMENT ===== \n");
				Console.WriteLine("1. Product");
				Console.WriteLine("2. Order");
				Console.WriteLine("3. Customer");
				Console.WriteLine("4. Membership");
				Console.WriteLine("0. Exit");

				Console.Write("Enter selection: ");
				int choose = Convert.ToInt32(Console.ReadLine());

				switch (choose)
				{
					case 1:
						Console.WriteLine("\n ===== PRODUCT MANAGEMENT ===== \n");
                        Console.WriteLine("1. Create new product");
						Console.WriteLine("2. View all products");
						Console.WriteLine("3. Update product");
						Console.WriteLine("4. Delete product");
						Console.WriteLine("0. Back");

                        Console.WriteLine("Enter selection: ");
						ProductController productcontroller = new ProductController();
						choose = Convert.ToInt32(Console.ReadLine());

						switch(choose)
						{
							case 1:
                                Console.WriteLine("Create new product");
                                Console.WriteLine("Enter name: ");
								string name = Console.ReadLine();
                                Console.WriteLine("Enter barcode: ");
								int barcode = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter price: ");
								double price = Convert.ToDouble(Console.ReadLine());

								Product product = new Product
								{
									Name = name, 
									Barcode = barcode,
									Price = price
								};
								productcontroller.Add(product);

								break;

							case 2:
								Console.WriteLine("View all product");
								List<Product> productsList = productcontroller.GetAll();

								foreach (Product pr in productsList)
								{
									Console.WriteLine($"{ pr.Id } { pr.Name } { pr.Barcode } { pr.Price }");
                                }

								break;

							case 3:
								Console.WriteLine("Update product ");
                                Console.WriteLine("Enter id: ");
								int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter new name: ");
                                string newName = Console.ReadLine();
                                Console.WriteLine("Enter new barcode: ");
                                int newBarcode = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter new price: ");
                                double newPrice = Convert.ToDouble(Console.ReadLine());

								Product p = new Product
								{
									Name = newName,
									Barcode = newBarcode,
									Price = newPrice
								};
								productcontroller.Update(id, p);

								break;

							case 4:
                                Console.WriteLine("Delete product");
                                Console.WriteLine("Enter id: ");
								id = Convert.ToInt32(Console.ReadLine());

								productcontroller.Delete(id);

								break;

							case 0:
								break;

                            default:
                                Console.WriteLine("\n Invalid choice please choose again.");

                                break;

                        }
						break;

                    case 2:
                        Console.WriteLine("\n ===== ORDER MANAGEMENT ===== \n");
                        Console.WriteLine("1. Create new order");
                        Console.WriteLine("2. View all orders");
                        Console.WriteLine("3. Update order");
                        Console.WriteLine("4. Delete order");
                        Console.WriteLine("0. Back");

                        Console.WriteLine("Enter selection: ");
                        OrderController ordercontroller = new OrderController();
                        choose = Convert.ToInt32(Console.ReadLine());

                        switch (choose)
                        {
                            case 1:
                                Console.WriteLine("Create new product");
                                Console.WriteLine("Enter date create: ");
                                string dateCreate = Console.ReadLine();
                                Console.WriteLine("Enter totalAmount: ");
                                string totalAmount = Console.ReadLine();
                                Console.WriteLine("Enter Customer ID");
                                int customerId = Convert.ToInt32(Console.ReadLine());   

                                Order order = new Order
                                {
                                    DateCreate = dateCreate,
                                    TotalAmount = totalAmount,
                                    CustomerId = customerId
                                };
                                ordercontroller.Add(order);

                                break;

                            case 2:
                                Console.WriteLine("View all order");
                                List<Order> ordersList = ordercontroller.GetAll();

                                foreach (Order or in ordersList)
                                {
                                    Console.WriteLine($"{or.DateCreate} {or.TotalAmount}");
                                }

                                break;

                            case 3:
                                Console.WriteLine("Update order ");
                                Console.WriteLine("Enter id: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter date create: ");
                                string newDateCreate = Console.ReadLine();
                                Console.WriteLine("Enter totalAmount: ");
                                string newTotalAmount = Console.ReadLine();

                                Order o = new Order
                                {
                                    DateCreate = newDateCreate,
                                    TotalAmount = newTotalAmount
                                };
                                ordercontroller.Update(id, o);

                                break;

                            case 4:
                                Console.WriteLine("Delete order");
                                Console.WriteLine("Enter id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                ordercontroller.Delete(id);

                                break;

                            case 0:
                                break;

                            default:
                                Console.WriteLine("\n Invalid choice please choose again.");

                                break;

                        }
                        break;

                    case 3:
                        Console.WriteLine("\n ===== CUSTOMER MANAGEMENT ===== \n");
                        Console.WriteLine("1. Create new customer");
                        Console.WriteLine("2. View all customers");
                        Console.WriteLine("3. Update customer");
                        Console.WriteLine("4. Delete customer");
                        Console.WriteLine("0. Back");

                        Console.WriteLine("Enter selection: ");
                        CustomerController customercontroller = new CustomerController();
                        choose = Convert.ToInt32(Console.ReadLine());

						switch(choose)
						{
							case 1:
                                Console.WriteLine("Create new customer");
                                Console.WriteLine("Enter name: ");
                                string name = Console.ReadLine();
                                Console.WriteLine("Enter phone: ");
                                string phone = Console.ReadLine();
                                Console.WriteLine("Enter email: ");
                                string email = Console.ReadLine();
                                Console.WriteLine("Enter membership id: ");
                                int membershipId = Convert.ToInt32(Console.ReadLine());

                                Customer customer = new Customer
                                {
									Name = name,
									Phone = phone,
									Email = email,
									MembershipId = membershipId
                                };
                                customercontroller.Add(customer);

                                break;

							case 2:
								Console.WriteLine("View all customers");
								List<Customer> customerList = customercontroller.GetAll();
								foreach (Customer cus in customerList)
								{
                                    Console.WriteLine($"{ cus.Id } { cus.Name } { cus.Phone} {cus.Email}");
                                }
								break;

							case 3:
								Console.WriteLine("Update customer");
                                Console.WriteLine("Update product ");
                                Console.WriteLine("Enter id: ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter new name: ");
                                string newName = Console.ReadLine();
                                Console.WriteLine("Enter new phone: ");
                                string newPhone = Console.ReadLine();
                                Console.WriteLine("Enter new email: ");
                                string newEmail = Console.ReadLine(); ;

                                Customer newCustomer = new Customer
                                {
                                    Id = id,
                                    Name = newName,
                                    Phone = newPhone,
                                    Email = newEmail,

                                };
                                customercontroller.Update(id, newCustomer);
                                break;

							case 4:
								Console.WriteLine("Delete customer");
                                Console.WriteLine("Enter id: ");
                                id = Convert.ToInt32(Console.ReadLine());

                                customercontroller.Delete(id);

                                break;


                            case 0:
                                break;

                            default:
                                Console.WriteLine("\n Invalid choice please choose again.");

                                break;

                        }





                        break;
				}
            } while (true);

		}
		catch (Exception)
		{

			throw;
		}
    }
}