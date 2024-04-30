namespace SchedulingSimulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSave = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblIO = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxTime = new System.Windows.Forms.TextBox();
            this.boxIO = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(121, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(79, 28);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(56, 115);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(56, 169);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(56, 220);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // lblIO
            // 
            this.lblIO.AutoSize = true;
            this.lblIO.Location = new System.Drawing.Point(56, 267);
            this.lblIO.Name = "lblIO";
            this.lblIO.Size = new System.Drawing.Size(23, 13);
            this.lblIO.TabIndex = 4;
            this.lblIO.Text = "I/O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(85, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Add Process";
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxName.Location = new System.Drawing.Point(121, 112);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(171, 25);
            this.boxName.TabIndex = 1;
            this.boxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxName_KeyPress);
            // 
            // boxID
            // 
            this.boxID.Enabled = false;
            this.boxID.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxID.Location = new System.Drawing.Point(121, 162);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(171, 25);
            this.boxID.TabIndex = 2;
            this.boxID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxID_KeyPress);
            // 
            // boxTime
            // 
            this.boxTime.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxTime.Location = new System.Drawing.Point(121, 213);
            this.boxTime.Name = "boxTime";
            this.boxTime.Size = new System.Drawing.Size(171, 25);
            this.boxTime.TabIndex = 3;
            this.boxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTime_KeyPress);
            // 
            // boxIO
            // 
            this.boxIO.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.boxIO.Location = new System.Drawing.Point(121, 264);
            this.boxIO.Name = "boxIO";
            this.boxIO.Size = new System.Drawing.Size(171, 25);
            this.boxIO.TabIndex = 4;
            this.boxIO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxIO_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(354, 26);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 26);
            this.panel2.TabIndex = 12;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(215, 315);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(77, 28);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 409);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boxIO);
            this.Controls.Add(this.boxTime);
            this.Controls.Add(this.boxID);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblIO);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnSave);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(147, 170);
            this.Name = "Form1";
            this.Text = "CPU-Scheduling-Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.TextBox boxTime;
        private System.Windows.Forms.TextBox boxIO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReset;
    }
}

