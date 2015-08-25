using System;
using System.Xml.Linq;

namespace CheckServices
{
    /// <summary>
    /// The VIES VATapprox data model returned by VIES Services.
    /// </summary>
    public class VatModelApprox : VatModel
    {

        #region private Fields
        //------------------------------------------------------
        //
        //  private Fields
        //
        //------------------------------------------------------
        string traderName;
        string traderCompanyType;
        string traderStreet;
        string traderPostcode;
        string traderCity;
        string requesterCountryCode;
        string requesterVatNumber;
        string traderAddress;
        ViesVatNumberValidation.eu.europa.ec.matchCode traderNameMatch;
        bool traderNameMatchSpecified;
        ViesVatNumberValidation.eu.europa.ec.matchCode traderCompanyTypeMatch;
        bool traderCompanyTypeMatchSpecified;
        ViesVatNumberValidation.eu.europa.ec.matchCode traderStreetMatch;
        bool traderStreetMatchSpecified;
        ViesVatNumberValidation.eu.europa.ec.matchCode traderPostcodeMatch;
        bool traderPostcodeMatchSpecified;
        ViesVatNumberValidation.eu.europa.ec.matchCode traderCityMatch;
        bool traderCityMatchSpecified;
        string requestIdentifier;
        
        #endregion private Fields

        #region public Properties

        //------------------------------------------------------
        //
        //  public Properties
        //
        //------------------------------------------------------

        public string TraderName
        {
            get { return traderName; }
            set { traderName = value; }
        }
        
        public string TraderCompanyType
        {
            get { return traderCompanyType; }
            set { traderCompanyType = value; }
        }

        public string TraderStreet
        {
            get { return traderStreet; }
            set { traderStreet = value; }
        }
       
        public string TraderPostcode
        {
            get { return traderPostcode; }
            set { traderPostcode = value; }
        }
        
        public string TraderCity
        {
            get { return traderCity; }
            set { traderCity = value; }
        }
        
        public string RequesterCountryCode
        {
            get { return requesterCountryCode; }
            set { requesterCountryCode = value; }
        }
       
        public string RequesterVatNumber
        {
            get { return requesterVatNumber; }
            set { requesterVatNumber = value; }
        }
        
        public string TraderAddress
        {
            get { return traderAddress; }
            set { traderAddress = value; }
        }

        public ViesVatNumberValidation.eu.europa.ec.matchCode TraderNameMatch
        {
            get { return traderNameMatch; }
            set { traderNameMatch = value; }
        }

        public bool TraderNameMatchSpecified
        {
            get { return traderNameMatchSpecified; }
            set { traderNameMatchSpecified = value; }
        }

        public ViesVatNumberValidation.eu.europa.ec.matchCode TraderCompanyTypeMatch
        {
            get { return traderCompanyTypeMatch; }
            set { traderCompanyTypeMatch = value; }
        }
       
        public bool TraderCompanyTypeMatchSpecified
        {
            get { return traderCompanyTypeMatchSpecified; }
            set { traderCompanyTypeMatchSpecified = value; }
        }

        public ViesVatNumberValidation.eu.europa.ec.matchCode TraderStreetMatch
        {
            get { return traderStreetMatch; }
            set { traderStreetMatch = value; }
        }

        public bool TraderStreetMatchSpecified
        {
            get { return traderStreetMatchSpecified; }
            set { traderStreetMatchSpecified = value; }
        }

        public ViesVatNumberValidation.eu.europa.ec.matchCode TraderPostcodeMatch
        {
            get { return traderPostcodeMatch; }
            set { traderPostcodeMatch = value; }
        }

        public bool TraderPostcodeMatchSpecified
        {
            get { return traderPostcodeMatchSpecified; }
            set { traderPostcodeMatchSpecified = value; }
        }

        public ViesVatNumberValidation.eu.europa.ec.matchCode TraderCityMatch
        {
            get { return traderCityMatch; }
            set { traderCityMatch = value; }
        }

        public bool TraderCityMatchSpecified
        {
            get { return traderCityMatchSpecified; }
            set { traderCityMatchSpecified = value; }
        }

        public string RequestIdentifier
        {
            get { return requestIdentifier; }
            set { requestIdentifier = value; }
        }

        #endregion public Properties

        #region Constructors

        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------
        public VatModelApprox(
            String countryCode,
            string vatNumber,
            string traderName,
            string traderCompanyType,
            string traderStreet,
            string traderPostcode,
            string traderCity,
            string requesterCountryCode,
            string requesterVatNumber,
            bool valid,
            DateTime requestDate,
            string traderAddress,
            ViesVatNumberValidation.eu.europa.ec.matchCode traderNameMatch,
            bool traderNameMatchSpecified,
            ViesVatNumberValidation.eu.europa.ec.matchCode traderCompanyTypeMatch,
            bool traderCompanyTypeMatchSpecified,
            ViesVatNumberValidation.eu.europa.ec.matchCode traderStreetMatch,
            bool traderStreetMatchSpecified,
            ViesVatNumberValidation.eu.europa.ec.matchCode traderPostcodeMatch,
            bool traderPostcodeMatchSpecified,
            ViesVatNumberValidation.eu.europa.ec.matchCode traderCityMatch,
            bool traderCityMatchSpecified,
            string requestIdentifier) : base(
                    countryCode,
                    vatNumber,
                    requestDate,
                    valid,
                    traderName, 
                    traderStreet + " " + traderPostcode + ", " + traderCity)
            {
                this.countryCode = countryCode;
                this.vatNumber = vatNumber;
                this.traderName= traderName;
                this.traderCompanyType = traderCompanyType;
                this.traderStreet = traderStreet;
                this.traderPostcode = traderPostcode;
                this.traderCity = traderCity;
                this.requesterCountryCode = requesterCountryCode;
                this.requesterVatNumber = requesterVatNumber;
                this.valid = valid;
                this.requestDate = requestDate;
                this.traderAddress = traderAddress;
                this.traderNameMatch = traderNameMatch;
                this.traderNameMatchSpecified = traderNameMatchSpecified;
                this.traderCompanyTypeMatch = traderCompanyTypeMatch;
                this.traderCompanyTypeMatchSpecified = traderCompanyTypeMatchSpecified;
                this.traderStreetMatch = traderStreetMatch;
                this.traderStreetMatchSpecified = traderStreetMatchSpecified; 
                this.traderPostcodeMatch = traderPostcodeMatch;
                this.traderPostcodeMatchSpecified = traderPostcodeMatchSpecified;
                this.traderCityMatch = traderCityMatch;
                this.traderCityMatchSpecified = traderCityMatchSpecified;
                this.requestIdentifier = requestIdentifier;
            }
        #endregion Constructors

        #region public Methods
        //------------------------------------------------------
        //
        //  public Methods
        //
        //------------------------------------------------------

        /// <summary>
        /// Create string from response
        /// </summary>
        public string MakeText()
        {
            string data;
            data =
                "Results from EU VIES VAT Services: " + Environment.NewLine + Environment.NewLine +
                "vatNumber: " + vatNumber + Environment.NewLine +
                "countryCode: " + countryCode + Environment.NewLine +
                "valid: " + (valid == true ? "VALID" : "INVALID") + Environment.NewLine +
                "traderName: " + traderName + Environment.NewLine +
                "traderCompanyType: " + traderCompanyType + Environment.NewLine +
                "traderStreet: " + traderStreet + Environment.NewLine +
                "traderPostcode: " + traderPostcode + Environment.NewLine +
                "traderCity: " + traderCity + Environment.NewLine +
                "traderAddress" + traderAddress + Environment.NewLine +
                Environment.NewLine + 
                "requesterCountryCode: " + requesterCountryCode + Environment.NewLine +
                "requesterVatNumber: " + requesterVatNumber + Environment.NewLine +
                "requestDate: " + requestDate + Environment.NewLine +
                Environment.NewLine +
                "traderNameMatch: " + traderNameMatch + Environment.NewLine +
                "traderNameMatchSpecified: " + traderNameMatchSpecified + Environment.NewLine +
                "traderCompanyTypeMatch: " + traderCompanyTypeMatch + Environment.NewLine +
                "traderCompanyTypeMatchSpecified: " + traderCompanyTypeMatchSpecified + Environment.NewLine +
                "traderStreetMatch: " + traderStreetMatch + Environment.NewLine +
                "traderStreetMatchSpecified: " + traderStreetMatchSpecified + Environment.NewLine +
                "traderPostcodeMatch: " + traderPostcodeMatch + Environment.NewLine +
                "traderPostcodeMatchSpecified: " + traderPostcodeMatchSpecified + Environment.NewLine +
                "traderCityMatch: " + traderCityMatch + Environment.NewLine +
                "traderCityMatchSpecified: " + traderCityMatchSpecified + Environment.NewLine +
                "requestIdentifier: " + requestIdentifier;
            return data;
        }
        
        /// <summary>
        ///Create xml document from response
        /// </summary>
        public XDocument MakeXml()
        {
            XDocument XmlDoc = new XDocument(
            new XComment("checkVatApprox Validation response content"),
            new XElement("checkVatApprox",
                new XElement("vatNumber", vatNumber),
                new XElement("countryCode", countryCode),
                new XElement("valid", valid),
                new XElement("traderName", traderName),
                new XElement("traderCompanyType", traderCompanyType),
                new XElement("traderStreet", traderStreet),
                new XElement("traderPostcode", traderPostcode),
                new XElement("traderCity", traderCity),
                new XElement("traderAddress", traderAddress),
                new XElement("requesterCountryCode", requesterCountryCode),
                new XElement("requesterVatNumber", requesterVatNumber),
                new XElement("requestDate", requestDate),
                new XElement("traderNameMatch", traderNameMatch),
                new XElement("traderNameMatchSpecified", traderNameMatchSpecified),
                new XElement("traderCompanyTypeMatchSpecified", traderCompanyTypeMatchSpecified),
                new XElement("traderStreetMatch", traderStreetMatch),
                new XElement("traderStreetMatchSpecified", traderStreetMatchSpecified),
                new XElement("traderPostcodeMatch", traderPostcodeMatch),
                new XElement("traderPostcodeMatchSpecified", traderPostcodeMatchSpecified),
                new XElement("traderCityMatch", traderCityMatch),
                new XElement("traderCityMatchSpecified", traderCityMatchSpecified),
                new XElement("requestIdentifier", requestIdentifier)
                
              )
              );
            return XmlDoc;
              
        }
      
        #endregion public Methods

    }
}
