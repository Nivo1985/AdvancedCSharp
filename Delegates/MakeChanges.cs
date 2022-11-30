namespace Delegates;

public class MakeChanges
{
    public delegate void ChangeValidated();
    public delegate bool Processing(ChangeDetails changeDetails);
    public delegate void ProcessCompleted(ChangeDetails changeDetails);
    
    public ChangeValidated OnChangeValidated
    {
        get; 
        set;
    }

    public Processing OnProcessing
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
        if (!Validate(changeDetails)) return;
        if (OnProcessing?.Invoke(changeDetails) == true)
        {
            processCompleted?.Invoke(changeDetails);
        }
    }
}