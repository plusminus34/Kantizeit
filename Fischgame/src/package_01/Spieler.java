package package_01;

import java.awt.event.KeyEvent;

import ch.aplu.jgamegrid.GGKeyListener;
/* Klasse Spieler: Vom Spieler durch die Tastatur gesteuerter Fisch
Methoden:
keyPressed(), keyReleased() - Beschleunigt/bremst Spieler, wenn die Pfeiltasten gedrückt/losgelassen werden
*/
public class Spieler extends Fisch implements GGKeyListener {

	public Spieler(int pctype){
		super(Fischdaten.sprite(pctype), 10);
	    type=pctype;
	    initiate();
	}
	
	public boolean keyPressed(KeyEvent evt) {
	    switch (evt.getKeyCode()){
	      case KeyEvent.VK_UP:
	        ddy=-1;
	        movingy=true;
	        break;
	      case KeyEvent.VK_RIGHT:
	        ddx=1;
	        movingx=true;
	        break;
	      case KeyEvent.VK_LEFT:
	        ddx=-1;
	        movingx=true;
	        break;
	      case KeyEvent.VK_DOWN:
	        ddy=1;
	        movingy=true;
	        break;
	      case KeyEvent.VK_ESCAPE:
	    	alive=false;
	    	break;
	    }
	    return true;
	}

	public boolean keyReleased(KeyEvent evt) {
	    switch (evt.getKeyCode()){
	      case KeyEvent.VK_UP:
	        ddy=0;
	        movingy=false;
	        break;
	      case KeyEvent.VK_RIGHT:
	        ddx=0;
	        movingx=false;
	        break;
	      case KeyEvent.VK_LEFT:
	        ddx=0;
	        movingx=false;
	        break;
	      case KeyEvent.VK_DOWN:
	        ddy=0;
		    movingy=false;
	        break;
	    }
    return true;
	}

}
