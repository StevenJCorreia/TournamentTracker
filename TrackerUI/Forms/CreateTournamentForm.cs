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
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = new List<PrizeModel>();

        public CreateTournamentForm()
        {
            InitializeComponent();

            RefreshLists();
        }

        private void RefreshLists()
        {
            SelectTeamDropDown.DataSource = null;
            SelectTeamDropDown.DataSource = availableTeams;
            SelectTeamDropDown.DisplayMember = "TeamName";

            TeamListBox.DataSource = null;
            TeamListBox.DataSource = selectedTeams;
            TeamListBox.DisplayMember = "TeamName";

            PrizeListBox.DataSource = null;
            PrizeListBox.DataSource = selectedPrizes;
            PrizeListBox.DisplayMember = "PlaceName";
        }

        private void AddTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)SelectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                RefreshLists();
            }
        }

        private void CreatePrizeButton_Click(object sender, EventArgs e)
        {
            CreatePrizeForm Frm = new CreatePrizeForm(this);
            Frm.Show();
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);

            RefreshLists();
        }

        public void TeamComplete(TeamModel model)
        {
            selectedTeams.Add(model);

            RefreshLists();
        }

        private void CreateNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm Frm = new CreateTeamForm(this);
            Frm.Show();
        }

        private void RemoveSelectedTeamButton_Click(object sender, EventArgs e)
        {
            TeamModel t = (TeamModel)TeamListBox.SelectedItem;

            if (t != null)
            {
                selectedTeams.Remove(t);
                availableTeams.Add(t);

                RefreshLists();
            }
        }

        private void RemoveSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)PrizeListBox.SelectedItem;

            if (p != null)
            {
                selectedPrizes.Remove(p);

                RefreshLists();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            if (TournamentNameValue.Text.Length == 0)
            {
                MessageBox.Show("Please enter a tournament name.");
                return;
            }

            // Verify that team & prize lists aren't empty?

            decimal fee = 0;

            bool feeAcceptable = decimal.TryParse(EntryFeeValue.Text, out fee);

            if (!feeAcceptable)
            {
                MessageBox.Show("Please enter a valid entry fee.", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tournament = new TournamentModel();

            tournament.TournamentName = TournamentNameValue.Text;
            tournament.EntryFee = fee;

            tournament.Prizes = selectedPrizes;
            tournament.EnteredTeams = selectedTeams;

            TournamentLogic.CreateRounds(tournament);

            GlobalConfig.Connection.CreateTournament(tournament);

            this.Close();
        }
    }
}
