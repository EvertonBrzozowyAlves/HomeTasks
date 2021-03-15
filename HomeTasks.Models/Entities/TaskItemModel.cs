namespace HomeTasks.Models.Entities
{
    public class TaskItemModel : BaseModel
    {
        public long TaskItemId { get; set; }
        public string Description { get; set; }
        public long TaskId { get; set; }
        public bool IsCompleted { get; set; }
    }
}