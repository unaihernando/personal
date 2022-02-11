/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package basico;

import java.awt.Color;
import java.awt.FlowLayout;
import java.awt.Font;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.border.SoftBevelBorder;

/**
 *
 * @author idoia
 */
public class ProgPrincipal {
    
    public static void main(String[] args) {
        
        JFrame fram = new JFrame("Falling Balls");
        fram.setLayout(new FlowLayout());
        
        JLabel jlCabecera = new JLabel("Bola que cae y cae...");
        JLabel jlPie1a = new JLabel("xxx:");
        JLabel jlPie1b = new JLabel("?");
        jlPie1b.setFont(new Font("SansSerif",1,50));
        jlPie1b.setBorder(new SoftBevelBorder(SoftBevelBorder.LOWERED));
        
        Panel pan = new Panel();
        pan.setLayout(null);
        pan.setBackground(new Color(240,240,240));
        pan.setSize(500, 500);
      
        fram.add(jlCabecera);
        fram.add(pan);
        fram.add(jlPie1a);
        fram.add(jlPie1b);
                
        fram.setSize(600, 750);
        fram.getContentPane().setBackground(new Color(200,200,200));
        fram.setVisible(true);
        fram.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

        while ( true ) {
            fram.repaint();
            try {
                Thread.sleep(10);
            } catch (InterruptedException ex) {
                Logger.getLogger(ProgPrincipal.class.getName()).log(Level.SEVERE, null, ex);
            }
        }
    }
}
    
