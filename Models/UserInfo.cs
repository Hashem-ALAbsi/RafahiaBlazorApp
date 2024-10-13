namespace RafahiaBlazorApp.Models
{
    public class UserInfo
    {
        [EmailAddress]
        public string Email { get; set; }
    }
}
