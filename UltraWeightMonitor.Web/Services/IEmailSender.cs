using System.Threading.Tasks;

namespace UltraWeightMonitor.Web.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
