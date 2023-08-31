using Kociemba;
using MBLDTracker.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MBLDTracker
{
    public static class Scrambler
    {
        private static int[] FaceTurnTableU = new int[8] { 0, 1, 2, 5, 8, 7, 6, 3 };
        private static int[] SideTurnTableU = new int[12] { 47, 46, 45, 11, 10, 9, 20, 19, 18, 38, 37, 36 };
        private static int[] FaceTurnTableF = new int[8] { 18, 19, 20, 23, 26, 25, 24, 21 };
        private static int[] SideTurnTableF = new int[12] { 6, 7, 8, 9, 12, 15, 29, 28, 27, 44, 41, 38 };
        private static int[] FaceTurnTableR = new int[8] { 9, 10, 11, 14, 17, 16, 15, 12 };
        private static int[] SideTurnTableR = new int[12] { 45, 48, 51, 35, 32, 29, 26, 23, 20, 8, 5, 2 };
        private static int[] SliceTurnTableM = new int[12] { 52, 49, 46, 1, 4, 7, 19, 22, 25, 28, 31, 34 };
        private static int[] SliceTurnTableE = new int[12] { 39, 40, 41, 21, 22, 23, 12, 13, 14, 48, 49, 50 };
        private static int[] SliceTurnTableS = new int[12] { 43, 40, 37, 3, 4, 5, 10, 13, 16, 32, 31, 30 };
        /* Not necessary for this program, but here are the remaining turn tables
        private static int[] FaceTurnTableL = new int[8] { 36, 37, 38, 41, 44, 43, 42, 39 };
        private static int[] SideTurnTableL = new int[12] { 53, 50, 47, 0, 3, 6, 18, 21, 24, 27, 30, 33 };
        private static int[] FaceTurnTableB = new int[8] { 45, 46, 47, 50, 53, 52, 51, 48 };
        private static int[] SideTurnTableB = new int[12] { 33, 34, 35, 17, 14, 11, 2, 1, 0, 36, 39, 42 };
        private static int[] FaceTurnTableD = new int[8] {27, 28, 29, 32, 35, 34, 33, 30 };
        private static int[] SideTurnTableD = new int[12] { 53, 52, 51, 17, 16, 15, 26, 25, 24, 44, 43, 42 };
         */


        public static void GenerateRandomScramble(ScrambleModel newScramble)
        {
            string info = "";
            string searchString = Tools.randomCube();
            newScramble.ColorString = searchString;
            //string solution = SearchRunTime.solution(searchString, out info, buildTables: true);
            string solution = Search.solution(searchString, out info);
            var turns = solution.Split(" ");
            for (int i = turns.Length - 1; i >= 0; i--)
            {
                if (turns[i].Contains('\''))
                {
                    newScramble.Scramble += turns[i][0] + " ";
                }
                else if (turns[i].Length == 1 && (!turns[i].Contains('\'')))
                {
                    newScramble.Scramble += turns[i] + "' ";
                }
                else newScramble.Scramble += turns[i] + " ";
            }
            AddRandomOrientation(newScramble);

        }
        private static void AddRandomOrientation(ScrambleModel scramble)
        {
            Random rnd= new Random();
            int randomOrientation = rnd.Next(1, 25);
            switch (randomOrientation)
            {
                //nothing
                case 1:
                    break;
                //Uw
                case 2:
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Uw";
                    break;
                //Uw'
                case 3:
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Uw'";
                    break;
                //Uw2
                case 4:
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Uw2";
                    break;
                //Rw
                case 5:
                    ApplyTurn(scramble, FaceTurnTableR, 2);
                    ApplyTurn(scramble, SideTurnTableR, 3);
                    ApplyTurn(scramble, SliceTurnTableM, 9);
                    scramble.Scramble += "Rw";
                    break;
                //Rw Uw;
                case 6:
                    ApplyTurn(scramble, FaceTurnTableR, 2);
                    ApplyTurn(scramble, SideTurnTableR, 3);
                    ApplyTurn(scramble, SliceTurnTableM, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Rw Uw";
                    break;
                //Rw Uw'
                case 7:
                    ApplyTurn(scramble, FaceTurnTableR, 2);
                    ApplyTurn(scramble, SideTurnTableR, 3);
                    ApplyTurn(scramble, SliceTurnTableM, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Rw Uw'";
                    break;
                //Rw Uw2
                case 8:
                    ApplyTurn(scramble, FaceTurnTableR, 2);
                    ApplyTurn(scramble, SideTurnTableR, 3);
                    ApplyTurn(scramble, SliceTurnTableM, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Rw Uw2";
                    break;
                //Rw'
                case 9:
                    ApplyTurn(scramble, FaceTurnTableR, 6);
                    ApplyTurn(scramble, SideTurnTableR, 9);
                    ApplyTurn(scramble, SliceTurnTableM, 3);
                    scramble.Scramble += "Rw'";
                    break;
                //Rw' Uw
                case 10:
                    ApplyTurn(scramble, FaceTurnTableR, 6);
                    ApplyTurn(scramble, SideTurnTableR, 9);
                    ApplyTurn(scramble, SliceTurnTableM, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Rw' Uw";
                    break;
                //Rw' Uw'
                case 11:
                    ApplyTurn(scramble, FaceTurnTableR, 6);
                    ApplyTurn(scramble, SideTurnTableR, 9);
                    ApplyTurn(scramble, SliceTurnTableM, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Rw' Uw'";
                    break;
                //Rw' Uw2
                case 12:
                    ApplyTurn(scramble, FaceTurnTableR, 6);
                    ApplyTurn(scramble, SideTurnTableR, 9);
                    ApplyTurn(scramble, SliceTurnTableM, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Rw' Uw2";
                    break;
                //Rw2
                case 13:
                    ApplyTurn(scramble, FaceTurnTableR, 4);
                    ApplyTurn(scramble, SideTurnTableR, 6);
                    ApplyTurn(scramble, SliceTurnTableM, 6);
                    scramble.Scramble += "Rw2";
                    break;
                //Rw2 Uw
                case 14:
                    ApplyTurn(scramble, FaceTurnTableR, 4);
                    ApplyTurn(scramble, SideTurnTableR, 6);
                    ApplyTurn(scramble, SliceTurnTableM, 6);
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Rw2 Uw";
                    break;
                //Rw2 Uw'
                case 15:
                    ApplyTurn(scramble, FaceTurnTableR, 4);
                    ApplyTurn(scramble, SideTurnTableR, 6);
                    ApplyTurn(scramble, SliceTurnTableM, 6);
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Rw2 Uw'";
                    break;
                //Rw2 Uw2
                case 16:
                    ApplyTurn(scramble, FaceTurnTableR, 4);
                    ApplyTurn(scramble, SideTurnTableR, 6);
                    ApplyTurn(scramble, SliceTurnTableM, 6);
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Rw2 Uw2";
                    break;
                //Fw
                case 17:
                    ApplyTurn(scramble, FaceTurnTableF, 2);
                    ApplyTurn(scramble, SideTurnTableF, 3);
                    ApplyTurn(scramble, SliceTurnTableS, 3);
                    scramble.Scramble += "Fw";
                    break;
                //Fw Uw
                case 18:
                    ApplyTurn(scramble, FaceTurnTableF, 2);
                    ApplyTurn(scramble, SideTurnTableF, 3);
                    ApplyTurn(scramble, SliceTurnTableS, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Fw Uw";
                    break;
                //Fw Uw'
                case 19:
                    ApplyTurn(scramble, FaceTurnTableF, 2);
                    ApplyTurn(scramble, SideTurnTableF, 3);
                    ApplyTurn(scramble, SliceTurnTableS, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Fw Uw'";
                    break;
                //Fw Uw2
                case 20:
                    ApplyTurn(scramble, FaceTurnTableF, 2);
                    ApplyTurn(scramble, SideTurnTableF, 3);
                    ApplyTurn(scramble, SliceTurnTableS, 3);
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Fw Uw2";
                    break;
                //Fw' 
                case 21:
                    ApplyTurn(scramble, FaceTurnTableF, 6);
                    ApplyTurn(scramble, SideTurnTableF, 9);
                    ApplyTurn(scramble, SliceTurnTableS, 9);
                    scramble.Scramble += "Fw'";
                    break;
                //Fw' Uw
                case 22:
                    ApplyTurn(scramble, FaceTurnTableF, 6);
                    ApplyTurn(scramble, SideTurnTableF, 9);
                    ApplyTurn(scramble, SliceTurnTableS, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 2);
                    ApplyTurn(scramble, SideTurnTableU, 3);
                    ApplyTurn(scramble, SliceTurnTableE, 9);
                    scramble.Scramble += "Fw' Uw";
                    break;
                //Fw' Uw'
                case 23:
                    ApplyTurn(scramble, FaceTurnTableF, 6);
                    ApplyTurn(scramble, SideTurnTableF, 9);
                    ApplyTurn(scramble, SliceTurnTableS, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 6);
                    ApplyTurn(scramble, SideTurnTableU, 9);
                    ApplyTurn(scramble, SliceTurnTableE, 3);
                    scramble.Scramble += "Fw' Uw'";
                    break;
                //Fw' Uw2
                case 24:
                    ApplyTurn(scramble, FaceTurnTableF, 6);
                    ApplyTurn(scramble, SideTurnTableF, 9);
                    ApplyTurn(scramble, SliceTurnTableS, 9);
                    ApplyTurn(scramble, FaceTurnTableU, 4);
                    ApplyTurn(scramble, SideTurnTableU, 6);
                    ApplyTurn(scramble, SliceTurnTableE, 6);
                    scramble.Scramble += "Fw' Uw2";
                    break;

            }
        }
        private static void ApplyTurn(ScrambleModel scramble, int[] turnTable, int distance)
        {
            Reverse(scramble, turnTable, 0, turnTable.Length - 1);
            Reverse(scramble, turnTable, 0, distance - 1);
            Reverse(scramble, turnTable, distance, turnTable.Length - 1);
        }
        private static void Reverse(ScrambleModel scramble, int[] turnTable, int left, int right)
        {
            char[] charArray = scramble.ColorString.ToCharArray();
            while (left < right)
            {
                int leftValue = turnTable[left];
                int rightValue = turnTable[right];
                char temp = charArray[leftValue];
                charArray[leftValue] = charArray[rightValue];
                charArray[rightValue] = temp;
                left++;
                right--;
            }
            scramble.ColorString = new string(charArray);
            
        }
        
    }
}
