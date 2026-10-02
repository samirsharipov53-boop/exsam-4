
public interface ITaskService
{
    public void AddTask();
    public void DisplayTask();
    public void ComplateTask(int id);
    public void DeleteTask(int id);

    public string SearchByTitle(string n);

    public List<Preority>  GetByPriority();


}