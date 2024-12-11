using Fluxor;
using StatePresistanceProject.Actions;
using StatePresistanceProject.State;

namespace StatePresistanceProject.Reducer;

public static class IncrementCounterSampleActionReducer
{
    [ReducerMethod]
    public static SampleStore ReduceIncrementCounterAction(SampleStore state, IncrementSampleCounterAction action) =>
    new(clickCount: state.ClickCount + 1);
}
