public class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Email { get; set; }

    public Customer(int id, string? name, string? email)
    {
        Id = id;
        Name = name;
        Email = email;
    }
}

public class Programs
{
    private static List<Customer> customers = new List<Customer>();
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Make a choice");
            Console.WriteLine("1.Create a customer ");
            Console.WriteLine("2.Read Customer");
            Console.WriteLine("3.Update Customer");
            Console.WriteLine("4.Delete Customer");

            var choice = Console.ReadLine();
            switch(choice)
            {
                case "1":
                    Console.WriteLine("Create an ID, Name and Email ");
                    int CreateID = Convert.ToInt32(Console.ReadLine());
                    var CreateName = Convert.ToString(Console.ReadLine());
                    var CreateEmail = Convert.ToString(Console.ReadLine());
                    if(CreateName !=null && CreateEmail != null)
                    {
                        CreateCustomer(CreateID, CreateName, CreateEmail);
                    }
                    break;
                case "2":
                    int ReadID = Convert.ToInt32(Console.ReadLine());
                    var ReadName = Convert.ToString(Console.ReadLine());
                    var ReadEmail = Convert.ToString(Console.ReadLine());
                    if (ReadName != null && ReadEmail != null)
                    {
                        ReadCustomer(ReadID);
                    }
                    break;
                case "3":
                    int UpdateID = Convert.ToInt32(Console.ReadLine());
                    var UpdateName = Convert.ToString(Console.ReadLine());
                    var UpdateEmail = Convert.ToString(Console.ReadLine());
                    if (UpdateName != null && UpdateEmail != null)
                    {
                        UpdateCustomer(UpdateID, UpdateName, UpdateEmail);
                    }
                    break;
                case "4":
                    int DeleteID = Convert.ToInt32(Console.ReadLine());
                      DeleteCustomer(DeleteID);
                    
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    public static void CreateCustomer(int id,string name, string email)
    {
        var customer = customers.FirstOrDefault(x => x.Id == id);
        if (customer == null)
        {
            customers.Add(new Customer(id, name, email));
            Console.WriteLine("New Customer Added with an ID of " + id);
            Console.WriteLine("New Customer with Name " + name);
            Console.WriteLine("New Customer with Email of " + email);
        }
        else
        {
            Console.WriteLine("A customer with ID" + id + " Already Exist");
        }
    }
    public static void ReadCustomer(int id)
    {
        var customer = customers.FirstOrDefault(x => x.Id == id);
        if (customer != null)
        {
            Console.WriteLine("The ID of the Customer is " + id);
            Console.WriteLine("Read the Customer with Name " + customer.Name);
            Console.WriteLine("Read the Customer with Email of " + customer.Email);
        }
        else
        {
            Console.WriteLine("The Customer Couldn't be read");
        }
    }
    public static void UpdateCustomer(int id, string name, string email)
    {
        var customer = customers.FirstOrDefault(x => x.Id == id);
        if (customer != null)
        {
            customer.Name = name;
            customer.Email = email;
            Console.WriteLine("Customer updated succesfully");
            Console.WriteLine("Updated the Customer with ID " + id);
            Console.WriteLine("Updated the Customer with Name " + customer.Name);
            Console.WriteLine("Updated the Customer with Email of " + customer.Email);
        }
        else
        {
            Console.WriteLine("The Customer Couldn't be updated");
        }
    }
    public static void DeleteCustomer(int id)
    {
        var customer = customers.FirstOrDefault(x => x.Id == id);
        if (customer != null)
        {
            customers.Remove(customer);
            Console.WriteLine("Deleted the Customer with ID " + id);
            Console.WriteLine("Deleted the Customer with Name " + customer.Name);
            Console.WriteLine("Deleted the Customer with Email of " + customer.Email);
        }
        else
        {
            Console.WriteLine("The Customer Couldn't be Deleted, or He is not on the list");
        }
    }
}
