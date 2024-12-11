using Fluxor;

namespace StatePresistanceProject.State;

[FeatureState]
public class CounterStore
{
    public int ClickCount { get; }

    public CounterStore() { }
    public CounterStore(int clickCount)
    {
        ClickCount = clickCount;
    }
}
