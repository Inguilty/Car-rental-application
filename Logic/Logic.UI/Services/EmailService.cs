using System.Threading.Tasks;
using Microsoft.AspNet.Identity;

namespace Logic.UI.Services
{
    public class EmailService : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            return Task.FromResult(0);
        }
    }
}
