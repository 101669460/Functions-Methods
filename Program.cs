using System;

namespace Functions_Methods
{
    class Program
    {
        
        static void Program1(){
            Console.WriteLine("Welcome Friends!");
            Console.WriteLine("Have a nice day!");
        }
        
        static string Program2(string name){
           Console.WriteLine("Welcome Friend " + name + "!");
           Console.WriteLine("Have a nice day!");
           return name;
        }
        static int Program3(int num1, int num2){
            int answer = num1 + num2;
            Console.WriteLine("The sum of two numbers is : " + answer);
            return answer;
        }
        static int Program4(string words){
            int spaces = 0;
            string words1;
            for (int i = 0; i < words.Length; i++ ){
                words1 = words.Substring(i,1);
                if (words1 == " "){
                    spaces++;
                }
            }
            return spaces;
        }
        static int Program5(int[] nums){
            int result = 0;
            for (int i = 0; i < nums.Length; i++){
                result  += nums[i];
            }
            return result;
        }
        static void Program6(int num1, int num2){
            int num3 = num2;
            num2 = num1;
            num1 = num3;
            Console.WriteLine("Now the 1st number is : " + num1 + " , and the 2nd number is : " + num2);
        }
        static void Program7(int num1, int num2){
            int answer = num1;
            for(int i = 1; i < num2; i++ ){
                answer = answer * num1;
                }
            Console.WriteLine("So, the number " + num1 + " ^ (to the power) " + num2 + " = " + answer);
        }
        static void Program8(int length){
            int num1 = 0;
            int num2 = 1;
            int num3;
            Console.Write(num1 + " ");
            Console.Write(num2 + " ");
            for (int i = 2; i < length; i++){
                num3 = num1 + num2;
            	Console.Write(num3 + " ");
                num1 = num2;
                num2 = num3;
            }
        }
        static void Program9(int num){
               for (int i=2; i < num; i++)
                    if (num %i == 0) 
                        Console.Write(num + " is not a prime number.");
                Console.Write(num + " is a prime number");
        }       
        static void Program10(int num){
            int total = 0;
            int digit = num;
            while(digit != 0){
                total = total + digit%10;
                digit = digit/10;
            }
            Console.Write("The sum of the digits of the number " + num + " is : " + total);
        }


        static void Main(string[] args)
        {
            Program10(1236);
            
        }
      
    }

}
        
       
