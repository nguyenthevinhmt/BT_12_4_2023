namespace Main2
{
    public abstract class Order
    {
        protected int orderId;
        protected String customerName;
        protected double totalPrice;

        public Order(int orderId, String customerName, double totalPrice)
        {
            this.orderId = orderId;
            this.customerName = customerName;
            this.totalPrice = totalPrice;
        }

        // Phương thức tính tổng số tiền của đơn hàng, được ghi đè bởi các lớp con
        public abstract double calculateTotalPrice();
    }

    // Tạo lớp Order để đại diện cho đơn hàng
    interface IPrintOrder
    {
        public void printOrder();
    }
    // Tạo lớp OnlineOrder kế thừa từ lớp Order
    public class OnlineOrder : Order,IPrintOrder
    {
        private double shippingFee;

        public OnlineOrder(int orderId, String customerName, double totalPrice, double shippingFee)
                          : base(orderId, customerName, totalPrice)
        {
        
               this.shippingFee = shippingFee;
        }

    // Ghi đè phương thức calculateTotalPrice để tính tổng số tiền của đơn hàng online
    
        public override double calculateTotalPrice()
        {
            return totalPrice + shippingFee;
        }

    
        public  void printOrder()
        {
            Console.WriteLine("abc");
        }
    }
    // Tạo lớp InStoreOrder kế thừa từ lớp Order
    public class InStoreOrder : Order
    {
         private double taxRate;

         public InStoreOrder(int orderId, String customerName, double totalPrice, double taxRate)
                            : base(orderId, customerName, totalPrice)
         {
        
              this.taxRate = taxRate;
         }

    // Ghi đè phương thức calculateTotalPrice để tính tổng số tiền của đơn hàng mua trực tiếp tại cửa hàng
    
         public override double calculateTotalPrice()
         {
              return totalPrice + totalPrice * taxRate;
         }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo một đơn hàng online và một đơn hàng mua trực tiếp tại cửa hàng
            Order onlineOrder = new OnlineOrder(1, "John Smith", 100.0, 10.0);
            Order inStoreOrder = new InStoreOrder(2, "Jane Doe", 200.0, 0.1);

            //onlineOrder.printOrder();

            // Gọi phương thức calculateTotalPrice để tính tổng số tiền của đơn hàng online và đơn hàng mua trực tiếp tại cửa hàng
            double onlineOrderTotalPrice = onlineOrder.calculateTotalPrice();
            double inStoreOrderTotalPrice = inStoreOrder.calculateTotalPrice();
        }
    }
}









