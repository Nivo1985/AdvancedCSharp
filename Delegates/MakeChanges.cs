namespace Delegates;

public class MakeChanges
{
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
        catch
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