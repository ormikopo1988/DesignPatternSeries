namespace Mediator.Exercise.End
{
    public class ControlChangedEventHandler : IEventHandler
    {
        private readonly TextBox usernameTextBox;
        private readonly TextBox passwordTextBox;
        private readonly CheckBox agreeToTermsCheckBox;
        private readonly Button signUpButton;

        public ControlChangedEventHandler(TextBox usernameTextBox, TextBox passwordTextBox, CheckBox agreeToTermsCheckBox, Button signUpButton)
        {
            this.usernameTextBox = usernameTextBox;
            this.passwordTextBox = passwordTextBox;
            this.agreeToTermsCheckBox = agreeToTermsCheckBox;
            this.signUpButton = signUpButton;
        }

        public void Handle()
        {
            signUpButton.IsEnabled = IsFormValid();
        }

        private bool IsFormValid()
        {
            return !usernameTextBox.IsEmpty() && !passwordTextBox.IsEmpty() && agreeToTermsCheckBox.IsChecked;
        }
    }
}
