using HomeTasks.Models.Entities;

namespace HomeTasks.Models.Interfaces
{
    public interface IFamily
    {
        BaseResponse RegisterNew(BaseRequest request);
    }
}