using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suites
{
    [Serializable]
    public enum PaymentProcessorSequenceType
    {
        Invalid,
        GiftCardDeposit,
        StoreCardDeposit,
        TeleCheckDeposit,
        WireTransferDeposit,
        PaperCheckDeposit,
        GiftCertificateDeposit,
        CreditCardDeposit,
        DepositTotal,

        GlobalAuthorization,
        GiftCardAuthorization,
        StoreCardAuthorization,
        PurchaseOrderAuthorization,
        WireTransferAuthorization,
        PaperCheckAuthorization,
        GiftCertificationAuthorization,
        AccountReceivableAuthorization,
        CreditCardAuthorization,
        TeleCheckAuthorization,
        NoTenderAuthorization,
    }
}
