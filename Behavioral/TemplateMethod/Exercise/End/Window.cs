using System;

namespace TemplateMethod.Exercise.End
{
    public class Window
    {
        public void Close()
        {
            OnClosing();

            Console.WriteLine("Removing the window from the screen.");

            OnClosed();
        }

        protected virtual void OnClosing()
        {
            // Before window close hook
        }

        protected virtual void OnClosed()
        {
            // After window close hook
        }
    }
}
