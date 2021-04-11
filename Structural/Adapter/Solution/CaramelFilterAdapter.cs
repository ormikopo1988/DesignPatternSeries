using Adapter.Solution.ThirdPartyFilters;

namespace Adapter.Solution
{
    public class CaramelFilterAdapter : IFilter
    {
        private readonly CaramelFilter caramelFilter;

        public CaramelFilterAdapter(CaramelFilter caramelFilter)
        {
            this.caramelFilter = caramelFilter;
        }

        public void Apply(Image image)
        {
            caramelFilter.Init();

            caramelFilter.Render(image);
        }
    }
}
