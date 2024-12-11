using Fluxor;

namespace StatePresistanceProject.State
{
    [FeatureState]
    public record Value
    {
        public string Content { get; }

        public Value()
        {

        }
        public Value(string NewContent)
        {
            Content = NewContent;
        }
    }
}
