namespace Mediator.Solution.UsingObserver
{
    public class ListBoxChangeEventHandler : IEventHandler
    {
        private readonly ListBox articlesListBox;
        private readonly TextBox titleTextBox;
        private readonly Button saveButton;

        public ListBoxChangeEventHandler(ListBox articlesListBox, TextBox titleTextBox, Button saveButton)
        {
            this.articlesListBox = articlesListBox;
            this.titleTextBox = titleTextBox;
            this.saveButton = saveButton;
        }

        public void Handle()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }
    }
}
