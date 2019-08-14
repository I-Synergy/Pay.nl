namespace PayNL.API.PaymentProfile.GetAll
{
    public class Response : ResponseBase
    {
        public Objects.PaymentProfile[] PaymentProfiles { get; set; }
    }
}
