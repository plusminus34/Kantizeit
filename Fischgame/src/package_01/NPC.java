package package_01;

//import java.awt.Point;
/* Klasse NPC: Computergesteuerter Fisch
Methoden:
act() - Wie bei Fisch, ruft aber zuerst noch getIdea() auf
spawn() - legt Startwerte für Grösse, Position und Richtung fest
getIdea() - steuert NPC, für verschiedene Fischarten verschiedene Bewegungsmuster
*/
public class NPC extends Fisch {
	public int t=0;
	
	public NPC(int npctype) {
		super(Fischdaten.sprite(npctype), 10);
	    type=npctype;
	    initiate();
	}
	
	  
	public void act(){
		getIdea();
		poisoned--;
		dx+=ddx;
		dy+=ddy;
		if (ddx < 0){
			setHorzMirror(true);
		} else if (ddx > 0) {
			setHorzMirror(false);
		}
		if (dx > mdx){
			dx=mdx;
			ddx=0;
		} else if (dx < mdx*-1){
			dx=-mdx;
			ddx=0;
		}
		if (dy > mdy){
			dy=mdy;
			ddy=0;
		} else if (dy < mdy*-1){
			dy=-mdy;
			ddy=0;
		}
		if ((getX() >= 511+width && dx > 0 )||( getX() <= -width && dx < 0)){
			dx=0;
			gameGrid.removeActor(this);
			alive=false;
		}
		if (getY() >= 511+height && dy > 0 || getY() <= -height && dy < 0 ){
			dy=0;
			gameGrid.removeActor(this);
			alive=false;
		}
		move();
		t++;
	}
	
	public void spawn(){
		initiate();
		int spawnstage = (int) (Math.random()*10);
		if (spawnstage >= 8){spawnstage = (int) (Math.random()*10);}
		if (spawnstage >= 6){spawnstage = (int) (Math.random()*10);}
		if (spawnstage > 4){spawnstage = (int) (Math.random()*10);}
		if (spawnstage > 2){spawnstage = (int) (Math.random()*10);}//billige Art, um kleinere Fische zu bekommen
		for (int  i=0; i<spawnstage; i++){
			grow();
		}
		switch(type){
		case 1:
		case 3:
		case 4:
			if(Math.random()<0.5){
				setX(-width);
				dx=1;
			}else{
				setX(511+width);
				dx=-1;
			}
			setY((int) (Math.random()*511));
			break;
		case 5:
		case 6:
			setX((int) (Math.random()*511));
			setY(511+height);
			break;
		}
		t=0;
	}
	
	public void getIdea(){
		switch (type){
		case -1:
			if (stage==5 || stage==6){
				dx=-mdx;
			}
		case 1:
		case 3:
			if (dx>=0){
				ddx+=1;
			} else {
				ddx-=1;
			}
			break;
		case 4:
			if (dx>=0){
				ddx+=1;
			} else {
				ddx-=1;
			}
			if (t%10 == 0){
				dy+=Math.round(Math.random()*2-1);
			}
			break;
		case 5:
			dy=(int) -(Math.pow(Math.sin(t*Math.PI/15),2)*mdy);
			break;
		case 6:
			dy--;
		}
	}

}
