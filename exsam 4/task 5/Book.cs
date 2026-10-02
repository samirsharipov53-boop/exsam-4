public class Book
{
    public string? Title{get; set;}
    public string? Autor{get; set;}
    public  BookStatus Status {get;set;}
    public DateTime BorrowDate {get; set;}
    public DateTime DueDate {get; set;}
   
    public void Borrow(int day)
    {
     if(Status==BookStatus.Aviable)
        {
            Status=BookStatus.Borowed;
            BorrowDate = DateTime.Now;
            DueDate = BorrowDate.AddDays(day);
        }
        else if (Status != BookStatus.Aviable)
        {
            System.Console.WriteLine("Китоб аллакай дода шудааст");
        }
    } 
    DateTime Returne;
    public int Return(DateTime date)
    {
Returne=date;
        if (Status != BookStatus.Borowed)
        {
            System.Console.WriteLine("EROR");
        }
        if (date > DueDate)
        {
           int Jarima= (date.Day-DueDate.Day)*5;
            return Jarima;
            
        }
    
        return 0;
    }

    public bool IsOverdue()
    {
        if (Returne < BorrowDate)
        {
            return true;
        }
        else return false;
    }
}

