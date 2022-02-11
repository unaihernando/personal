
package basico;

import java.awt.BasicStroke;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
import java.awt.Graphics2D;
import javax.swing.JLabel;
import javax.swing.JPanel;

@SuppressWarnings("serial")
public class Panel extends JPanel {
    
    static Bola bola1 = null;
    Thread thread1 = null; //La bola no es exactamente un thread. Crear un Thread a partir de la bola nos vendrá bien
    
    JLabel JLabelNB;
    
    Panel( ){
        
        bola1 = new Bola( 100f, 50f, 40f, 40f );
        thread1 = new Thread(bola1);
        thread1.start();
    }
    
    @Override
    public Dimension getPreferredSize() {
        return new Dimension(600,600);
    }

    @Override
    public void paintComponent(Graphics g) {
        super.paintComponent(g);        
        
        Graphics2D g2d = (Graphics2D) g;
        g2d.setStroke(new BasicStroke(40f));
        g.setColor(Color.BLUE);
        g2d.draw(bola1);            
    }    
}
