using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mitarbeiterverwaltung
{
    public partial class Form1 : Form
    {
        //Trust Server; Integrated Security=True ODER
        //User und Passwort angeben
        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=NB2405\SQLEXPRESS;Initial Catalog=PM;Integrated Security=True;TrustServerCertificate=True");
            
        public Form1()
        {
            InitializeComponent();
            getGeschlecht();
        }

        private void getGeschlecht()
        {
            geschlechtDropdown.Items.Clear();
//------Methode aulagern-----------------------------------------------------------------------------
            databaseConnection.Open();
            string query = "SELECT Geschlecht_lang FROM Geschlecht";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            databaseConnection.Close();
//---------------------------------------------------------------------------------------------------
            foreach(DataRow row in dataSet.Tables[0].Rows)
            {
                geschlechtDropdown.Items.Add(row["Geschlecht_lang"].ToString());
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            showMitarbeiter();
            //MitarbeiterDB.SelectionChanged += MitarbeiterDB_SelectionChanged;
        }

        private DataSet getMitarbeiterTable()
        {
            databaseConnection.Open();
            string query = "SELECT M.ID_Mitarbeiter, M.Vorname, M.Nachname, G.Geschlecht_lang FROM Mitarbeiter M inner join Geschlecht G ON G.ID_Geschlecht = M.ID_Geschlecht";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);


            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);          

            databaseConnection.Close();
            return dataSet;
        }

        private void showMitarbeiter()
        {
            //Zugriff auf DataGridView; die Tabelle, die auf der nullten Stelle steht (es können auch mehrere Tabellen sein)
            MitarbeiterDB.DataSource = getMitarbeiterTable().Tables[0];
        }


//------Mitarbeiter einpflegen:
        private void btnSaveMitarbeiter_Click(object sender, EventArgs e)
        {
            string vorname = vornameInput.Text;
            string nachname =  nachnameInput.Text;
            int geschlecht = 0;
            if (geschlechtDropdown.SelectedIndex == 0) 
            {
                geschlecht = 0;
            }
            else if(geschlechtDropdown.SelectedIndex == 1)
            {
                geschlecht = 1;
            }
            else 
            {
                geschlecht = 2;
            }

            if(vornameInput.Text != "" && nachnameInput.Text != "" && geschlechtDropdown.SelectedIndex >= 0)
            {
                databaseConnection.Open();
                //string.Format->damit die Werte übergeben werden können
                string query = string.Format("insert into Mitarbeiter(Vorname, Nachname, ID_Geschlecht) values ('{0}', '{1}', '{2}')", vorname, nachname, geschlecht) ;
                SqlCommand cmd = new SqlCommand(query, databaseConnection);
                cmd.ExecuteNonQuery();
                databaseConnection.Close();
            }

            showMitarbeiter();
            clearInput();
            
        }


//------Inputfelder leeren
        private void clearInput()
        {
            vornameInput.Text = "";
            nachnameInput.Text = "";
            geschlechtDropdown.SelectedIndex = -1;
        }

        private void btnClearMitarbeiter_Click(object sender, EventArgs e)
        {
            clearInput();
        }


//------Mitarbeiter bearbeiten
        private void MitarbeiterDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            vornameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[1].Value.ToString();
            nachnameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[2].Value.ToString();
            geschlechtDropdown.Text = MitarbeiterDB.SelectedRows[0].Cells[3].Value.ToString();
        }

        //private void MitarbeiterDB_SelectionChanged(object sender, EventArgs e)
        //{
        //    //nachnameInput.Text = MitarbeiterDB.SelectedCells[1].Value.ToString();
        //    vornameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[1].Value.ToString();
        //    nachnameInput.Text = MitarbeiterDB.SelectedRows[0].Cells[2].Value.ToString();
        //   // geschlechtDropdown.SelectedIndex = MitarbeiterDB.SelectedRows[0];               
        //}
        

        //------Mitarbeiter löschen
        private void btnDeleteMitarbeiter_Click(object sender, EventArgs e)
        {
            if (MitarbeiterDB.SelectedRows.Count > 0)
            {
                int mitarbeiterID =  Convert.ToInt32(MitarbeiterDB.SelectedRows[0].Cells["ID_Mitarbeiter"].Value);

                var confirmResult = MessageBox.Show("Sind Sie sicher, dass Sie diesen Mitarbeiter löschen möchten?");

                if(confirmResult == DialogResult.Yes)
                {
                    databaseConnection.Open();

                    string query = "DELETE FROM Mitarbeiter WHERE ID_Mitarbeiter = @ID_Mitarbeiter";
                    SqlCommand cmd = new SqlCommand(query, databaseConnection);
                    cmd.Parameters.AddWithValue("@ID_Mitaerbeiter", mitarbeiterID);

                    cmd.ExecuteNonQuery();
                    showMitarbeiter();
                }
                else
                {
                    MessageBox.Show("Bitte wählen Sie einen Mitarbeiter aus, um ihn zu löschen.");
                }
            }
        }

       

        //private void Form1_Load(object sender, EventArgs e)
        //{
        //    databaseConnection.Open();
        //    string query =  "SELECT M.Vorname, M.Nachname, G.Geschlecht_lang FROM Mitarbeiter M inner join Geschlecht G ON G.ID_Geschlecht = M.ID_Geschlecht";

        //    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);


        //    DataSet dataSet = new DataSet();
        //    sqlDataAdapter.Fill(dataSet);

        //    //Zugriff auf DataGridView; die Tabelle, die auf der nullten Stelle steht (es können auch mehrere Tabellen sein)
        //    MitarbeiterDB.DataSource = dataSet.Tables[0];

        //    databaseConnection.Close();
        //}
    }
}
