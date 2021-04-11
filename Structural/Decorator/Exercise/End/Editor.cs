using System;

namespace Decorator.Exercise.End
{
    public class Editor
    {
        public void OpenProject(string path) 
        {
            var artefacts = new IArtefact[4] 
            {
                new Artefact("Main"),
                new Artefact("Demo"),
                new Artefact("EmailClient"),
                new Artefact("EmailProvider"),
            };

            // We can apply multiple decorators
            artefacts[0] = new ErrorArtefact(new MainArtefact(artefacts[0]));
            artefacts[2] = new ErrorArtefact(artefacts[2]);

            // In the future, we can create a SourceControlDecorator that adds
            // a special marker to the icon if artefacts are not committed to the repository.

            foreach (var artefact in artefacts)
            {
                Console.WriteLine(artefact.Render());
            }
        }
    }
}
