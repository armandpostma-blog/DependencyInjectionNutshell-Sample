namespace DependencyInjectionNutshell.Model
{
    public class Customer
    {
        private readonly int _customerId;
        private readonly string _customerName;

        public int CustomerId
        {
            get { return _customerId; }
        }

        public string CustomerName
        {
            get { return _customerName; }
        }

        public Customer(int customerId, string customerName)
        {
            _customerId = customerId;
            _customerName = customerName;
        }
    }
}
