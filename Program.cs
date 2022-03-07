// Takım üyelerinin ataması
TeamUserList.TeamList.Add(new TeamUserModel(1, "Ahmet"));
TeamUserList.TeamList.Add(new TeamUserModel(2, "Aylin"));
TeamUserList.TeamList.Add(new TeamUserModel(3, "Selin"));
TeamUserList.TeamList.Add(new TeamUserModel(4, "Mehmet"));
TeamUserList.TeamList.Add(new TeamUserModel(5, "Selami"));

// Default görev ataması
ToDoLine.ToDoLineList.Add(new CardModel("c#", "c# dersi", 1, CardSizeEnumModel.S.ToString()));
ToDoLine.ToDoLineList.Add(new CardModel("sql", "sql dersi", 2, CardSizeEnumModel.M.ToString()));

// Linelar Boarda atanıyor, yani kart oluşturuluyor
BoardModel.BoardModelDict.Add("TODO Line", ToDoLine.ToDoLineList);
BoardModel.BoardModelDict.Add("IN PROGRESS Line", InProgressLine.InProgressLineList);
BoardModel.BoardModelDict.Add("DONE Line", DoneLine.DoneLineList);

OperationsController.StartPrint();
int selectOperation = int.Parse(Console.ReadLine());
int control = OperationsController.ControlFunction(selectOperation);
while (control == 1)
{
    OperationsController.CallFunction(selectOperation);
    OperationsController.PrintBoard();
    OperationsController.StartPrint();
    selectOperation = int.Parse(Console.ReadLine());
    control = OperationsController.ControlFunction(selectOperation);
}
Console.WriteLine("1-4 Aralığı Dışında bir sayı girildi, çıkış yapılıyor...");
Console.WriteLine("Programı Sonlandırmak için bir tuşa basınız...");
// OperationsController.PrintBoard();
Console.ReadLine();
