import java.awt.Color;
import java.awt.Component;

import javax.swing.*;
public class snake{
    public static void name(String[] args) 
    {
       JFrame Board=new JFrame("THE SNAKE GAME");
       JLabel Title=new JLabel("THE SNAKEGAME");
       Board.setBounds(10,10,905,700);

    Board.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
    Board.setResizable(false);
    Board.setLocation(500,800);
    Board.setBackground(Color.DARK_GRAY);

    snake gm= new snake();

    Board.add(gm);
    Board.setVisible(true);

    }
}