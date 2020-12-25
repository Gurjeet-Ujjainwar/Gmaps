
namespace GMaps
{
    partial class Frm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtboxStreet = new System.Windows.Forms.TextBox();
            this.txtboxCity = new System.Windows.Forms.TextBox();
            this.txtboxState = new System.Windows.Forms.TextBox();
            this.txtboxzipcode = new System.Windows.Forms.TextBox();
            this.streetlbl = new System.Windows.Forms.Label();
            this.cityLbl = new System.Windows.Forms.Label();
            this.stateLbl = new System.Windows.Forms.Label();
            this.zipcodeLbl = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer1.Panel1.Controls.Add(this.zipcodeLbl);
            this.splitContainer1.Panel1.Controls.Add(this.stateLbl);
            this.splitContainer1.Panel1.Controls.Add(this.cityLbl);
            this.splitContainer1.Panel1.Controls.Add(this.streetlbl);
            this.splitContainer1.Panel1.Controls.Add(this.txtboxzipcode);
            this.splitContainer1.Panel1.Controls.Add(this.txtboxState);
            this.splitContainer1.Panel1.Controls.Add(this.txtboxCity);
            this.splitContainer1.Panel1.Controls.Add(this.txtboxStreet);
            this.splitContainer1.Panel1.ForeColor = System.Drawing.Color.White;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(530, 450);
            this.webBrowser1.TabIndex = 0;
            // 
            // txtboxStreet
            // 
            this.txtboxStreet.Location = new System.Drawing.Point(62, 52);
            this.txtboxStreet.Name = "txtboxStreet";
            this.txtboxStreet.Size = new System.Drawing.Size(140, 20);
            this.txtboxStreet.TabIndex = 0;
            // 
            // txtboxCity
            // 
            this.txtboxCity.Location = new System.Drawing.Point(62, 109);
            this.txtboxCity.Name = "txtboxCity";
            this.txtboxCity.Size = new System.Drawing.Size(140, 20);
            this.txtboxCity.TabIndex = 1;
            // 
            // txtboxState
            // 
            this.txtboxState.Location = new System.Drawing.Point(62, 167);
            this.txtboxState.Name = "txtboxState";
            this.txtboxState.Size = new System.Drawing.Size(140, 20);
            this.txtboxState.TabIndex = 2;
            // 
            // txtboxzipcode
            // 
            this.txtboxzipcode.Location = new System.Drawing.Point(62, 235);
            this.txtboxzipcode.Name = "txtboxzipcode";
            this.txtboxzipcode.Size = new System.Drawing.Size(140, 20);
            this.txtboxzipcode.TabIndex = 3;
            // 
            // streetlbl
            // 
            this.streetlbl.AutoSize = true;
            this.streetlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streetlbl.Location = new System.Drawing.Point(62, 33);
            this.streetlbl.Name = "streetlbl";
            this.streetlbl.Size = new System.Drawing.Size(49, 16);
            this.streetlbl.TabIndex = 4;
            this.streetlbl.Text = "Street";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLbl.Location = new System.Drawing.Point(62, 93);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(30, 15);
            this.cityLbl.TabIndex = 5;
            this.cityLbl.Text = "City";
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLbl.Location = new System.Drawing.Point(62, 151);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(40, 15);
            this.stateLbl.TabIndex = 6;
            this.stateLbl.Text = "State";
            // 
            // zipcodeLbl
            // 
            this.zipcodeLbl.AutoSize = true;
            this.zipcodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipcodeLbl.Location = new System.Drawing.Point(62, 219);
            this.zipcodeLbl.Name = "zipcodeLbl";
            this.zipcodeLbl.Size = new System.Drawing.Size(64, 15);
            this.zipcodeLbl.TabIndex = 7;
            this.zipcodeLbl.Text = "Zip Code";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(65, 310);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 30);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(6, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Made By Gurjeet";
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Frm";
            this.Text = "GMap";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label zipcodeLbl;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label streetlbl;
        private System.Windows.Forms.TextBox txtboxzipcode;
        private System.Windows.Forms.TextBox txtboxState;
        private System.Windows.Forms.TextBox txtboxCity;
        private System.Windows.Forms.TextBox txtboxStreet;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
    }
}

