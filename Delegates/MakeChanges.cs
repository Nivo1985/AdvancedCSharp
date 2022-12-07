namespace Delegates;

public class MakeChanges
{
    // public delegate void ChangeValidated();
    // public delegate bool Processing(ChangeDetails changeDetails);
    // public delegate void ProcessCompleted(ChangeDetails changeDetails);
    
    public Action OnChangeValidated
    {
        get; 
        set;
    }

    public Func<ChangeDetails, bool> OnProcessing
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

    public void Process(ChangeDetails changeDetails, Action<ChangeDetails>? processCompleted = default)
    {
        if (!Validate(changeDetails)) return;
        if (OnProcessing?.Invoke(changeDetails) == true)
        {
            processCompleted?.Invoke(changeDetails);
        }
    }
}