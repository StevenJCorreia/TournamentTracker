using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI.Forms
{
    public partial class CreateTeamForm : Form
    {
        private List<PersonModel> availableTeamMembers = GlobalConfig.Connection.GetPerson_All();
        private List<PersonModel> selectedTeamMembers = new List<PersonModel>();
        private ITeamRequester callingForm;

        public CreateTeamForm(ITeamRequester caller)
        {
            InitializeComponent();

            callingForm = caller;

            RefreshLists();
        }

        private void RefreshLists()
        {
            SelectMemberDropDown.DataSource = null;
            SelectMemberDropDown.DataSource = availableTeamMembers;
            SelectMemberDropDown.DisplayMember = "FullName";

            TeamMemberListBox.DataSource = null;
            TeamMemberListBox.DataSource = selectedTeamMembers;
            TeamMemberListBox.DisplayMember = "FullName";
        }

        private void CreateTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = new TeamModel();

            t.TeamName = TeamNameValue.Text;
            t.TeamMembers = (List<PersonModel>)TeamMemberListBox.DataSource;

            t = GlobalConfig.Connection.CreateTeam(t);

            callingForm.TeamComplete(t);

            this.Close();
        }

        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a first name.");
                return false;
            }

            if (LastNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a last name.");
                return false;
            }

            if (EmailValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter an email address.");
                return false;
            }

            if (CellphoneValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a cell phone number.");
                return false;
            }

            // TODO - Add more validation
            if (!EmailValue.Text.Contains('@'))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }

            if (CellphoneValue.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid phone number");
                return false;
            }

            return true;
        }

        private void CreateMemberButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PersonModel p = new PersonModel();

                p.FirstName = FirstNameValue.Text;
                p.LastName = LastNameValue.Text;
                p.Email = EmailValue.Text;
                p.Cellphone = CellphoneValue.Text;

                p = GlobalConfig.Connection.CreatePerson(p);

                selectedTeamMembers.Add(p);

                RefreshLists();

                ResetMemberGroupBox();
            }
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)SelectMemberDropDown.SelectedItem;

            if (p != null)
            {
                availableTeamMembers.Remove(p);
                selectedTeamMembers.Add(p);

                RefreshLists(); 
            }
        }

        private void RemoveSelectedMemberButton_Click(object sender, EventArgs e)
        {
            PersonModel p = (PersonModel)TeamMemberListBox.SelectedItem;

            if (p != null)
            {
                selectedTeamMembers.Remove(p);
                availableTeamMembers.Add(p);

                RefreshLists();
            }
        }

        private void ResetMemberGroupBox()
        {
            FirstNameValue.Clear();
            LastNameValue.Clear();
            EmailValue.Clear();
            CellphoneValue.Clear();
        }
    }
}
