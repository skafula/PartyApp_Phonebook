using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Party_App_WF
{
    public partial class MainForm : Form
    {
        Phonebook phoneBook = new Phonebook();
        PartyManager partyManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

                // PartyManager application

        #region PartyManager

                    // Initialize GUI methods

        #region GUI stuffs

        private void ClearInputControls()
        {
            tbMaxGuests.Text = string.Empty;
            tbCostPerPerson.Text = string.Empty;
        }
        private void ClearOutputControls()
        {
            lblNumOfGuests.Text = "0";
            lblTotalCost.Text = "0.00";
            lblTotalFees.Text = "0.00";
            lblSurpDef.Text = "0.00";
            listboxGuestList.Items.Clear();
        }
        private void InitializeGUI()
        {
            ClearInputControls();
            ClearOutputControls();

            grpAddGuests.Enabled = false;
            grpNewParty.Enabled = true;
        }
        private void UpdateGUI()
        {
            listboxGuestList.Items.Clear();
            string[] guestList = partyManager.GetGuestList();
            if (guestList != null)
            {
                for (int i = 0; i < guestList.Length; i++)
                {
                    string str = $"{i + 1,4} {guestList[i],-20}";
                    listboxGuestList.Items.Add(str);
                }
            }
            int numOfGuests = partyManager.GetNumOfGuests();
            lblNumOfGuests.Text = numOfGuests.ToString();

            double totalCost = partyManager.CalcTotalCost();
            lblTotalCost.Text = totalCost.ToString("0.00");

            double totalFee = partyManager.CalcTotalFees();
            lblTotalFees.Text = totalFee.ToString("0.00");

            double finalSurpDef = partyManager.CalcSurpDef();
            lblSurpDef.Text = finalSurpDef.ToString();

            IsGuestListFull();
            IsChangeBtnActive();

            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
        }

        #endregion

                    // Events

        #region Events

                        // Create Party

        private void btnCreateList_Click(object sender, EventArgs e)
        {
            CreateParty();
            grpAddGuests.Enabled = true;
            btnAddToList.Enabled = true;
            UpdateGUI();
        }

                        // Make changes on PartyList

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            partyManager.AddNewGuest(tbFirstName.Text, tbLastName.Text);
            AddItemsToGuestListBox(partyManager.GetGuestList());
            UpdateGUI();
        }

        private void listboxGuestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = IsListBoxItemSelected();

            if (index >= 0)
            {
                string name = partyManager.GetItemAt(index);
                string[] names = name.Split(' ');
                tbFirstName.Text = names[1].Trim();
                tbLastName.Text = names[0].Trim();
            }
            IsChangeBtnActive();
        }
        private void lblGuestList_Click(object sender, EventArgs e)
        {
            AddItemsToGuestListBox(partyManager.GetGuestList());
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            partyManager.DeleteAt(listboxGuestList.SelectedIndex);
            UpdateGUI();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            bool readable = NameIsReadableData();
            bool convertOk = false;

            if (readable)
            {
                convertOk = partyManager.ChangeAt(IsListBoxItemSelected(), tbFirstName.Text, tbLastName.Text);
                if (convertOk)
                {
                    UpdateGUI();
                }
            }
            else
                MessageBox.Show("Hiányzó adat!");
            
        }

        #endregion

        #region Events element Methods
            
                        // CreateList Button
        private void CreateParty()
        {
            ReadPartySize();
            bool costOk = ReadCostPerPerson();
            bool feeOk = ReadFeePerPerson();
            if (costOk && feeOk)
            {
                MessageBox.Show($"Party list with space for {partyManager.Count} guests created!", "Success");
            }
            else
                MessageBox.Show("Add meg a Cost és Fee értékét is!");
            return;
        }
        private bool ReadPartySize()
        {
            int maxNumber = 0;
            if (int.TryParse(tbMaxGuests.Text, out maxNumber) && (maxNumber > 0))
            {
                partyManager = new PartyManager(maxNumber);
                //MessageBox.Show($"Party list with space for {maxNumber} guests created!", "Success");
            }
            else
            {
                MessageBox.Show("Invalid Total Number. Please try again!", "Error");
                return false;
            }
            return true;
        }
        private bool ReadCostPerPerson()
        {
            if (!string.IsNullOrEmpty(tbCostPerPerson.Text) && double.TryParse(tbCostPerPerson.Text, out double costPerPerson))
            {
                partyManager.CostPerPerson = costPerPerson;
                return true;
            }
            return false;
        }
        private bool ReadFeePerPerson()
        {
            if (!string.IsNullOrEmpty(tbFeePerPerson.Text) && double.TryParse(tbFeePerPerson.Text, out double feePerPerson))
            {
                partyManager.FeePerPerson = feePerPerson;
                return true;
            }
            return false;
        }

                        // Add items to GuestList

        private void AddItemsToGuestListBox(string[] nameOfGuests)
        {
            listboxGuestList.Items.Clear();
            for (int i = 0; i < nameOfGuests.Length; i++)
            {
                listboxGuestList.Items.Add(nameOfGuests[i]);
            }
        }
        private int IsListBoxItemSelected()
        {
            int index = listboxGuestList.SelectedIndex;

            if (listboxGuestList.SelectedIndex < 0)
            {
                MessageBox.Show("Select an item in the list");
                return -1;
            }
            return index;
        }
        private bool NameIsReadableData()
        {
            if (tbFirstName.Text.Length > 0 && tbLastName.Text.Length > 0)
            {
                return true;
            }
            else
                return false;
        }

        private bool IsGuestListFull()
        {
            // If GuestList full, btn enable = false
            var b = partyManager.Count == partyManager.GetNumOfGuests();
            btnAddToList.Enabled = !b;
            return b;
        }
        private void IsChangeBtnActive()
        {
            var b = listboxGuestList.SelectedIndex > -1;
            btnChange.Enabled = b;
            btnDelete.Enabled = b;
        }

        #endregion

        #endregion

        // PhoneBook application

        #region PhoneBook

        // Loading ListBox
        private void AddItemsToListBox(string[,] phoneBook)
        {
            for (int i = 0; i < phoneBook.GetLength(1); i++)
            {
                string strOut = string.Format("{0,-27} \t{1,15}", phoneBook[0, i], phoneBook[1, i]);
                lbPhoneBook.Items.Add(strOut);
            }
        }
        // Show ListBox elements
        private void btnShowPhoneBook_Click(object sender, EventArgs e)
        {
            lbPhoneBook.Items.Clear();
            AddItemsToListBox(phoneBook.GetPhoneList());
        }
        // Order the elements then show ListBox (elements dont get back to the original order)
        private void btnOrderList_Click(object sender, EventArgs e)
        {
            lbPhoneBook.Items.Clear();
            phoneBook.SortByName();
            AddItemsToListBox(phoneBook.GetPhoneList());
        }

        #endregion

    }
}
