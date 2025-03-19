using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataLayer;


namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID {  get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        public string NationalNo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public short Gender {  get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get; set; }

        public clsCountry CountryInfo;
        
        private string _ImagePath {  get; set; }

        public string ImagePath
        {
            get { return _ImagePath; }
            set { _ImagePath = value; }
        }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.Now;
            Address = "";
            Phone = "";
            Email = "";
            NationalityCountryID = -1;
            ImagePath = "";

            Mode = enMode.AddNew;
        }
        private clsPerson(int personID, string firstName, string secondName, string thirdName, string lastName, string nationalNo, DateTime dateOfbirth,
            short gender, string address, string phone, string email, int nationalityCountryID, string imagePath)
        {
            PersonID = personID;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            NationalNo = nationalNo;
            DateOfBirth = dateOfbirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            NationalityCountryID = nationalityCountryID;
            ImagePath = imagePath;
            CountryInfo = clsCountry.Find(NationalityCountryID);
            Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPerson(this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gender,
                this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return (this.PersonID != -1);
        }
        private bool _UpdatePerson()
        {
            return clsPersonData.UpdatePerson(this.PersonID, this.FirstName, this.SecondName,
                this.ThirdName, this.LastName, this.NationalNo, this.DateOfBirth, this.Gender,
                this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);
        }

        public static clsPerson Find(int PersonID)
        {
			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", NationalNo = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int NationalityCountryID = -1;
			short Gender = 0;

            bool isFound = clsPersonData.GetPersonInfoByID(PersonID, ref FirstName,
                ref SecondName, ref ThirdName, ref LastName, ref NationalNo, ref DateOfBirth, ref Gender, ref Address,
                ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

            if (isFound)
            {
                return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo,DateOfBirth,
                    Gender,Address, Phone, Email, NationalityCountryID, ImagePath);
            }
            else
            {
                return null;
            }
		}
		public static clsPerson Find(string NationalNo)
		{
			string FirstName = "", SecondName = "", ThirdName = "", LastName = "", Email = "", Phone = "", Address = "", ImagePath = "";
			DateTime DateOfBirth = DateTime.Now;
			int PersonID = -1 , NationalityCountryID = -1;
			short Gender = 0;

			bool isFound = clsPersonData.GetPersonInfoByNationalNo(NationalNo,ref PersonID, ref FirstName,
				ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address,
				ref Phone, ref Email, ref NationalityCountryID, ref ImagePath);

			if (isFound)
			{
				return new clsPerson(PersonID, FirstName, SecondName, ThirdName, LastName, NationalNo, DateOfBirth,
					Gender, Address, Phone, Email, NationalityCountryID, ImagePath);
			}
			else
			{
				return null;
			}
		}

		public bool Save()
		{
			switch (Mode)
			{
				case enMode.AddNew:
					if (_AddNewPerson())
					{

						Mode = enMode.Update;
						return true;
					}
					else
					{
						return false;
					}

				case enMode.Update:

					return _UpdatePerson();

			}

			return false;
		}

		public static DataTable GetAllPeople()
		{
			return clsPersonData.GetAllPeople();
		}

		public static bool DeletePerson(int ID)
		{
			return clsPersonData.DeletePerson(ID);
		}

		public static bool isPersonExist(int ID)
		{
			return clsPersonData.IsPersonExist(ID);
		}

		public static bool isPersonExist(string NationlNo)
		{
			return clsPersonData.IsPersonExist(NationlNo);
		}


	}
}
