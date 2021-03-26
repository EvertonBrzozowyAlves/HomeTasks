using HomeTasks.Models.Entities.MethodModels.FamilyModel;

namespace HomeTasks.Models.Interfaces
{
    public interface IFamily
    {
        FamilyRegisterNewResponseModel RegisterNew(FamilyRegisterNewRequestModel request);
    }
}