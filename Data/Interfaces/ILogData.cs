using AzureFunctionsHttpTemplate.Models;

namespace AzureFunctionsHttpTemplate.Data.Interfaces
{
    public interface ILogData
    {
        Task CreateLog(Log newLog);
    }
}