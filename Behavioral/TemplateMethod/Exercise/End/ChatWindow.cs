using System;

namespace TemplateMethod.Exercise.End
{
    public class ChatWindow : Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Calling ChatWindow OnClose method.");

            base.OnClosed();
        }

        protected override void OnClosing()
        {
            Console.WriteLine("Calling ChatWindow OnClosing method.");

            base.OnClosing();
        }
    }
}
