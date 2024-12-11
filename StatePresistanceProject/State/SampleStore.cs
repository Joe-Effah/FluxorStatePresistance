using Fluxor;

namespace StatePresistanceProject.State;

[FeatureState]
public class SampleStore
{
    public int ClickCount { get; }

    public SampleStore() { }
    public SampleStore(int clickCount)
    {
        ClickCount = clickCount;
    }
}
