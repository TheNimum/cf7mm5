using System;

namespace cf7mm5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            Console.WriteLine("skriv in fem tal");
            
                // denna for loop gör någonting,. 
                for(i = 0; i<arr.Length; i++){
                    
                System.Console.Write($"index[{i+1}]: ");
                arr[i] = Int32.Parse(Console.ReadLine());



                

                } //denna delen av koden skriver talen i backlänges ordning.
                for(i = arr.Length -1; i>=0; i--){
                    Console.Write(arr[i]);

                }
                
                
                




            }
    }

    
    
         
    
}