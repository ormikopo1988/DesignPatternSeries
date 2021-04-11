using Command.Solution.Framework;

namespace Command.Solution
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public void Execute()
        {
            customerService.AddCustomer();
        }
    }
}
