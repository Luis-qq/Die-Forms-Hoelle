namespace Test12
{
   partial class Form1
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      private Label lblKlasse;
      private Label lblSchueler;
      private Label lblVorname;
      private Label lblNachname;
      private Label lblTelefon;

      private ComboBox cbKlassen;
      private ListBox lbSchueler;
      private TextBox tbVorname;
      private TextBox tbNachname;
      private TextBox tbTelefon;

      private Button btnHinzu;
      private Button btnLoeschen;
      private Button btnEditieren;

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
         components = new System.ComponentModel.Container();

         lblKlasse = new Label();
         lblSchueler = new Label();
         lblVorname = new Label();
         lblNachname = new Label();
         lblTelefon = new Label();

         cbKlassen = new ComboBox();
         lbSchueler = new ListBox();
         tbVorname = new TextBox();
         tbNachname = new TextBox();
         tbTelefon = new TextBox();

         btnHinzu = new Button();
         btnLoeschen = new Button();
         btnEditieren = new Button();

         SuspendLayout();

         // lblKlasse
         lblKlasse.AutoSize = true;
         lblKlasse.Location = new Point(12, 15);
         lblKlasse.Name = "lblKlasse";
         lblKlasse.Size = new Size(44, 15);
         lblKlasse.TabIndex = 0;
         lblKlasse.Text = "Klasse:";

         // cbKlassen Aufgabe 2
         cbKlassen.DropDownStyle = ComboBoxStyle.DropDownList;
         cbKlassen.FormattingEnabled = true;
         cbKlassen.Items.AddRange(new string[] { "", "FTI11", "FTE11", "FTI22", "FTE22" });
         cbKlassen.Location = new Point(70, 12);
         cbKlassen.Name = "cbKlassen";
         cbKlassen.Size = new Size(170, 23);
         cbKlassen.TabIndex = 1;

         // lblSchueler
         lblSchueler.AutoSize = true;
         lblSchueler.Location = new Point(12, 48);
         lblSchueler.Name = "lblSchueler";
         lblSchueler.Size = new Size(50, 15);
         lblSchueler.TabIndex = 2;
         lblSchueler.Text = "Schüler:";

         // lbSchueler
         lbSchueler.FormattingEnabled = true;
         lbSchueler.ItemHeight = 15;
         lbSchueler.Location = new Point(12, 66);
         lbSchueler.Name = "lbSchueler";
         lbSchueler.Size = new Size(228, 274);
         lbSchueler.TabIndex = 3;

         // lblVorname
         lblVorname.AutoSize = true;
         lblVorname.Location = new Point(270, 15);
         lblVorname.Name = "lblVorname";
         lblVorname.Size = new Size(55, 15);
         lblVorname.TabIndex = 4;
         lblVorname.Text = "Vorname:";

         // tbVorname
         tbVorname.Location = new Point(340, 12);
         tbVorname.Name = "tbVorname";
         tbVorname.Size = new Size(200, 23);
         tbVorname.TabIndex = 5;

         // lblNachname
         lblNachname.AutoSize = true;
         lblNachname.Location = new Point(270, 50);
         lblNachname.Name = "lblNachname";
         lblNachname.Size = new Size(68, 15);
         lblNachname.TabIndex = 6;
         lblNachname.Text = "Nachname:";

         // tbNachname
         tbNachname.Location = new Point(340, 47);
         tbNachname.Name = "tbNachname";
         tbNachname.Size = new Size(200, 23);
         tbNachname.TabIndex = 7;

         // lblTelefon
         lblTelefon.AutoSize = true;
         lblTelefon.Location = new Point(270, 85);
         lblTelefon.Name = "lblTelefon";
         lblTelefon.Size = new Size(46, 15);
         lblTelefon.TabIndex = 8;
         lblTelefon.Text = "Telefon:";

         // tbTelefon
         tbTelefon.Location = new Point(340, 82);
         tbTelefon.Name = "tbTelefon";
         tbTelefon.Size = new Size(200, 23);
         tbTelefon.TabIndex = 9;

         // btnHinzu
         btnHinzu.Location = new Point(340, 125);
         btnHinzu.Name = "btnHinzu";
         btnHinzu.Size = new Size(120, 30);
         btnHinzu.TabIndex = 10;
         btnHinzu.Text = "Hinzu";
         btnHinzu.UseVisualStyleBackColor = true;

         // btnLoeschen
         btnLoeschen.Location = new Point(340, 165);
         btnLoeschen.Name = "btnLoeschen";
         btnLoeschen.Size = new Size(120, 30);
         btnLoeschen.TabIndex = 11;
         btnLoeschen.Text = "Löschen";
         btnLoeschen.UseVisualStyleBackColor = true;

         // btnEditieren
         btnEditieren.Location = new Point(480, 165);
         btnEditieren.Name = "btnEditieren";
         btnEditieren.Size = new Size(120, 30);
         btnEditieren.TabIndex = 12;
         btnEditieren.Text = "Editieren";
         btnEditieren.UseVisualStyleBackColor = true;

         // Form1
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(620, 360);
         Controls.Add(btnEditieren);
         Controls.Add(btnLoeschen);
         Controls.Add(btnHinzu);
         Controls.Add(tbTelefon);
         Controls.Add(lblTelefon);
         Controls.Add(tbNachname);
         Controls.Add(lblNachname);
         Controls.Add(tbVorname);
         Controls.Add(lblVorname);
         Controls.Add(lbSchueler);
         Controls.Add(lblSchueler);
         Controls.Add(cbKlassen);
         Controls.Add(lblKlasse);
         Name = "Form1";
         Text = "Schülerliste";

         ResumeLayout(false);
         PerformLayout();
      }

      #endregion
   }

   //Aufgabe 1
   public class Schueler
   {
      public string Vorname;
      public string Nachname;
      public int Telefon;
      public string Klasse;

      public override string ToString() => $"{Nachname}, {Vorname} ({Telefon})";
   }
}
