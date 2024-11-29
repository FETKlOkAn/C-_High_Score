namespace High_Score_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Log_In = new System.Windows.Forms.Button();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_new_here = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_register = new System.Windows.Forms.TextBox();
            this.button_register = new System.Windows.Forms.Button();
            this.button_play = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_click_add_point = new System.Windows.Forms.Button();
            this.label_score = new System.Windows.Forms.Label();
            this.label_int_score = new System.Windows.Forms.Label();
            this.label_current_user = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label_High_Score = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Log_In
            // 
            this.button_Log_In.Location = new System.Drawing.Point(52, 89);
            this.button_Log_In.Name = "button_Log_In";
            this.button_Log_In.Size = new System.Drawing.Size(100, 23);
            this.button_Log_In.TabIndex = 0;
            this.button_Log_In.Text = "Log In";
            this.button_Log_In.UseVisualStyleBackColor = true;
            this.button_Log_In.Click += new System.EventHandler(this.button_Log_In_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_login.Location = new System.Drawing.Point(52, 63);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 1;
            // 
            // label_new_here
            // 
            this.label_new_here.AutoSize = true;
            this.label_new_here.Location = new System.Drawing.Point(49, 135);
            this.label_new_here.Name = "label_new_here";
            this.label_new_here.Size = new System.Drawing.Size(112, 13);
            this.label_new_here.TabIndex = 2;
            this.label_new_here.Text = "New Here?  Register :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_register
            // 
            this.textBox_register.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_register.Location = new System.Drawing.Point(52, 173);
            this.textBox_register.Name = "textBox_register";
            this.textBox_register.Size = new System.Drawing.Size(100, 20);
            this.textBox_register.TabIndex = 5;
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(52, 199);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(100, 23);
            this.button_register.TabIndex = 4;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(246, 63);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 6;
            this.button_play.Text = "Play Game";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button_click_add_point);
            this.panel1.Location = new System.Drawing.Point(252, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 317);
            this.panel1.TabIndex = 7;
            // 
            // button_click_add_point
            // 
            this.button_click_add_point.Enabled = false;
            this.button_click_add_point.Location = new System.Drawing.Point(126, 150);
            this.button_click_add_point.Name = "button_click_add_point";
            this.button_click_add_point.Size = new System.Drawing.Size(136, 23);
            this.button_click_add_point.TabIndex = 0;
            this.button_click_add_point.Text = "Click to Add a Point !";
            this.button_click_add_point.UseVisualStyleBackColor = true;
            this.button_click_add_point.Click += new System.EventHandler(this.button_click_add_point_Click);
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Location = new System.Drawing.Point(526, 70);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(41, 13);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "Score :";
            // 
            // label_int_score
            // 
            this.label_int_score.AutoSize = true;
            this.label_int_score.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_int_score.Location = new System.Drawing.Point(573, 66);
            this.label_int_score.Name = "label_int_score";
            this.label_int_score.Size = new System.Drawing.Size(16, 17);
            this.label_int_score.TabIndex = 9;
            this.label_int_score.Text = "0";
            // 
            // label_current_user
            // 
            this.label_current_user.AutoSize = true;
            this.label_current_user.Location = new System.Drawing.Point(69, 261);
            this.label_current_user.Name = "label_current_user";
            this.label_current_user.Size = new System.Drawing.Size(69, 13);
            this.label_current_user.TabIndex = 10;
            this.label_current_user.Text = "Current User:";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(81, 290);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(0, 13);
            this.label_user.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(754, 106);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(304, 314);
            this.textBox2.TabIndex = 12;
            // 
            // label_High_Score
            // 
            this.label_High_Score.AutoSize = true;
            this.label_High_Score.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_High_Score.Location = new System.Drawing.Point(760, 70);
            this.label_High_Score.Name = "label_High_Score";
            this.label_High_Score.Size = new System.Drawing.Size(165, 26);
            this.label_High_Score.TabIndex = 13;
            this.label_High_Score.Text = "High Score Table";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 729);
            this.Controls.Add(this.label_High_Score);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label_current_user);
            this.Controls.Add(this.label_int_score);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBox_register);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.label_new_here);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.button_Log_In);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Log_In;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.Label label_new_here;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_register;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_click_add_point;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_int_score;
        private System.Windows.Forms.Label label_current_user;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label_High_Score;
    }
}

