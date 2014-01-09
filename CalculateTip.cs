using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
///initialize amount and percentage in class
///Nicole C Peoples
/// </summary>
/// 
//begin Constructors:  Constructors have 
//no return type and 
//same name as the class: If no constructor written, compiler will initialize
public class CalculateTip  
{
    private double amount;
    private double percent;


    public CalculateTip()
    {
        Amount = 0;
        Percent = 0;
    }

    public CalculateTip(double amt, double perc)//initializing variables
    {
        Amount = amt;
        Percent = perc;
    }

    public double Amount //property
    {
        set { amount = value; } //value is a prebuilt property that goes with properties
        get { return amount; }

    } //end amount Property

    public double Percent //property
    {
        set
        {
            if (value > 1)
            {
                value /= 100;
            }
            percent = value;
        }//end set

        get { return percent; }
    }// end Percent property


    public double TipCalculator() //method
    {
        return Amount * Percent;

    } //end CalculateTip

    public double CalculateTotal() //method
    {
        return Amount + TipCalculator();

    } //end CalculateTotal

}// end Public Class CalculateTip
