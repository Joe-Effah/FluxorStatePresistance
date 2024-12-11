namespace StatePresistanceProject.Actions;

public class SetValueAction
{
    public string Value { get; set; }
    public SetValueAction(string value)
    {
        Value = value;
    }
}
