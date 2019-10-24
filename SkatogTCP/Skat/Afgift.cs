using System;

namespace Skat
{
    public class Afgift
    {
        
        
        public static double BilAfgift(double pris)
        {
            double vbilAfGift = 0; //vi giver vbilAfGift double som type og den indholder "0" som værdi. 

            if (pris < 0) // Tjekker om pris er under 0
            {
                throw new ArgumentException("Det tal du har indtastet er negativt."); // kaster Exception hvis pris er negativt.
            }

            if (pris < 200000 || pris == 200000) // Tjekker om pris er mindre eller lige med 200k. 
            {
                vbilAfGift = pris * 0.85;  
            }
            else if (pris > 200000) // Tjekker om pris større end 200k
            {
                vbilAfGift = (pris * 1.50) - 130000; 
            }

            return vbilAfGift; // retunere vbilAfGift når en "IF/Els If" er true.

        }

        public static double ElBilAfgift(double pris)
        {
            
            double vbilAfgift = 0; //vi giver vbilAfGift double som type og den indholder "0" som værdi. 

            if (pris < 0) // Tjekker om pris er under 0
            {


                throw new ArgumentException("Det tal du har indtastet er negativt."); // kaster Exception hvis pris er negativt.
            }

            if (pris <= 200000) // Tjekker om pris er mindre eller lige med 200k. 
            {
                vbilAfgift = pris * 0.85;
            }
            else if (pris > 200000) // Tjekker om pris større end 200k
            {
                vbilAfgift = (pris * 1.50) - 130000;
            }

        

            double velbilsafgift = vbilAfgift * 0.20;


            return velbilsafgift; // retunere vbilAfGift når en "IF/Els If" er true.

        }

    }


    








}
   
            

