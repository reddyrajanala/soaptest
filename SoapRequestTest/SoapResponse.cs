using System.Collections.Generic;
using System.Xml.Serialization;

namespace SoapRequestTest
{
    [XmlRoot(ElementName = "Stat", Namespace = "http://www.fhnc.com/emm/1")]
    public class Stat
    {
        [XmlElement(ElementName = "StatCd", Namespace = "http://www.fhnc.com/emm/1")]
        public string StatCd { get; set; }
        [XmlElement(ElementName = "ServerStatCd", Namespace = "http://www.fhnc.com/emm/1")]
        public string ServerStatCd { get; set; }
        [XmlElement(ElementName = "ServerTimestamp", Namespace = "http://www.fhnc.com/emm/1")]
        public string ServerTimestamp { get; set; }
        [XmlElement(ElementName = "TraceId", Namespace = "http://www.fhnc.com/emm/1")]
        public string TraceId { get; set; }
    }

    [XmlRoot(ElementName = "AcctType", Namespace = "http://www.fhnc.com/emm/1")]
    public class AcctType
    {
        [XmlElement(ElementName = "AcctTypeValue", Namespace = "http://www.fhnc.com/emm/1")]
        public string AcctTypeValue { get; set; }
    }

    [XmlRoot(ElementName = "CurCd", Namespace = "http://www.fhnc.com/emm/1")]
    public class CurCd
    {
        [XmlElement(ElementName = "CurCdValue", Namespace = "http://www.fhnc.com/emm/1")]
        public string CurCdValue { get; set; }
    }

    [XmlRoot(ElementName = "AcctIdent", Namespace = "http://www.fhnc.com/emm/1")]
    public class AcctIdent
    {
        [XmlElement(ElementName = "AcctIdentType", Namespace = "http://www.fhnc.com/emm/1")]
        public string AcctIdentType { get; set; }
        [XmlElement(ElementName = "AcctIdentValue", Namespace = "http://www.fhnc.com/emm/1")]
        public string AcctIdentValue { get; set; }
    }

    [XmlRoot(ElementName = "AltAcctIdentifiers", Namespace = "http://www.fhnc.com/emm/1")]
    public class AltAcctIdentifiers
    {
        [XmlElement(ElementName = "AcctIdent", Namespace = "http://www.fhnc.com/emm/1")]
        public AcctIdent AcctIdent { get; set; }
    }

    [XmlRoot(ElementName = "LowCurAmt", Namespace = "http://www.fhnc.com/emm/1")]
    public class LowCurAmt
    {
        [XmlElement(ElementName = "Amt", Namespace = "http://www.fhnc.com/emm/1")]
        public string Amt { get; set; }
    }

    [XmlRoot(ElementName = "HighCurAmt", Namespace = "http://www.fhnc.com/emm/1")]
    public class HighCurAmt
    {
        [XmlElement(ElementName = "Amt", Namespace = "http://www.fhnc.com/emm/1")]
        public string Amt { get; set; }
    }

    [XmlRoot(ElementName = "CurAmtRange", Namespace = "http://www.fhnc.com/emm/1")]
    public class CurAmtRange
    {
        [XmlElement(ElementName = "LowCurAmt", Namespace = "http://www.fhnc.com/emm/1")]
        public LowCurAmt LowCurAmt { get; set; }
        [XmlElement(ElementName = "HighCurAmt", Namespace = "http://www.fhnc.com/emm/1")]
        public HighCurAmt HighCurAmt { get; set; }
    }

    [XmlRoot(ElementName = "RateMatrixTier", Namespace = "http://www.fhnc.com/emm/1")]
    public class RateMatrixTier
    {
        [XmlElement(ElementName = "CurAmtRange", Namespace = "http://www.fhnc.com/emm/1")]
        public CurAmtRange CurAmtRange { get; set; }
        [XmlElement(ElementName = "Rate", Namespace = "http://www.fhnc.com/emm/1")]
        public string Rate { get; set; }
        [XmlElement(ElementName = "IntAPY", Namespace = "http://www.fhnc.com/emm/1")]
        public string IntAPY { get; set; }
        [XmlElement(ElementName = "Tier", Namespace = "http://www.fhnc.com/emm/1")]
        public string Tier { get; set; }
        [XmlElement(ElementName = "ExpDt", Namespace = "http://www.fhnc.com/emm/1")]
        public string ExpDt { get; set; }
    }

    [XmlRoot(ElementName = "RateMatrixTiers", Namespace = "http://www.fhnc.com/emm/1")]
    public class RateMatrixTiers
    {
        [XmlElement(ElementName = "RateMatrixTier", Namespace = "http://www.fhnc.com/emm/1")]
        public List<RateMatrixTier> RateMatrixTier { get; set; }
    }

    [XmlRoot(ElementName = "CapFreq", Namespace = "http://www.fhnc.com/emm/1")]
    public class CapFreq
    {
        [XmlElement(ElementName = "RecurType", Namespace = "http://www.fhnc.com/emm/1")]
        public string RecurType { get; set; }
        [XmlElement(ElementName = "DayOfMonth", Namespace = "http://www.fhnc.com/emm/1")]
        public string DayOfMonth { get; set; }
    }

    [XmlRoot(ElementName = "IntRateData", Namespace = "http://www.fhnc.com/emm/1")]
    public class IntRateData
    {
        [XmlElement(ElementName = "RateMatrixTiers", Namespace = "http://www.fhnc.com/emm/1")]
        public RateMatrixTiers RateMatrixTiers { get; set; }
        [XmlElement(ElementName = "IntRateCategory", Namespace = "http://www.fhnc.com/emm/1")]
        public string IntRateCategory { get; set; }
        [XmlElement(ElementName = "CapFreq", Namespace = "http://www.fhnc.com/emm/1")]
        public CapFreq CapFreq { get; set; }
        [XmlElement(ElementName = "IntPlan", Namespace = "http://www.fhnc.com/emm/1")]
        public string IntPlan { get; set; }
        [XmlElement(ElementName = "CompoundFreq", Namespace = "http://www.fhnc.com/emm/1")]
        public string CompoundFreq { get; set; }
        [XmlElement(ElementName = "CurrentIntRate", Namespace = "http://www.fhnc.com/emm/1")]
        public string CurrentIntRate { get; set; }
    }

    [XmlRoot(ElementName = "IntRateDataGroup", Namespace = "http://www.fhnc.com/emm/1")]
    public class IntRateDataGroup
    {
        [XmlElement(ElementName = "IntRateData", Namespace = "http://www.fhnc.com/emm/1")]
        public List<IntRateData> IntRateData { get; set; }
    }

    [XmlRoot(ElementName = "DepAcctInfo", Namespace = "http://www.fhnc.com/emm/1")]
    public class DepAcctInfo
    {
        [XmlElement(ElementName = "AcctType", Namespace = "http://www.fhnc.com/emm/1")]
        public AcctType AcctType { get; set; }
        [XmlElement(ElementName = "ProductIdent", Namespace = "http://www.fhnc.com/emm/1")]
        public string ProductIdent { get; set; }
        [XmlElement(ElementName = "CurCd", Namespace = "http://www.fhnc.com/emm/1")]
        public CurCd CurCd { get; set; }
        [XmlElement(ElementName = "Desc", Namespace = "http://www.fhnc.com/emm/1")]
        public string Desc { get; set; }
        [XmlElement(ElementName = "AltAcctIdentifiers", Namespace = "http://www.fhnc.com/emm/1")]
        public AltAcctIdentifiers AltAcctIdentifiers { get; set; }
        [XmlElement(ElementName = "IntRateDataGroup", Namespace = "http://www.fhnc.com/emm/1")]
        public IntRateDataGroup IntRateDataGroup { get; set; }
    }

    [XmlRoot(ElementName = "AcctRec", Namespace = "http://www.fhnc.com/emm/1")]
    public class AcctRec
    {
        [XmlElement(ElementName = "AcctId", Namespace = "http://www.fhnc.com/emm/1")]
        public string AcctId { get; set; }
        [XmlElement(ElementName = "DepAcctInfo", Namespace = "http://www.fhnc.com/emm/1")]
        public DepAcctInfo DepAcctInfo { get; set; }
    }

    [XmlRoot(ElementName = "AcctIntRateDataGetRs", Namespace = "http://www.fhnc.com/emm/1")]
    public class AcctIntRateDataGetRs
    {
        [XmlElement(ElementName = "Stat", Namespace = "http://www.fhnc.com/emm/1")]
        public Stat Stat { get; set; }
        [XmlElement(ElementName = "RqUID", Namespace = "http://www.fhnc.com/emm/1")]
        public string RqUID { get; set; }
        [XmlElement(ElementName = "AcctRec", Namespace = "http://www.fhnc.com/emm/1")]
        public AcctRec AcctRec { get; set; }
    }

    [XmlRoot(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class Body
    {
        [XmlElement(ElementName = "AcctIntRateDataGetRs", Namespace = "http://www.fhnc.com/emm/1")]
        public AcctIntRateDataGetRs AcctIntRateDataGetRs { get; set; }
    }

    [XmlRoot(ElementName = "Envelope", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
    public class AccountInformationResponseEnvelope
    {
        [XmlElement(ElementName = "Header", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public string Header { get; set; }
        [XmlElement(ElementName = "Body", Namespace = "http://schemas.xmlsoap.org/soap/envelope/")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "set", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Set { get; set; }
        [XmlAttribute(AttributeName = "math", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Math { get; set; }
        [XmlAttribute(AttributeName = "exsl", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Exsl { get; set; }
        [XmlAttribute(AttributeName = "date", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "fhn", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Fhn { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "mes", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Mes { get; set; }
        [XmlAttribute(AttributeName = "xsd4xsd", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsd4xsd { get; set; }
        [XmlAttribute(AttributeName = "com", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Com { get; set; }
        [XmlAttribute(AttributeName = "n", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string N { get; set; }
        [XmlAttribute(AttributeName = "ns5", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns5 { get; set; }
        [XmlAttribute(AttributeName = "soapenv", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Soapenv { get; set; }
    }

}

