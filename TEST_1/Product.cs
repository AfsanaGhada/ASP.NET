namespace TEST_1
{
    public class Product
    {
        public int ProductId { get; set; }
        public String ProductName { get; set; }
        public int Price { get; set; }
        public Product(int id,String name,int price) {
            ProductId = id;
            ProductName = name; 
            Price = price;
        }
        public void DisplayProductDetail()
        {
            Console.WriteLine($"ProductId is: {ProductId}");
            Console.WriteLine($"ProductName is: {ProductName}"); 
            Console.WriteLine($"Price is: {Price}");
        }
    }
}
