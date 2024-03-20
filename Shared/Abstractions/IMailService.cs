namespace Shared.Abstractions
{
    public interface IMailService
    {
        Task SendMessageAsync(string to, string subject, string body);
    }
}
