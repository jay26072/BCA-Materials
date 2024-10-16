public class Program5 
{
    public static void main(String[] args) {
        int num = Integer.parseInt(args[0]), temp = num, remainder, sum = 0;

        while (num > 0) {
            remainder = num % 10;
            sum = (sum *10) + remainder;
            num = num / 10;
        }

        if(temp == sum) {
            System.out.println("This is palindrome number");
        }
        else {
            System.out.println("This is Not palindrome number");
        }
    }
}