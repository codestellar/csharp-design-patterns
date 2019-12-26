namespace DecoratorDesignPattern
{
    public abstract class MicrosoftExamVoucherComponent
    {
        public int VoucherCount;
        public int VoucherPrice;
        public abstract double CalculateTotalInvoice();
    }
}
