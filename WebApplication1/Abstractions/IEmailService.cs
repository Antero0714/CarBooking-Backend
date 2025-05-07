namespace WebApplication1.Abstractions
{
    public interface IEmailService
    {
        Task SendAsync(string to, string subject, string body);
    }
}