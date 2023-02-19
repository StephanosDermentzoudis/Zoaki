using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ZoakiFinal
{
    public partial class Form1 : Form
    {
        String difficulty = "Medium";
        int cclicks;
        private int _ticks;
        private int _clicks;
        private int diskolia = 11;
        int x, y;
        public int[] Xarr = new int[720];
        public int[] Yarr = new int[330];

        public class animal
        {
            public string name = "name";
        }

        public class player
        {
            public string username;
        }
        public Form1()
        {
            InitializeComponent();
            ReturnBTN.Location = new Point(10000, 200);
            this.dataGridView1.Location = new Point(10000, 195);
            Stats.Location = new Point(24, 416);
            Save.Location = new Point(24, 387);

            textBox1.Text = "Unnamed";
            textBox1.Location = new Point(186, 100);
            player Pplayer = new player();
            Pplayer.username = textBox1.Text;

            this.capybara.Location = new System.Drawing.Point(314, 136);
            this.buttoneasy.Location = new System.Drawing.Point(379, 12);
            this.buttonnormal.Location = new System.Drawing.Point(523, 12);
            this.buttonext.Location = new System.Drawing.Point(663, 12);
            for (int i = 20; i < Xarr.Length; i++)
            {
                Xarr.Append(i);
            };
            for (int i = 20; i < Yarr.Length; i++)
            {
                Yarr.Append(i);
            };
            animal Capybara = new animal();

            Capybara.name = "Capybara";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //capybara
            cclicks = 0;
            Stats.Location = new Point(20004, 416);
            Save.Location = new Point(20004, 387);
            textBox1.Location = new Point(18006, 100);
            this.buttoneasy.Location = new System.Drawing.Point(37900, 12);
            this.buttonnormal.Location = new System.Drawing.Point(52300, 12);
            this.buttonext.Location = new System.Drawing.Point(66300, 12);
            timer1.Start();
            timer2.Start();
            label2.Text = "Clicks " + _clicks;
            _clicks++;
        }





        private void buttonext_Click(object sender, EventArgs e)
        {
            difficulty = "Extreme";
            diskolia = 6;
            MessageBox.Show("Υπέρτατη δυσκολία έχεις 5 δευτερόλεπτα!");
            this.timer2.Interval = 500;
        }

        private void buttonnormal_Click(object sender, EventArgs e)
        {
            difficulty = "Medium";
            diskolia = 11;
            MessageBox.Show("Μέτρια δυσκολία έχεις 10 δευτερόλεπτα!");
            this.timer2.Interval = 1000;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }






        private void ReturnBTN_Click(object sender, EventArgs e)
        {
            ReturnBTN.Location = new Point(10000, 200);
            this.dataGridView1.Location = new Point(10000, 195);

        }

        private void capybara_Click(object sender, EventArgs e)
        {
            Stats.Location = new Point(20004, 416);
            Save.Location = new Point(20004, 387);
            textBox1.Location = new Point(18006, 100);
            this.buttoneasy.Location = new System.Drawing.Point(37900, 12);
            this.buttonnormal.Location = new System.Drawing.Point(52300, 12);
            this.buttonext.Location = new System.Drawing.Point(66300, 12);
            timer1.Start();
            timer2.Start();
            label2.Text = "Clicks " + _clicks;
            _clicks++;
        }

        private void ReturnBTN_Click_1(object sender, EventArgs e)
        {
            ReturnBTN.Location = new Point(10000, 200);
            this.dataGridView1.Location = new Point(10000, 195);
        }



        private void buttonnormal_Click_1(object sender, EventArgs e)
        {
            difficulty = "Medium";
            diskolia = 11;
            MessageBox.Show("Μέτρια δυσκολία έχεις 10 δευτερόλεπτα!");
            this.timer2.Interval = 1000;
        }

        private void buttoneasy_Click(object sender, EventArgs e)
        {
            difficulty = "Easy";
            diskolia = 16;
            MessageBox.Show("Εύκολη δυσκολία έχεις 15 δευτερόλεπτα!");
            this.timer2.Interval = 1500;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Save_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\stefan\\Documents\\ZoakiDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into ZoakiDt values (@Username,@Clicks,@Difficulty)", con);
            cmd.Parameters.AddWithValue("@Username", (textBox1.Text));
            cmd.Parameters.AddWithValue("@Clicks", (cclicks.ToString()));
            cmd.Parameters.AddWithValue("@Difficulty", difficulty);

            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Saved Succesfully");
        }

        public void Stats_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\stefan\\Documents\\ZoakiDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from ZoakiDt", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            this.dataGridView1.Location = new System.Drawing.Point(193, 195);
            ReturnBTN.Location = new System.Drawing.Point(25, 206);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //reset
            timer1.Stop();
            timer2.Stop();

            Stats.Location = new Point(24, 416);
            Save.Location = new Point(24, 387);
            this.buttoneasy.Location = new System.Drawing.Point(379, 12);
            this.buttonnormal.Location = new System.Drawing.Point(523, 12);
            this.buttonext.Location = new System.Drawing.Point(663, 12);
            _clicks = 0;
            _ticks = 0;
            label1.Text = "Timer: 0";
            label2.Text = "Clicks: 0";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //timer
            _ticks++;
            label1.Text = "Time: " + _ticks;

            if (_ticks == diskolia)
            {
                timer1.Stop();
                timer2.Stop();

                cclicks = _clicks;
                Stats.Location = new Point(24, 416);
                Save.Location = new Point(24, 387);
                this.buttoneasy.Location = new System.Drawing.Point(379, 12);
                this.buttonnormal.Location = new System.Drawing.Point(523, 12);
                this.buttonext.Location = new System.Drawing.Point(663, 12);
                label1.Text = "Game Over";
                label2.Text = "Your clicks: " + _clicks;
                _ticks = 0;
                _clicks = 0;
                MessageBox.Show("Time is up!");
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            Random rand = new Random();
            x = rand.Next(Xarr.Length);
            y = rand.Next(Yarr.Length);
            this.capybara.Location = new System.Drawing.Point(x, y);
        }

        private void buttonext_Click_1(object sender, EventArgs e)
        {
            difficulty = "Extreme";
            diskolia = 6;
            MessageBox.Show("Υπέρτατη δυσκολία έχεις 5 δευτερόλεπτα!");
            this.timer2.Interval = 500;
        }




    }
}
    



