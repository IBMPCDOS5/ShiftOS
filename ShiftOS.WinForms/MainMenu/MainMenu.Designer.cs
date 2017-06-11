﻿namespace ShiftOS.WinForms.MainMenu
{
    partial class MainMenu
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
            this.flmenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lbticker = new System.Windows.Forms.Label();
            this.pnloptions = new System.Windows.Forms.Panel();
            this.txtubase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdsport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdsaddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.opt_btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.flcampaign = new System.Windows.Forms.FlowLayoutPanel();
            this.btnnewgame = new System.Windows.Forms.Button();
            this.btncontinue = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.flmenu.SuspendLayout();
            this.pnloptions.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flcampaign.SuspendLayout();
            this.SuspendLayout();
            // 
            // flmenu
            // 
            this.flmenu.AutoSize = true;
            this.flmenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flmenu.Controls.Add(this.button1);
            this.flmenu.Controls.Add(this.button2);
            this.flmenu.Controls.Add(this.button3);
            this.flmenu.Controls.Add(this.button4);
            this.flmenu.Controls.Add(this.button5);
            this.flmenu.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flmenu.Location = new System.Drawing.Point(49, 367);
            this.flmenu.Name = "flmenu";
            this.flmenu.Size = new System.Drawing.Size(187, 145);
            this.flmenu.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Campaign";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(3, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sandbox";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(3, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Settings";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(3, 90);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(181, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "About";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(3, 119);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(181, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lbticker
            // 
            this.lbticker.AutoSize = true;
            this.lbticker.Location = new System.Drawing.Point(29, 515);
            this.lbticker.Name = "lbticker";
            this.lbticker.Size = new System.Drawing.Size(93, 13);
            this.lbticker.TabIndex = 1;
            this.lbticker.Tag = "header3";
            this.lbticker.Text = "This is a tickerbar.";
            // 
            // pnloptions
            // 
            this.pnloptions.Controls.Add(this.txtubase);
            this.pnloptions.Controls.Add(this.label3);
            this.pnloptions.Controls.Add(this.txtdsport);
            this.pnloptions.Controls.Add(this.label2);
            this.pnloptions.Controls.Add(this.txtdsaddress);
            this.pnloptions.Controls.Add(this.label1);
            this.pnloptions.Controls.Add(this.flowLayoutPanel1);
            this.pnloptions.Location = new System.Drawing.Point(49, 26);
            this.pnloptions.Name = "pnloptions";
            this.pnloptions.Size = new System.Drawing.Size(432, 290);
            this.pnloptions.TabIndex = 2;
            // 
            // txtubase
            // 
            this.txtubase.Location = new System.Drawing.Point(146, 133);
            this.txtubase.Name = "txtubase";
            this.txtubase.Size = new System.Drawing.Size(225, 20);
            this.txtubase.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unite API base URL:";
            // 
            // txtdsport
            // 
            this.txtdsport.Location = new System.Drawing.Point(146, 85);
            this.txtdsport.Name = "txtdsport";
            this.txtdsport.Size = new System.Drawing.Size(225, 20);
            this.txtdsport.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digital Society Port:";
            // 
            // txtdsaddress
            // 
            this.txtdsaddress.Location = new System.Drawing.Point(146, 54);
            this.txtdsaddress.Name = "txtdsaddress";
            this.txtdsaddress.Size = new System.Drawing.Size(225, 20);
            this.txtdsaddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digital Society Address:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.opt_btncancel);
            this.flowLayoutPanel1.Controls.Add(this.btnsave);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 259);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 31);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // opt_btncancel
            // 
            this.opt_btncancel.AutoSize = true;
            this.opt_btncancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.opt_btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.opt_btncancel.Location = new System.Drawing.Point(377, 3);
            this.opt_btncancel.Name = "opt_btncancel";
            this.opt_btncancel.Size = new System.Drawing.Size(52, 25);
            this.opt_btncancel.TabIndex = 0;
            this.opt_btncancel.Text = "Cancel";
            this.opt_btncancel.UseVisualStyleBackColor = true;
            this.opt_btncancel.Click += new System.EventHandler(this.opt_btncancel_Click);
            // 
            // btnsave
            // 
            this.btnsave.AutoSize = true;
            this.btnsave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Location = new System.Drawing.Point(327, 3);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(44, 25);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // flcampaign
            // 
            this.flcampaign.AutoSize = true;
            this.flcampaign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flcampaign.Controls.Add(this.btnnewgame);
            this.flcampaign.Controls.Add(this.btncontinue);
            this.flcampaign.Controls.Add(this.button10);
            this.flcampaign.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flcampaign.Location = new System.Drawing.Point(242, 364);
            this.flcampaign.Name = "flcampaign";
            this.flcampaign.Size = new System.Drawing.Size(187, 87);
            this.flcampaign.TabIndex = 3;
            // 
            // btnnewgame
            // 
            this.btnnewgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnewgame.Location = new System.Drawing.Point(3, 3);
            this.btnnewgame.Name = "btnnewgame";
            this.btnnewgame.Size = new System.Drawing.Size(181, 23);
            this.btnnewgame.TabIndex = 0;
            this.btnnewgame.Text = "New Game";
            this.btnnewgame.UseVisualStyleBackColor = true;
            this.btnnewgame.Click += new System.EventHandler(this.btnnewgame_Click);
            // 
            // btncontinue
            // 
            this.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontinue.Location = new System.Drawing.Point(3, 32);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(181, 23);
            this.btncontinue.TabIndex = 1;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = true;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // button10
            // 
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(3, 61);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(181, 23);
            this.button10.TabIndex = 4;
            this.button10.Text = "Back";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1161, 566);
            this.Controls.Add(this.flcampaign);
            this.Controls.Add(this.pnloptions);
            this.Controls.Add(this.lbticker);
            this.Controls.Add(this.flmenu);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.flmenu.ResumeLayout(false);
            this.pnloptions.ResumeLayout(false);
            this.pnloptions.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flcampaign.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flmenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lbticker;
        private System.Windows.Forms.Panel pnloptions;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button opt_btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtubase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdsport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdsaddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flcampaign;
        private System.Windows.Forms.Button btnnewgame;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Button button10;
    }
}