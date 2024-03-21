using AzureFunctionsHttpTemplate.Data.Interfaces;
using AzureFunctionsHttpTemplate.Models;

namespace AzureFunctionsHttpTemplate.Data
{
    public class LogData(ApplicationDbContext context) : ILogData
    {
        public async Task CreateLog(Log newLog)
        {
            await context.Logs.AddAsync(newLog);
            await context.SaveChangesAsync();
        }
    }
}
