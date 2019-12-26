namespace DecoratorDesignPattern
{
    public class MicrosoftExamReBookingDecoratorComponent : MicrosoftExamBookingDecorator
    {
        public MicrosoftExamReBookingDecoratorComponent(MicrosoftExamVoucherComponent theComponent) : base(theComponent)
        {
        }

        public override double CalculateTotalInvoice()
        {
            var regularPrice = base.CalculateTotalInvoice();
            return regularPrice * 0.9;
        }
    }
}
