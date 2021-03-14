using System;
using HomeTasks.Models.Enums;

namespace HomeTasks.Models.Entities
{
    public class TaskModel : BaseModel
    {
        public long TaskModelId { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Points { get; set; }
        public long FamilyId { get; set; }
        public long? FamilyMemberId { get; set; }
        public TaskStatusEnum TaskStatusEnum { get; set; }
        public DateTime? TaskDueDate { get; set; }
        public TaskFrequencyTypeEnum TaskFrequencyType { get; set; }
    }
}