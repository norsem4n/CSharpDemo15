/* Project:         Homework 7 - Assignment Set 16
 * Date:            December 2020
 * Last Modified:   12.11.2020
 * Developed By:    CGK
 * Class Name:      CharterManager
 * Purpose:         Manages selection criteria for Yacht Charters
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Globalization;

namespace CKarnasProgram16
{
    class CharterManager
    {
        #region"Properties"
        //instance property (auto-implemented – public get and private set)
        public List<Charter> CharterList { get; private set; }

        #endregion

        #region"Constructors"
        //instantiates object and instantiates the List<Charter> collection
        public CharterManager()
        {
            CharterList = new List<Charter>();
        }

        #endregion

        #region"Methods"
        //a method to a) instantiate a Charter object and add it to the List <Charter> collection
        public void AddCharter(string customerName, string yachtType, int yachtSize, decimal hoursChartered)
        {
            Charter aCharter = new Charter(customerName, yachtType, yachtSize, hoursChartered);

            CharterList.Add(aCharter);
        }

        //a method to find and return the lowest charter fee among all the charters
        public decimal FindLowestCharterFee()
        {
            // using LINQ (Method Syntax)
            //var lowest = CharterList.Min(f => f.CharterFee);
            //return lowest;

            decimal currentLowest = CharterList[0].CharterFee;

            foreach (Charter aCharter in CharterList)
            {
                if (aCharter.CharterFee < currentLowest)
                {
                    currentLowest = aCharter.CharterFee;
                }
            }
            return currentLowest;
        }

        //a method to sum up and return the total fees from all the charters
        // using LINQ (Method Syntax)
        public decimal GetTotalCharterFees()
        {
            // using LINQ (Method Syntax)
            //decimal total = CharterList.Sum(f => f.CharterFee);
            //return total;

            decimal total = 0;

            foreach (Charter aCharter in CharterList)
            {
                total += aCharter.CharterFee;
            }
            return total;
        }
        
        //a method to calculate and return the average charter fee
        public decimal GetAvgCharterFee()
        {
            //using LINQ (Method Syntax)
            var average = CharterList.Average(f => f.CharterFee);
            return average;
        }

        //a method to count and return the number of charters for a specific yacht size
        public int GetCharterCount(int yachtSize)
        {
            //return CharterList.Count;
            //GetLength for an array

            int count = 0;

            foreach (Charter aCharter in CharterList)
            {
                if (aCharter.YachtSize == yachtSize)
                {
                    ++count;
                }
            }
            return count;

            // using LINQ (Query syntax)

            //int count = (from aFood in FoodList
            //             where aFood.FoodType == aGroup
            //             select aFood).Count();
            //return count;

            // using LINQ (Method Syntax)

            //int count = CharterList.Count(f => f.YachtSize == yachtSize);
            //return count;
        }

        #endregion
    }
}
