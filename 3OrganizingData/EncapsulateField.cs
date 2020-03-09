using System;

namespace OrganizingData
{
    public class EncapsulateField
    {
        class Invoice
        {
            public Supplier _supplier;

            public Invoice(Supplier supplier)
            {
                _supplier = supplier;
            }
        }

        class Supplier
        {
            public void ChangeSupplierOnInvoice(Invoice invoice)
            {
                invoice._supplier = this;
            }
        }
    }
}
