using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetSudokuIHM
{
    class Case
    {
     
        private int nbHypothese;
        private   char valeur;
        private char[] hypotheses;


        
        
        public    Case(char v,int nbhypoth, char[] hypotheses)
    {
       
                this.valeur = v;
                this.nbHypothese = nbhypoth;
                this.hypotheses = hypotheses;
    }
        public char Valeur { get { return valeur; } set { valeur = value; } }
        public int NbHypothese { get { return nbHypothese; } set { nbHypothese = value; } }
        public char[] Hypotheses { get { return hypotheses; } set { hypotheses = value; } }


       
    }
}
