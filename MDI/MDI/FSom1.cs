using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI
{
    /// <summary>
    /// collection of simple tasks with respect to
    /// listboxes and algo
    /// </summary>
    public partial class FSom1 : Form
    {
        public FSom1()
        {
            InitializeComponent();
        }

        private void FSom1_FormClosed(object sender, FormClosedEventArgs e)
        {
            //empty the variable for checking for an existing tab
            ClassSom1.Form1 = null;
        }

        /// <summary>
        /// fill the listboxes with random numbers between 0-20
        /// </summary>
        
        int n = 3, min = 0, max = 20;

        private void fillRandom_Click(object sender, EventArgs e)
        {
            ListLeft.Items.Clear();
            ListRight.Items.Clear();
            ClassSom1.ArrLeft = ClassSom1.FillRandom(n, min, max);
            for (int i = 0; i < ClassSom1.ArrLeft.Length; i++) ListLeft.Items.Add(ClassSom1.ArrLeft[i]);
            ClassSom1.ArrRight = ClassSom1.FillRandom(n, min, max);
            for (int i = 0; i < ClassSom1.ArrRight.Length; i++) ListRight.Items.Add(ClassSom1.ArrRight[i]);
        }

        /// <summary>
        /// add up the selected items and display in the textbox
        /// </summary>
        private void sumSelec_Click(object sender, EventArgs e)
        {
            if (ListLeft.SelectedIndex > -1 && ListRight.SelectedIndex > -1)
            {
                txtSum.Clear();
                int sum = Convert.ToInt32(ListLeft.SelectedItem) + Convert.ToInt32(ListRight.SelectedItem);
                txtSum.Text = sum.ToString();
            }
        }

        /// <summary>
        /// remove the selected item when pressing the button
        /// </summary>

        private void delSelec_Click(object sender, EventArgs e)
        {
            if (ListLeft.SelectedIndex > -1)
            {
                int[] LeftArr = ClassSom1.GetArrFromList(ListLeft);
                int[] RightArr = ClassSom1.GetArrFromList(ListRight);

                LeftArr = ClassSom1.DeleteItem(ListLeft.SelectedIndex, ListLeft.Items.Count, LeftArr);
                RightArr = ClassSom1.DeleteItem(ListRight.SelectedIndex, ListRight.Items.Count, RightArr);

                ClassSom1.FillListFromArray(LeftArr, ListLeft);
                ClassSom1.FillListFromArray(RightArr, ListRight);


            }
        }

        /// <summary>
        /// delete the selected item in the left listbox and add in the right listbox
        /// </summary>

        private void selecToRight_Click(object sender, EventArgs e)
        {
            if(ListLeft.SelectedIndex != -1)
            {
                int[] LeftArr = ClassSom1.GetArrFromList(ListLeft);
                int[] RightArr = ClassSom1.GetArrFromList(ListRight);

                RightArr = ClassSom1.AddSingleItem(ListLeft.SelectedIndex, ListRight.Items.Count, LeftArr, RightArr);
                LeftArr = ClassSom1.DeleteItem(ListLeft.SelectedIndex, ListLeft.Items.Count, LeftArr);

                ClassSom1.FillListFromArray(LeftArr, ListLeft);
                ClassSom1.FillListFromArray(RightArr, ListRight);
            }
            

        }

        /// <summary>
        /// delete the selected from the right listbox and add to right listbox
        /// </summary>

        private void selecToLeft_Click(object sender, EventArgs e)
        {
            if (ListRight.SelectedIndex != -1)
            {
                int[] LeftArr = ClassSom1.GetArrFromList(ListLeft);
                int[] RightArr = ClassSom1.GetArrFromList(ListRight);

                LeftArr = ClassSom1.AddSingleItem(ListRight.SelectedIndex, ListLeft.Items.Count, RightArr, LeftArr);
                RightArr = ClassSom1.DeleteItem(ListRight.SelectedIndex, ListRight.Items.Count, RightArr);

                ClassSom1.FillListFromArray(LeftArr, ListLeft);
                ClassSom1.FillListFromArray(RightArr, ListRight);
            }
        }


        /// <summary>
        /// delete all the items from the left listbox and add to the right listbox if there are no duplicates
        /// </summary>

        private void allToRight_Click(object sender, EventArgs e)
        {
            int[] LeftArr = ClassSom1.GetArrFromList(ListLeft);
            int[] RightArr = ClassSom1.GetArrFromList(ListRight);

            int Length = ClassSom1.LengthOfArrayWithoutDuplicates(RightArr, LeftArr);
            RightArr = ClassSom1.MoveAllItems(LeftArr, RightArr, Length);

            ListLeft.Items.Clear();
            ClassSom1.FillListFromArray(RightArr, ListRight);
        }

        /// <summary>
        /// delete all the items from the right listbox and add to the left listbox if there are no duplicates
        /// </summary>
        private void allToLeft_Click(object sender, EventArgs e)
        {
            int[] LeftArr = ClassSom1.GetArrFromList(ListLeft);
            int[] RightArr = ClassSom1.GetArrFromList(ListRight);

            int Length = ClassSom1.LengthOfArrayWithoutDuplicates(RightArr, LeftArr);
            LeftArr = ClassSom1.MoveAllItems(RightArr, LeftArr, Length);

            ClassSom1.FillListFromArray(LeftArr, ListLeft);
            ListRight.Items.Clear();
        }
    }
}