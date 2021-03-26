using System;
using HomeTasks.Data.Family;
using HomeTasks.Models.Entities.MethodModels.FamilyModel;
using HomeTasks.Models.Interfaces;

namespace HomeTasks.Business.Family
{
    public class FamilyBusiness : IFamilyBusiness
    {
        private readonly IFamilyData _data;
        public FamilyBusiness(IFamilyData data)
        {
            _data = data;
        }

        public FamilyRegisterNewResponseModel RegisterNew(FamilyRegisterNewRequestModel request)
        {
            try
            {
                return _data.RegisterNew(request);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}