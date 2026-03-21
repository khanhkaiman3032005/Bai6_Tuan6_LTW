using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;
namespace Bai6_Tuan6_LTW.Models
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Không làm gì cả, chỉ trả về thành công
            return Task.CompletedTask;
        }
    }
}
