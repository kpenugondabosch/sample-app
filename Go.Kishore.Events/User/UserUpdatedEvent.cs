namespace Go.Kishore.Events.User
{
    public record UserUpdatedEvent
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public bool? IsActive { get; set; }
        public string Language { get; set; }

        public UserUpdatedEvent()
        {

        }
        public UserUpdatedEvent(Guid id, string firstName, string lastName, string displayName, string userName, string email, string countryCode, string phoneNumber, bool? isActive)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DisplayName = displayName;
            UserName = userName;
            Email = email;
            CountryCode = countryCode;
            PhoneNumber = phoneNumber;
            IsActive = isActive;
        }
    }
}
