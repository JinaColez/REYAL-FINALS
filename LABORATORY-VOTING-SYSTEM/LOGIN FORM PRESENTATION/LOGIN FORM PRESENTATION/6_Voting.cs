using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LOGIN_FORM_PRESENTATION
{
    public partial class Voting : Form
    {
        public Voting()
            {
            InitializeComponent();

            
 
            voteBox.SelectedIndexChanged += voteBox_SelectedIndexChanged; 
            }

        private void VINCE_Click(object sender, EventArgs e)
        {

        }

        private void closeButt_Click(object sender, EventArgs e)
        {
            

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void voteBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            switch ( voteBox.SelectedItem.ToString() )
                {
                case "OFFICIAL 1":
                    pictureBox2.BringToFront();
                    break;
                case "OFFICIAL 2":
                    RENZ.BringToFront();
                    break;
                case "OFFICIAL 3":
                    BARDS.BringToFront();
                    break;
                case "OFFICIAL 4":
                    MARK.BringToFront();
                    break;
                case "OFFICIAL 5":
                    IMOT.BringToFront();
                    break;
                case "OFFICIAL 6":
                    VINCE.BringToFront();
                    break;
                case "OFFICIAL 7":
                    CHARLIE.BringToFront();
                    break;
                case "OFFICIAL 8":
                    MJ.BringToFront();
                    break;
                case "OFFICIAL 9":
                    IAN.BringToFront();
                    break;
                case "OFFICIAL 0":
                    JAKE.BringToFront();
                    break;
                case "OFFICIAL 01":
                    CARLO.BringToFront();
                    break;





                }
             
            }

      

        private void VOTEBTN_Click(object sender, EventArgs e)
        {
            try
                {
                string conn = "datasource=localhost;database=login;port=3307;SSLMode=none;username=root;password=; ";
                string query = "insert into votersdata (candidate ,votecount) values('"+voteBox.SelectedItem.ToString()+"','"+"1"+"')";
                MySqlConnection connection = new MySqlConnection(conn);
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                try
                    {
                    connection.Open();
                    reader = command.ExecuteReader();
                    connection.Close();
                    CustomMessageBox customMessage = new CustomMessageBox("Voted");
                    customMessage.ShowDialog();
 

                    }
                catch (Exception ex)
                    {
                    MessageBox.Show(ex.Message);
                    }
                }
            catch (Exception ex)
                {
                MessageBox.Show(ex.Message);
                }

            
           
        }

        private void Voting_Load(object sender, EventArgs e)
        {
        /*KUYS MARK LAGAY KA LANG NENTO OR GAWA KA PA NANG IBANG FORM KUNG PAPANO YUNG BOTOHAN GAYAHIN MO LANG TOH*/
            voteBox.Items.Add("OFFICIAL 1");
            voteBox.Items.Add("OFFICIAL 2");
            voteBox.Items.Add("OFFICIAL 3");
            voteBox.Items.Add("OFFICIAL 4");
            voteBox.Items.Add("OFFICIAL 5");
            voteBox.Items.Add("OFFICIAL 6");
            voteBox.Items.Add("OFFICIAL 7");
            voteBox.Items.Add("OFFICIAL 8");
            voteBox.Items.Add("OFFICIAL 9");
            voteBox.Items.Add("OFFICIAL 0");
            voteBox.Items.Add("OFFICIAL 01");
            }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void IAN_Click(object sender, EventArgs e)
        {

        }

        private void MARK_Click(object sender, EventArgs e)
        {

        }

        private void JAKE_Click(object sender, EventArgs e)
        {

        }

        private void IMOT_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void next_Click(object sender, EventArgs e)
        {
            
        }
    }
}
