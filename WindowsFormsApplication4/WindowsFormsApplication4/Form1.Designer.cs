namespace WindowsFormsApplication4
{
    partial class Zahlenraten
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnEnde = new System.Windows.Forms.Button();
            this.lblRate1 = new System.Windows.Forms.Label();
            this.gbZahleingabe = new System.Windows.Forms.GroupBox();
            this.lblVersuche = new System.Windows.Forms.Label();
            this.lblFalsch = new System.Windows.Forms.Label();
            this.lblErraten = new System.Windows.Forms.Label();
            this.lblRate_kleiner = new System.Windows.Forms.Label();
            this.txtEingabe = new System.Windows.Forms.TextBox();
            this.lblRate_groesser = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Werte_bisher = new System.Windows.Forms.ListView();
            this.Versuch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kleiner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groesser = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Werte_aus_ein = new System.Windows.Forms.Button();
            this.lblErmittlung = new System.Windows.Forms.Label();
            this.gbZahleingabe.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(46, 29);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnEnde
            // 
            this.btnEnde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEnde.Location = new System.Drawing.Point(187, 219);
            this.btnEnde.Name = "btnEnde";
            this.btnEnde.Size = new System.Drawing.Size(52, 29);
            this.btnEnde.TabIndex = 1;
            this.btnEnde.Text = "Ende";
            this.btnEnde.UseVisualStyleBackColor = true;
            this.btnEnde.Click += new System.EventHandler(this.btnEnde_Click);
            // 
            // lblRate1
            // 
            this.lblRate1.Location = new System.Drawing.Point(6, 11);
            this.lblRate1.Name = "lblRate1";
            this.lblRate1.Size = new System.Drawing.Size(212, 24);
            this.lblRate1.TabIndex = 2;
            this.lblRate1.Text = "Raten Sie die gesuchte Zahl:";
            this.lblRate1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbZahleingabe
            // 
            this.gbZahleingabe.Controls.Add(this.lblVersuche);
            this.gbZahleingabe.Controls.Add(this.lblFalsch);
            this.gbZahleingabe.Controls.Add(this.lblErraten);
            this.gbZahleingabe.Controls.Add(this.lblRate_kleiner);
            this.gbZahleingabe.Controls.Add(this.txtEingabe);
            this.gbZahleingabe.Controls.Add(this.lblRate_groesser);
            this.gbZahleingabe.Controls.Add(this.lblRate1);
            this.gbZahleingabe.Location = new System.Drawing.Point(12, 47);
            this.gbZahleingabe.Name = "gbZahleingabe";
            this.gbZahleingabe.Size = new System.Drawing.Size(227, 109);
            this.gbZahleingabe.TabIndex = 3;
            this.gbZahleingabe.TabStop = false;
            this.gbZahleingabe.Visible = false;
            // 
            // lblVersuche
            // 
            this.lblVersuche.Location = new System.Drawing.Point(6, 80);
            this.lblVersuche.Name = "lblVersuche";
            this.lblVersuche.Size = new System.Drawing.Size(154, 24);
            this.lblVersuche.TabIndex = 6;
            this.lblVersuche.Text = "Benötigte Versuche: ";
            this.lblVersuche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblVersuche.Visible = false;
            // 
            // lblFalsch
            // 
            this.lblFalsch.Location = new System.Drawing.Point(6, 33);
            this.lblFalsch.Name = "lblFalsch";
            this.lblFalsch.Size = new System.Drawing.Size(154, 24);
            this.lblFalsch.TabIndex = 8;
            this.lblFalsch.Text = "Unzulässige Eingabe!";
            this.lblFalsch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblFalsch.Visible = false;
            // 
            // lblErraten
            // 
            this.lblErraten.Location = new System.Drawing.Point(6, 33);
            this.lblErraten.Name = "lblErraten";
            this.lblErraten.Size = new System.Drawing.Size(154, 21);
            this.lblErraten.TabIndex = 6;
            this.lblErraten.Text = "Richtig! Gesuchte Zahl: ";
            this.lblErraten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErraten.Visible = false;
            // 
            // lblRate_kleiner
            // 
            this.lblRate_kleiner.Location = new System.Drawing.Point(6, 56);
            this.lblRate_kleiner.Name = "lblRate_kleiner";
            this.lblRate_kleiner.Size = new System.Drawing.Size(192, 24);
            this.lblRate_kleiner.TabIndex = 5;
            this.lblRate_kleiner.Text = " ist groesser als die gesuchte Zahl.";
            this.lblRate_kleiner.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRate_kleiner.Visible = false;
            // 
            // txtEingabe
            // 
            this.txtEingabe.Location = new System.Drawing.Point(154, 15);
            this.txtEingabe.MaxLength = 4;
            this.txtEingabe.Name = "txtEingabe";
            this.txtEingabe.Size = new System.Drawing.Size(44, 20);
            this.txtEingabe.TabIndex = 4;
            this.txtEingabe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEingabe_KeyDown);
            // 
            // lblRate_groesser
            // 
            this.lblRate_groesser.Location = new System.Drawing.Point(6, 56);
            this.lblRate_groesser.Name = "lblRate_groesser";
            this.lblRate_groesser.Size = new System.Drawing.Size(192, 24);
            this.lblRate_groesser.TabIndex = 4;
            this.lblRate_groesser.Text = " ist kleiner als die gesuchte Zahl.";
            this.lblRate_groesser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRate_groesser.Visible = false;
            // 
            // Werte_bisher
            // 
            this.Werte_bisher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Werte_bisher.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Versuch,
            this.kleiner,
            this.groesser});
            this.Werte_bisher.FullRowSelect = true;
            this.Werte_bisher.Location = new System.Drawing.Point(12, 163);
            this.Werte_bisher.Name = "Werte_bisher";
            this.Werte_bisher.Size = new System.Drawing.Size(148, 85);
            this.Werte_bisher.TabIndex = 4;
            this.Werte_bisher.UseCompatibleStateImageBehavior = false;
            this.Werte_bisher.View = System.Windows.Forms.View.Details;
            this.Werte_bisher.Visible = false;
            // 
            // Versuch
            // 
            this.Versuch.Text = "Nr.";
            this.Versuch.Width = 30;
            // 
            // kleiner
            // 
            this.kleiner.Text = "kleiner";
            this.kleiner.Width = 43;
            // 
            // groesser
            // 
            this.groesser.Text = "groesser";
            this.groesser.Width = 52;
            // 
            // Werte_aus_ein
            // 
            this.Werte_aus_ein.Location = new System.Drawing.Point(166, 162);
            this.Werte_aus_ein.Name = "Werte_aus_ein";
            this.Werte_aus_ein.Size = new System.Drawing.Size(73, 37);
            this.Werte_aus_ein.TabIndex = 5;
            this.Werte_aus_ein.Text = "Werte ein-/ ausblenden";
            this.Werte_aus_ein.UseVisualStyleBackColor = true;
            this.Werte_aus_ein.Visible = false;
            this.Werte_aus_ein.Click += new System.EventHandler(this.Werte_aus_ein_Click);
            // 
            // lblErmittlung
            // 
            this.lblErmittlung.Location = new System.Drawing.Point(64, 10);
            this.lblErmittlung.Name = "lblErmittlung";
            this.lblErmittlung.Size = new System.Drawing.Size(175, 32);
            this.lblErmittlung.TabIndex = 6;
            this.lblErmittlung.Text = "Es wurde eine Zufallszahl zwischen 0 und 1000 ermittelt.";
            this.lblErmittlung.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblErmittlung.Visible = false;
            // 
            // Zahlenraten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 259);
            this.Controls.Add(this.lblErmittlung);
            this.Controls.Add(this.Werte_aus_ein);
            this.Controls.Add(this.Werte_bisher);
            this.Controls.Add(this.gbZahleingabe);
            this.Controls.Add(this.btnEnde);
            this.Controls.Add(this.btnStart);
            this.Name = "Zahlenraten";
            this.Text = "Zahlenraten";
            this.gbZahleingabe.ResumeLayout(false);
            this.gbZahleingabe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnEnde;
        private System.Windows.Forms.Label lblRate1;
        private System.Windows.Forms.GroupBox gbZahleingabe;
        private System.Windows.Forms.TextBox txtEingabe;
        private System.Windows.Forms.Label lblRate_groesser;
        private System.Windows.Forms.Label lblRate_kleiner;
        private System.Windows.Forms.Label lblErraten;
        private System.Windows.Forms.Label lblFalsch;
        private System.Windows.Forms.Label lblVersuche;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ListView Werte_bisher;
        private System.Windows.Forms.ColumnHeader Versuch;
        private System.Windows.Forms.ColumnHeader kleiner;
        private System.Windows.Forms.ColumnHeader groesser;
        private System.Windows.Forms.Button Werte_aus_ein;
        private System.Windows.Forms.Label lblErmittlung;
    }
}

