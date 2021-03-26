using System;
using HomeTasks.Models.Entities.MethodModels.FamilyModel;

namespace HomeTasks.Data.Family.Implementations
{
    public class FamilyData : IFamilyData
    {
        public FamilyRegisterNewResponseModel RegisterNew(FamilyRegisterNewRequestModel request)
        {
            try
            {
                throw new NotImplementedException();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}