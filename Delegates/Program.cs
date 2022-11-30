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
    changer.Process(change, changeUtils.DoPaperWork);
    
}