using System;
using System.Collections.Generic;
using System.Text;

namespace homework.oops
{
    class Pen
    {
        public class PenData
        {

            private string penColor;
            private String penBrand;
            private double penPrice;

            PenData()
            // d constctr
            {
                penColor = "red";
                penBrand = "cello";
                penPrice = 10;
            }

            PenData(string str1, String str, int num)
            //p constctr
            {
                penColor = str1;
                penBrand = str;
                penPrice = num;
            }

            // Getter and setter methods
            

            public void setPenColor(string penColor)
            {
                this.penColor = penColor;
            }

            
            public void setpenBrand(String penBrand)
            {
                this.penBrand = penBrand;
            }
      
            public void setpenPrice(double penPrice)
            {
                this.penPrice = penPrice;
            }
            public string getPenColor()
            {
                return penColor;
            }
            public String getPenBrand()
            {
                return penBrand;
            }
            public double getPenPrice()
            {
                return penPrice;
            }
        }
    }
}
