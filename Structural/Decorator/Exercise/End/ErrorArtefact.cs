namespace Decorator.Exercise.End
{
    public class ErrorArtefact : IArtefact
    {
        private readonly IArtefact artefact;

        public ErrorArtefact(IArtefact artefact)
        {
            this.artefact = artefact;
        }

        public string Render()
        {
            return artefact.Render() + " [Error]";
        }
    }
}
