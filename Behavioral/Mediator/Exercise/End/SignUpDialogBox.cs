using System;

namespace Mediator.Exercise.End
{
    public class SignUpDialogBox
    {
        private readonly TextBox usernameTextBox = new TextBox();
        private readonly TextBox passwordTextBox = new TextBox();
        private readonly CheckBox agreeToTermsCheckBox = new CheckBox();
        private readonly Button signUpButton = new Button();

        public SignUpDialogBox()
        {
            var controlChangedEventHandler = new ControlChangedEventHandler(usernameTextBox, passwordTextBox, agreeToTermsCheckBox, signUpButton);

            usernameTextBox.AddEventHandler(controlChangedEventHandler);
            passwordTextBox.AddEventHandler(controlChangedEventHandler);
            agreeToTermsCheckBox.AddEventHandler(controlChangedEventHandler);
        }

        public void SimulateUserInteraction()
        {
            // Initially the button should be disabled
            Console.WriteLine("Initially: " + signUpButton.IsEnabled);

            // The user enters their username, the button is still disabled
            usernameTextBox.Content = "username";
            Console.WriteLine("After setting the username: " + signUpButton.IsEnabled);

            // The user enters their password, the button is still disabled
            passwordTextBox.Content = "password";
            Console.WriteLine("After setting the password: " + signUpButton.IsEnabled);

            // The agrees to the terms, the button becomes enabled
            agreeToTermsCheckBox.IsChecked = true;
            Console.WriteLine("After agreeing to terms: " + signUpButton.IsEnabled);

            // The user removes the password, the button becomes disabled
            passwordTextBox.Content = string.Empty;
            Console.WriteLine("After removing the password: " + signUpButton.IsEnabled);

            // The user enters the password again, the button becomes enabled
            passwordTextBox.Content = "password";
            Console.WriteLine("After re-setting the password: " + signUpButton.IsEnabled);
        }
    }
}
