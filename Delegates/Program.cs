// See https://aka.ms/new-console-template for more information

using Delegates;

Example1();

Console.ReadKey();

void Example1()
{
    var change = new ChangeDetails()
    {
        Id = 1,
        Name = "Name 1"
    };
    var changer = new MakeChanges();
    //changer.Proceess(change); // show what happens 
    
    var changeUtils = new ChangeValidatedUtils();
    changer.OnChangeValidated += changeUtils.SaveChangeToList;
    changer.OnChangeValidated += changeUtils.PrioritizeChange;
    changer.Process(change, changeUtils.DoPaperWork);
}