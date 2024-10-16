import java.applet.*;
import java.awt.*;
/*
<applet code="pro10" width="300" height="300">
<param name="oval" value="4">
</applet>*/

public class pro10 extends Applet
{
	int o,i=50;
	public void init()
	{
		o=Integer.parseInt(Getparameter("oval"));
	}
	public void paint(graphic g)
	{
		for (int i=1;i<0;i++)
		{
			g.drawOval(10+1,10+1,100+1,100+1);
		}
	}
}