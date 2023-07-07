using Structural.Adapter.ThirdParty;

namespace Structural.Adapter;

public class CaramelAdapterFilter : IFilter
{
    private Caramel _thirdPartyCaramelFilter;

    public CaramelAdapterFilter(Caramel thirdPartyCaramelFilter)
    {
        _thirdPartyCaramelFilter = thirdPartyCaramelFilter;
    }
    public void Apply(Image image)
    {
        _thirdPartyCaramelFilter.init();
        _thirdPartyCaramelFilter.render(image);
    }
}