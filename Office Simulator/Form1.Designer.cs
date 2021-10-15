
namespace Office_Simulator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.currentCash = new System.Windows.Forms.Button();
            this.bt_market = new System.Windows.Forms.Button();
            this.bt_darkweb = new System.Windows.Forms.Button();
            this.mark_basicOffice = new System.Windows.Forms.Button();
            this.mark_icon_basicoffice = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.employee_1 = new System.Windows.Forms.Button();
            this.employee_2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mark_icon_basicoffice)).BeginInit();
            this.SuspendLayout();
            // 
            // currentCash
            // 
            this.currentCash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.currentCash.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.currentCash.ForeColor = System.Drawing.Color.Green;
            this.currentCash.Location = new System.Drawing.Point(12, 381);
            this.currentCash.Name = "currentCash";
            this.currentCash.Size = new System.Drawing.Size(232, 57);
            this.currentCash.TabIndex = 0;
            this.currentCash.Text = "CASH: 5000";
            this.currentCash.UseVisualStyleBackColor = true;
            this.currentCash.Click += new System.EventHandler(this.currentCash_Click);
            // 
            // bt_market
            // 
            this.bt_market.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_market.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_market.ForeColor = System.Drawing.Color.Green;
            this.bt_market.Location = new System.Drawing.Point(250, 381);
            this.bt_market.Name = "bt_market";
            this.bt_market.Size = new System.Drawing.Size(232, 57);
            this.bt_market.TabIndex = 1;
            this.bt_market.Text = "Market";
            this.bt_market.UseVisualStyleBackColor = true;
            this.bt_market.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_darkweb
            // 
            this.bt_darkweb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_darkweb.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.bt_darkweb.ForeColor = System.Drawing.Color.Green;
            this.bt_darkweb.Location = new System.Drawing.Point(488, 428);
            this.bt_darkweb.Name = "bt_darkweb";
            this.bt_darkweb.Size = new System.Drawing.Size(232, 10);
            this.bt_darkweb.TabIndex = 2;
            this.bt_darkweb.Text = "Blackmarket";
            this.bt_darkweb.UseVisualStyleBackColor = true;
            // 
            // mark_basicOffice
            // 
            this.mark_basicOffice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mark_basicOffice.Location = new System.Drawing.Point(250, 335);
            this.mark_basicOffice.Name = "mark_basicOffice";
            this.mark_basicOffice.Size = new System.Drawing.Size(232, 40);
            this.mark_basicOffice.TabIndex = 3;
            this.mark_basicOffice.Text = "Basic Office";
            this.mark_basicOffice.UseVisualStyleBackColor = true;
            this.mark_basicOffice.Click += new System.EventHandler(this.mark_basicOffice_Click);
            // 
            // mark_icon_basicoffice
            // 
            this.mark_icon_basicoffice.Image = ((System.Drawing.Image)(resources.GetObject("mark_icon_basicoffice.Image")));
            this.mark_icon_basicoffice.InitialImage = ((System.Drawing.Image)(resources.GetObject("mark_icon_basicoffice.InitialImage")));
            this.mark_icon_basicoffice.Location = new System.Drawing.Point(12, 12);
            this.mark_icon_basicoffice.Name = "mark_icon_basicoffice";
            this.mark_icon_basicoffice.Size = new System.Drawing.Size(404, 201);
            this.mark_icon_basicoffice.TabIndex = 4;
            this.mark_icon_basicoffice.TabStop = false;
            this.mark_icon_basicoffice.Visible = false;
            this.mark_icon_basicoffice.Click += new System.EventHandler(this.mark_icon_basicoffice_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 219);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(404, 20);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(726, 381);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Employees";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // employee_1
            // 
            this.employee_1.Location = new System.Drawing.Point(726, 335);
            this.employee_1.Name = "employee_1";
            this.employee_1.Size = new System.Drawing.Size(227, 39);
            this.employee_1.TabIndex = 7;
            this.employee_1.Text = "employee_1";
            this.employee_1.UseVisualStyleBackColor = true;
            this.employee_1.Click += new System.EventHandler(this.employee_1_Click);
            // 
            // employee_2
            // 
            this.employee_2.Location = new System.Drawing.Point(726, 290);
            this.employee_2.Name = "employee_2";
            this.employee_2.Size = new System.Drawing.Size(227, 39);
            this.employee_2.TabIndex = 8;
            this.employee_2.Text = "employee_2";
            this.employee_2.UseVisualStyleBackColor = true;
            this.employee_2.Click += new System.EventHandler(this.employee_2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(250, 289);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "4D Developers";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.employee_2);
            this.Controls.Add(this.employee_1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.mark_icon_basicoffice);
            this.Controls.Add(this.mark_basicOffice);
            this.Controls.Add(this.bt_darkweb);
            this.Controls.Add(this.bt_market);
            this.Controls.Add(this.currentCash);
            this.Name = "Form1";
            this.Text = "Office Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mark_icon_basicoffice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button currentCash;
        private System.Windows.Forms.Button bt_market;
        private System.Windows.Forms.Button bt_darkweb;
        private System.Windows.Forms.Button mark_basicOffice;
        private System.Windows.Forms.PictureBox mark_icon_basicoffice;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button employee_1;
        private System.Windows.Forms.Button employee_2;
        private System.Windows.Forms.Button button2;
    }
}

