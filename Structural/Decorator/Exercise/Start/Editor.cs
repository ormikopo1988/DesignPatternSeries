using System;

namespace Decorator.Exercise.Start
{
    /// <summary>
    /// We’re going to build a code editor like IntelliJ or VSCode. 
    /// When we open a project, we should see all the artefacts (items) in that project. 
    /// Every artefact should have an icon and the icon can be different from one artefact to another. 
    /// For example, the Main file’s icon has a special green play marker on top of the icon.
    /// Similarly, if an artefact includes errors, its icon should include an error marker.
    /// We’re simulating the rendering of these icons using simple strings. 
    /// Next, look at the current implementation of these concepts in the current Start folder. 
    /// Read the comments in the Artefact class about the problems with this implementation. 
    /// Refactor the solution using the decorator pattern. 
    /// </summary>
    public class Editor
    {
        public void OpenProject(string path)
        {
            var artefacts = new Artefact[4] 
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            artefacts[0].IsMain = true;
            artefacts[2].HasError = true;

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}
