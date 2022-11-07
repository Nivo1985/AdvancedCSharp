namespace Delegates;

public class MakeChanges
{
    public delegate void ChangeValidated();
    public delegate void ProcessCompleted();
    public ChangeValidated OnChangeValidated
    {
        get; 
        set;
    }
    private bool Validate(ChangeDetails changeDetails)
    {
        try
        {
            ArgumentNullException.ThrowIfNull(changeDetails);
        }
        catch (Exception e)
        {
            return false;
        }

        OnChangeValidated?.Invoke();
        return true;
    }

    public void Process(ChangeDetails changeDetails, ProcessCompleted? processCompleted = default)
    {
        Validate(changeDetails);
        
        processCompleted?.Invoke();
    }
}