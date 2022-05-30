using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PraktikumWeek14_AqillaSM
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league"); // sebagai data koneksi ke DBMSnya, memasukkan IP Address, localhost, user, password
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter; // hasil query akan disimpan olehnya atau menjadi penampung
        string sqlQuery;
        DataTable dtTeam = new DataTable();
        int PosisiSekarang = 0;
        DataTable dtTopSkor = new DataTable();
        DataTable dtWorst = new DataTable();
        DataTable dtMatch = new DataTable();
        string SimpanKode;

        private void FormTeam_Load(object sender, EventArgs e)
        {
            sqlQuery = "select team.team_name as 'Nama Tim', concat((manager.manager_name), ' (' , (nationality.nation), ')') as 'Manager', concat((team.home_stadium), ', ', (team.city), ' (', (team.capacity), ')') as 'Stadium', team.team_id as 'Team ID' from team, manager, nationality where team.manager_id = manager.manager_id and manager.nationality_id = nationality.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam); // sampai sini
            IsiDataPemain(0);
        }

        public void IsiDataPemain(int Posisi)
        {
            LabelTeam.Text = dtTeam.Rows[Posisi][0].ToString();
            LabelManager.Text = dtTeam.Rows[Posisi][1].ToString();
            LabelStadium.Text = dtTeam.Rows[Posisi][2].ToString();
            SimpanKode = dtTeam.Rows[Posisi][3].ToString();
            PosisiSekarang = Posisi;

            dtTopSkor = new DataTable();
            sqlQuery = "SELECT player.player_name as 'Nama', sum(if(dmatch.`type`='GO',1,0)) as 'Goal', sum(if(dmatch.`type`='GP',1,0)) as 'Penalty' FROM player, dmatch, team  WHERE player.player_id = dmatch.player_id and player.team_id = team.team_id and team.team_name = '" + LabelTeam.Text + "' GROUP BY 1 ORDER BY 2 DESC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopSkor);
            int Goal = Convert.ToInt32(dtTopSkor.Rows[0][1].ToString());
            int GoalPenalty = Convert.ToInt32(dtTopSkor.Rows[0][2].ToString());
            int TotalGoal = Goal + GoalPenalty;
            labelTopScorer.Text = dtTopSkor.Rows[0][0].ToString() + " " + TotalGoal + "(" + dtTopSkor.Rows[0][2].ToString() + ")";

            DataTable dtWorst = new DataTable();
            sqlQuery = "SELECT player.player_name as 'Nama Player', sum(if(dmatch.`type` = 'CY',1,0)) as 'Jumlah Yellow Card', sum(if(dmatch.`type` = 'CR',1,0)) as 'Jumlah Red Card',sum(if(dmatch.`type` = 'CY',1,0)) + sum(if(dmatch.`type` = 'CR',3,0)) as 'Total Value' FROM dmatch, team, player  WHERE player.player_id = dmatch.player_id and player.team_id = team.team_id and team.team_name = '" + LabelTeam.Text + "' GROUP BY 1 ORDER BY 4 DESC;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorst);
            LabelWorst.Text = dtWorst.Rows[0][0].ToString() + ", " + dtWorst.Rows[0][1].ToString() + " Yellow Card and " + dtWorst.Rows[0][2] + " Red Card";

            dtMatch = new DataTable();
            sqlQuery = "select date_format(m.match_date, '%d/%m/%Y') as 'match_date', if(m.team_home='" + SimpanKode + "', 'HOME', 'AWAY') as 'Home/Away', concat('vs ',if(m.team_home='" + SimpanKode + "', (select t.team_name from team t where t.team_id = m.team_away), (select t.team_name from team t where t.team_id = m.team_home)))as 'lawan', if (goal_home is null or goal_away is null, 'belum berlangsung', concat(m.goal_home, ' - ', m.goal_away))as 'score' FROM `match` m WHERE m.team_home = '" + SimpanKode + "' or m.team_away = '" + SimpanKode + "' ORDER BY m.match_date desc limit 5;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            DataGridMatch.DataSource = dtMatch;
        }

        private void ButtonFirst_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                IsiDataPemain(0);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void ButtonPrev_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang > 0)
            {
                PosisiSekarang--;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeam.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void ButtonLast_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtTeam.Rows.Count - 1)
            {
                IsiDataPemain(dtTeam.Rows.Count - 1);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }
        }
    }
}
