using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace sortiranjeVozila
{
    public partial class Form1 : Form
    {
        List<Vozilo> voziloList = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDodajVozilo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxMarka.Text) ||
                    string.IsNullOrWhiteSpace(textBoxModel.Text) ||
                    string.IsNullOrWhiteSpace(textBoxGodProizvodnje.Text) ||
                    string.IsNullOrWhiteSpace(textBoxKilometraza.Text) ||

                    //tries to parse the text from the
                    //textBoxGodProizvodnje and textBoxKilometraza field into a short (32-bit integer)
                    !int.TryParse(textBoxGodProizvodnje.Text, out int godina) ||
                    !int.TryParse(textBoxKilometraza.Text, out int kilometraza))
                {
                    MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                        "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBoxModel.Clear();
                    textBoxMarka.Clear();
                    textBoxGodProizvodnje.Clear();
                    textBoxKilometraza.Clear();
                    textBoxModel.Focus();
                }
                else
                {
                    Vozilo vozilo = new Vozilo(textBoxMarka.Text, textBoxModel.Text, godina, kilometraza);
                    voziloList.Add(vozilo);

                    textBoxModel.Clear();
                    textBoxMarka.Clear();
                    textBoxGodProizvodnje.Clear();
                    textBoxKilometraza.Clear();
                    textBoxModel.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Pogrešan unos. Molimo pokušajte ponovo",
                    "Pogrešan unos", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxMarka.Clear();
                textBoxModel.Clear();
                textBoxGodProizvodnje.Clear();
                textBoxKilometraza.Clear();
            }


        }

        private void buttonSortiraj_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite kriterij sortiranja.", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxSmjerSortiranja.SelectedItem == null)
            {
                MessageBox.Show("Molimo odaberite smjer sortiranja (Uzlazno ili Silazno).", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (comboBox1.SelectedItem.ToString())
            {
                case "Marka":
                    voziloList = comboBoxSmjerSortiranja.SelectedItem.ToString() == "Uzlazno"
                        ? voziloList.OrderBy(v => v.Marka).ToList()
                        : voziloList.OrderByDescending(v => v.Marka).ToList();
                    break;
                case "Model":
                    voziloList = comboBoxSmjerSortiranja.SelectedItem.ToString() == "Uzlazno"
                        ? voziloList.OrderBy(v => v.Model).ToList()
                        : voziloList.OrderByDescending(v => v.Model).ToList();
                    break;
                case "Godina Proizvodnje":
                    voziloList = comboBoxSmjerSortiranja.SelectedItem.ToString() == "Uzlazno"
                        ? voziloList.OrderBy(v => v.GodinaProizvodnje).ToList()
                        : voziloList.OrderByDescending(v => v.GodinaProizvodnje).ToList();
                    break;
                case "Kilometraza":
                    voziloList = comboBoxSmjerSortiranja.SelectedItem.ToString() == "Uzlazno"
                        ? voziloList.OrderBy(v => v.Kilometraza).ToList()
                        : voziloList.OrderByDescending(v => v.Kilometraza).ToList();
                    break;
                default:
                    break;
            }

            textBoxIspis.Clear();
            foreach (Vozilo v in voziloList)
            {
                textBoxIspis.AppendText(v.ToString() + Environment.NewLine);
            }

        }
        private void SpremiUXml()
        {
            // Proveri da li ima vozila za spremanje
            if (voziloList.Count == 0)
            {
                MessageBox.Show("Nema vozila za spremanje!", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Kreiraj XML dokument koristeći LINQ
            var xmlDokument = new XDocument(
                new XElement("Vozila",
                    from vozilo in voziloList
                    select new XElement("Vozilo",
                        new XElement("Marka", vozilo.Marka),
                        new XElement("Model", vozilo.Model),
                        new XElement("GodinaProizvodnje", vozilo.GodinaProizvodnje),
                        new XElement("Kilometraza", vozilo.Kilometraza)
                    )
                )
            );
            // Definiši lokaciju za čuvanje datoteke
            string putanja = "vozila.xml";
            try
            {
                // Spremi XML datoteku
                xmlDokument.Save(putanja);
                MessageBox.Show($"Podaci su uspešno sačuvani u datoteku: {putanja}", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Došlo je do greške prilikom spremanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSpremiXML_Click(object sender, EventArgs e)
        {
            SpremiUXml();
        }

        private void UcitajIzXml()
        {
            // Kreiraj OpenFileDialog za odabir XML datoteke
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
                openFileDialog.Title = "Odaberite XML datoteku";

                // Prikaži dijalog i proveri da li je korisnik izabrao datoteku
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Učitaj XML dokument
                        XDocument xmlDokument = XDocument.Load(openFileDialog.FileName);

                        // Očisti postojeći voziloList
                        voziloList.Clear();

                        // Popuni voziloList iz XML dokumenta
                        foreach (var voziloElement in xmlDokument.Descendants("Vozilo"))
                        {
                            Vozilo novoVozilo = new Vozilo
                            {
                                Marka = voziloElement.Element("Marka")?.Value,
                                Model = voziloElement.Element("Model")?.Value,
                                GodinaProizvodnje = int.Parse(voziloElement.Element("GodinaProizvodnje")?.Value ?? "0"),
                                Kilometraza = int.Parse(voziloElement.Element("Kilometraza")?.Value ?? "0")
                            };

                            voziloList.Add(novoVozilo);
                        }

                        MessageBox.Show("Podaci su uspešno učitani iz datoteke.", "Informacija", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Došlo je do greške prilikom učitavanja: {ex.Message}", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
        private void btnUcitajXML_Click(object sender, EventArgs e)
        {
                UcitajIzXml();
        }
    }
}

