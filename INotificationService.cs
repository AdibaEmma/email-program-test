namespace EmailSenderProgram
{
    public interface INotificationService
    {
        bool SendWelcomeMails();
        bool SendComebackMails();
    }
}