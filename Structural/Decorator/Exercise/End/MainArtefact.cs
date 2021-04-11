namespace Decorator.Exercise.End
{
    public class MainArtefact : IArtefact
    {
        private readonly IArtefact artefact;

        public MainArtefact(IArtefact artefact)
        {
            this.artefact = artefact;
        }

        public string Render()
        {
            return artefact.Render() + " [Main]";
        }
    }
}
