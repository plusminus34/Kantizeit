package package_01;

import java.awt.Color;
import java.awt.event.KeyEvent;

import ch.aplu.jgamegrid.*;

public class BLInput extends GGTextField implements GGKeyListener{
	String drin = "Fritzi";
	String allowedchars = "abcdefghijklmnopqrstuvwxyzQWERTZUIOPASDFGHJKLYXCVBNM‰ˆ¸ƒ÷‹‡ÈË1234567890+*Á%&/()=.,-_+\\<> ";
	public boolean finished = false;

	public BLInput(GameGrid gg, String text, Location location, boolean enableRefresh) {
		super(gg, text, location, enableRefresh);

		this.setBgColor(new Color(63,127,255));
		this.setTextColor(Color.BLACK);
		this.show();
	}

	
	
	@Override
	public boolean keyPressed(KeyEvent evt) {
		if (allowedchars.contains(""+evt.getKeyChar())){
			drin=drin+evt.getKeyChar();
			this.setText(drin);
		} else if(evt.getKeyCode()==KeyEvent.VK_ENTER){
			finished=true;
		} else if ((evt.getKeyCode()==KeyEvent.VK_DELETE || evt.getKeyCode()==KeyEvent.VK_BACK_SPACE) && drin.length()>0){
			drin=drin.substring(0, drin.length()-1);
			this.setText(drin);
		}
		return false;
	}

	@Override
	public boolean keyReleased(KeyEvent evt) {

		return false;
	}

}
