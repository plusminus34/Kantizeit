package package_01;

import java.awt.Point;
/* Klasse Fischdaten: Übergibt auf Befehl Werte für die Eigenschaften von Fischen einer bestimmten Art und Stufe
Methoden:
setCollision() - Legt direkt die für die Kollision mit anderen Fischen benötigte Form des Fisches fest
alles andere - Gibt den Standardwert der gewünschten Eigenschaft für die gegebene Fischsorte zurück
*/
public abstract class Fischdaten {
	
	public static String sprite(int type){
		switch(type){
		case -2:
			return "sprites/Levelselect.png";
		case -1:
			return "sprites/Knopffisch.png";
		case 0:
			return "sprites/Rotfisch.png";
		case 1:
			return "sprites/Futfisch.png";
		case 2:
			return "sprites/Gruenfisch.png";
		case 3:
			return "sprites/Futterfisch.png";
		case 4:
			return "sprites/Fressfisch.png";
		case 5:
			return "sprites/Inky.png";
		case 6:
			return "sprites/Qualle.png";
		}
		return "";
	}
	
	public static int bodysize(int type, int num){
		switch(type){
		case -2://Levelselect(dummy)
			return 0;
		case -1://Knopffisch(dummy)
			return 0;
		case 0://Rotfisch
			return 30*(num+1);
		case 1://Futfisch
			return 28*(num+1);
		case 2://Grünfisch
			int [] gruenfischbodysize = {452,766,1295,2192,3710,6277,10622,17975,30417,51472};
			return gruenfischbodysize[num];
		case 3://Futterfisch
			int [] futterfischbodysize = {113,206,377,688,1256,2292,4184,7637,13941,25447};
			return futterfischbodysize[num];
		case 4://Fressfisch
			int [] fressfischbodysize = {1976,2826,4041,5778,8262,11815,16895,24159,34546,49400};
			return fressfischbodysize[num];
		case 5://Inky
			int [] inkybodysize = {314,524,874,1458,2432,4058,6768,11290,18833,31416};
			return inkybodysize[num];
		case 6://Qualle
			int [] quallebodysize = {157,246,385,602,942,1474,2306,3608,5647,8836};
			return quallebodysize[num];
		}
		return 0;
	}

	public static int mouthsize(int type, int num){
		switch(type){
		case -2:
			return 0;
		case -1:
			return 0;
		case 0:
			return 30*(num+1);
		case 1:
			return 28*(num+1);
		case 2:// 30% bodysize
			return (int) ((double)bodysize(type,num)*0.3);//hässlich, aber irgendwie hat es erst so funktioniert
		case 3:// 20% bodysize
			return (int) ((double)bodysize(type,num)*0.2);
		case 4:// 40% bodysize
			return (int) ((double)bodysize(type,num)*0.4);
		case 5:// 35%
			return (int) ((double)bodysize(type,num)*0.35);
		case 6:// 70%
			return (int) ((double)bodysize(type,num)*0.7);
		}
		return 0;
	}

	public static int value(int type, int num){
		switch(type){
		case -2:
			return 0;
		case -1:
			return 0;
		case 0:
			return 30*(num+1);
		case 1:
			return 28*(num+1);
		case 2:
			return 10*(num+1);
		case 3:
			return 10*(num+1);
		case 4:
			return 15*(num+1);
		case 5:
			return 30*(num+1);
		case 6:
			return 4*(num+1);
		}
		return 0;
	}

	public static int poison(int type, int num){
		switch(type){
		case -2:
			return 0;
		case -1:
			return 0;
		case 0:
			return 0;
		case 1:
			return 0;
		case 2:
			return 0;
		case 3:
			return 0;
		case 4:
			return 0;
		case 5:
			return 0;
		case 6:
			return 10+num*num;
		}
		return 0;
	}
	
	public static int width(int type, int num){
		switch(type){
		case -2:
			return 88;
		case -1:
			return 90;
		case 0:
			return 51*(num+1);
		case 1:
			return 50*(num+1);
		case 2:
			int [] gruenfischwidth = {24,32,40,52,68,90,116,152,196,256};
			return gruenfischwidth[num];
		case 3:
			int [] futterfischwidth = {12,16,22,30,40,54,73,99,133,180};
			return futterfischwidth[num];
		case 4:
			int [] fressfischwidth = {52,62,74,88,106,127,152,182,217,260};
			return fressfischwidth[num];
		case 5:
			int [] inkywidth = {20,26,33,43,56,72,93,120,155,200};
			return inkywidth[num];
		case 6:
			int [] quallewidth = {20,25,31,39,49,61,77,96,120,150};
			return quallewidth[num];
		}
		return 0;
	}
	
	public static int height(int type, int num){
		switch(type){
		case -2:
			return 88;
		case -1:
			return 50;
		case 0:
			return 25*(num+1);
		case 1:
			return 25*(num+1);
		case 2:
			int [] gruenfischheight = {24,32,40,52,68,90,116,152,196,256};
			return gruenfischheight[num];
		case 3:
			int [] futterfischheight = {12,16,22,30,40,54,73,99,133,180};
			return futterfischheight[num];
		case 4:
			int [] fressfischheight = {38,45,54,65,78,93,111,133,159,190};
			return fressfischheight[num];
		case 5:
			int [] inkyheight = {20,26,33,43,56,72,93,120,155,200};
			return inkyheight[num];
		case 6:
			int [] qualleheight = {20,25,31,39,49,61,77,96,120,150};
			return qualleheight[num];
		}
		return 0;
	}
	
	public static int mdx(int type, int num){
		switch(type){
		case -2:
			return 0;
		case -1:
			if (num==5 || num==6){
				return 7;
			}
			return 0;
		case 0:
			return 10;
		case 1:
			return 6;
		case 2:
			return 11;
		case 3:
			return 6;
		case 4:
			return 7;
		case 5:
			return 3;
		case 6:
			return 2;
		}
		return 0;
	}
	
	public static int mdy(int type, int num){
		switch(type){
		case -2:
			return 0;
		case -1:
			return 0;
		case 0:
			return 5;
		case 1:
			return 3;
		case 2:
			return 7;
		case 3:
			return 4;
		case 4:
			return 4;
		case 5:
			return 10+2*num;
		case 6:
			return 4;
		}
		return 0;
	}
	
	public static int toeat(int type, int num){
		switch(type){
		case -2:
			return 100;
		case -1:
			return 100;
		case 0:
			int [] rotfischtoeat = {40,90,150,220,300,390,490,600,720,10000};
			return rotfischtoeat[num];
		case 1:
			int [] futfischtoeat = {40,90,150,220,300,390,490,600,720,10000};
			return futfischtoeat[num];
		case 2://bodysize(stage+1)
			int [] gruenfischtoeat = {766,1295,2192,3710,6277,10622,17975,30417,51472,87102};
			return gruenfischtoeat[num];
		case 3:
			int [] futterfischtoeat = {206,377,688,1256,2292,4184,7637,13941,25447,46449};
			return futterfischtoeat[num];
		case 4:
			int [] fressfischtoeat = {2826,4041,5778,8262,11815,16895,24159,34546,49400,70641};
			return fressfischtoeat[num];
		case 5:
			int [] inkytoeat = {524,874,1458,2432,4058,6768,11290,18833,31416,52406};
			return inkytoeat[num];
		case 6:
			int [] qualletoeat = {246,385,602,942,1474,2306,3608,5647,8836,13826};
			return qualletoeat[num];
		}
		return 0;
	}
	
	public static void setCollision(Fisch fish){
		switch(fish.type){
		case -2:
		case -1:
		case 0:
		case 1:
		case 2:
		case 3:
		case 5:
		case 6:
		    fish.setCollisionCircle(fish.stage, new Point(0,0), fish.height/2);
		    break;
		case 4:
			fish.setCollisionRectangle(fish.stage, new Point(0,0), fish.width, fish.height);
			break;
		}
	}
}
