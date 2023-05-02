using Microsoft.Data.Sqlite;
using SQLitePCL;
using System;
using System.Runtime.CompilerServices;
using System.Web;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace database
{

    public partial class Form1 : Form
    {
        private SqliteConnection conn;


        public Form1()
        {
            InitializeComponent();
            conn = new SqliteConnection("Data Source=database.db");
            conn.Open();

            pictureBox3.Visible = false;
            pictureBox4.Visible = false;


            emailBox.ReadOnly = true;
            emailBox.BackColor = Color.White;
            addressBox.ReadOnly = true;
            addressBox.BackColor = Color.White;
            rodneBox.ReadOnly = true;
            rodneBox.BackColor = Color.White;
            telephoneBox.ReadOnly = true;
            telephoneBox.BackColor = Color.White;
            mestobox.ReadOnly= true;
            mestobox.BackColor = Color.White;
            pscbox.ReadOnly = true;
            pscbox.BackColor = Color.White;





            rod1Box.Visible = false;
            rod2Box.Visible = false;
            rod3Box.Visible = false;
            rod4Box.Visible = false;

            emailBox.ReadOnly = true;
            rodneBox.ReadOnly = true;
            addressBox.ReadOnly = true;
            telephoneBox.ReadOnly = true;

            hypoteka_button.Visible = false;
            auto_uver_button.Visible = false;
            dum_uver_button.Visible = false;
            dalsi_uver_button.Visible = false;

            dum_button.Visible = false;
            auto_button.Visible = false;
            zivotni_button.Visible = false;
            dalsi_pojisteni_button.Visible = false;

            jat_button.Visible = false;
            risk_button.Visible = false;
            safe_button.Visible = false;
            dalsi_investice_button.Visible = false;

            spor1_button.Visible = false;
            spor2_button.Visible = false;
            spor3_button.Visible = false;
            dalsi_sporeni_button.Visible = false;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


        private void nameBox1_TextChanged(object sender, EventArgs e)
        {
            string clientName = nameBox.Text;

            rodneBox.Text = "";
            emailBox.Text = "";
            telephoneBox.Text = "";
            addressBox.Text = "";
            mestobox.Text = "";
            pscbox.Text = "";

            rod1Box.Text = "";  
            rod2Box.Text = "";
            rod3Box.Text = "";
            rod4Box.Text = "";
            rod1Button.Text = "";
            rod2Button.Text = "";
            rod3Button.Text = "";
            rod4Button.Text = "";




            var readcmd = new SqliteCommand("SELECT * FROM clients WHERE Name = @Name", conn);
            readcmd.Parameters.AddWithValue("@Name", clientName);

            var reader = readcmd.ExecuteReader();

           

            while (reader.Read())
            {
                string name = reader.GetString(0);
                string rodne = reader.GetString(1);
                string email = reader.GetString(2);
                string telephone = reader.GetString(3);
                string address = reader.GetString(4);
                
                string rodina1 = reader.GetString(5);
                string rodina2 = reader.GetString(6);
                string rodina3 = reader.GetString(7);
                string rodina4 = reader.GetString(8);
                
                string text1 = reader.GetString(9);
                string text2 = reader.GetString(10);
                string text3 = reader.GetString(11);
                string text4 = reader.GetString(12);
                string text5 = reader.GetString(13);
                string text6 = reader.GetString(14);
                string text7 = reader.GetString(15);
                string text8 = reader.GetString(16);
                string text9 = reader.GetString(17);
                string text10 = reader.GetString(18);
                string text11 = reader.GetString(19);
                string text12 = reader.GetString(20);
                string text13 = reader.GetString(21);
                string text14 = reader.GetString(22);
                string text15 = reader.GetString(23);
                string text16 = reader.GetString(24);

                






                nameBox.Text = name;
                rodneBox.Text = rodne;
                emailBox.Text = email;
                telephoneBox.Text = telephone;
                addressBox.Text = address;
                

                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                
                

                rod1Box.Text = rodina1;
                rod2Box.Text = rodina2;
                rod3Box.Text = rodina3;
                rod4Box.Text = rodina4;

                rod1Button.Text = rod1Box.Text;
                rod2Button.Text = rod2Box.Text;
                rod3Button.Text = rod3Box.Text;
                rod4Button.Text = rod4Box.Text;

                hypo.Text = text1;
                auto_uver.Text = text2;
                dum.Text = text3;
                textBox4.Text = text4;
                textBox5.Text = text5;
                textBox6.Text = text6;
                textBox7.Text = text7;
                textBox8.Text = text8;
                textBox9.Text = text9;
                textBox10.Text = text10;
                textBox11.Text = text11;
                textBox12.Text = text12;
                textBox13.Text = text13;
                textBox14.Text = text14;
                textBox15.Text = text15;
                textBox16.Text = text16;




            }

          

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            nameBox.Text = "";
            rodneBox.Text = "";
            emailBox.Text = "";
            telephoneBox.Text = "";
            addressBox.Text = "";

        }

        private void rodneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telBox_TextChanged(object sender, EventArgs e)
        {

        }

        int change = 0;
        private void editButton_Click(object sender, EventArgs e)
        {


            //muze editovat
            if (change == 0)
            {
                change = 1;
                rod1Box.Visible = true;
                rod2Box.Visible = true;
                rod3Box.Visible = true;
                rod4Box.Visible = true;

                emailBox.ReadOnly = false;
                emailBox.BackColor = Color.WhiteSmoke;
                addressBox.ReadOnly = false;
                addressBox.BackColor = Color.WhiteSmoke;
                rodneBox.ReadOnly = false;
                rodneBox.BackColor = Color.WhiteSmoke;
                telephoneBox.ReadOnly = false;
                telephoneBox.BackColor = Color.WhiteSmoke;
            }
            else
            {
                change = 0;
                rod1Box.Visible = false;
                rod2Box.Visible = false;
                rod3Box.Visible = false;
                rod4Box.Visible = false;

                emailBox.ReadOnly = true;
                emailBox.BackColor = Color.White;
                addressBox.ReadOnly = true;
                addressBox.BackColor = Color.White;
                rodneBox.ReadOnly = true;
                rodneBox.BackColor = Color.White;
                telephoneBox.ReadOnly = true;
                telephoneBox.BackColor = Color.White;
            }

            rod1Button.Text = rod1Box.Text;
            rod2Button.Text = rod2Box.Text;
            rod3Button.Text = rod3Box.Text;
            rod4Button.Text = rod4Box.Text;



            

            string Name = nameBox.Text;
            string Rodne_Cislo = rodneBox.Text;
            string Email = emailBox.Text;
            string Telephone = telephoneBox.Text;
            string Address = addressBox.Text;


            string Rodina1 = rod1Box.Text;
            string Rodina2 = rod2Box.Text;
            string Rodina3 = rod3Box.Text;
            string Rodina4 = rod4Box.Text;

            string txt1 = hypo.Text;
            string txt2 = auto_uver.Text;
            string txt3 = dum.Text;
            string txt4 = textBox4.Text;
            string txt5 = textBox5.Text;
            string txt6 = textBox6.Text;
            string txt7 = textBox7.Text;
            string txt8 = textBox8.Text;
            string txt9 = textBox9.Text;
            string txt10 = textBox10.Text;
            string txt11 = textBox11.Text;
            string txt12 = textBox12.Text;
            string txt13 = textBox13.Text;
            string txt14 = textBox14.Text;
            string txt15 = textBox15.Text;
            string txt16 = textBox16.Text;




            var cmdCheck = new SqliteCommand($"SELECT COUNT(*) FROM clients WHERE Name ='{Name}'", conn);
            int count = Convert.ToInt32(cmdCheck.ExecuteScalar());


            //vytvor noveho client, nebo zmena hodnot
            if (count == 0)
            {
                var cmdInsert = new SqliteCommand($"INSERT INTO clients values ('{Name}','{Rodne_Cislo}','{Email}'," +
                $"'{Telephone}','{Address}','{Rodina1}','{Rodina2}','{Rodina3}','{Rodina4}','{txt1}','{txt2}','{txt3}','{txt4}','{txt5}','{txt6}','{txt7}','{txt8}','{txt9}','{txt10}','{txt11}','{txt12}','{txt13}','{txt14}','{txt15}','{txt16}')", conn);

                cmdInsert.ExecuteNonQuery();
            }
            else
            {
                var cmdUpdate = new SqliteCommand($"UPDATE clients SET Rodne_Cislo='{Rodne_Cislo}', Email='{Email}'," +
                    $" Telephone='{Telephone}', Address='{Address}'," +
                $" Rodina1='{Rodina1}', Rodina2='{Rodina2}', Rodina3='{Rodina3}', Rodina4='{Rodina4}', txt1='{txt1}', txt2='{txt2}', txt3='{txt3}', txt4='{txt4}', txt5='{txt5}', txt6='{txt6}', txt7='{txt7}', txt8='{txt8}', txt9='{txt9}', txt10='{txt10}', txt11='{txt11}', txt12='{txt12}', txt13='{txt14}', txt15='{txt15}', txt16='{txt16}' WHERE Name ='{Name}'", conn);

                cmdUpdate.ExecuteNonQuery();
            }
            

            
            

        }

        //otevre clena rodiny
        private void rod1Button_Click(object sender, EventArgs e)
        {
            nameBox.Text = rod1Box.Text;
        }

        private void rod2Button_Click(object sender, EventArgs e)
        {
            nameBox.Text = rod2Box.Text;
        }

        private void rod3Button_Click(object sender, EventArgs e)
        {
            nameBox.Text = rod3Box.Text;
        }

        private void rod4Button_Click(object sender, EventArgs e)
        {
            nameBox.Text = rod4Box.Text;
        }
        

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            nameBox.Text = "test2";
        }

        private void tel_vice_Click(object sender, EventArgs e)
        {
            //Tel_open.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool uver = false;
        private void button1_Click(object sender, EventArgs e)
        {

            if (uver == false)
            {
                button1.Size = new Size(480, 90);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 90);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 1080);

                button3.Size = new Size(480, 90);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 1215);

                button4.Size = new Size(480, 90);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 1350);



                hypoteka_button.Visible = true;
                auto_uver_button.Visible = true;
                dum_uver_button.Visible = true;
                dalsi_uver_button.Visible = true;


                hypoteka_button.Location = new Point(2150, 585);
                auto_uver_button.Location = new Point(2150, 705);
                dum_uver_button.Location = new Point(2150, 825);
                dalsi_uver_button.Location = new Point(2150, 945);


                //



                uver = true;
            }
            else
            {
                button1.Size = new Size(480, 120);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 120);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 600);

                button3.Size = new Size(480, 120);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 750);

                button4.Size = new Size(480, 120);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 900);



                hypoteka_button.Visible = false;
                auto_uver_button.Visible = false;
                dum_uver_button.Visible = false;
                dalsi_uver_button.Visible = false;




                uver = false;
            }

            dum_button.Visible = false;
            auto_button.Visible = false;
            zivotni_button.Visible = false;
            dalsi_pojisteni_button.Visible = false;

            jat_button.Visible = false;
            risk_button.Visible = false;
            safe_button.Visible = false;
            dalsi_investice_button.Visible = false;

            spor1_button.Visible = false;
            spor2_button.Visible = false;
            spor3_button.Visible = false;
            dalsi_sporeni_button.Visible = false;


        }

        bool pojisteni = false;
        private void button2_Click(object sender, EventArgs e)
        {
           if (pojisteni == false) 
            {
                button1.Size = new Size(480, 90);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 90);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 585);

                button3.Size = new Size(480, 90);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 1215);

                button4.Size = new Size(480, 90);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 1350);





                dum_button.Visible = true;
                auto_button.Visible = true;
                zivotni_button.Visible = true;
                dalsi_pojisteni_button.Visible = true;


                dum_button.Location = new Point(2150, 720);
                auto_button.Location = new Point(2150, 840);
                zivotni_button.Location = new Point(2150, 960);
                dalsi_pojisteni_button.Location = new Point(2150, 1090);

                //

                

                pojisteni = true;
            }
           else
            {
                button1.Size = new Size(480, 120);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 120);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 600);

                button3.Size = new Size(480, 120);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 750);

                button4.Size = new Size(480, 120);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 900);


                dum_button.Visible = false;
                auto_button.Visible = false;
                zivotni_button.Visible = false;
                dalsi_pojisteni_button.Visible = false;


                pojisteni = false;
            }

            hypoteka_button.Visible = false;
            auto_uver_button.Visible = false;
            dum_uver_button.Visible = false;
            dalsi_uver_button.Visible = false;

            jat_button.Visible = false;
            risk_button.Visible = false;
            safe_button.Visible = false;
            dalsi_investice_button.Visible = false;

            spor1_button.Visible = false;
            spor2_button.Visible = false;
            spor3_button.Visible = false;
            dalsi_sporeni_button.Visible = false;

        }

        private void dum_button_Click(object sender, EventArgs e)
        {
            textBox7.Location = new Point(2000, 450);
            textBox7.Visible = true;
        }


        bool auto = false;
        private void auto_button_Click(object sender, EventArgs e)
        {
            textBox5.Location = new Point(2000, 450);
            textBox5.Visible = true;
        }

        bool zivot = false;
        private void zivotni_button_Click(object sender, EventArgs e)
        {
            textBox6.Location = new Point(2000, 450);
            textBox6.Visible = true;
        }

        bool investice = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (investice == false)
            {
                button1.Size = new Size(480, 90);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 90);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 585);

                button3.Size = new Size(480, 90);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 715);

                button4.Size = new Size(480, 90);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 1335);





                jat_button.Visible = true;
                risk_button.Visible = true;
                safe_button.Visible = true;
                dalsi_investice_button.Visible = true;


                jat_button.Location = new Point(2150, 840);
                risk_button.Location = new Point(2150, 960);
                safe_button.Location = new Point(2150, 1080);
                dalsi_investice_button.Location = new Point(2150, 1200);

                //

                

                investice = true;
            }
            else
            {
                button1.Size = new Size(480, 120);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 120);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 600);

                button3.Size = new Size(480, 120);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 750);

                button4.Size = new Size(480, 120);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 900);


                jat_button.Visible = false;
                risk_button.Visible = false;
                safe_button.Visible = false;
                dalsi_investice_button.Visible = false;




                investice = false;
            }

            hypoteka_button.Visible = false;
            auto_uver_button.Visible = false;
            dum_uver_button.Visible = false;
            dalsi_uver_button.Visible = false;

            dum_button.Visible = false;
            auto_button.Visible = false;
            zivotni_button.Visible = false;
            dalsi_pojisteni_button.Visible = false;

            spor1_button.Visible = false;
            spor2_button.Visible = false;
            spor3_button.Visible = false;
            dalsi_sporeni_button.Visible = false;

        }


        bool spor = false;
        private void button4_Click(object sender, EventArgs e)
        {

            if (spor == false)
            {
                button1.Size = new Size(480, 90);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 90);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 585);

                button3.Size = new Size(480, 90);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 705);

                button4.Size = new Size(480, 90);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 825);


                spor1_button.Visible = true;
                spor2_button.Visible = true;
                spor3_button.Visible = true;
                dalsi_sporeni_button.Visible = true;


                spor1_button.Location = new Point(2150, 960);
                spor2_button.Location = new Point(2150, 1080);
                spor3_button.Location = new Point(2150, 1200);
                dalsi_sporeni_button.Location = new Point(2150, 1320);

                //

               


                spor = true;
            }
            else
            {
                button1.Size = new Size(480, 120);
                button1.Font = new Font(button1.Font.FontFamily, 22);

                button2.Size = new Size(480, 120);
                button2.Font = new Font(button2.Font.FontFamily, 22);
                button2.Location = new Point(2090, 600);

                button3.Size = new Size(480, 120);
                button3.Font = new Font(button3.Font.FontFamily, 22);
                button3.Location = new Point(2090, 750);

                button4.Size = new Size(480, 120);
                button4.Font = new Font(button4.Font.FontFamily, 22);
                button4.Location = new Point(2090, 900);



                spor1_button.Visible = false;
                spor2_button.Visible = false;
                spor3_button.Visible = false;
                dalsi_sporeni_button.Visible = false;




                spor = false;
            }

            hypoteka_button.Visible = false;
            auto_uver_button.Visible = false;
            dum_uver_button.Visible = false;
            dalsi_uver_button.Visible = false;

            dum_button.Visible = false;
            auto_button.Visible = false;
            zivotni_button.Visible = false;
            dalsi_pojisteni_button.Visible = false;

            jat_button.Visible = false;
            risk_button.Visible = false;
            safe_button.Visible = false;
            dalsi_investice_button.Visible = false;


        }

        private void home_button_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(480, 120);
            button1.Font = new Font(button1.Font.FontFamily, 22);

            button2.Size = new Size(480, 120);
            button2.Font = new Font(button2.Font.FontFamily, 22);
            button2.Location = new Point(2090, 600);

            button3.Size = new Size(480, 120);
            button3.Font = new Font(button3.Font.FontFamily, 22);
            button3.Location = new Point(2090, 750);

            button4.Size = new Size(480, 120);
            button4.Font = new Font(button4.Font.FontFamily, 22);
            button4.Location = new Point(2090, 900);


            hypoteka_button.Visible = false;
            auto_uver_button.Visible = false;
            dum_uver_button.Visible = false;
            dalsi_uver_button.Visible = false;

            dum_button.Visible = false;
            auto_button.Visible = false;
            zivotni_button.Visible = false;
            dalsi_pojisteni_button.Visible = false;

            jat_button.Visible = false;
            risk_button.Visible = false;
            safe_button.Visible = false;
            dalsi_investice_button.Visible = false;

            spor1_button.Visible = false;
            spor2_button.Visible = false;
            spor3_button.Visible = false;
            dalsi_sporeni_button.Visible = false;

            uver = false;
            investice = false;
            pojisteni = false;
            spor = false;

            hypo.Visible = false;
            auto_uver.Visible = false;
            dum.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            
        }

        private void hypoteka_button_Click(object sender, EventArgs e)
        {
            hypo.Location = new Point(2000, 450);
            hypo.Visible = true;
        }

        private void auto_uver_button_Click(object sender, EventArgs e)
        {
            auto_uver.Location = new Point(2000, 450);
            auto_uver.Visible = true;
        }

        private void dum_uver_button_Click(object sender, EventArgs e)
        {
            dum.Location = new Point(2000, 450);
            dum.Visible = true;
        }

        private void dalsi_pojisteni_button_Click(object sender, EventArgs e)
        {
            textBox8.Location = new Point(2000, 450);
            textBox8.Visible = true;
        }

        private void dalsi_uver_button_Click(object sender, EventArgs e)
        {
            textBox4.Location = new Point(2000, 450);
            textBox4.Visible = true;
        }

        private void jat_button_Click(object sender, EventArgs e)
        {
            textBox9.Location = new Point(2000, 450);
            textBox9.Visible = true;
        }

        private void risk_button_Click(object sender, EventArgs e)
        {
            textBox10.Location = new Point(2000, 450);
            textBox10.Visible = true;
        }

        private void safe_button_Click(object sender, EventArgs e)
        {
            textBox11.Location = new Point(2000, 450);
            textBox11.Visible = true;
        }

        private void dalsi_investice_button_Click(object sender, EventArgs e)
        {
            textBox12.Location = new Point(2000, 450);
            textBox12.Visible = true;
        }

        private void spor1_button_Click(object sender, EventArgs e)
        {
            textBox13.Location = new Point(2000, 450);
            textBox13.Visible = true;
        }

        private void spor2_button_Click(object sender, EventArgs e)
        {
            textBox14.Location = new Point(2000, 450);
            textBox14.Visible = true;
        }

        private void spor3_button_Click(object sender, EventArgs e)
        {
            textBox15.Location = new Point(2000, 450);
            textBox15.Visible = true;
        }

        private void dalsi_sporeni_button_Click(object sender, EventArgs e)
        {
            textBox16.Location = new Point(2000, 450);
            textBox16.Visible = true;
        }
    }
}