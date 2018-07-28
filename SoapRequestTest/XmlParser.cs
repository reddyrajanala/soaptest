using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace SoapRequestTest
{
    public class RateInitialAmountBalancesResult
    {
        public string Rate { get; set; }
        public string InitialAmount { get; set; }
        public List<AccountBalance> AccountBalances { get; set; } = new List<AccountBalance>();
    }

    public class AccountBalance
    {
        public string BalTypeValue { get; set; }
        public string CurAmt { get; set; }
    }

    public class XmlParser
    {
        public static RateInitialAmountBalancesResult Parse(string responseXml)
        {

            XDocument xDocument = XDocument.Parse(responseXml);
            XNamespace headNameSpace = "http://www.fhnc.com/emm/1";

            var accountRateBalanceResult = new RateInitialAmountBalancesResult();

            //get Initial Amount
            var initialAmts = xDocument.Descendants(headNameSpace + "InitialAmt").ToArray();

            var amtElement = initialAmts.Select(x => x.Element(headNameSpace + "Amt")).FirstOrDefault();

            if (amtElement != null)
            {
                accountRateBalanceResult.InitialAmount = amtElement.Value;
            }

            //get Rate --CREDIT only
            var intRateDataGroups = xDocument.Descendants(headNameSpace + "IntRateDataGroup").ToArray();
            foreach (var intRateDataGroup in intRateDataGroups)
            {
                var intRateDatas = intRateDataGroup.Descendants(headNameSpace + "IntRateData").ToList();
                foreach (var intRateData in intRateDatas)
                {
                    var intRateCategory = intRateData.Element(headNameSpace + "IntRateCategory");
                    if (intRateCategory != null && intRateCategory.Value == "CREDIT")
                    {
                        var rateMatrixTiers = intRateData.Descendants(headNameSpace + "RateMatrixTiers").ToList();
                        var RateMatrixTier = rateMatrixTiers.Select(x => x.Element(headNameSpace + "RateMatrixTier"));
                        accountRateBalanceResult.Rate = RateMatrixTier.Select(x => x.Element(headNameSpace + "Rate").Value).FirstOrDefault();
                    }
                }
            }

            //get AccountBalances
            var accountBalances = xDocument.Descendants(headNameSpace + "AcctBalances").ToArray();
            foreach (var accountBalance in accountBalances)
            {
                var acctBalences = accountBalance.Descendants(headNameSpace + "AcctBal").ToArray();

                foreach (var acctBalance in acctBalences)
                {
                    var balance = new AccountBalance
                    {
                        BalTypeValue = acctBalance.Element(headNameSpace + "BalType").Element(headNameSpace + "BalTypeValue").Value,
                        CurAmt = acctBalance.Element(headNameSpace + "CurAmt").Element(headNameSpace + "Amt").Value
                    };

                    accountRateBalanceResult.AccountBalances.Add(balance);
                }
            }

            return accountRateBalanceResult;
        }
    }
}