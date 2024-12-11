using Fluxor;
using StatePresistanceProject.Actions;
using StatePresistanceProject.State;

namespace StatePresistanceProject.Reducer;

public class SetValueReducer
{
    [ReducerMethod]
    public static Value ReduceSetValue(Value state, SetValueAction action) => new(action.Value);
}
