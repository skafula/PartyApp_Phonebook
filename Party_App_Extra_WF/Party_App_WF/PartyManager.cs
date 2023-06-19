using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_App_WF
{
    public class PartyManager
    {
        int numOfElems = 0;
        string[] _guestList;        // Array for names
        double _costPerPerson;
        double _feePerPerson;

        public double CostPerPerson 
        {
            get { return _costPerPerson; }
            set
            {
                if (value >= 0) { _costPerPerson = value; }
            } 
        }
        public int Count { get { return _guestList.Length; } }
        public double FeePerPerson 
        {
            get { return _feePerPerson; }
            set
            {
                if (_feePerPerson >= 0) { _feePerPerson = value; }
            }
        }

        // Constructor to build the array with parameter 'size' chosen by user
        public PartyManager(int maxNumOfGuests) 
        {
            _guestList = new string[maxNumOfGuests];
        }

        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int vacantPos = FindVacantPos();

            if (vacantPos != -1)
            {
                _guestList[vacantPos] = FullName(firstName, lastName);
            }
            else
                ok = false;
            return ok;
        }
        public double CalcTotalCost()
        {
            return _costPerPerson * NumOfGuests();
        }
        public double CalcTotalFees()
        {
            return _feePerPerson * NumOfGuests();
        }
        public bool ChangeAt(int index, string firstName, string lastName)
        {
            if (firstName != null && lastName != null && index >= 0)
            {
                string fullname = FullName(firstName, lastName);
                _guestList[index] = fullname;
                return true;
            }
            else
                return false;
        }
        public bool CheckIndex(int index)
        {
            return false;
        }
        public bool DeleteAt(int index)
        {
            _guestList[index] = string.Empty;
            numOfElems--;
            MoveElementsOneStepToLeft(index);
            return false;
        }
        private int FindVacantPos()
        {
            int vacantPos = -1;
            for (int index = 0; index < _guestList.Length; index++)
            {
                if (string.IsNullOrEmpty(_guestList[index]))
                {
                    vacantPos = index;
                    break;
                }
            }
            return vacantPos;
        }
        
        // Returnint a formatted string as name
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + " " + char.ToUpper(firstName[0]) + firstName.Substring(1).ToLower();
        }
        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < _guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(_guestList[i]))
                {
                    guests[j++] = _guestList[i];
                }
            }
            return guests;
        }
        public string GetItemAt(int index)
        {
            return _guestList[index];
        }
        private void MoveElementsOneStepToLeft(int index)
        {
            for (int i = index + 1; i < _guestList.Length; i++)
            {
                _guestList[i-1] = _guestList[i];
                _guestList[i] = string.Empty;
            }
        }
        private int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < _guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(_guestList[i]))
                {
                    numGuests++;
                }
            }
            return numGuests;
        }
        public int GetNumOfGuests()
        {
            return NumOfGuests();
        }
        public double CalcSurpDef()
        {
            return CalcTotalCost() - CalcTotalFees();
        }
    }
}
