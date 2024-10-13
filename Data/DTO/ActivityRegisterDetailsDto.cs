namespace RafahiaBlazorApp.Data.DTO
{
    public class ActivityRegisterDetailsDto
    {
        public string? UserID { get; set; }
        public string? UserName { get; set; }
        public string NameIctivity { get; set; }
        public string? PhoneIctivity { get; set; }
        public string? ContryIctivity { get; set; }
        public string? AddressIctivity { set; get; }
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public string? DescriptionIctivity { get; set; }
        public string? StarsIctivity { get; set; }
        public bool? restaurant { get; set; }
        public bool? parking { get; set; }
        public bool? swimmingpool { get; set; }
        public string? ImageActivity { get; set; }
    }
}
