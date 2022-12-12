// See https://aka.ms/new-console-template for more information

using Delegates;

Example1();

Console.ReadKey();

void Example1()
{
    var change = new ChangeDetails()
    { 
        Id = 1,
        Name = "Name 1",
        Valid = true
    };
    var changer = new MakeChanges();
    
    var changeUtils = new ChangeUtils();
    changer.OnChangeValidated += changeUtils.SaveChangeToList;
    changer.OnChangeValidated += changeUtils.PrioritizeChange;
    changer.OnProcessing += changeUtils.Process;

    var local = "LOCAL VAR ";
    Action<ChangeDetails> processCompletedChain = (changeDetails) =>
    {
        Console.WriteLine("Lambda + Local: Do paper work for {0} _ {1}", changeDetails.Name,local);
    };
    processCompletedChain += (changeDetails) =>
    {
        Console.WriteLine("Lambda + Local: Check paper work for {0} _ {1}", changeDetails.Name,local);
    };
    processCompletedChain += (changeDetails) =>
    {
        Console.WriteLine("Lambda + Local: Clean up after paper work for {0} _ {1}", changeDetails.Name,local);
    };
    changer.Process(change, processCompletedChain);
}