namespace minestat_client
{
    partial class MineStat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MineStat));
            this.ip_value = new System.Windows.Forms.TextBox();
            this.ip_label = new System.Windows.Forms.Label();
            this.port_label = new System.Windows.Forms.Label();
            this.port_value = new System.Windows.Forms.TextBox();
            this.confirm_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.version_value = new System.Windows.Forms.Label();
            this.version_label = new System.Windows.Forms.Label();
            this.message_value = new System.Windows.Forms.Label();
            this.server_message_label = new System.Windows.Forms.Label();
            this.players_value = new System.Windows.Forms.Label();
            this.server_player_label = new System.Windows.Forms.Label();
            this.server_value = new System.Windows.Forms.Label();
            this.server_name_label = new System.Windows.Forms.Label();
            this.status_value = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ip_value
            // 
            this.ip_value.BackColor = System.Drawing.Color.Red;
            this.ip_value.Location = new System.Drawing.Point(56, 41);
            this.ip_value.Name = "ip_value";
            this.ip_value.Size = new System.Drawing.Size(188, 20);
            this.ip_value.TabIndex = 0;
            this.ip_value.Validating += new System.ComponentModel.CancelEventHandler(this.ip_value_Validating);
            // 
            // ip_label
            // 
            this.ip_label.AutoSize = true;
            this.ip_label.Location = new System.Drawing.Point(15, 48);
            this.ip_label.Name = "ip_label";
            this.ip_label.Size = new System.Drawing.Size(17, 13);
            this.ip_label.TabIndex = 1;
            this.ip_label.Text = "IP";
            // 
            // port_label
            // 
            this.port_label.AutoSize = true;
            this.port_label.Location = new System.Drawing.Point(251, 47);
            this.port_label.Name = "port_label";
            this.port_label.Size = new System.Drawing.Size(26, 13);
            this.port_label.TabIndex = 2;
            this.port_label.Text = "Port";
            // 
            // port_value
            // 
            this.port_value.BackColor = System.Drawing.Color.White;
            this.port_value.Location = new System.Drawing.Point(293, 40);
            this.port_value.Name = "port_value";
            this.port_value.Size = new System.Drawing.Size(100, 20);
            this.port_value.TabIndex = 3;
            this.port_value.Text = "25565";
            this.port_value.TextChanged += new System.EventHandler(this.port_value_TextChanged);
            // 
            // confirm_button
            // 
            this.confirm_button.Location = new System.Drawing.Point(18, 82);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(113, 23);
            this.confirm_button.TabIndex = 5;
            this.confirm_button.Text = "Check";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.version_value);
            this.panel1.Controls.Add(this.version_label);
            this.panel1.Controls.Add(this.message_value);
            this.panel1.Controls.Add(this.server_message_label);
            this.panel1.Controls.Add(this.players_value);
            this.panel1.Controls.Add(this.server_player_label);
            this.panel1.Controls.Add(this.server_value);
            this.panel1.Controls.Add(this.server_name_label);
            this.panel1.Location = new System.Drawing.Point(18, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 146);
            this.panel1.TabIndex = 6;
            // 
            // version_value
            // 
            this.version_value.AutoSize = true;
            this.version_value.BackColor = System.Drawing.Color.White;
            this.version_value.Location = new System.Drawing.Point(190, 82);
            this.version_value.Name = "version_value";
            this.version_value.Size = new System.Drawing.Size(0, 13);
            this.version_value.TabIndex = 7;
            // 
            // version_label
            // 
            this.version_label.AutoSize = true;
            this.version_label.Location = new System.Drawing.Point(38, 82);
            this.version_label.Name = "version_label";
            this.version_label.Size = new System.Drawing.Size(42, 13);
            this.version_label.TabIndex = 6;
            this.version_label.Text = "Version";
            // 
            // message_value
            // 
            this.message_value.AutoSize = true;
            this.message_value.BackColor = System.Drawing.Color.White;
            this.message_value.Location = new System.Drawing.Point(190, 116);
            this.message_value.Name = "message_value";
            this.message_value.Size = new System.Drawing.Size(0, 13);
            this.message_value.TabIndex = 5;
            // 
            // server_message_label
            // 
            this.server_message_label.AutoSize = true;
            this.server_message_label.Location = new System.Drawing.Point(38, 116);
            this.server_message_label.Name = "server_message_label";
            this.server_message_label.Size = new System.Drawing.Size(83, 13);
            this.server_message_label.TabIndex = 4;
            this.server_message_label.Text = "Server message";
            // 
            // players_value
            // 
            this.players_value.AutoSize = true;
            this.players_value.BackColor = System.Drawing.Color.White;
            this.players_value.Location = new System.Drawing.Point(190, 45);
            this.players_value.Name = "players_value";
            this.players_value.Size = new System.Drawing.Size(0, 13);
            this.players_value.TabIndex = 3;
            // 
            // server_player_label
            // 
            this.server_player_label.AutoSize = true;
            this.server_player_label.Location = new System.Drawing.Point(38, 45);
            this.server_player_label.Name = "server_player_label";
            this.server_player_label.Size = new System.Drawing.Size(92, 13);
            this.server_player_label.TabIndex = 2;
            this.server_player_label.Text = "Number of players";
            // 
            // server_value
            // 
            this.server_value.AutoSize = true;
            this.server_value.BackColor = System.Drawing.Color.White;
            this.server_value.Location = new System.Drawing.Point(190, 12);
            this.server_value.Name = "server_value";
            this.server_value.Size = new System.Drawing.Size(0, 13);
            this.server_value.TabIndex = 1;
            // 
            // server_name_label
            // 
            this.server_name_label.AutoSize = true;
            this.server_name_label.Location = new System.Drawing.Point(38, 12);
            this.server_name_label.Name = "server_name_label";
            this.server_name_label.Size = new System.Drawing.Size(67, 13);
            this.server_name_label.TabIndex = 0;
            this.server_name_label.Text = "Server name";
            // 
            // status_value
            // 
            this.status_value.BackColor = System.Drawing.Color.Yellow;
            this.status_value.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.status_value.Location = new System.Drawing.Point(18, 117);
            this.status_value.Name = "status_value";
            this.status_value.Size = new System.Drawing.Size(375, 26);
            this.status_value.TabIndex = 7;
            this.status_value.Text = "Status pending";
            this.status_value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MineStat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 311);
            this.Controls.Add(this.status_value);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.confirm_button);
            this.Controls.Add(this.port_value);
            this.Controls.Add(this.port_label);
            this.Controls.Add(this.ip_label);
            this.Controls.Add(this.ip_value);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 350);
            this.MinimumSize = new System.Drawing.Size(430, 350);
            this.Name = "MineStat";
            this.Text = "MineStat";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ip_value;
        private System.Windows.Forms.Label ip_label;
        private System.Windows.Forms.Label port_label;
        private System.Windows.Forms.TextBox port_value;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label message_value;
        private System.Windows.Forms.Label server_message_label;
        private System.Windows.Forms.Label players_value;
        private System.Windows.Forms.Label server_player_label;
        private System.Windows.Forms.Label server_value;
        private System.Windows.Forms.Label server_name_label;
        private System.Windows.Forms.Label version_label;
        private System.Windows.Forms.Label version_value;
        private System.Windows.Forms.Label status_value;
    }
}

