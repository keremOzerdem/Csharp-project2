// Takım ataması
TeamUserList.TeamList.Add(new TeamUserModel(1, "Ahmet"));
TeamUserList.TeamList.Add(new TeamUserModel(2, "Aylin"));
TeamUserList.TeamList.Add(new TeamUserModel(3, "Selin"));
TeamUserList.TeamList.Add(new TeamUserModel(4, "Mehmet"));
TeamUserList.TeamList.Add(new TeamUserModel(5, "Selami"));

// Default görev ataması
ToDoColumn.ToDoColumnList.Add(new CardModel("c#", "c# dersi", 1, CardSizeEnumModel.S.ToString()));
ToDoColumn.ToDoColumnList.Add(new CardModel("sql", "sql dersi", 2, CardSizeEnumModel.M.ToString()));

// Linelar Boarda atanıyor, yani kart oluşturuluyor
BoardModel.BoardModelDict.Add("TODO Line", ToDoColumn.ToDoColumnList);
BoardModel.BoardModelDict.Add("IN PROGRESS Line", InProgressColumn.InProgressColumnList);
BoardModel.BoardModelDict.Add("DONE Line", DoneColumn.DoneColumnList);

OperationsController.StartPrint();
int select = int.Parse(Console.ReadLine());
int control = OperationsController.ControlFunction(select);
while (control == 0)
{
    OperationsController.CallFunction(select);
    OperationsController.PrintBoard();
    OperationsController.StartPrint();
    select = int.Parse(Console.ReadLine());
    control = OperationsController.ControlFunction(select);
}
Console.WriteLine("1-4 Aralığı Dışında bir sayı girildi, çıkış yapılıyor...");
Console.WriteLine("Programı Sonlandırmak için bir tuşa basınız...");
// OperationsController.PrintBoard();
Console.ReadLine();
