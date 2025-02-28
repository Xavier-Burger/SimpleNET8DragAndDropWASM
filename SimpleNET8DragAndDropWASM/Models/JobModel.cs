namespace SimpleNET8DragAndDropWASM.Models
{
    public class JobModel
    {
        public int Id { get; set; }
        public JobStatuses Status { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime LastUpdated { get; set; }
        public int Order { get; set; }
    }

    public enum JobStatuses
    {
        Todo,
        Started,
        Completed
    }
}
