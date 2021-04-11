using System;

namespace Command.Problem
{
    public class Button
    {
        private readonly CustomerService customerService;

        public Button(CustomerService customerService)
        {
            this.customerService = customerService;
        }

        public string Label { get; set; }

        public void Click()
        {
            // Let's say we want to design a GUI framework, that other developers will use in order to build GUI applications.
            // At the time of designing a framework (at the time of implementing the button class in this context),
            // we do not know what code should be executed, when we click a button. 
            // Maybe this click would lead to an HTTP call, or to something being written to a database.
            // The command pattern aims to solve this particular problem.
            Console.WriteLine("Button clicked. About to call CustomerService to save the customer.");

            // Our Button class is tightly coupled and must know about this CustomerService. Cannot be used inside any context this way.
            // The framework we are building cannot know beforehand the context in which it is going to run into.
            customerService.AddCustomer();
        }
    }
}
