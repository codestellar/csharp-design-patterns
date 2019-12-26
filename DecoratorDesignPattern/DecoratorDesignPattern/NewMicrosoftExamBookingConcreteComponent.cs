namespace DecoratorDesignPattern
{
    public class NewMicrosoftExamBookingConcreteComponent : MicrosoftExamVoucherComponent
    {
        public override double CalculateTotalInvoice()
        {
            return (VoucherCount * VoucherPrice);
        }
    }
}
