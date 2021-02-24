package package_01;

import java.awt.Color;
import java.io.*;
import java.util.Random;

import ch.aplu.jgamegrid.*;

/* Klasse Fischgame: Das meiste passiert hier
Methoden:
act() - Prüft, ob bestimmte Fische(z.B. der Spieler) gefressen wurden und handelt entsprechend (neue Fische hinzufügen, Spielmodus wechseln)
collide() - Macht, dass zwei sich berührende Fsiche versuchen, einander zu fressen
addscore() - Fügt dem Punktetotal die angegebene Menge hinzu und zeigt die Punkte an
startMenu(), startGame(), startGameover(), etc. - Entfernt alles und fügt je nach Modus verschiedene neue Fische hinzu
writeHighscore() - Speichert die aktuelle Bestenliste im File fischgame_highscore.txt
readHighscore() - Liest die Daten aus fischgame_highscore.txt heraus
*/
public class Fischgame extends GameGrid implements GGActorCollisionListener {
	private static final long serialVersionUID = 7742411446668213885L; //KA wofür das ist
	
	int gamemode;	//0: Menü  -  1: Spiel  -  2: Gameover  -  3: Highscore  -  4: Highscore-Input - 5: Levelauswahl
	int level;		//0: Klassisch  -  1: Erweitert
	int t;
    Spieler player;
	NPC [] b = new NPC[5];
	GGProgressBar bar;
	BLInput highscoreinput;
	int score;
	GGTextField scoredisplay;
	String [] hsname = {"Hai","Hecht","Wal","Eisbär","Krokodil","Tintenfisch","Pinguin","Frosch","Seepferdchen","Krebs"};
	int [] hsscore = {1000,900,800,700,600,500,400,300,200,100};
	Random rand = new Random();

	//Wichtige Methoden
	
	  public Fischgame()
	  {
	    super(511, 511, 1, null, "sprites/BG_1.png", false);
	    setTitle("Fischgame");
	    try {
			readHighscore();
		} catch (IOException e) {
			e.printStackTrace();
		}
	    
	    startMenu();
	    
	    
	    setSimulationPeriod(40);
	    show();
	    doRun();
	  }
	
	  public void act(){
		  switch (gamemode){
		  case 0:
			  if (!b[0].alive){
				  startLevelselect();
			  }
			  if (!b[1].alive){
				  dispose();
			  }
			  if (!b[2].alive){
				  startHighscore();
			  }
			  break;
		  case 1:
			  for (int i=0; i < b.length; i++){
				  if (b[i].alive==false){
					  b[i]=new NPC(getenemytype());
					  addActor(b[i], new Location(1000, 1000));
					  b[i].spawn();
					  player.addCollisionActor(b[i]);
				  }
				  if (!player.alive){
					  startGameover();
				  }
				  if (player.poisoned > 0){
					  bar.setBgColor(new Color(63,255,63));
					  bar.setStripColor(new Color(0,128,0));
					  bar.setValue(player.eaten);
					  scoredisplay.setBgColor(new Color(63,255,63));
				  } else {
					  bar.setBgColor(new Color(63,127,255));
					  bar.setStripColor(new Color(0,0,255));
					  bar.setValue(player.eaten);
					  scoredisplay.setBgColor(new Color(63,127,255));
				  }
			  }
			  break;
		  case 2:
			  if (b[1].getX() < 4){
				  for (int i=0; i<10; i++){
					  if (score > hsscore[i]){
						  startHighscoreInput();
						  break;
					  }
				  }
				  if (score <= hsscore[9]){
					  startMenu();
				  }
			  }
			  break;
		  case 3:
			  if (!b[0].alive){
				  startMenu();
			  }
			  if (!b[1].alive){
					hsname[0] = "Hai";
					hsscore[0] = 1000;
					hsname[1] = "Hecht";
					hsscore[1] = 900;
					hsname[2] = "Wal";
					hsscore[2] = 800;
					hsname[3] = "Eisbär";
					hsscore[3] = 700;
					hsname[4] = "Krokodil";
					hsscore[4] = 600;
					hsname[5] = "Tintenfisch";
					hsscore[5] = 500;
					hsname[6] = "Pinguin";
					hsscore[6] = 400;
					hsname[7] = "Frosch";
					hsscore[7] = 300;
					hsname[8] = "Seepferdchen";
					hsscore[8] = 200;
					hsname[9] = "Krebs";
					hsscore[9] = 100;
					try {
						writeHighscore();
					} catch (IOException e) {
						e.printStackTrace();
					}
					startHighscore();
			  }
			  break;
		  case 4:
			  if (highscoreinput.finished){
				  for (int i=0; i<10; i++){
					  if (score > hsscore[i] && highscoreinput.drin.length()>0){
						  for (int j = 9; j > i; j--){
							  hsname[j]=hsname[j-1];
							  hsscore[j]=hsscore[j-1];
						  }
						  hsname[i]=highscoreinput.drin;
						  hsscore[i]=score;
						  try {
							writeHighscore();
						  } catch (IOException e) {
							e.printStackTrace();
						  }
						  break;
					  }
				  }
				  startMenu();
			  }
			  break;
		  case 5:
			  if (!b[0].alive){
				  level=0;
				  startGame();
			  }
			  if (!b[1].alive){
				  level=1;
				  startGame();
			  }
			  break;
		  }
		  t++;
	  }

	public int collide(Actor actor1, Actor actor2) {
		Fisch m = (Fisch) actor1;
		Fisch n = (Fisch) actor2;
		m.trytoeat(n);
		if (n.alive==false){
			bar.setMax(player.toeat);
			bar.setValue(m.eaten);
			addscore(n.value);
			removeActor(n);
		} else{
		n.trytoeat(m);
		if (m.alive==false){
			bar.setMax(player.toeat);
			bar.setValue(m.eaten);
			removeActor(m);
		}
		}
		return 0;
	}

	//Start[Gamemode]
	
	public void startMenu(){
		gamemode=0;
		removeAllActors();
		t=0;
		score=0;
		
	    player = new Spieler(0);
	    player.grow();
	    addActor(player, new Location(255,255));
	    addKeyListener(player);

    	b[0] = new NPC(-1);
    	b[0].mdx = 0;
    	addActor(b[0], new Location(100, 100));
    	player.addCollisionActor(b[0]);

    	b[1] = new NPC(-1);
    	b[1].mdx = 0;
	    b[1].grow();
    	addActor(b[1], new Location(411, 411));
    	player.addCollisionActor(b[1]);
    	
    	b[2] = new NPC(-1);
    	b[2].mdx = 0;
	    b[2].grow();
	    b[2].grow();
    	addActor(b[2], new Location(100, 411));
    	player.addCollisionActor(b[2]);
    	
	    for (int i=3; i < b.length; i++){
	    	b[i]= new NPC(-1);
	    	addActor(b[i], new Location(1, 1000));
	    	b[i].mdx=0;
	    	player.addCollisionActor(b[i]);
	    }
	    
	    bar = new GGProgressBar(this, new Location(0,-50), 500, 10);
	    scoredisplay = new GGTextField(this, "Punkte: 0", new Location(30,-10), true);
    	
	    player.addActorCollisionListener(this);
	}
	
	public void startGame(){
		gamemode=1;
		removeAllActors();
		t=0;
		score=0;
		
	    player = new Spieler(getplayertype(level));
	    addActor(player, new Location(255,255));
	    addKeyListener(player);

	    for (int i=0; i < b.length; i++){
	    	b[i]= new NPC(getenemytype());
	    	addActor(b[i], new Location(1, 1));
	    	b[i].spawn();
	    	player.addCollisionActor(b[i]);
	    }
	    
	    bar = new GGProgressBar(this, new Location(255,500), 500, 10);
	    bar.setTextColor(TRANSPARENT);
	    bar.setBgColor(new Color(63,127,255));
	    bar.setStripColor(new Color(0,0,255));
	    bar.setMin(0);
	    bar.setMax(player.toeat);
	    bar.setValue(0);
	    
	    scoredisplay = new GGTextField(this, "Punkte: 0", new Location(30,10), true);
	    scoredisplay.setBgColor(new Color(63,127,255));
	    scoredisplay.setTextColor(BLACK);
	    scoredisplay.show();
	    
	    player.addActorCollisionListener(this);
	}
	
	public void startGameover(){
		gamemode=2;
		removeAllActors();
		t=0;
		
	    player = new Spieler(0);
	    addActor(player, new Location(1,-50));

    	b[0] = new NPC(-1);
    	b[0].dx = -1;
	    for (int i=0; i<5; i++){
	    	b[0].grow();
	    }
    	addActor(b[0], new Location(511, 255));

    	b[1] = new NPC(-1);
    	b[1].dx = -1;
	    for (int i=0; i<6; i++){
	    	b[1].grow();
	    }
    	addActor(b[1], new Location(611, 255));
    	
	    for (int i=2; i < b.length; i++){
	    	b[i]= new NPC(-1);
	    	addActor(b[i], new Location(1, 1000));
	    	b[i].mdx=0;
	    }
	    
	    bar = new GGProgressBar(this, new Location(0,-50), 500, 10);
	    scoredisplay = new GGTextField(this, "Punkte: 0", new Location(30,-10), true);
	}
	
	public void startHighscore(){
		gamemode=3;
		removeAllActors();
		t=0;
		score=0;
		
	    player = new Spieler(0);
	    addActor(player, new Location(100,100));
	    addKeyListener(player);
	    player.grow();

    	b[0] = new NPC(-1);
    	b[0].mdx = 0;
	    b[0].grow();
	    b[0].grow();
	    b[0].grow();
    	addActor(b[0], new Location(100, 411));
    	player.addCollisionActor(b[0]);

    	b[1] = new NPC(-1);
    	b[1].mdx = 0;
	    b[1].grow();
	    b[1].grow();
	    b[1].grow();
	    b[1].grow();
    	addActor(b[1], new Location(411, 411));
    	player.addCollisionActor(b[1]);
    	
	    for (int i=2; i < b.length; i++){
	    	b[i]= new NPC(-1);
	    	addActor(b[i], new Location(1, 1000));
	    	b[i].mdx=0;
	    	player.addCollisionActor(b[i]);
	    }
	    
	    try {
			readHighscore();
		} catch (IOException e) {
			e.printStackTrace();
		}
	    
	    bar = new GGProgressBar(this, new Location(0,-50), 500, 10);
	    scoredisplay = new GGTextField(this, "", new Location(200,-10), true);
	    
	    for (int i=0;i<10;i++){
	    	GGTextField hsspot = new GGTextField(this, " " + hsname[i] + " :   " + hsscore[i] + " ", new Location(195,100+ 25*i),true);
	    	hsspot.setBgColor(new Color(75+20*i,255,75+20*i));
	    	hsspot.setTextColor(new Color(180-20*i,0,180-20*i));
	    	hsspot.show();
	    } 
	    
	    player.addActorCollisionListener(this);
	}
	
	public void startHighscoreInput(){
		gamemode=4;
		removeAllActors();
		t=0;

    	GGTextField sometext = new GGTextField(this, "Mit deiner Punktzahl von " + score + " hast du die Bestenliste erreicht!", new Location(100,100),true);
    	sometext.setBgColor(new Color(63,127,255));
    	sometext.show();
    	
    	GGTextField moretext = new GGTextField(this, "Gib bitte deinen Namen ein:     ", new Location(100,128),true);
    	moretext.setBgColor(new Color(63,127,255));
    	moretext.show();
    	
		highscoreinput = new BLInput(this, "Fritzi", new Location(264,128), true);
		addKeyListener(highscoreinput);
	}
	
	public void startLevelselect(){
		gamemode=5;
		removeAllActors();
		t=0;

	    player = new Spieler(0);
	    player.grow();
	    addActor(player, new Location(255,255));
	    addKeyListener(player);

    	b[0] = new NPC(-2);
    	b[0].mdx = 0;
    	addActor(b[0], new Location(100, 100));
    	player.addCollisionActor(b[0]);

    	b[1] = new NPC(-2);
    	b[1].mdx = 0;
	    b[1].grow();
    	addActor(b[1], new Location(411, 411));
    	player.addCollisionActor(b[1]);
    	
	    for (int i=2; i < b.length; i++){
	    	b[i]= new NPC(-1);
	    	addActor(b[i], new Location(1, 1000));
	    	b[i].mdx=0;
	    	player.addCollisionActor(b[i]);
	    }
	    
	    bar = new GGProgressBar(this, new Location(0,-50), 500, 10);
	    scoredisplay = new GGTextField(this, "Punkte: 0", new Location(30,-10), true);
    	
	    player.addActorCollisionListener(this);
	}
	
	// Verschiedene Methoden
	
	public void addscore(int amount){
		String foo = "Punkte: ";
		score+=amount;
		foo = foo + score;
		scoredisplay.setText(foo);
	}
	
	public int getplayertype(int map){
		switch(map){
		case 0:
			return 0;
		case 1:
			return 2;
		}
		return 1;
	}
	
	public int getenemytype(){
		double decision=rand.nextDouble();
		switch(level){
		case 0:
			return 1;
		case 1:
			if (decision < 0.65){
				return 3;
			} else if (0.65 <= decision && decision <= 0.8) {
				return 4;
			} else if (0.8 <= decision && decision <= 0.85) {
				return 5;
			} else if (0.85 <= decision && decision <= 1) {
				return 6;
			}
		}
		return 1;
	}
	
	public void writeHighscore() throws IOException{
	    FileWriter fw = new FileWriter("fischgame_highscore.txt");
	    BufferedWriter bw = new BufferedWriter(fw);
	    for (int i=0;i<10;i++){
	    	bw.write(hsname[i]);
	    	bw.newLine();
	    	bw.write(Integer.toString(hsscore[i]));
	    	bw.newLine();
	    }
	    bw.close();
	}
	
	public void readHighscore() throws IOException{
	    FileReader fr = new FileReader("fischgame_highscore.txt");
	    BufferedReader br = new BufferedReader(fr);

	    for (int i=0;i<10;i++){
	    	hsname[i]=br.readLine();
	    	hsscore[i]=Integer.parseInt(br.readLine());
	    }

	    br.close();
	}
}
