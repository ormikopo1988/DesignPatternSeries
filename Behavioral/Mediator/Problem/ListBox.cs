namespace Mediator.Problem
{
    /// <summary>
    /// The ListBox here is also part of the GUI framework we are building.
    /// The ListBox in this example needs to talk to the objects from Button and TextBox classes.
    /// Whenever we select something from this ListBox the Selection property gets some value,
    /// then the TextBox must be updated with the value of this Selection property and
    /// also the Button must become enabled. We do not have access to the code of the ListBox class
    /// and this class cannot know anything about Button & TextBox classes, because it is part 
    /// of a framework and frameworks cannot know anything about the context of the application
    /// they are running in.
    /// </summary>
    public class ListBox : UIControl
    {
        public string Selection { get; set; }
    }
}
