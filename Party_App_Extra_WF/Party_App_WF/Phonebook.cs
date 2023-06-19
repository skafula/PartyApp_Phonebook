using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Party_App_WF
{
    public class Phonebook
    {
        string[] names = { "Kovács Dénes", "Nasztaszja Filippovna", "Lev Nyikolajevics", "Rejtő Jenő", "Mark Zuckerberg" };
        string[] phones = { "010-2233", "020-3322", "030-4443", "040-5423", "050-6488" };
        string[,] phoneList;

        public Phonebook()
        {
            LoadPhoneList();
        }
        
        // Public main method and a private helper method to Sort elements by name in separated names[] and phones[]

        #region SortinMethods
        public void SortByName()
        {
            int pos, i;
            int length = names.Length;

            for(pos = 0; pos < length - 1; pos++)
            {
                for (i = 0; i < length - pos - 1; i++) 
                {
                    int result = names[i].CompareTo(names[i+1]);

                    if (result == 1)
                    {
                        SwapValues(i);
                    }
                }
            }
            LoadPhoneList();
        }
        private void SwapValues(int pos)
        {
            string temp = names[pos];
            names[pos] = names[pos+1];
            names[pos+1] = temp;

            temp = phones[pos];
            phones[pos] = phones[pos+1];
            phones[pos+1] = temp;
        }
        #endregion

        // Load phoneList 2 dimensional array with names[] and phones[]
        private void LoadPhoneList()
        {
            phoneList = new string[2, names.Length];
            for (int i = 0; i < phoneList.GetLength(0); i++)
            {
                for (int j = 0; j < phoneList.GetLength(1); j++)
                {
                    switch (i) 
                    {
                        case 0:
                            phoneList[i,j] = names[j]; 
                            break;
                        case 1:
                            phoneList[i,j] = phones[j];
                            break;
                    }
                }
            }
        }
        // Let Design to Get phoneList[,] elements
        public string[,] GetPhoneList()
        {
            return phoneList;
        }
    }
}
