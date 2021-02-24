package package_01;

import ch.aplu.jgamegrid.*;

/* Klasse Fisch: Superklasse für Spieler und NPCs
Methoden:
act() - Prüft, ob die momentane Richtung erlaubt ist, korrigiert sie falls nötig und ruft move() auf
move() - Verschiebt den Fisch in x- und y-Richtung gemäss den aktuellen Geschwindigkeiten
initiate() - Setzt Anfangswerte für Grösse, Geschwindigkeit, Kollision, etc. Werte aus Fischdaten ein
grow() - Lässt Fisch den nächsten Sprite verwenden, erhöht seine Stufe und passt Eigenschaften an die neue Stufe an
trytoeat() - frisst einen kleineren* Fisch und ruft danach wenn nötig grow() auf

*Fisch A kann Fisch B nur fressen, wenn die Maulgrösse von A grösser als die Körpergrösse von B ist und A nicht vergiftet ist
*/
public class Fisch extends Actor{
	 public int dx = 0;
	 public int dy = 0;
	 public int mdx = 6;
	 public int mdy = 3;
	 public int ddx = 0;
	 public int ddy = 0;
	 public int bodysize = 1;
	 public int mouthsize = 1;
	 public int value = 0;
	 public int poison = 0;
	 public int stage = 0;
	 public int eaten = 0;
	 public int toeat = 100;
	 public int type;
	 public int width;
	 public int height;
	 public int poisoned = 0;
	 public boolean movingx = false;
	 public boolean movingy = false;
	 public boolean alive = true;
	
	// Wichtiges
	
	  public Fisch(String sprite, int i)
	  {
	    super(sprite,10);
	  }

	public void move(){
		  setLocation(new Location(getLocation().x+dx, getLocation().y +dy));
	  }
	  
	  public void act()
	  {
		  poisoned=Math.max(poisoned-1, 0);
		  dx+=ddx;
		  dy+=ddy;
		  if (ddx < 0){
			  setHorzMirror(true);
		  } else if (ddx > 0) {
			  setHorzMirror(false);
		  }
		  if (!movingx){
			  if (dx>0){
				  dx--;
			  } else if (dx<0){
				  dx++;
			  }
		  }
		  if (!movingy){
			  if (dy>0){
				  dy--;
			  } else if (dy<0){
				  dy++;
			  }
		  }
		  if (Math.abs(dx) > Math.abs(mdx)){
			  dx=mdx*(dx/Math.abs(dx));
			  ddx=0;
		  }
		  if (Math.abs(dy) > Math.abs(mdy)){
			  dy=mdy*(dy/Math.abs(dy));
			  ddy=0;
		  }
		  if (getX() >= 511 && dx > 0 || getX() <= 0 && dx < 0){
			  dx=0;
		  }
		  if (getY() >= 511 && dy > 0 || getY() <= 0 && dy < 0 ){
			  dy=0;
		  }
		  if (poisoned > 0 && dx != 0){
			  dx=dx/Math.abs(dx);
		  }
		  if (poisoned > 0 && dy != 0){
			  dy=dy/Math.abs(dy);
		  }
	    move();
	  }
	  
	  public void initiate(){
		mdx=Fischdaten.mdx(type, 0);
		mdy=Fischdaten.mdy(type, 0);
		bodysize = Fischdaten.bodysize(type, 0);
		mouthsize = Fischdaten.mouthsize(type, 0);
		value = Fischdaten.value(type, 0);
		poison = Fischdaten.poison(type, 0);
		width = Fischdaten.width(type, 0);
		height = Fischdaten.height(type, 0);
		toeat = Fischdaten.toeat(type, 0);
	    Fischdaten.setCollision(this);
	  }
	  
	  // verschiedene Methoden
	  
	  public void grow(){
		  stage++;
		  if (stage<10){
		  showNextSprite();
		  bodysize = Fischdaten.bodysize(type, stage);
		  mouthsize = Fischdaten.mouthsize(type, stage);
		  value = Fischdaten.value(type, stage);
		  poison = Fischdaten.poison(type, stage);
		  width = Fischdaten.width(type, stage);
		  height = Fischdaten.height(type, stage);
		  toeat = Fischdaten.toeat(type, stage);
		  mdx = Fischdaten.mdx(type, stage);
		  mdy = Fischdaten.mdy(type, stage);
		  Fischdaten.setCollision(this);
		  } else {
			  stage--;
			  bodysize += toeat;
			  mouthsize += (int) (toeat/10);
			  toeat = Fischdaten.toeat(type, stage);
		  }
		  
	  }
	  
	  public void trytoeat(Fisch prey){
		  if (mouthsize > prey.bodysize && poisoned <= 0){
			  eaten += prey.bodysize;
			  poisoned += prey.poison;
			  prey.alive = false;
			  if (eaten >= toeat){
				  eaten -= toeat;
				  grow();
			  }
		  }
	  }
}
