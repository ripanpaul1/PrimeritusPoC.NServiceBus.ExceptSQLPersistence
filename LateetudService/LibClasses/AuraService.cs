using LateetudService.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace LateetudService.LibClasses
{
    public class AuraService
    {
        public string GetAuraString(string XmlString, string RequestType)
        {
            return this.GetAuraString(XmlString, RequestType, null);
        }
        public string GetAuraString(string XmlString, string RequestType, string ConnectionString)
        {
            if (XmlString == null) return null;
            if (!XmlString.Contains("xml")) return null;
            try
            {
                if (string.IsNullOrWhiteSpace(RequestType)) return null;
                if (RequestType == "1")
                {
                    var vendor_AssignmentRecord_v13 = (Vendor_AssignmentRecord_v13)new XmlSerializer(typeof(Vendor_AssignmentRecord_v13)).Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(XmlString)));
                    if (vendor_AssignmentRecord_v13 == null) return null;
                    else
                    {
                        StringBuilder data = new StringBuilder();

                        #region assignment data
                        data.Append("[[[3_AssignmentIdentity:::" + vendor_AssignmentRecord_v13.AssignmentIdentity + "]]]");
                        data.Append("[[[3_AssignmentTypeName:::" + vendor_AssignmentRecord_v13.AssignmentTypeName + "]]]");
                        data.Append("[[[3_ClientReferenceNumber:::" + vendor_AssignmentRecord_v13.ClientAccountNumber + "]]]");
                        data.Append("[[[3_ClientCompanyID:::" + vendor_AssignmentRecord_v13.ClientCompanyID + "]]]");
                        data.Append("[[[3_ClientContact:::" + vendor_AssignmentRecord_v13.ClientContact + "]]]");
                        data.Append("[[[3_ClientName:::" + vendor_AssignmentRecord_v13.ClientName + "]]]");
                        data.Append("[[[3_CollateralType:::" + vendor_AssignmentRecord_v13.CollateralType + "]]]");
                        data.Append("[[[3_LoanNumber:::" + vendor_AssignmentRecord_v13.LoanNumber + "]]]");
                        data.Append("[[[3_LienHolder:::" + vendor_AssignmentRecord_v13.LienHolder + "]]]");
                        data.Append("[[[3_Make:::" + vendor_AssignmentRecord_v13.Make + "]]]");
                        data.Append("[[[3_Model:::" + vendor_AssignmentRecord_v13.Model + "]]]");
                        data.Append("[[[3_Vin:::" + vendor_AssignmentRecord_v13.Vin + "]]]");
                        data.Append("[[[3_Year:::" + vendor_AssignmentRecord_v13.Year + "]]]");
                        #endregion

                        #region person
                        if (vendor_AssignmentRecord_v13.Persons != null && vendor_AssignmentRecord_v13.Persons.Length > 0)
                        {
                            data.Append("[[[6_Person:::|||");
                            for (int prow = 0; prow < vendor_AssignmentRecord_v13.Persons.Length; prow++)
                            {
                                if (prow > 0) data.Append("|||___|||");
                                data.Append("3_First Name===" + vendor_AssignmentRecord_v13.Persons[prow].First_Name + "|||");
                                data.Append("3_SSN===" + vendor_AssignmentRecord_v13.Persons[prow].SSN + "|||");
                                data.Append("3_PersonTypeName===" + vendor_AssignmentRecord_v13.Persons[prow].Debtor_Type_Name);
                            }
                            data.Append("]]]");
                        }
                        #endregion

                        #region Address
                        if (vendor_AssignmentRecord_v13.Addresses != null && vendor_AssignmentRecord_v13.Addresses.Length > 0)
                        {
                            data.Append("[[[6_Address:::|||");
                            for (int arow = 0; arow < vendor_AssignmentRecord_v13.Addresses.Length; arow++)
                            {
                                if (arow > 0) data.Append("|||___|||");
                                data.Append("3_PersonTypeID===" + vendor_AssignmentRecord_v13.Addresses[arow].Debtor_Type_Name + "|||");
                                data.Append("3_AddressLine1===" + vendor_AssignmentRecord_v13.Addresses[arow].Address_Line_1 + "|||");
                                data.Append("3_City===" + vendor_AssignmentRecord_v13.Addresses[arow].City + "|||");
                                data.Append("3_State===" + vendor_AssignmentRecord_v13.Addresses[arow].State + "|||");
                                data.Append("3_ZipCode===" + vendor_AssignmentRecord_v13.Addresses[arow].Zip_Code + "|||");
                                data.Append("3_DebtorAddressTypeID===" + vendor_AssignmentRecord_v13.Addresses[arow].Debtor_Address_Type_Name);
                            }
                            data.Append("]]]");
                        }
                        #endregion

                        #region ContactInformation
                        if (vendor_AssignmentRecord_v13.ContactInformation != null && vendor_AssignmentRecord_v13.ContactInformation.Length > 0)
                        {
                            data.Append("[[[6_ContactInformation:::|||");
                            for (int crow = 0; crow < vendor_AssignmentRecord_v13.ContactInformation.Length; crow++)
                            {
                                if (crow > 0) data.Append("|||___|||");
                                data.Append("3_PersonTypeCode===" + vendor_AssignmentRecord_v13.ContactInformation[crow].Debtor_Type_Name + "|||");
                                data.Append("3_Phone_Number===" + vendor_AssignmentRecord_v13.ContactInformation[crow].Phone_Number + "|||");
                                data.Append("3_AddressTypeCode===" + vendor_AssignmentRecord_v13.ContactInformation[crow].Debtor_Address_Type_Name);
                            }
                            data.Append("]]]");
                        }
                        #endregion

                        return data.ToString();
                    }
                }
                else if (RequestType == "2")
                {
                    if (string.IsNullOrWhiteSpace(ConnectionString)) return null;
                    var noteUpdate = (NoteUpdate)new XmlSerializer(typeof(NoteUpdate)).Deserialize(new MemoryStream(Encoding.UTF8.GetBytes(XmlString)));
                    if (noteUpdate == null) return null;
                    else
                    {
                        if (string.IsNullOrWhiteSpace(noteUpdate.ClientReferenceID)) return null;
                        else
                        {
                            string AuraReference = this.GetAuraReference(ConnectionString, "GetProcessReference", noteUpdate.ClientReferenceID);
                            if (AuraReference == null) return null;
                            else
                            {
                                StringBuilder data = new StringBuilder();

                                #region note update master data
                                data.Append("[[[_List of Process References:::" + AuraReference + "]]]");
                                #endregion

                                #region note update detail data
                                if (noteUpdate.Notes != null && noteUpdate.Notes.Length > 0)
                                {
                                    data.Append("[[[6_Note:::|||");
                                    for (int prow = 0; prow < noteUpdate.Notes.Length; prow++)
                                    {
                                        if (prow > 0) data.Append("|||___|||");
                                        data.Append("3_SystemSource===" + noteUpdate.SystemSource + "|||");
                                        data.Append("3_NoteCreator===" + noteUpdate.Notes[prow].NoteCreator + "|||");
                                        data.Append("3_Note_GF===" + noteUpdate.Notes[prow].Note_GF);
                                    }
                                    data.Append("]]]");
                                }
                                #endregion

                                return data.ToString();
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public string GetAuraReference(string ConnectionString, string StoredProcedure, string ClientReferenceNumber)
        {
            try
            {
                List<VMParameter> vMParameters = new List<VMParameter>();
                vMParameters.Add(new VMParameter("@ClientReferenceNumber", ClientReferenceNumber, SqlDbType.VarChar, 255));
                DataTable dt = new DMLService(ConnectionString).ConfigureAdapter(StoredProcedure, CommandType.StoredProcedure, vMParameters);
                if (dt == null) return null;
                if (dt.Rows.Count == 0) return null;
                if (Convert.ToString(dt.Rows[0]["Assignment_Reference_Number"]).Trim() == "") return null;
                return Convert.ToString(dt.Rows[0]["Assignment_Reference_Number"]).Trim();
            }
            catch
            {
                return null;
            }
        }
    }
}
