namespace LabTask_UserDeets
{
    internal class Contact
    {
        public string PhoneNumber { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return PhoneNumber+" "+Email+" "+FullName+" "+Address;
        }
    }
}