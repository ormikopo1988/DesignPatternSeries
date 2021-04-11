namespace Decorator.Exercise.Start
{
    public class Artefact
    {
        public bool HasError { get; set; }
        public bool IsMain { get; set; }

        private readonly string name;

        public Artefact(string name)
        {
            this.name = name;
        }

        public string Render()
        {
            // The current implementation is not easily extensible. If tomorrow we need
            // to support other special markers, we have to come back and modify this class.
            //
            // For example, if the project is under source control, we need to highlight
            // the artefacts that are changed but not committed to the repository with a
            // special marker.
            //
            // Similarly, if an artefact is excluded from the project, we may want to
            // make the icon look disabled or semi-transparent.
            //
            // Every time we need to support a new marker, we have to come back and modify
            // this class. Over time, the code in this class gets more and more convoluted
            // with several if statements and additional fields.

            var errorIcon = HasError ? "[Error]" : string.Empty;
            var mainIcon = IsMain ? "[Main]" : string.Empty;

            return $"{name} {errorIcon} {mainIcon}";
        }
    }
}
