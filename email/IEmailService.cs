namespace EmailSenderProgram.email
{
    public interface IEmailService
    {
        void SendEmail(string email, EmailType type);
    }
}