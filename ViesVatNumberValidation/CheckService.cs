using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckServices
{
    /// <summary>
    /// Service for correct data model
    /// </summary>
    class CheckService 
    {
        /// <summary>
        /// VatModelApprox
        /// </summary>
        public static VatModelApprox getDetails(string countryCode, string vatNumber, string requesterCountryCode, string requesterVatNumber)
        {
            string traderName = null;
            string traderCompanyType = null;
            string traderStreet = null;
            string traderPostcode = null;
            string traderCity = null;
            bool valid;
            string traderAddress = null;
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

            ViesVatNumberValidation.eu.europa.ec.checkVatService checkVatService = new ViesVatNumberValidation.eu.europa.ec.checkVatService();
            #region requestDate
            DateTime requestDate = checkVatService.checkVatApprox(
                ref countryCode,
                ref vatNumber,
                ref traderName,
                ref traderCompanyType,
                ref traderStreet,
                ref traderPostcode,
                ref traderCity,
                requesterCountryCode,
                requesterVatNumber,
                out valid,
                out traderAddress,
                out traderNameMatch,
                out traderNameMatchSpecified,
                out traderCompanyTypeMatch,
                out traderCompanyTypeMatchSpecified,
                out traderStreetMatch,
                out traderStreetMatchSpecified,
                out traderPostcodeMatch,
                out traderPostcodeMatchSpecified,
                out traderCityMatch,
                out traderCityMatchSpecified,
                out requestIdentifier);
            #endregion requestDate

            #region viesVAT
            VatModelApprox viesVAT = new VatModelApprox(
                countryCode,
                vatNumber,
                traderName,
                traderCompanyType,
                traderStreet,
                traderPostcode,
                traderCity,
                requesterCountryCode,
                requesterVatNumber,
                valid,
                requestDate,
                traderAddress,
                traderNameMatch,
                traderNameMatchSpecified,
                traderCompanyTypeMatch,
                traderCompanyTypeMatchSpecified,
                traderStreetMatch,
                traderStreetMatchSpecified,
                traderPostcodeMatch,
                traderPostcodeMatchSpecified,
                traderCityMatch,
                traderCityMatchSpecified,
                requestIdentifier);
            #endregion viesVAT

            return viesVAT;
        }

        /// <summary>
        /// VatModel
        /// </summary>
        public static VatModel getDetails(string countryCode, string vatNumber)
        {
            bool valid;
            string name;
            string address;

            ViesVatNumberValidation.eu.europa.ec.checkVatService checkVatService = new ViesVatNumberValidation.eu.europa.ec.checkVatService();
            DateTime requestDate = checkVatService.checkVat(ref countryCode, ref vatNumber, out valid, out name, out address);
            VatModel viesVAT = new VatModel(countryCode, vatNumber, requestDate, valid, name, address);
            
            return viesVAT;
        }
        
    }
}
