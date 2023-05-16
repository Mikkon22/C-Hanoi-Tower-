
namespace HanoiTower
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnAuxiliary = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlBackground = new System.Windows.Forms.Panel();
            this.ring7 = new System.Windows.Forms.Panel();
            this.ring6 = new System.Windows.Forms.Panel();
            this.ring5 = new System.Windows.Forms.Panel();
            this.ring4 = new System.Windows.Forms.Panel();
            this.ring3 = new System.Windows.Forms.Panel();
            this.ring2 = new System.Windows.Forms.Panel();
            this.ring1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblCounter = new System.Windows.Forms.Label();
            this.lblLicznik = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStart.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStart.Location = new System.Drawing.Point(3, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(439, 132);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Startowy";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAuxiliary
            // 
            this.btnAuxiliary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAuxiliary.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAuxiliary.Location = new System.Drawing.Point(448, 3);
            this.btnAuxiliary.Name = "btnAuxiliary";
            this.btnAuxiliary.Size = new System.Drawing.Size(439, 132);
            this.btnAuxiliary.TabIndex = 1;
            this.btnAuxiliary.Text = "Pomocniczy";
            this.btnAuxiliary.UseVisualStyleBackColor = true;
            this.btnAuxiliary.Click += new System.EventHandler(this.btnAuxiliary_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDestination.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDestination.Location = new System.Drawing.Point(893, 3);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(441, 132);
            this.btnDestination.TabIndex = 2;
            this.btnDestination.Text = "Docelowy";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.btnDestination, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAuxiliary, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 444);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1337, 138);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // pnlBackground
            // 
            this.pnlBackground.Controls.Add(this.lblLicznik);
            this.pnlBackground.Controls.Add(this.lblCounter);
            this.pnlBackground.Controls.Add(this.lblMessage);
            this.pnlBackground.Controls.Add(this.ring7);
            this.pnlBackground.Controls.Add(this.ring6);
            this.pnlBackground.Controls.Add(this.ring5);
            this.pnlBackground.Controls.Add(this.ring4);
            this.pnlBackground.Controls.Add(this.ring3);
            this.pnlBackground.Controls.Add(this.ring2);
            this.pnlBackground.Controls.Add(this.ring1);
            this.pnlBackground.Controls.Add(this.panel4);
            this.pnlBackground.Controls.Add(this.panel3);
            this.pnlBackground.Controls.Add(this.panel2);
            this.pnlBackground.Controls.Add(this.panel1);
            this.pnlBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBackground.Location = new System.Drawing.Point(0, 0);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(1337, 444);
            this.pnlBackground.TabIndex = 4;
            // 
            // ring7
            // 
            this.ring7.BackColor = System.Drawing.Color.Blue;
            this.ring7.Location = new System.Drawing.Point(180, 200);
            this.ring7.Name = "ring7";
            this.ring7.Padding = new System.Windows.Forms.Padding(5);
            this.ring7.Size = new System.Drawing.Size(60, 25);
            this.ring7.TabIndex = 4;
            // 
            // ring6
            // 
            this.ring6.BackColor = System.Drawing.Color.HotPink;
            this.ring6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ring6.Location = new System.Drawing.Point(160, 230);
            this.ring6.Margin = new System.Windows.Forms.Padding(10);
            this.ring6.Name = "ring6";
            this.ring6.Padding = new System.Windows.Forms.Padding(5);
            this.ring6.Size = new System.Drawing.Size(100, 25);
            this.ring6.TabIndex = 4;
            // 
            // ring5
            // 
            this.ring5.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ring5.Location = new System.Drawing.Point(140, 260);
            this.ring5.Name = "ring5";
            this.ring5.Size = new System.Drawing.Size(140, 25);
            this.ring5.TabIndex = 4;
            // 
            // ring4
            // 
            this.ring4.BackColor = System.Drawing.Color.Chartreuse;
            this.ring4.Location = new System.Drawing.Point(120, 290);
            this.ring4.Name = "ring4";
            this.ring4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ring4.Size = new System.Drawing.Size(180, 25);
            this.ring4.TabIndex = 4;
            // 
            // ring3
            // 
            this.ring3.BackColor = System.Drawing.Color.Gold;
            this.ring3.Location = new System.Drawing.Point(100, 320);
            this.ring3.Name = "ring3";
            this.ring3.Size = new System.Drawing.Size(220, 25);
            this.ring3.TabIndex = 4;
            // 
            // ring2
            // 
            this.ring2.BackColor = System.Drawing.Color.Peru;
            this.ring2.Location = new System.Drawing.Point(80, 350);
            this.ring2.Name = "ring2";
            this.ring2.Size = new System.Drawing.Size(260, 25);
            this.ring2.TabIndex = 4;
            // 
            // ring1
            // 
            this.ring1.BackColor = System.Drawing.Color.Crimson;
            this.ring1.Location = new System.Drawing.Point(60, 380);
            this.ring1.Name = "ring1";
            this.ring1.Size = new System.Drawing.Size(300, 25);
            this.ring1.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(1106, 122);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(20, 300);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(660, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(20, 300);
            this.panel3.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(200, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(20, 300);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 14);
            this.panel1.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(591, 9);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(149, 31);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Błędny ruch.";
            this.lblMessage.Visible = false;
            // 
            // lblCounter
            // 
            this.lblCounter.AutoSize = true;
            this.lblCounter.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCounter.Location = new System.Drawing.Point(250, 0);
            this.lblCounter.Name = "lblCounter";
            this.lblCounter.Size = new System.Drawing.Size(30, 32);
            this.lblCounter.TabIndex = 7;
            this.lblCounter.Text = "0";
            // 
            // lblLicznik
            // 
            this.lblLicznik.AutoSize = true;
            this.lblLicznik.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLicznik.Location = new System.Drawing.Point(3, 0);
            this.lblLicznik.Name = "lblLicznik";
            this.lblLicznik.Size = new System.Drawing.Size(225, 32);
            this.lblLicznik.TabIndex = 8;
            this.lblLicznik.Text = "Licznik ruchów:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 582);
            this.Controls.Add(this.pnlBackground);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmMain";
            this.Text = "HanoiTower - Mikołaj Kondek projekt Algorytmy i Struktury Danych ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnAuxiliary;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ring1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel ring7;
        private System.Windows.Forms.Panel ring6;
        private System.Windows.Forms.Panel ring5;
        private System.Windows.Forms.Panel ring4;
        private System.Windows.Forms.Panel ring3;
        private System.Windows.Forms.Panel ring2;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblCounter;
        private System.Windows.Forms.Label lblLicznik;
    }
}

