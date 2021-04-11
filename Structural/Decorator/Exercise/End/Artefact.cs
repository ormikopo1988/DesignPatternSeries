namespace Decorator.Exercise.End
{
    public class Artefact : IArtefact
    {
        private readonly string name;

        public Artefact(string name)
        {
            this.name = name;
        }

        public string Render()
        {
            return name;
        }
    }
}
