/*
Author: Yihan Wang
Date:   11-10-2015
Description:    Class that implements a merge sort to be used to sort the total Cost
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237assignment4
{
    class MergeSort
    {

        public MergeSort(IComparable[] droidCollection)
        {

            IComparable[] totalCost = new IComparable[droidCollection.Length];

            int x = 0;
            //Calculate the total cost and store in an array
            foreach (IDroid droid in droidCollection)
            {
                if (droid != null)
                {
                    droid.CalculateTotalCost();
                    totalCost[x] = droid.TotalCost;
                    x++;
                }
            }
            int lo = 0, hi = x;

            Sortmerge(totalCost, lo, hi);
        }


        private static void Sortmerge(IComparable[] totalCost, int lo, int hi)
        {
            if (lo < hi)
            {
                int mid = (lo + hi) / 2;

                //Call recusively to divide the arrays
                Sortmerge(totalCost, lo, mid);
                Sortmerge(totalCost, mid + 1, hi);

                //Create two arrays split down the middle for the right and left side
                IComparable[] leftArray = new IComparable[mid];
                IComparable[] rightArray = new IComparable[totalCost.Length - mid];

                //Copy the main array into the temporaries
                Array.Copy(totalCost, leftArray, mid);
                Array.Copy(totalCost, mid, rightArray, 0, rightArray.Length);

                int i = 0, j = 0;

                //do the merge sort
                for (int k = lo; k < hi; k++)
                {
                    if (i == leftArray.Length)
                    {
                        totalCost[k] = rightArray[j++];
                    }
                    else if (j == rightArray.Length)
                    {
                        totalCost[k] = leftArray[i++];
                    }
                    else if (leftArray[i].CompareTo(rightArray[j]) == -1)
                    {
                        totalCost[k] = leftArray[i++];
                    }
                    else
                    {
                        totalCost[k] = rightArray[j++];
                    }
                }
            }
        }
    }
}
