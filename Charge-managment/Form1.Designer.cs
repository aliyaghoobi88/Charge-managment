
namespace Charge_managment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbx_charger_Remain = new System.Windows.Forms.TextBox();
            this.lbl_remain = new System.Windows.Forms.Label();
            this.tbx_lineStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_hsp = new System.Windows.Forms.Label();
            this.tbx_highsp = new System.Windows.Forms.TextBox();
            this.SYS_tick = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.tbx_rly_ip = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_rly_port = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_lowsp = new System.Windows.Forms.TextBox();
            this.lbl_lsp = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbx_charger_Remain
            // 
            this.tbx_charger_Remain.Location = new System.Drawing.Point(92, 40);
            this.tbx_charger_Remain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_charger_Remain.Name = "tbx_charger_Remain";
            this.tbx_charger_Remain.Size = new System.Drawing.Size(176, 20);
            this.tbx_charger_Remain.TabIndex = 1;
            // 
            // lbl_remain
            // 
            this.lbl_remain.AutoSize = true;
            this.lbl_remain.Location = new System.Drawing.Point(20, 40);
            this.lbl_remain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_remain.Name = "lbl_remain";
            this.lbl_remain.Size = new System.Drawing.Size(43, 13);
            this.lbl_remain.TabIndex = 4;
            this.lbl_remain.Text = "Remain";
            // 
            // tbx_lineStatus
            // 
            this.tbx_lineStatus.Location = new System.Drawing.Point(92, 13);
            this.tbx_lineStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_lineStatus.Name = "tbx_lineStatus";
            this.tbx_lineStatus.Size = new System.Drawing.Size(176, 20);
            this.tbx_lineStatus.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Line Staus";
            // 
            // lbl_hsp
            // 
            this.lbl_hsp.AutoSize = true;
            this.lbl_hsp.Location = new System.Drawing.Point(16, 30);
            this.lbl_hsp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_hsp.Name = "lbl_hsp";
            this.lbl_hsp.Size = new System.Drawing.Size(65, 13);
            this.lbl_hsp.TabIndex = 11;
            this.lbl_hsp.Text = "High Setpint";
            // 
            // tbx_highsp
            // 
            this.tbx_highsp.Location = new System.Drawing.Point(92, 26);
            this.tbx_highsp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_highsp.Name = "tbx_highsp";
            this.tbx_highsp.Size = new System.Drawing.Size(176, 20);
            this.tbx_highsp.TabIndex = 10;
            this.tbx_highsp.Text = "80";
            // 
            // SYS_tick
            // 
            this.SYS_tick.Enabled = true;
            this.SYS_tick.Interval = 3000;
            this.SYS_tick.Tick += new System.EventHandler(this.SYS_tick_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IP Address";
            // 
            // tbx_rly_ip
            // 
            this.tbx_rly_ip.Location = new System.Drawing.Point(80, 11);
            this.tbx_rly_ip.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_rly_ip.Name = "tbx_rly_ip";
            this.tbx_rly_ip.Size = new System.Drawing.Size(176, 20);
            this.tbx_rly_ip.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Port";
            // 
            // tbx_rly_port
            // 
            this.tbx_rly_port.Location = new System.Drawing.Point(80, 41);
            this.tbx_rly_port.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_rly_port.Name = "tbx_rly_port";
            this.tbx_rly_port.Size = new System.Drawing.Size(176, 20);
            this.tbx_rly_port.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbx_lineStatus);
            this.groupBox1.Controls.Add(this.lbl_remain);
            this.groupBox1.Controls.Add(this.tbx_charger_Remain);
            this.groupBox1.Location = new System.Drawing.Point(33, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(286, 82);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Charger  ";
            // 
            // tbx_lowsp
            // 
            this.tbx_lowsp.Location = new System.Drawing.Point(92, 58);
            this.tbx_lowsp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_lowsp.Name = "tbx_lowsp";
            this.tbx_lowsp.Size = new System.Drawing.Size(176, 20);
            this.tbx_lowsp.TabIndex = 8;
            this.tbx_lowsp.Text = "40";
            // 
            // lbl_lsp
            // 
            this.lbl_lsp.AutoSize = true;
            this.lbl_lsp.Location = new System.Drawing.Point(16, 61);
            this.lbl_lsp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_lsp.Name = "lbl_lsp";
            this.lbl_lsp.Size = new System.Drawing.Size(69, 13);
            this.lbl_lsp.TabIndex = 9;
            this.lbl_lsp.Text = "Low Setpoint";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_hsp);
            this.groupBox2.Controls.Add(this.tbx_highsp);
            this.groupBox2.Controls.Add(this.lbl_lsp);
            this.groupBox2.Controls.Add(this.tbx_lowsp);
            this.groupBox2.Location = new System.Drawing.Point(32, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(286, 93);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condition";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbx_rly_ip);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tbx_rly_port);
            this.groupBox3.Location = new System.Drawing.Point(326, 33);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(265, 78);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Relay Setting";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(32, 214);
            this.btn_save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(80, 22);
            this.btn_save.TabIndex = 20;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 251);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laptop Battery Protector";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbx_charger_Remain;
        private System.Windows.Forms.Label lbl_remain;
        private System.Windows.Forms.TextBox tbx_lineStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_hsp;
        private System.Windows.Forms.TextBox tbx_highsp;
        private System.Windows.Forms.Timer SYS_tick;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbx_rly_ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_rly_port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbx_lowsp;
        private System.Windows.Forms.Label lbl_lsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

