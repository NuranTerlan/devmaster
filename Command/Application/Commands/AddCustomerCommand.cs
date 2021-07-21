using Command.Framework;

namespace Command.Application.Commands
{
    public class AddCustomerCommand : ICommand
    {
        private readonly CustomerService _customerService;

        public AddCustomerCommand(CustomerService customerService)
        {
            _customerService = customerService;
        }
        
        public void Execute()
        {
            _customerService.AddCustomer();
        }
    }
}