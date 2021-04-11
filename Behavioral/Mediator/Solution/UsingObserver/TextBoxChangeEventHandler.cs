namespace Mediator.Solution.UsingObserver
{
    public class TextBoxChangeEventHandler : IEventHandler
    {
        private readonly TextBox titleTextBox;
        private readonly Button saveButton;

        public TextBoxChangeEventHandler(TextBox titleTextBox, Button saveButton)
        {
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void Handle()
        {
            var title = titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(title);
            saveButton.IsEnabled = !isEmpty;
        }
    }
}
