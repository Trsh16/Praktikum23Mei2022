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

namespace Praktikum13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtTeam = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeamnumber = new DataTable();
        DataTable dtcekcaptain = new DataTable();
        int PosisiSekarang = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "select p.player_id, p.player_name, p.birthdate, nationality_id, p.team_id, p.team_number from player p;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPemain);

            sqlQuery = "select team_id, team_name from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);

            sqlQuery = "select nationality_id, nation from nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNationality);

            cb_Nationality.DataSource = dtNationality;
            cb_Nationality.DisplayMember = "nation";
            cb_Nationality.ValueMember = "nationality_id";

            cb_Team.DataSource = dtTeam;
            cb_Team.DisplayMember = "team_name";
            cb_Team.ValueMember = "team_id";

            IsiDataPemain(0);
        }

        public void bilateamcaptainpindah ()
        {
            dtcekcaptain = new DataTable();
            sqlQuery = "select player_name, team_name from team t, player p where p.player_id = t.captain_id and p.team_id = p.team_id";

            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtcekcaptain);
        }
        public void ceknumberpunggung ()
        {
            dtTeamnumber = new DataTable();
            sqlQuery = "select * from player where team_id = '"+cb_Team.SelectedValue.ToString()+"' and team_number = '"+numericUpDown_Teamnumber.Value+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamnumber);
            if (dtTeamnumber.Rows.Count == 0)
            {
                lb_availability.Text = "Available";
            }
            else
            {
                lb_availability.Text = "Not available";
            }
        }

        public void IsiDataPemain(int Posisi)
        {
            tBox_ID.Text = dtPemain.Rows[Posisi][0].ToString();
            tBox_Name.Text = dtPemain.Rows[Posisi][1].ToString();
            dt_birthday.Text = dtPemain.Rows[Posisi][2].ToString();
            cb_Nationality.SelectedValue = dtPemain.Rows[Posisi][3].ToString();
            cb_Team.SelectedValue = dtPemain.Rows[Posisi][4].ToString();
            numericUpDown_Teamnumber.Value = Convert.ToInt32(dtPemain.Rows[Posisi][5].ToString());
            PosisiSekarang = Posisi;  
            playeridlama = tBox_ID.Text;
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btn_prev_Click(object sender, EventArgs e)
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

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (PosisiSekarang < dtPemain.Rows.Count - 1)
            {
                PosisiSekarang++;
                IsiDataPemain(PosisiSekarang);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtPemain.Rows.Count - 1);
        }
        public string playeridlama;
        private void btn_save_Click(object sender, EventArgs e)
        {
            
            sqlQuery = "UPDATE player SET player_id = '"+tBox_ID.Text+"', player_name = '" + tBox_Name.Text + "', birthdate = '" + dt_birthday.Value.ToString("yyyyMMdd") + "', nationality_id = '" + cb_Nationality.SelectedValue.ToString() + "', team_id = '" + cb_Team.SelectedValue.ToString() + "', team_number = '" + numericUpDown_Teamnumber.Value + "' WHERE player_id = '" + playeridlama + "'";
            if (lb_availability.Text == "Not available")
            {
                MessageBox.Show("Error, team number sudah ada!");
            }
            else
            {
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
           
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_Nationality_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cb_Team_SelectedIndexChanged(object sender, EventArgs e)
        {
            ceknumberpunggung();
        }

        private void numericUpDown_Teamnumber_ValueChanged(object sender, EventArgs e)
        {
            ceknumberpunggung();
        }
    }
}
