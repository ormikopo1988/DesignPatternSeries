using System;

namespace Mediator.Solution
{
    /// <summary>
    /// This is the mediator object and all the logic behind the articles dialog box is in a single place.
    /// </summary>
    public class ArticlesDialogBox : DialogBox
    {
        private readonly ListBox articlesListBox;
        private readonly TextBox titleTextBox;
        private readonly Button saveButton;

        public ArticlesDialogBox()
        {
            this.articlesListBox = new ListBox(this);
            this.titleTextBox = new TextBox(this);
            this.saveButton = new Button(this);
        }

        public void SimulateUserInteraction()
        {
            articlesListBox.Selection = "Article 1";
            articlesListBox.Selection = string.Empty;
            articlesListBox.Selection = "Article 2";
            Console.WriteLine($"TextBox: {titleTextBox.Content}");
            Console.WriteLine($"Is button enabled: {saveButton.IsEnabled}");
        }

        public override void Changed(UIControl uiControl)
        {
            if (uiControl == articlesListBox)
            {
                ArticleSelected();
            }
            else if (uiControl == titleTextBox)
            {
                TitleChanged();
            }
            else if (uiControl == saveButton)
            {
                ButtonChanged();
            }
        }

        private void ArticleSelected()
        {
            titleTextBox.Content = articlesListBox.Selection;
            saveButton.IsEnabled = true;
        }

        private void TitleChanged()
        {
            var title = titleTextBox.Content;
            var isEmpty = string.IsNullOrEmpty(title);
            saveButton.IsEnabled = !isEmpty;
        }

        private void ButtonChanged()
        {
            Console.WriteLine($"Save button changed to {saveButton.IsEnabled}.");
        }
    }
}
