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
    public partial class TournamentDashboardForm : Form
    {
        List<TournamentModel> tournaments = GlobalConfig.Connection.GetTournament_All();

        public TournamentDashboardForm()
        {
            InitializeComponent();

            RefreshLists();
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            CreateTournamentForm Frm = new CreateTournamentForm();
            Frm.Show();
        }

        private void LoadTournamentButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshLists()
        {
            LoadTournamentDropDown.DataSource = null;
            LoadTournamentDropDown.DataSource = tournaments;
            LoadTournamentDropDown.DisplayMember = "TournamentName";
        }
    }
}
