namespace DecoratorDesignPattern
{
    public class MicrosoftExamBookingDecorator : MicrosoftExamVoucherComponent
    {
        private MicrosoftExamVoucherComponent _theComponent;

        public MicrosoftExamBookingDecorator(MicrosoftExamVoucherComponent theComponent)
        {
            _theComponent = theComponent;
        }

        public override double CalculateTotalInvoice()
        {
            return _theComponent.CalculateTotalInvoice();
        }
    }
}
