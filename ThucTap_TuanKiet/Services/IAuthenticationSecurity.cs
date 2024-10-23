namespace ThucTap_TuanKiet.Services
{
    public interface IAuthenticationSecurity
    {
        public string Login(string email, string password);
        public string ChangePassword(int id, string password);
        public string ResetPassword(int id);
    }
}
