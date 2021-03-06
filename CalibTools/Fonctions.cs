﻿namespace CalibTools
{
    using Snap7;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.IO;
    using System.Reflection;

    internal class Fonctions
    {
        public static void Bump(int numDB)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer 1 byte

            if (Main._statusConnection)
            {
                S7.SetBitAt(ref Buffer, 0, 2, true);
                res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write DB_Diag.DBX150.2

                //S7.SetBitAt(ref Buffer, 0, 2, false);
                //res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write DB_Diag.DBX150.2
            }
        }

        public static bool CheckCon()
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer 1 byte
            res = Main.Client.DBRead(94, 0, 1, Buffer);

            if (res == 0)
                return true;
            else
                return false;
        }

        public static int CheckDbsDiag(int numDB)
        {
            // Initialisation
            int res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer

            //
            if (Main._statusConnection)
                res = Main.Client.DBRead(numDB, 0, Buffer.Length, Buffer);

            return res;
        }

        public static void ForceOn(int numDB)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer 1 byte
            bool val;

            if (Main._statusConnection)
            {
                res = Main.Client.DBRead(numDB, 102, 1, Buffer);
                val = S7.GetBitAt(Buffer, 0, 0);
                if (val == false)
                {
                    S7.SetBitAt(ref Buffer, 0, 0, true);
                    res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write false
                }
                else
                {
                    S7.SetBitAt(ref Buffer, 0, 0, false);
                    res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write true
                }
            }
        }

        public static void ForceCalib(int numDB)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer 1 byte
            bool val;

            if (Main._statusConnection)
            {
                res = Main.Client.DBRead(numDB, 102, 1, Buffer);
                val = S7.GetBitAt(Buffer, 0, 3);
                if (val == false)
                {
                    S7.SetBitAt(ref Buffer, 0, 3, true);
                    res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write false
                }
                else
                {
                    S7.SetBitAt(ref Buffer, 0, 3, false);
                    res = Main.Client.DBWrite(numDB, 102, 1, Buffer); // Write true
                }
            }
        }

        public static void Reset()
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[1]; // Buffer 1 byte

            if (Main._statusConnection)
            {
                S7.SetBitAt(ref Buffer, 0, 6, true);
                res = Main.Client.DBWrite(94, 0, 1, Buffer); // Write DB94.DBX0.6

                S7.SetBitAt(ref Buffer, 0, 6, false);
                res = Main.Client.DBWrite(94, 0, 1, Buffer); // Write DB94.DBX0.6
            }
        }

        public static void StateMotor(int numDB)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[2]; // Buffer 2 bytes
            byte[] BufferBis = new byte[55]; // Buffer 10 bytes

            if (Main._statusConnection)
            {
                res = Main.Client.DBRead(numDB, 80, 2, Buffer);
            }

            BitArray arBits = new BitArray(Buffer); // Convert buffer bytes to array of bits
            for (int i = 0; i < 15; i++)
                Main._arStateMotor.Add(arBits.Get(i)); // Fill the array

            if (Main._statusConnection)
            {
                res = Main.Client.DBRead(numDB, 56, 55, BufferBis);
            }

            Main._dspdMotor = S7.GetRealAt(BufferBis, 0);
            Main._dintMotor = S7.GetIntAt(BufferBis, 6)/10;
            Main._dspdFMotor = S7.GetDIntAt(BufferBis, 48) / 100;
        }

        public static Double StrToDouble(string sVal, char Separator, long Precision)
        {
            string[] sDouble;
            Double Val;

            sDouble = sVal.Split(new char[1] { Separator });
            Val = Convert.ToInt64(sDouble[0]) * Precision + Convert.ToInt64(sDouble[1]);
            return Val / Precision;
        }

        public static void WriteCalibSpeed(int numDB, int value)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[4]; // Buffer 2 bytes

            // On écrit la valeur dans le buffer
            S7.SetDIntAt(Buffer, 0, value);

            // Ecriture de la vitesse en mode forcé
            if (Main._statusConnection)
                res = Main.Client.DBWrite(numDB, 104, Buffer.Length, Buffer);
        }

        public static void WriteListDbs(List<string> items)
        {
            string strAppDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetModules()[0].FullyQualifiedName);
            string nameFile = @"\indexDbs.txt";

            System.IO.StreamWriter resultFile =
                new System.IO.StreamWriter(strAppDir + nameFile);

            for (int i = 0; i < items.Count; i++)
            {
                resultFile.WriteLine(items[i]);
            }

            resultFile.Close();
        }

        public static void WriteMesSpeed(int numDB, double value)
        {
            // Initialisation
            var res = -1; // Résultat de la fonction
            byte[] Buffer = new byte[4]; // Buffer 2 bytes

            // On écrit la valeur dans le buffer
            float a = (float)value;
            S7.SetRealAt(Buffer, 0, a);

            // Ecriture de la vitesse en mode forcé
            if (Main._statusConnection)
                res = Main.Client.DBWrite(numDB, 32, Buffer.Length, Buffer);
        }
    }
}