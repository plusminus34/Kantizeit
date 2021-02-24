package package_01;

import java.awt.*;
import java.applet.Applet;

public class BestenlistenPopup extends Applet{
	private static final long serialVersionUID = -5154972886225489475L;
	
	TextField textteil = new TextField("Text");
	
	public BestenlistenPopup(){
		add(textteil);
		start();
	}
}
