using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace MDI
{
    class ClassSom1
    {
        public static FSom1 Form1;

        /// <summary>
        ///  fill L with n unique random ints
        ///  between min and max
        /// </summary>
        /// <algo>
        /// 
        /// </algo>
        
        static Random random = new Random();
        public static int[] ArrLeft;
        public static int[] ArrRight;

        internal static int[] FillRandom(int n, int min, int max)
        {
            int[] z = new int[n];

            for (int i = 0; i < n; i++)
            {
                z[i] = random.Next(min, max);
            }
            return z;
        }

        /// <summary>
        /// delete the selected item
        /// </summary>
        internal static int[] DeleteItem(int selectedIndex, int countFrom, int [] ArrFrom)
        {
            int[] temp = new int[countFrom-1];
            int x = 0;
            for (int i = 0; i < ArrFrom.Length; i++)
            {
                if (selectedIndex == i)
                {
                    continue;
                }
                else
                {
                    temp[x] = ArrFrom[i];
                    x++;
                }
            }
            return temp;
        }

        /// <summary>
        /// Add a single item to an array
        /// </summary>
        internal static int[] AddSingleItem(int selectedIndexFrom, int CountTo, int[] ArrFrom, int[] ArrTo)
        {
            int[] temp = new int[CountTo + 1];
            int x = 0;
            for (int i = 0; i < ArrTo.Length; i++)
            {
                temp[i] = ArrTo[i];
                x++;
            }
            temp[x] = ArrFrom[selectedIndexFrom];


            return temp;
        }

        /// <summary>
        /// Count the amount of items without duplicates
        /// </summary>
        internal static int LengthOfArrayWithoutDuplicates(int[] ArrFrom, int[] ArrTo)
        {
            int temp = 0;
            for (int i = 0; i < ArrFrom.Length; i++)
            {
                for (int x = 0; x < ArrFrom.Length; x++)
                {
                    if (ArrTo[i] == ArrFrom[x])
                    {
                        temp++;
                    }
                }
            }
            int Length = ArrFrom.Length + ArrTo.Length - temp;
            return Length;
        }

        /// <summary>
        /// Move all items from array A to array B and delete the duplicates
        /// </summary>
        internal static int[] MoveAllItems(int[] ArrFrom, int[] ArrTo, int Length)
        {
            int[] temp = new int[Length];
            int b = 0;
            bool check = false;
            for (int i = 0; i < ArrTo.Length; i++)
            {
                temp[i] = ArrTo[i];
                b++;
            }
            for (int i = 0; i < ArrFrom.Length; i++)
            {
                check = false;
                for (int x = 0; x < ArrTo.Length && check == false; x++)
                {
                    if (ArrFrom[i] == ArrTo[x])
                    {
                        check = true;
                    }
                }

                if (check == false)
                {
                    temp[b] = ArrFrom[i];
                    b++;
                }
            }


            //fill the temp array from arrfrom without duplicates

            return temp;
        }

        /// <summary>
        /// Fill an array with the contents of the listbox
        /// </summary>
        internal static int[] GetArrFromList(ListBox Array)
        {
            int[] temp = new int[Array.Items.Count];
            for (int i = 0; i < Array.Items.Count; i++)
            {
                temp[i] = Convert.ToInt32(Array.Items[i]);
            }
            return temp;
        }

        /// <summary>
        /// Fill a listbox with the contents of an array
        /// </summary>
        internal static void FillListFromArray(int[] Array, ListBox List)
        {
            List.Items.Clear();
            for (int i = 0; i < Array.Length; i++) List.Items.Add(Array[i]);
        }

        
    }
} 
