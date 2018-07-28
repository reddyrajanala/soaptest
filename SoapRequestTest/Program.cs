using System;

namespace SoapRequestTest
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Run test!");


            var responseXml = GetTestResponse();


            var rateInitialAmountBalancesResult = XmlParser.Parse(responseXml);

            Console.WriteLine($"Rate: {rateInitialAmountBalancesResult.Rate}");
            Console.WriteLine($"InitialAmount: {rateInitialAmountBalancesResult.InitialAmount}");


            Console.WriteLine("Account Balances:");
            Console.WriteLine("-----------------------");
            foreach (var accountBalance in rateInitialAmountBalancesResult.AccountBalances)
            {
                Console.WriteLine($"{accountBalance.BalTypeValue} {accountBalance.CurAmt}");
            }
            Console.WriteLine("-----------------------");

            //            var soapHelper = new SoapHelper();
            //
            //            var rate = soapHelper.GetRate();
            //
            //            Console.WriteLine($"Rate is {rate}");
            //
            Console.ReadKey();


        }



        private static string GetTestResponse()
        {
            return @"<?xml version=""1.0"" encoding=""UTF-8""?>
<soapenv:Envelope xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:com=""http://tempuri.org/com.ffusion.webservices.api.ftb.Authenticate"" xmlns:date=""http://exslt.org/dates-and-times"" xmlns:exsl=""http://exslt.org/common"" xmlns:fhn=""http://www.fhnc.com/emm/1"" xmlns:math=""http://exslt.org/math"" xmlns:mes=""http://MessageView/"" xmlns:n=""http://tempuri.org/com.ffusion.webservices.api.ftb.Authenticate"" xmlns:ns5=""http://www.themindelectric.com/package/com.ffusion.webservices.api.ftb/"" xmlns:set=""http://exslt.org/sets"" xmlns:xsd4xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
   <soapenv:Header />
   <soapenv:Body>
      <fhn:AcctGetRs>
         <fhn:Stat>
            <fhn:StatCd>Successful</fhn:StatCd>
            <fhn:ServerStatCd>64000</fhn:ServerStatCd>
            <fhn:ServerTimestamp>2018-07-27T09:37:25-04:00</fhn:ServerTimestamp>
            <fhn:TraceId>692512661</fhn:TraceId>
         </fhn:Stat>
         <fhn:RqUID>da46a3b2-5ffe-4d4b-ad9c-d5209f2a28b3</fhn:RqUID>
         <fhn:AcctRec>
            <fhn:AcctId>710001216506</fhn:AcctId>
            <fhn:DepAcctInfo>
               <fhn:AcctType>
                  <fhn:AcctTypeValue>DDA</fhn:AcctTypeValue>
               </fhn:AcctType>
               <fhn:ProductIdent>67</fhn:ProductIdent>
               <fhn:CurCd>
                  <fhn:CurCdValue>USD</fhn:CurCdValue>
               </fhn:CurCd>
               <fhn:Desc>BARRON COLLIER PARTN</fhn:Desc>
               <fhn:AltAcctIdentifiers>
                  <fhn:AcctIdent>
                     <fhn:AcctIdentType>AcctNum</fhn:AcctIdentType>
                     <fhn:AcctIdentValue>710001216506</fhn:AcctIdentValue>
                  </fhn:AcctIdent>
               </fhn:AltAcctIdentifiers>
               <fhn:FIData>
                  <fhn:CurrentBranch>
                     <fhn:BranchIdent>6071</fhn:BranchIdent>
                  </fhn:CurrentBranch>
                  <fhn:OriginalBranch>
                     <fhn:BranchIdent>6071</fhn:BranchIdent>
                  </fhn:OriginalBranch>
               </fhn:FIData>
               <fhn:IntRateDataGroup>
                  <fhn:IntRateData>
                     <fhn:RateMatrixTiers>
                        <fhn:RateMatrixTier>
                           <fhn:Rate>1.85000</fhn:Rate>
                        </fhn:RateMatrixTier>
                     </fhn:RateMatrixTiers>
                     <fhn:IntRateCategory>CREDIT</fhn:IntRateCategory>
                     <fhn:CapFreq>
                        <fhn:RecurType>Monthly</fhn:RecurType>
                        <fhn:DayOfMonth>31</fhn:DayOfMonth>
                     </fhn:CapFreq>
                     <fhn:IntPlan>58</fhn:IntPlan>
                     <fhn:CompoundFreq>97</fhn:CompoundFreq>
                  </fhn:IntRateData>
                  <fhn:IntRateData>
                     <fhn:RateMatrixTiers>
                        <fhn:RateMatrixTier>
                           <fhn:Tier>01</fhn:Tier>
                           <fhn:Margin>0.05000</fhn:Margin>
                           <fhn:ExpDt>2019-05-31T00:00:00</fhn:ExpDt>
                        </fhn:RateMatrixTier>
                     </fhn:RateMatrixTiers>
                     <fhn:IntRateCategory>BONUS</fhn:IntRateCategory>
                  </fhn:IntRateData>
               </fhn:IntRateDataGroup>
               <fhn:InitialAmt>
                  <fhn:Amt>380065.04</fhn:Amt>
                  <fhn:CurCd>
                     <fhn:CurCdValue>USD</fhn:CurCdValue>
                  </fhn:CurCd>
               </fhn:InitialAmt>
               <fhn:RelMgrs>
                  <fhn:RelMgr>
                     <fhn:RelMgrIdent>60710</fhn:RelMgrIdent>
                     <fhn:Rank>1</fhn:Rank>
                  </fhn:RelMgr>
               </fhn:RelMgrs>
               <fhn:AcctBalances>
                  <fhn:AcctBal>
                     <fhn:BalType>
                        <fhn:BalTypeValue>Ledger</fhn:BalTypeValue>
                     </fhn:BalType>
                     <fhn:CurAmt>
                        <fhn:Amt>138801.79</fhn:Amt>
                     </fhn:CurAmt>
                  </fhn:AcctBal>
                  <fhn:AcctBal>
                     <fhn:BalType>
                        <fhn:BalTypeValue>Collected</fhn:BalTypeValue>
                     </fhn:BalType>
                     <fhn:CurAmt>
                        <fhn:Amt>138801.79</fhn:Amt>
                     </fhn:CurAmt>
                  </fhn:AcctBal>
                  <fhn:AcctBal>
                     <fhn:BalType>
                        <fhn:BalTypeValue>MemoDebits</fhn:BalTypeValue>
                     </fhn:BalType>
                     <fhn:CurAmt>
                        <fhn:Amt>138801.79</fhn:Amt>
                     </fhn:CurAmt>
                  </fhn:AcctBal>
               </fhn:AcctBalances>
               <fhn:LastActivityDt>2018-07-26</fhn:LastActivityDt>
               <fhn:AcctCodes>
                  <fhn:DailyBalSelectFlag>60DaysBalance</fhn:DailyBalSelectFlag>
                  <fhn:TrnHistInd>true</fhn:TrnHistInd>
                  <fhn:AbandonedFundsCd>FL</fhn:AbandonedFundsCd>
                  <fhn:TrnAdviceInd>false</fhn:TrnAdviceInd>
                  <fhn:ZeroBalCd>Investment</fhn:ZeroBalCd>
               </fhn:AcctCodes>
               <fhn:LastStmtDt>2018-06-29</fhn:LastStmtDt>
               <fhn:LastBatchProcessDt>2018-07-26</fhn:LastBatchProcessDt>
               <fhn:LastFileMaintenanceDt>2018-07-03</fhn:LastFileMaintenanceDt>
               <fhn:AcctPricings>
                  <fhn:AcctPricing>
                     <fhn:Fees>
                        <fhn:Fee>
                           <fhn:FeePlan>07</fhn:FeePlan>
                           <fhn:FeeType>SvcChg</fhn:FeeType>
                           <fhn:FeeWaiver>
                              <fhn:WaiveCd>CW</fhn:WaiveCd>
                              <fhn:TimeFrame />
                           </fhn:FeeWaiver>
                        </fhn:Fee>
                     </fhn:Fees>
                  </fhn:AcctPricing>
               </fhn:AcctPricings>
               <fhn:StmtPref>
                  <fhn:StmtHandling>Regular</fhn:StmtHandling>
                  <fhn:StmtCopyCount>1</fhn:StmtCopyCount>
                  <fhn:FormMedia>I</fhn:FormMedia>
               </fhn:StmtPref>
               <fhn:CustSumm>
                  <fhn:OrgCategories>
                     <fhn:OrgCategoryCodes>
                        <fhn:NAICSData>
                           <fhn:NAICSValue>000000</fhn:NAICSValue>
                        </fhn:NAICSData>
                        <fhn:SIC>0000</fhn:SIC>
                     </fhn:OrgCategoryCodes>
                  </fhn:OrgCategories>
                  <fhn:EmployeeInd>false</fhn:EmployeeInd>
                  <fhn:IssuedIdent>
                     <fhn:IssuedIdentType>TaxIdNb</fhn:IssuedIdentType>
                     <fhn:IssuedIdentValue>650247894</fhn:IssuedIdentValue>
                  </fhn:IssuedIdent>
                  <fhn:Language>ENU</fhn:Language>
                  <fhn:Branding>CB</fhn:Branding>
               </fhn:CustSumm>
               <fhn:TaxDetails>
                  <fhn:WithholdingType>CertifiedValid</fhn:WithholdingType>
               </fhn:TaxDetails>
               <fhn:AcctTitleDataGroup>
                  <fhn:AcctTitleData>
                     <fhn:AcctTitles>
                        <fhn:AcctTitle>BARRON COLLIER PARTNERSHIP LLLP</fhn:AcctTitle>
                     </fhn:AcctTitles>
                     <fhn:ContactMethods>
                        <fhn:ContactMethod>
                           <fhn:ContactMethodId>00</fhn:ContactMethodId>
                           <fhn:PostAddr>
                              <fhn:AddrType>ST</fhn:AddrType>
                              <fhn:Addr1>2600 GOLDEN GATE PARKWAY</fhn:Addr1>
                              <fhn:City>NAPLES</fhn:City>
                              <fhn:StateProv>FL</fhn:StateProv>
                              <fhn:PostalCd>341050000</fhn:PostalCd>
                           </fhn:PostAddr>
                           <fhn:ContactValidTimeFrame>
                              <fhn:StartDt>1911-11-11T00:00:00Z</fhn:StartDt>
                              <fhn:EndDt>2799-12-31T00:00:00Z</fhn:EndDt>
                           </fhn:ContactValidTimeFrame>
                           <fhn:UpdDt>2018-05-25T00:00:00Z</fhn:UpdDt>
                        </fhn:ContactMethod>
                     </fhn:ContactMethods>
                  </fhn:AcctTitleData>
               </fhn:AcctTitleDataGroup>
               <fhn:OwnershipInfo>
                  <fhn:OwnershipDataGroup>
                     <fhn:OwnershipData>
                        <fhn:OwnerType>PackageCode</fhn:OwnerType>
                        <fhn:OwnerValue>FULL</fhn:OwnerValue>
                     </fhn:OwnershipData>
                     <fhn:OwnershipData>
                        <fhn:OwnerType>CustProfitGrp</fhn:OwnerType>
                        <fhn:OwnerValue>1N</fhn:OwnerValue>
                     </fhn:OwnershipData>
                     <fhn:OwnershipData>
                        <fhn:OwnerType>CostCenter</fhn:OwnerType>
                        <fhn:OwnerValue>6071</fhn:OwnerValue>
                     </fhn:OwnershipData>
                  </fhn:OwnershipDataGroup>
                  <fhn:FundsOwnerCd>Commercial</fhn:FundsOwnerCd>
                  <fhn:FundsSubOwnerCd>Business</fhn:FundsSubOwnerCd>
               </fhn:OwnershipInfo>
               <fhn:OpenInfo>
                  <fhn:OpenDt>2007-08-01</fhn:OpenDt>
                  <fhn:OpenReason>CB</fhn:OpenReason>
               </fhn:OpenInfo>
               <fhn:ConfidentialCd>false</fhn:ConfidentialCd>
               <fhn:SigRequirements>
                  <fhn:SigRequirement>
                     <fhn:NumSigRequired>1</fhn:NumSigRequired>
                  </fhn:SigRequirement>
               </fhn:SigRequirements>
               <fhn:IntDispDataGroup>
                  <fhn:IntDispData>
                     <fhn:IntDisp>Redeposit</fhn:IntDisp>
                     <fhn:IntRateCategory>CREDIT</fhn:IntRateCategory>
                  </fhn:IntDispData>
               </fhn:IntDispDataGroup>
               <fhn:DebitPayOptions>
                  <fhn:OutOfBoundsProcPlan>50</fhn:OutOfBoundsProcPlan>
               </fhn:DebitPayOptions>
               <fhn:ProofOfDepFloatInd>true</fhn:ProofOfDepFloatInd>
               <fhn:BulkFileLoc>FTBMemphis</fhn:BulkFileLoc>
               <fhn:AnalysisAcctId>710001216506</fhn:AnalysisAcctId>
               <fhn:AnalysisCd>92</fhn:AnalysisCd>
            </fhn:DepAcctInfo>
            <fhn:AcctStat>
               <fhn:AcctStatCd>NoCheckActivity</fhn:AcctStatCd>
            </fhn:AcctStat>
         </fhn:AcctRec>
      </fhn:AcctGetRs>
   </soapenv:Body>
</soapenv:Envelope>";



        }
    }
}
