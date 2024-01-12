public class Division {
    /*
    Write a function that given two positive integer value parameters will print out all even numbers between 2 
    and the highest parameter value (inclusive) which is evenly divisible by the lowest parameter value.

Examples:

· Given 17 and 4, the output will be 4, 8, 12, 16

· Given 21 and 7, the output will be 14

· Given 5 and 20, the output will be 10, 20

· Given 3 and 10, the output will be 6

· Given 2 and 2, the output will be 2
    */
    public static void Exercise(int num1, int num2){
        if (num1 < 0 || num2 < 0) {
            Console.WriteLine("Invalid Params");
        }
        else {
            int largerNum = Math.Max(num1, num2);
            int smallerNum = Math.Min(num1, num2);

            for (int i = 2; i <= largerNum; i += 2){
                if(i % smallerNum == 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
