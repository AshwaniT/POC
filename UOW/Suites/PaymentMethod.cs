using System;

namespace Suites
{
    [Serializable]
    public enum PaymentMethod 
    {
        None,
        TeleCheck,
        CreditCard,
        WireTransfer,
        PurchaseOrder,
        PaperCheck,
        GiftCertificate,
        GiftCard,
        StoreCard,
        AccountReceivable,
        TeleCheckDeposit,
        CreditCardDeposit,
        WireTransferDeposit,
        PurchaseOrderDeposit,
        PaperCheckDeposit,
        GiftCertificateDeposit,
        GiftCardDeposit,
        StoreCardDeposit,
        AccountReceivableDeposit,
        NoTender,
        Cash
    }
}
