using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetSudokuIHM
{
    class Grille
    {
        private string nom;
        private string date;
        private string format;
        private char[,] tab;
        private Case[,] tabCase;
        private bool[] tabVérifNombre;
        private int nbHypothese;
        private char[] Hypotheses;

        public Grille(string nom, string date, string format, char[,] tab)
        {
            // TODO: Complete member initialization
            this.nom = nom;
            this.date = date;
            this.format = format;
            this.tab = tab;
            tabCase = new Case[format.Length, format.Length];
            CréerLesCases(tab);
        }

        private void CréerLesCases(char[,] tab)
        {
            
           
            for (int i = 0; i < format.Length; i++)
            {
                for (int j = 0; j < format.Length; j++)
                {
                    if (getFormat.IndexOf(tab[i,j])!=-1)
                    {
                        nbHypothese=1;
                        Hypotheses = new char[1];
                        Hypotheses[0] = tab[i, j];

                        tabCase[i, j] = new Case(tab[i, j], nbHypothese, Hypotheses);
                    }
                    else
                    {
                        InitialiserTabVérifNombre();
                        nbHypothese = getFormat.Length;
                        RechercheParLigne(tab[i, j], i, j);
                        RechercheParColonne(tab[i, j], i, j);
                        RechercheParRegion(tab[i, j], i, j);
                        Hypotheses = new char[nbHypothese];
                        int compte = 0;
                        for (int p = 0; p < getFormat.Length; p++)
                        {
                            if (!tabVérifNombre[p])
                            {
                                Hypotheses[compte] = getFormat[p];
                                compte++;

                            }

                        }
                        tabCase[i, j] = new Case(tab[i, j], nbHypothese, Hypotheses);

                    }
                                     

                    
                }
            }
        }

        private void RechercheParRegion(char c, int lig, int col)
        {
            if (nbHypothese > 1)
            {
                int tailleCarré = (int)Math.Sqrt(format.Length);
                bool CarréEstValide = false;
                int divC, divL, modC, modL;

                divC = col / tailleCarré;
                modC = col % tailleCarré;
                divL = lig / tailleCarré;
                modL = lig % tailleCarré;

                for (int i = divL * tailleCarré; i < divL * tailleCarré + tailleCarré; i++)
                {
                    if (i != col)
                    {
                        for (int j = divC * tailleCarré; j < divC * tailleCarré + tailleCarré; j++)
                        {
                            if (j != col)
                            {
                                if (getFormat.IndexOf(tab[i, j]) != -1 && !tabVérifNombre[format.IndexOf(tab[i, j])])
                                {
                                    setVrai(format.IndexOf(c));
                                    CarréEstValide = true;
                                }
                                else
                                {
                                    CarréEstValide = false;
                                    break;
                                }
                                if (!CarréEstValide)
                                    break;
                            }


                        }
                    }

                }

            }
        }

        private void RechercheParColonne(char c, int lig, int col)
        {
            if (nbHypothese>1)
            {
                for (int i = 0; i < getFormat.Length; i++)
                {
                    if (i != lig)
                    {
                        if (getFormat.IndexOf(tab[i, col]) != -1 && !tabVérifNombre[getFormat.IndexOf(tab[i, col])])
                        {
                            setVrai(getFormat.IndexOf(tab[i, col]));

                        }
                    }
                                    } 
            }
            
        }

        private void RechercheParLigne(char c, int lig, int col)
        {
            if (nbHypothese>1)
            {
                for (int i = 0; i < getFormat.Length; i++)
                {
                    if (i != col)
                    {
                        if (getFormat.IndexOf(tab[lig, i]) != -1 && !tabVérifNombre[getFormat.IndexOf(tab[lig, i])])
                        {
                            setVrai(getFormat.IndexOf(tab[lig, i]));
                        }
                    }
                 }
            }
            
        }
        public void setVrai(int indice)
        {
            tabVérifNombre[indice] = true;
            if (nbHypothese != 0)
                nbHypothese--;
        }
        public string getNom { get { return nom; } set {  nom = value; } }
        public string getDate { get { return date; } set { date = value; } }
        public string getFormat { get { return format; } set { format=value; } }
        public char[,] getTab { get { return tab; } set {tab =value; } }
        public Case[,] getTabCase { get { return tabCase; } set { tabCase=value; } }

        public void InitialiserTabVérifNombre()
        {
            tabVérifNombre = new bool[getFormat.Length];

           // int t = Grilles[cBChoixGrille.SelectedIndex].getFormat.Length;
            for (int i = 0; i < getFormat.Length; i++)
                tabVérifNombre[i] = false;
        }

        public void GrilleMiseàjour()
        {
            CréerLesCases(getTab);

        }
        public void ChangerLaValeurDuTab(int i, int j,char c)
        {
            tab[i, j] = c;
        }
    }
}
