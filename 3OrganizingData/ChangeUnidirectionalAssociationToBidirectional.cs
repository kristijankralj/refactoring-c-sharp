using System;

namespace OrganizingData
{
    public class ChangeUnidirectionalAssociationToBidirectional
    {
        class Invoice
        {
            private Supplier _supplier;

            public Invoice(Supplier supplier)
            {
                _supplier = supplier;
            }

            public int InvoiceId { get; set; }
            public int UserId { get; set; }
            public DateTime InvoiceDate { get; set; }
            public decimal Total { get; set; }
        }

        class Supplier
        {
            public int SupplierId { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
        }
    }
}
