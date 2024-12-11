using Fluxor;
using StatePresistanceProject.Actions;
using StatePresistanceProject.State;

namespace StatePresistanceProject.Reducer;

public static class IncrementCounterActionReducer
{
    [ReducerMethod]
    public static CounterStore ReduceIncrementCounterAction(CounterStore state, IncrementCounterAction action) =>
    new(clickCount: state.ClickCount + 1);
}
