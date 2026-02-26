using System.ComponentModel;

namespace Test12
{
   public partial class Form1 : Form
   {
      private BindingList<Schueler> _schueler = new();
      private BindingList<Schueler> _filteredSchueler = new();

      public Form1()
      {
         InitializeComponent();
         InitialisiereBeispielSchueler();

         btnHinzu.Click += btnHinzu_Click;
         btnLoeschen.Click += btnLoeschen_Click;
         btnEditieren.Click += btnEditieren_Click;

         lbSchueler.SelectedIndexChanged += lbSchueler_SelectedIndexChanged;
         cbKlassen.SelectedIndexChanged += cbKlassen_SelectedIndexChanged;
      }
      // Aufgabe 3
      private void InitialisiereBeispielSchueler()
      {
         _schueler = new BindingList<Schueler>
         {
            new() { Vorname = "Max",   Nachname = "Mustermann", Telefon = 01511234567, Klasse = "FTI11" },
            new() { Vorname = "Mia",   Nachname = "Schmidt",    Telefon = 01762222333, Klasse = "FTE11" },
            new() { Vorname = "Noah",  Nachname = "Klein",      Telefon = 01604444555, Klasse = "FTI22" },
            new() { Vorname = "Emma",  Nachname = "Wagner",     Telefon = 01798888999, Klasse = "FTE22" },
            new() { Vorname = "Lea",   Nachname = "Fischer",    Telefon = 01571010101, Klasse = "FTI11" },
            new() { Vorname = "Ben",   Nachname = "Becker",     Telefon = 01529090909, Klasse = "FTE11" },
         };

         lbSchueler.DataSource = _schueler;
      }
      // Aufgabe 4
      private void btnHinzu_Click(object? sender, EventArgs e)
      {
         string vorname = tbVorname.Text;
         string nachname = tbNachname.Text;
         int telefon = int.Parse(tbTelefon.Text);
         if (TryFindDuplicate(vorname, nachname, telefon))
            return;

         _schueler.Add(new Schueler
         {
            Vorname = vorname,
            Nachname = nachname,
            Telefon = telefon,
            Klasse = "FTE22"
         });


         tbVorname.Clear();
         tbNachname.Clear();
         tbTelefon.Clear();
         tbVorname.Focus();
      }

      private void btnLoeschen_Click(object? sender, EventArgs e)
      {
         if (lbSchueler.SelectedItem is not Schueler schueler)
         {
            MessageBox.Show("Bitte erst einen Schüler auswählen");
            return;
         }

         _schueler.Remove(schueler);
      }
      // Aufgabe 6
      private void lbSchueler_SelectedIndexChanged(object? sender, EventArgs e)
      {
         if (lbSchueler.SelectedItem is not Schueler schueler)
            return;

         tbVorname.Text = schueler.Vorname;
         tbNachname.Text = schueler.Nachname;
         tbTelefon.Text = schueler.Telefon.ToString();

         
      }
      // Aufgabe 7
      private bool TryFindDuplicate(string vorname, string nachname, int telefon)
      {
         foreach (var schueler in _schueler)
         {
            if (schueler.Vorname == vorname && schueler.Nachname == nachname && schueler.Telefon == telefon)
            {
               MessageBox.Show("Doppelter Eintrag gefunden!");
               return true;
            }
         }
         return false;
      }

      private void btnEditieren_Click(object? sender, EventArgs e)
      {
         if (lbSchueler.SelectedItem is not Schueler schueler)
         {
            MessageBox.Show("Bitte erst einen Schüler auswählen");
            return;
         }
         int index = lbSchueler.SelectedIndex;

         string vorname = tbVorname.Text;
         string nachname = tbNachname.Text;
         int telefon = int.Parse(tbTelefon.Text);

         _schueler[index].Vorname = vorname;
         _schueler[index].Nachname = nachname;
         _schueler[index].Telefon = telefon;

         //var cm = (CurrencyManager)BindingContext[lbSchueler.DataSource!];
         //cm.Refresh();
         lbSchueler.DataSource = null;
         lbSchueler.DataSource = _schueler;
      }
      // Aufgabe 8
      private void cbKlassen_SelectedIndexChanged(object? sender, EventArgs e)
      {
         var klasse = cbKlassen.SelectedItem;
         if (String.IsNullOrWhiteSpace(klasse?.ToString()))
         {
            lbSchueler.DataSource = _schueler;
            return;
         }

         _filteredSchueler.Clear();
         foreach (var schueler in _schueler)
         {
            if (schueler.Klasse == klasse)
               _filteredSchueler.Add(schueler);
         }
         lbSchueler.DataSource = _filteredSchueler;
      }
   }
}
