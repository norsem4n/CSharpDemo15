/* Project:         Homework 7 - Assignment Set 16
 * Date:            December 2020
 * Last Modified:   12.11.2020
 * Developed By:    CGK
 * Class Name:      Charter
 * Purpose:         Showcases price and accommodations for different yacht charters
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKarnasProgram16
{
    class Charter
    {
        #region"Properties"
        //5 instance properties (auto-implemented – public get and private set)
        public decimal CharterFee { get; private set; }
        public decimal CharterHours { get; private set; }
        public string CustomerName { get; private set; }
        public int YachtSize { get; private set; }
        public string YachtTypes { get; private set; }

        #endregion

        #region"Constructors"
        //instantiates object and set its customer name, yacht type, yacht size, and hours chartered using parameters
        //calls a private method (see below) to set the charter fee.
        public Charter(string customerName, string yachtType, int yachtSize, decimal hoursChartered)
        {
            CustomerName = customerName;
            CharterHours = hoursChartered;
            YachtSize = yachtSize;
            YachtTypes = yachtType;

            CharterFee = CalculateCharterFee();
        }
        #endregion

        #region"Methods"
        //a private method to calculate and return the charter fee based on the rate table
        private decimal CalculateCharterFee()
        {
            decimal charterFee = 0;

            switch(YachtSize)
            {
                case 22:
                    charterFee = 208 * CharterHours;
                    break;
                case 24:
                    charterFee = 283 * CharterHours;
                    break;
                case 30:
                    charterFee = 305 * CharterHours;
                    break;
                case 32:
                    charterFee = 397 * CharterHours;
                    break;
                case 36:
                    charterFee = 495 * CharterHours;
                    break;
                case 38:
                    charterFee = 546 * CharterHours;
                    break;
                case 45:
                    charterFee = 675 * CharterHours;
                    break;
            }
            return charterFee;
        }

        #endregion

    }
}
