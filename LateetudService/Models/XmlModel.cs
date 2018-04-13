
namespace LateetudService.Models
{
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class Vendor_AssignmentRecord_v13
    {

        private string clientNameField;

        private string assignmentTypeNameField;

        private string assignmentIdentityField;

        private string clientAccountNumberField;

        private string loanNumberField;

        private string lienHolderField;

        private string yearField;

        private string makeField;

        private string modelField;

        private string vinField;

        private string clientContactField;

        private string collateralTypeField;

        private string clientCompanyIDField;

        private Vendor_AssignmentRecord_v13Person[] personsField;

        private Vendor_AssignmentRecord_v13Address[] addressesField;

        private Vendor_AssignmentRecord_v13Contact[] contactInformationField;

        /// <remarks/>
        public string ClientName
        {
            get
            {
                return this.clientNameField;
            }
            set
            {
                this.clientNameField = value;
            }
        }

        /// <remarks/>
        public string AssignmentTypeName
        {
            get
            {
                return this.assignmentTypeNameField;
            }
            set
            {
                this.assignmentTypeNameField = value;
            }
        }

        /// <remarks/>
        public string AssignmentIdentity
        {
            get
            {
                return this.assignmentIdentityField;
            }
            set
            {
                this.assignmentIdentityField = value;
            }
        }

        /// <remarks/>
        public string ClientAccountNumber
        {
            get
            {
                return this.clientAccountNumberField;
            }
            set
            {
                this.clientAccountNumberField = value;
            }
        }

        /// <remarks/>
        public string LoanNumber
        {
            get
            {
                return this.loanNumberField;
            }
            set
            {
                this.loanNumberField = value;
            }
        }

        /// <remarks/>
        public string LienHolder
        {
            get
            {
                return this.lienHolderField;
            }
            set
            {
                this.lienHolderField = value;
            }
        }

        /// <remarks/>
        public string Year
        {
            get
            {
                return this.yearField;
            }
            set
            {
                this.yearField = value;
            }
        }

        /// <remarks/>
        public string Make
        {
            get
            {
                return this.makeField;
            }
            set
            {
                this.makeField = value;
            }
        }

        /// <remarks/>
        public string Model
        {
            get
            {
                return this.modelField;
            }
            set
            {
                this.modelField = value;
            }
        }

        /// <remarks/>
        public string Vin
        {
            get
            {
                return this.vinField;
            }
            set
            {
                this.vinField = value;
            }
        }

        /// <remarks/>
        public string ClientContact
        {
            get
            {
                return this.clientContactField;
            }
            set
            {
                this.clientContactField = value;
            }
        }

        /// <remarks/>
        public string CollateralType
        {
            get
            {
                return this.collateralTypeField;
            }
            set
            {
                this.collateralTypeField = value;
            }
        }

        /// <remarks/>
        public string ClientCompanyID
        {
            get
            {
                return this.clientCompanyIDField;
            }
            set
            {
                this.clientCompanyIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Person", IsNullable = false)]
        public Vendor_AssignmentRecord_v13Person[] Persons
        {
            get
            {
                return this.personsField;
            }
            set
            {
                this.personsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Address", IsNullable = false)]
        public Vendor_AssignmentRecord_v13Address[] Addresses
        {
            get
            {
                return this.addressesField;
            }
            set
            {
                this.addressesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Contact", IsNullable = false)]
        public Vendor_AssignmentRecord_v13Contact[] ContactInformation
        {
            get
            {
                return this.contactInformationField;
            }
            set
            {
                this.contactInformationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Vendor_AssignmentRecord_v13Person
    {

        private string first_NameField;

        private string sSNField;

        private string debtor_Type_NameField;

        /// <remarks/>
        public string First_Name
        {
            get
            {
                return this.first_NameField;
            }
            set
            {
                this.first_NameField = value;
            }
        }

        /// <remarks/>
        public string SSN
        {
            get
            {
                return this.sSNField;
            }
            set
            {
                this.sSNField = value;
            }
        }

        /// <remarks/>
        public string Debtor_Type_Name
        {
            get
            {
                return this.debtor_Type_NameField;
            }
            set
            {
                this.debtor_Type_NameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Vendor_AssignmentRecord_v13Address
    {

        private string debtor_Type_NameField;

        private string address_Line_1Field;

        private string cityField;

        private string stateField;

        private string zip_CodeField;

        private string debtor_Address_Type_NameField;

        /// <remarks/>
        public string Debtor_Type_Name
        {
            get
            {
                return this.debtor_Type_NameField;
            }
            set
            {
                this.debtor_Type_NameField = value;
            }
        }

        /// <remarks/>
        public string Address_Line_1
        {
            get
            {
                return this.address_Line_1Field;
            }
            set
            {
                this.address_Line_1Field = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string Zip_Code
        {
            get
            {
                return this.zip_CodeField;
            }
            set
            {
                this.zip_CodeField = value;
            }
        }

        /// <remarks/>
        public string Debtor_Address_Type_Name
        {
            get
            {
                return this.debtor_Address_Type_NameField;
            }
            set
            {
                this.debtor_Address_Type_NameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class Vendor_AssignmentRecord_v13Contact
    {

        private string debtor_Type_NameField;

        private string phone_NumberField;

        private string debtor_Address_Type_NameField;

        /// <remarks/>
        public string Debtor_Type_Name
        {
            get
            {
                return this.debtor_Type_NameField;
            }
            set
            {
                this.debtor_Type_NameField = value;
            }
        }

        /// <remarks/>
        public string Phone_Number
        {
            get
            {
                return this.phone_NumberField;
            }
            set
            {
                this.phone_NumberField = value;
            }
        }

        /// <remarks/>
        public string Debtor_Address_Type_Name
        {
            get
            {
                return this.debtor_Address_Type_NameField;
            }
            set
            {
                this.debtor_Address_Type_NameField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class NoteUpdate
    {

        private string systemSourceField;

        private string clientReferenceIDField;

        private string dateTimeStampField;

        private NoteUpdateNote[] notesField;

        /// <remarks/>
        public string SystemSource
        {
            get
            {
                return this.systemSourceField;
            }
            set
            {
                this.systemSourceField = value;
            }
        }

        /// <remarks/>
        public string ClientReferenceID
        {
            get
            {
                return this.clientReferenceIDField;
            }
            set
            {
                this.clientReferenceIDField = value;
            }
        }

        /// <remarks/>
        public string DateTimeStamp
        {
            get
            {
                return this.dateTimeStampField;
            }
            set
            {
                this.dateTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Note", IsNullable = false)]
        public NoteUpdateNote[] Notes
        {
            get
            {
                return this.notesField;
            }
            set
            {
                this.notesField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class NoteUpdateNote
    {

        private string noteCreatorField;

        private string note_GFField;

        /// <remarks/>
        public string NoteCreator
        {
            get
            {
                return this.noteCreatorField;
            }
            set
            {
                this.noteCreatorField = value;
            }
        }

        /// <remarks/>
        public string Note_GF
        {
            get
            {
                return this.note_GFField;
            }
            set
            {
                this.note_GFField = value;
            }
        }
    }
}
