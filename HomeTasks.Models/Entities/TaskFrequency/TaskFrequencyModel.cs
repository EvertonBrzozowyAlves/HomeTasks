using System;

namespace HomeTasks.Models.Entities
{
    public class TaskFrequencyModel : BaseModel
    {
        public long TaskFrequencyId { get; set; }
        public DateTime ActionDate { get; set; }
        public long TaskId { get; set; }
        public bool IsCompleted { get; set; }
    }
}