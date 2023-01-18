using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace SafeHome360
{
    public partial class main : Form
    {
        public string status;
        private SerialPort com;
        string date_time_error;
        Byte statusByte;
        myMaisonEntity maison;

        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.com = new SerialPort("COM1", 9600, Parity.None, 8, StopBits.One);

            closeConnectionToolStripMenuItem.Enabled = true;
            try
            {
                this.com.Open();
                //gestion le proprietes
                date_time_error = DateTime.Now.ToString();
                status = "Le port com 1 est ouvert " + date_time_error;
                //db.infos.Add()
                lblStatus.Text = status;
                lblStatus.BackColor = Color.Green;
                lblStatus.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          //  mnuOpen.Enabled = false;

        }

        

        private void btnF1_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF1,"window");
        }
        private void ButtonStyle(Button button,string type)
        {
            try
            {
                if (com.IsOpen == true)
                {
                    date_time_error = DateTime.Now.ToString();
                    if (button.BackColor != Color.Red)
                    {
                        //style pour button a l'activation
                        button.BackColor = Color.Red;
                        //messsage pour la barre des status 
                        status = button.Text + " Activer : " + date_time_error;
                        statusByte = Convert.ToByte(1);
                        //arriere plan 
                        lblStatus.BackColor = Color.Green;

                        
                        
                    }
                    else
                    {
                        if (type == "window")
                        {
                            //couleur a la fermeture  pour les fenetre
                            button.BackColor = Color.LightSlateGray;

                        }
                        else if (type == "door")
                        {
                            //couleur a la fermeture pour les portes
                            button.BackColor = Color.LightCyan;
                        }

                        //personalisation du bouton
                        button.ForeColor = Color.Black;

                        //personnalisation de la barre des status
                        status = button.Text + " Desactiver  : "+date_time_error;
                        statusByte = Convert.ToByte(0);
                        lblStatus.BackColor = Color.Red;
                    }
                    //envoie des informations a la barre des status
                    sendBytes(button, type);
                    lblStatus.Text = status;
                    lblStatus.ForeColor = Color.White;

                }
                else
                {
                    status = "Erreur : Vueillez vous connecter d'abord";
                    MessageBox.Show(status, "Erreur de connexion",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Error);
                    lblStatus.Text = status;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void sendBytes(Button button,string type)
        {
            //verification  du type 
            byte[] msg = new byte[3];

            if (type == "window")
            {
                msg[0] = 0;
            }else if (type == "door")
            {
                msg[0] =1;
            }else if (type == "mouvement")
            {
                msg[0] = 2;
            }
            else 
            {
                msg[0] = 3;
            }

            //verification du numero
            Byte numero = Convert.ToByte(button.Text.Substring(1));
            //MessageBox.Show(numero.ToString());
            msg[1] =numero;

            //verification du status
            msg[2] = statusByte;

            //envoies des donnees sous forme de bytes
            this.com.Write(msg,0,3);



            //ajout a la base de donnees
            maison = new myMaisonEntity();
            
            history infos = new history();

            infos.message = status;
            infos.date = date_time_error.ToString();
            infos.Button = button.Name;
            infos.status = msg[2];
           

            maison.histories.Add(infos);
            maison.SaveChanges();

        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF2, "window");
        }

        private void btnF3_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF3, "window");
        }

        private void btnF4_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF4, "window");
        }

        private void btnF5_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF5, "window");
        }

        private void btnF6_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnF6, "window");
        }

        private void btnP1_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnP1, "door");
        }

        private void btnP2_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnP2, "door");

        }

        private void btnP3_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnP3, "door");

        }

        private void btnP4_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnP4, "door");

        }

        private void btnP5_Click(object sender, EventArgs e)
        {
            ButtonStyle(btnP5, "door");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonStyle(button1, "door");

        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            

        }

        private void panImage_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panImage_Click(object sender, EventArgs e)
        {
         
        }

        private void closeConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (com.IsOpen == true)
                {
                    this.com.Close();

                    date_time_error = DateTime.Now.ToString();
                    status = "Fermuture de la connecion faite avec success ! : " + date_time_error;
                    lblStatus.Text = status;
                    lblStatus.BackColor = Color.Orange;
                    lblStatus.ForeColor = Color.White;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //mnuOpen.Enabled = true;
            closeConnectionToolStripMenuItem.Enabled = false;
        }

        private void mnuBar_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
