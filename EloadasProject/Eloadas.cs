using System;

namespace EloadasProject
{
    public class Eloadas
    {
        private const string SOR_HIBA = "A soroknak nagyobbnak kell lennie nullánál";
        private const string HELY_HIBA = "A helyeknek nagyobbnak kell lennie nullánál";
        bool[,] rendelesek;

        public Eloadas(int sorokSzama, int helyekSzama)
        {
            if (sorokSzama < 1)
                throw new ArgumentException(String.Format(SOR_HIBA));
            if (helyekSzama < 1)
                throw new ArgumentException(String.Format(HELY_HIBA));
            else
            {
                rendelesek = new bool[sorokSzama, helyekSzama];
                for (int i = 0; i < sorokSzama; i++)
                {
                    for (int j = 0; j < helyekSzama; j++)
                    {
                        rendelesek[i, j] = false;
                    }
                }
            }
        }

        public bool Lefoglal()
        {
            for (int i = 0; i < rendelesek.GetLength(0); i++)
            {
                for (int j = 0; j < rendelesek.GetLength(1); j++)
                {
                    if (!rendelesek[i, j])
                    {
                        rendelesek[i, j] = true;
                        return true;
                    }
                }
            }
            return false;
        }

        public int HelySzabad()
        {
            int s = 0;
            for (int i = 0; i < rendelesek.GetLength(0); i++)
            {
                for (int j = 0; j < rendelesek.GetLength(1); j++)
                {
                    if (!rendelesek[i, j])
                    {
                        s++;
                    }
                }
            }
            return s;
        }

        public bool Full()
        {
            return HelySzabad() == 0 ? true : false;
        }

        public bool Lefoglalva(int sorSzam, int helySzam)
        {
            if (sorSzam < 1)

                throw new ArgumentException(String.Format(SOR_HIBA));
            if (helySzam < 1)

                throw new ArgumentException(String.Format(HELY_HIBA));

            return rendelesek[sorSzam - 1, helySzam - 1];
        }
    }
}
