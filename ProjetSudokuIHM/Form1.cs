using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetSudokuIHM
{
    public partial class Form1 : Form
    {
        public bool FichierValider = false;
        string path;
        List<Grille> Grilles = new List<Grille>();
        string nom;
        string date;
        string format;
        string commentaire;
        char[,] tabGrille;
        bool[] tabVérifNombre;

        public Form1()
        {

            InitializeComponent();
            dGVGrille.Visible = false;
            cBChoixGrille.Visible = false;


        }

        private void btnFile_Click(object sender, EventArgs e)
        {

            oFDChoixFile.Title = "Choisir un fichier";
            oFDChoixFile.ShowDialog();



        }

        private bool VérifierFichier(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(@"" + path);
                if (lines.Length == 0)
                {
                    MessageBox.Show("le fichier " + path + " donnée est vide", "Avertissement", MessageBoxButtons.OK);
                    return false;
                }
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("le fichier " + path + " donnée est vide", "Attention", MessageBoxButtons.OK);
                return false;
            }

        }

        private void oFDChoixFile_FileOk(object sender, CancelEventArgs e)
        {
            if (VérifierFichier(oFDChoixFile.FileName))
            {
                initialiserForm();
                TraiterGrille();
                RemplirComboBox();

            }

        }

        private void RemplirComboBox()
        {

            foreach (Grille g in Grilles)
            {
                cBChoixGrille.Items.Add(g.getNom);
            }

        }

        private void TraiterGrille()
        {
            char[,] tab;
            using (StreamReader reader = new StreamReader(oFDChoixFile.FileName))
            {
                while ((commentaire = reader.ReadLine()) != null)
                {
                    nom = reader.ReadLine();
                    date = reader.ReadLine();
                    format = reader.ReadLine();
                    tab = new char[format.Length, format.Length];
                    for (int i = 0; i < format.Length; i++)
                    {
                        char[] ligne = reader.ReadLine().ToCharArray();
                        int j = 0;
                        foreach (char c in ligne)
                        {
                            tab[i, j] = c;
                            j++;
                            // Console.WriteLine(c);
                        }

                    }
                    Grilles.Add(new Grille(nom, date, format, tab));
                }
            }
        }

        private void initialiserForm()
        {
            cBChoixGrille.Visible = true;
            dGVGrille.Visible = true;
            tBCheminFile.Enabled = false;
            tBCheminFile.Text = oFDChoixFile.FileName;
        }

        private void cBChoixGrille_SelectedIndexChanged(object sender, EventArgs e)
        {
            AfficherGrilleSélectionnée(Grilles[cBChoixGrille.SelectedIndex]);

        }

        private void AfficherGrilleSélectionnée(Grille grille)
        {
            Char[,] tabGrille = grille.getTab;
            int taille = (grille.getFormat).Length;
           
            for (int i = 0; i < taille; i++)
            {
                CréerDataGrille(i,taille);

                for (int j = 0; j < taille; j++)

                {
                    if (grille.getTabCase[i, j].Valeur != '.')
                    {
                        this.dGVGrille.Rows[i].Cells[j].Value = grille.getTabCase[i, j].Valeur;
                        

                    }
                    else
                    {
                        this.dGVGrille.Rows[i].Cells[j].Value = grille.getTabCase[i, j].Valeur;
                        
                      //  for (int k = 0; k < grille.getTabCase[i, j].NbHypothese; k++)
                       // {
                           
                       // }
                                        }
                       
                
                }
            }

        }

        private void CréerDataGrille(int i,int taille)
        {
            dGVGrille.ColumnCount = taille;
            dGVGrille.RowCount = taille;
            DataGridViewRow row = this.dGVGrille.RowTemplate;
            dGVGrille.Rows[i].Height = (dGVGrille.Height)/taille;
            using (Font font = new Font(
         dGVGrille.DefaultCellStyle.Font.FontFamily, 10, FontStyle.Bold))
            {
                dGVGrille.Columns[i].DefaultCellStyle.Font = font;
            }    
            
           
        }

        

        private void btnResoluer_Click(object sender, EventArgs e)
        {
            Grille gr = Grilles[cBChoixGrille.SelectedIndex];


            for (int i = 0; i <gr.getFormat.Length ; i++)
            {
                for (int j = 0; j < gr.getFormat.Length; j++)
                {
                    if (gr.getTabCase[i, j].NbHypothese == 1 && gr.getTabCase[i, j].Valeur.Equals('.'))
                    {
                       // MessageBox.Show(gr.getTabCase[i, j].Valeur + " : " + i + " - " + j);
                       // gr.getTab[i, j] = gr.getTabCase[i, j].Valeur;
                        gr.ChangerLaValeurDuTab(i,j,gr.getTabCase[i, j].Hypotheses[0]);
                        gr.GrilleMiseàjour();
                        AfficherGrilleSélectionnée(gr);
                        /*
                         * dGVGrille.Rows[i].Cells[j].Value = gr.getTabCase[i, j].Hypotheses[0];
                        gr.getTabCase[i, j].Valeur = gr.getTabCase[i, j].Hypotheses[0];

                         */
                       // MessageBox.Show(gr.getTabCase[i, j].Valeur + " : " + i + " - " + j);

                        goto Exit;
                    }
                }
            }
        Exit: ;
        }


      
    }
}