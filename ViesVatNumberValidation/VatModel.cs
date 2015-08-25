using System;

namespace CheckServices
{
    /// <summary>
    /// The VIES VAT data model returned by VIES Services.
    /// </summary>
    public class VatModel
    {
        #region private Fields
        //------------------------------------------------------
        //
        //  private Fields
        //
        //------------------------------------------------------
        protected String countryCode;
        protected String vatNumber;
        protected DateTime requestDate;
        protected bool valid;
        protected String name;
        protected String address;
        #endregion private Fields

        #region public Properties

        //------------------------------------------------------
        //
        //  public Properties
        //
        //------------------------------------------------------

        /// <summary>
        /// 
        /// </summary>
        public string CountryCode
        {
            get { return countryCode; }
            set { countryCode = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string VatNumber
        {
            get { return vatNumber; }
            set { vatNumber = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public DateTime RequestDate
        {
            get { return requestDate; }
            set { requestDate = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Valid
        {
            get { return valid; }
            set { valid = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        #endregion public Properties

        #region Constructors

        //------------------------------------------------------
        //
        //  Constructors
        //
        //------------------------------------------------------
       
        /// <summary>
        /// Constructor of VIES VAT model
        /// </summary>
        public VatModel(String countryCode, String vatNumber,
                            DateTime requestDate, bool valid,
                            String name, String address)
        {
            this.countryCode = countryCode;
            this.vatNumber = vatNumber;
            this.requestDate = requestDate;
            this.name = name;
            this.address = address;
            this.valid = valid;
        }

        #endregion Constructors
    }
}
