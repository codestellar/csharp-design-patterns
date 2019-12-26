namespace DecoratorDesignPattern
{
    public class MicrosoftExamPremiumBookingDecoratorComponent : MicrosoftExamBookingDecorator
    {
        public MicrosoftExamPremiumBookingDecoratorComponent(MicrosoftExamVoucherComponent theComponent) : base(theComponent)
        {
        }

        public override double CalculateTotalInvoice()
        {
            var regularPrice = base.CalculateTotalInvoice();
            return regularPrice * 0.8;
        }
    }
}
