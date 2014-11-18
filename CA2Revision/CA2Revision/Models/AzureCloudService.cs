using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CA2Revision.Models
{
    public class AzureCloudService
    {

        public static String[] InstanceSizeDescription
        {
            get
            {
                return new String[] { "Very Small", "Small", "Medium", "Large", "Very Large", "A6", "A7" };
            }
        }

        public static double[] InstancePriceDescription
        {
            get
            {
                return new double[] { 0.02, 0.08, 0.16, 0.32, 0.64, 0.90, 1.80 };
            }
        }


        [Required(ErrorMessage ="Required Field")]
        [DisplayName("Instance Size")]
        public String InstanceSize { get; set; }


        [Required(ErrorMessage = "Required Field")]
        [Range(2, Int32.MaxValue, ErrorMessage ="At Least 2 instances Required")]
        [DisplayName("Number of Instances")]
        public int NumInstances { get; set; }

        public double Cost
        {
            get
            {
                int size = 0;
                for(int i =0; i < InstanceSizeDescription.Length; i ++)
                {
                    if (InstanceSizeDescription[i] == this.InstanceSize)
                    {
                        size = i;
                        break;

                    }
                }
                double HourlyPrice = NumInstances * InstancePriceDescription[size];
                double dailyPrice = HourlyPrice * 24;
                double yearlyPrice;

                //check if leap year
                if(DateTime.IsLeapYear(DateTime.Now.Year))
                {
                    yearlyPrice = dailyPrice * 366;
                }
                else // if not leap year
                {
                    yearlyPrice = dailyPrice * 365;
                }

                return yearlyPrice;
            }
        }
    }
}