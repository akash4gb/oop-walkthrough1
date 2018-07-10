using System;
using System.Windows.Forms;
using OOPWalkThrough1.Models;

namespace OOPWalkThrough1
{
    public partial class PersonInformationUI : Form
    {
        public PersonInformationUI()
        {
            InitializeComponent();
        }

        Person person1 = new Person();
        private void showButton_Click(object sender, EventArgs e)
        {
            person1.firstName = firstNameTextBox.Text;
            person1.middleName = middleNameTextBox.Text;
            person1.lastName = lastNameTextBox.Text;

            fullNameTextBox.Text=person1.GetFullName();
            reverseNameTextBox.Text = person1.GetReverseName();
        }
    }
}
