namespace TestAppCore.DataLayerModels
{
    public class UserProfile
    {
        public int UserProfileID { get; set; }
        public Guid UserID { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string FirstLineAddress { get; set; }
        public string SecondLineAddress { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }
        public string MaritalStatus {  get; set; }
    }
}
