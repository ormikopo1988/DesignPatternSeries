using System;

namespace Mediator.Solution.UsingObserver
{
    public class ArticlesDialogBox
    {
        private readonly ListBox articlesListBox = new ListBox();
        private readonly TextBox titleTextBox = new TextBox();
        private readonly Button saveButton = new Button();

        public ArticlesDialogBox()
        {
            articlesListBox.AddEventHandler(new ListBoxChangeEventHandler(articlesListBox, titleTextBox, saveButton));
            titleTextBox.AddEventHandler(new TextBoxChangeEventHandler(titleTextBox, saveButton));
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            articlesListBox.Selection = string.Empty;
            articlesListBox.Selection = "Article 2";
            Console.WriteLine($"(Using observer) -> TextBox: {titleTextBox.Content}");
            Console.WriteLine($"(Using observer) -> Is button enabled: {saveButton.IsEnabled}");
        }
    }
}
