public class Program8 {
    public static void main(String[] args) {
        int input = Integer.parseInt(args[0]), i = 0;

        while (input > 0) {
            input = input / 10;
            i++;
        }

        try{
            if (i % 2 != 0) {
                throw new OddException("Error! The input contains odd number of Digits!");
            }
            else{
                System.out.println("No error will be thrown because the input contains even number of digits");
            }
        }
        catch (OddException e){
            System.out.println(e);
        }
    }
}