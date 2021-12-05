using System;

namespace exercice_implementation_de_la_notion_de_tableau
{
    // creation de la classe tab
    class tab
    {
        public string type;// creer variable type 

        // Creer et initialiser constructeur pour la classe tab
        public tab()
        {
            type = "int";
        }
        /*procedure d'insertion des elements dans un tableau de
         type et valeur et position et dimension donne par l'utilisateur*/
        public void inserer_elements(string type, int dim, char val, int pos)
        {
            // traitement a faire pour le type des entiers
            if (type == "int")
            {
                int[] tab = new int[dim];
                for (int i = 0; i < tab.Length; i++)
                {
                    // recherche sur la position saisie
                    if (i == pos)
                        //convertion de type char to int 
                        tab[i] = Convert.ToInt32(val);
                }
            }
            //traitement a faire pour le cas de type des chaines de caracteres
            else if (type == "string")
            {
                string[] tab = new string[dim];
                for (int i = 0; i < tab.Length; i++)
                {
                    if (i == pos)
                        tab[i] = Convert.ToString(val);
                }
            }

        }
        //procedure de suppression d'un element a partie de sa position donne par l'utilisateur
        public void supprimer_element_par_position(string type, int pos, int dim)
        {
            // traitement a faire pour le type des entiers
            if (type == "int")
            {
                //creation de tableau dentiers de dimension donnee
                int[] tab1 = new int[dim];
                int i;

                // boucle pour explorer les elements du tableau de premier jusquau dernier
                for (i = 0; i < tab1.Length; i++)
                {
                    //declaration dentier index pour stocker la position delement a suupprimer
                    if (i == pos)
                    {
                        int index = i;
                        //boucle for qui va de lelement a supprimer jusqu'a la fin de tableau
                        for (i = index; i < tab1.Length - 1; i++)
                            // deplacemenet des elements qui sont apres lelement a supprimer d'une case a gauche
                            tab1[i] = tab1[i + 1];
                    }
                }

            }
            else if (type == "string")
            {
                //creation de tableau de chaines de characteres de dimension donnee
                string[] tab1 = new string[dim];
                int i;

                // boucle pour explorer les elements du tableau de premier jusquau dernier
                for (i = 0; i < tab1.Length; i++)
                {
                    //declaration dentier index pour stocker la position delement a suupprimer
                    if (i == pos)
                    {
                        int index = i;
                        //boucle for qui va de lelement a supprimer jusqu'a la fin de tableau
                        for (i = index; i < tab1.Length - 1; i++)
                            // deplacemenet des elements qui sont apres lelement a supprimer d'une case a gauche
                            tab1[i] = tab1[i + 1];
                    }
                }
            }


        }
        public void supprimer_element_par_valeur(string type, char val, int dim)
        {
            int i;
            int index = 1;
            if (type == "int")
            {
                int[] tab2 = new int[dim];
                for (i = 0; i < tab2.Length; i++)
                {
                    //recherche de la valeur sasie pour stocker son index i dans index
                    if (tab2[i] == Convert.ToInt32(val))
                    {
                        index = i;
                        // deplacement des elements d'une case a gauche
                        for (i = index; i < tab2.Length; i++)
                            tab2[i] = tab2[i + 1];
                    }
                }
            }
            else if (type == "string")
            {
                string[] tab2 = new string[dim];
                for (i = 0; i < tab2.Length; i++)
                {
                    //recherche de la valeur sasie pour stocker son index i dans index
                    if (tab2[i] == Convert.ToString(val))
                    {
                        index = i;
                        // deplacement des elements d'une case a gauche
                        for (i = index; i < tab2.Length; i++)
                            tab2[i] = tab2[i + 1];
                    }
                }

            }
        }
        public void rechercher_element(string type, int dim, char val)
        {
            int i;
            bool trouve = false;
            if (type == "int")
            {
                int[] tab3 = new int[dim];
                for (i = 0; i < tab3.Length; i++)
                {
                    if (tab3[i] == Convert.ToInt32(val))
                    {
                        trouve = true;
                    }
                }
            }
            else if (type == "string")
            {
                string[] tab3 = new string[dim];
                for (i = 0; i < tab3.Length; i++)
                {
                    if (tab3[i] == Convert.ToString(val))
                    {
                        trouve = true;
                    }
                }
            }
            if (!trouve)
            {
                //element est trouve
            }

        }
        public void trier_tableau(int dim)
        {
            int[] tab = new int[dim];
            int temp;
            //utilisation de deux boucles pour comparer les elements de tableaux chaqun avec celui qui le suive 
            for (int i = 0; i < tab.Length; i++)

            {
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[i] > tab[j])
                    {
                        //utilisation dune variable temp pour stocker temporairement la plus petite valeur
                        temp = tab[i];
                        tab[i] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }
        public void inverser_tableau(int dim)
        {
            int[] tab = new int[dim];
            // initialisation dune variable j par la derniere valeure du tableau
            int j = tab[tab.Length - 1];
            while (tab[0] < tab[j])
            {
                // echange de premiere valeure avec la derniere 
                int temp = tab[0];
                tab[0] = tab[j];
                tab[j] = temp;
                tab[0]++;
                (tab[j])--;
            }
        }

    }

}
