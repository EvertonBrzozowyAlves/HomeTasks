namespace HomeTasks.Models.Entities.FamilyMember
{
    public class FamilyMemberModel : BaseModel
    {
        public long FamilyMemberId { get; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public long FamilyId { get; set; }
    }
}