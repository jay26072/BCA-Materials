public class patten
	{
		public static void main(String[ ]args)
		{
			int i,j,k;
			int n=12;
            for(i=0;i<n;i++)
			{
                for(k=1;k<n-i;k++)
                {
                    System.out.print(" ");
                }
                System.out.print("*");
                for(j=0;j<=i-1;j++)
                {
                    System.out.print("-");
                }
                for(j=1;j<i;j++)
                {
                    System.out.print("-");
                }
                if(i>0)
                {
                    System.out.print("*");
                }
        System.out.println("");
        }
    }
	}