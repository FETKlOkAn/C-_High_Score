using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_Score_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] users = new string[100, 2] ;
        bool user_found;
        int count_users = 0;
        int current_score;
        string current_username;


        private void button_register_Click(object sender, EventArgs e)
        {
            user_found = false;
            string username = textBox_register.Text;

            for (int i = 0; i < users.GetLength(0); i++)
            {

                if (users[i,0] == username)
                {
                    user_found = true;
                    MessageBox.Show(users[i, 0]);
                }
            }

            if (user_found)
            {
                MessageBox.Show("Username already exists. Please Log in");
            }
            else
            {
                
                MessageBox.Show(Convert.ToString(count_users));
                users[count_users, 0] = username;
                users[count_users, 1] = "0";
                count_users++;
                MessageBox.Show("Succesfully Created a new User called : " + username);
            }

            textBox_register.Text = "";
        }

        private void button_Log_In_Click(object sender, EventArgs e)
        {
            current_username = textBox_login.Text;
            string score;

            for (int i = 0; i < count_users; i++)
            {

                if (users[i, 0] == current_username)
                {
                    score = users[i, 1];
                    current_score = Convert.ToInt32(score);
                }
            }

            button_play.Enabled = true;
            label_current_user.Text = current_username;

        }

        private void button_play_Click(object sender, EventArgs e)
        {
            button_click_add_point.Enabled = true;
        }

        private void button_click_add_point_Click(object sender, EventArgs e)
        {
            current_score++;
            label_int_score.Text = current_score.ToString();
            for (int i = 0; i < count_users; i++)
            {

                if (users[i, 0] == current_username)
                {
                    users[i, 1] = Convert.ToString(current_score);
                }
            }
        }
    }
}
