namespace Delegates;

public class ChangeUtils
{
    public void SaveChangeToList()
    {
        Console.WriteLine("Change saved to list");
    }
    
    public void PrioritizeChange()
    {
        Console.WriteLine("Change Prioritized");
    }

    public void DoPaperWork(ChangeDetails changeDetails)
    {
        Console.WriteLine("Do paper work for {0}", changeDetails.Name);
    }
    
    public void CheckPaperWork(ChangeDetails changeDetails)
    {
        Console.WriteLine("Check paper work for {0}", changeDetails.Name);
    }
    
    public void CleanUpAfterPaperWork(ChangeDetails changeDetails)
    {
        Console.WriteLine("Clean up after paper work for {0}", changeDetails.Name);
    }
    

    public bool Process(ChangeDetails changeDetails)
    {
        return changeDetails.Valid;
    }
}