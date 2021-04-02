using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
using UnityEngine;

public class LvLCreater : MonoBehaviour
{
    public Tilemap TilemapOutside;
    public Tilemap TilemapCenter;
    public Tilemap TilemapInside;
    public Tilemap Decor;
    public Tilemap Back;
    public GameObject T;
    public Tile DB;
    public Tile D0;
    public Tile D1;
    public Tile D2;
    public Tile D3;
    public Tile D4;
    public Tile D5;
    public Tile D6;
    public Tile D7;
    public Tile D8;
    public Tile D9;
    public Tile D10;
    public Tile D11;
    public Tile D12;
    public Tile D13;
    public Tile D14;
    public Tile D15;
    public Tile D16;
    public Tile D17;
    public Tile D60;
    public Tile D1A;
    public Tile D3A;
    public Tile D4A;
    public Tile D5A;
    public Tile D6A;
    public Tile D7A;
    public Tile D8A;
    public Tile D9A;
    public Tile D10A;
    public Tile D11A;
    public Tile D12A;
    public Tile D13A;
    public Tile D14A;
    public Tile D15A;
    public Tile D16A;
    public Tile D17A;
    public Tile D18A;
    public Tile D19A;
    public Tile D20A;
    public Tile D21A;
    public Tile D22A;
    public Tile D23A;
    public Tile D24A;
    public Tile D25A;
    public Tile D54;
    public Tile Lava0;
    public Tile Lava1;
    public Tile F1_1;
    public Tile F1_2;
    public Tile F1_3;
    public Tile F1_4;
    public Tile F1_5;
    public Tile F2_1;
    public Tile F2_2;
    public Tile F2_3;
    public Tile F2_4;
    public Tile F2_5;
    public Tile F3_1;
    public Tile F3_2;
    public Tile F3_3;
    public Tile F3_4;
    public Tile F3_5;
    public Tile W1_1;
    public Tile W1_2;
    public Tile W1_3;
    public Tile W2_1;
    public Tile W2_2;
    public Tile W2_3;
    public Tile W3_1;
    public Tile W3_2;
    public Tile W3_3;
    public Tile DW1_1;
    public Tile DW1_2;
    public Tile DW1_3;
    public Tile DW2_1;
    public Tile DW2_2;
    public Tile DW3_1;
    public Tile DW3_2;
    public Tile DW4_1;
    public Tile DW4_2;
    public Tile R1_1;
    public Tile R1_2;
    public Tile K1;
    public Tile K2;
    public Tile K3;
    public Tile K4;
    public int width;
    public int height;
    public List<PlanetData.LvLTile> LvL;
    public List<PlanetData.LvLTile> LvLDecor;
    public List<TileData.Tiles> tileset;
    public GameObject Player;



    
    private void Awake()
    {
        width = (int)Main_3.ActivePlanet.Scale[0] * 35;
        height = (int)Main_3.ActivePlanet.Scale[0] * 10;
        GameObject player = Instantiate(Player, new Vector3(Random.Range(0, width), height - 3, 0), Quaternion.identity);
        tileset = Main_3.ActivePlanet.TileSet;
        
    }

    void Start()
    {
        foreach(var T in tileset)
        {
            
            switch(T.Name)
            {
                case "DB":
                    {
                        DB = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D55":
                    {
                        D0 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D1":
                    {
                        D1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D2":
                    {
                        D2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D3":
                    {
                        D3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D4":
                    {
                        D4 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D5":
                    {
                        D5 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D6":
                    {
                        D6 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D7":
                    {
                        D7 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D8":
                    {
                        D8 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D9":
                    {
                        D9 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D10":
                    {
                        D10 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D11":
                    {
                        D11 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D12":
                    {
                        D12 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D13":
                    {
                        D13 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D14":
                    {
                        D14 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D15":
                    {
                        D15 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D16":
                    {
                        D16 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D17":
                    {
                        D17 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D1A":
                    {
                        D1A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                
                case "D3A":
                    {
                        D3A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D4A":
                    {
                        D4A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D5A":
                    {
                        D5A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D6A":
                    {
                        D6A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D7A":
                    {
                        D7A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D8A":
                    {
                        D8A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D9A":
                    {
                        D9A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D10A":
                    {
                        D10A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D11A":
                    {
                        D11A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D12A":
                    {
                        D12A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D13A":
                    {
                        D13A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D14A":
                    {
                        D14A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D15A":
                    {
                        D15A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D16A":
                    {
                        D16A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D17A":
                    {
                        D17A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D18A":
                    {
                        D18A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D19A":
                    {
                        D19A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D20A":
                    {
                        D20A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D21A":
                    {
                        D21A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D22A":
                    {
                        D22A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D23A":
                    {
                        D23A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D24A":
                    {
                        D24A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D25A":
                    {
                        D25A = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "D60":
                    {
                        D60 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "Lava0":
                    {
                        Lava0 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "Lava1":
                    {
                        Lava1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F1-1":
                    {
                        F1_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F1-2":
                    {
                        F1_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F1-3":
                    {
                        F1_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F1-4":
                    {
                        F1_4 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F1-5":
                    {
                        F1_5 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F2-1":
                    {
                        F2_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F2-2":
                    {
                        F2_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F2-3":
                    {
                        F2_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F2-4":
                    {
                        F2_4 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F2-5":
                    {
                        F2_5 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F3-1":
                    {
                        F3_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F3-2":
                    {
                        F3_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F3-3":
                    {
                        F3_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F3-4":
                    {
                        F3_4 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "F3-5":
                    {
                        F3_5 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W1-1":
                    {
                        W1_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W1-2":
                    {
                        W1_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W1-3":
                    {
                        W1_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W2-1":
                    {
                        W2_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W2-2":
                    {
                        W2_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W2-3":
                    {
                        W2_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W3-1":
                    {
                        W3_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W3-2":
                    {
                        W3_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "W3-3":
                    {
                        W3_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW1-1":
                    {
                        DW1_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW1-2":
                    {
                        DW1_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW1-3":
                    {
                        DW1_3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW2-1":
                    {
                        DW2_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW2-2":
                    {
                        DW2_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW3-1":
                    {
                        DW3_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW3-2":
                    {
                        DW3_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW4-1":
                    {
                        DW4_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "DW4-2":
                    {
                        DW4_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "R1-1":
                    {
                        R1_1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "R1-2":
                    {
                        R1_2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "K1":
                    {
                        K1 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "K2":
                    {
                        K2 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "K3":
                    {
                        K3 = Resources.Load<Tile>(T.tile);
                    }
                    break;
                case "K4":
                    {
                        K4 = Resources.Load<Tile>(T.tile);
                    }
                    break;

            }
        }
        StartCoroutine(LvLCreate());  
    }

    public void WriteFile()
    {
        FileStream fs = new FileStream(Application.persistentDataPath + "/LvLTest.txt", FileMode.Create); //Создание файлового потока

        StreamWriter w = new StreamWriter(fs);
        string S = "";
        for (int i = 0; i < LvL.Count; i++)
        {
            switch(LvL[i].type)
            {
                case 0:
                    {
                        S += "O";
                    }
                    break;
                case 1:
                    {
                        S += "(";
                    }
                    break;
                case 2:
                    {
                        S += "+";
                    }
                    break;
                case 3:
                    {
                        S += ")";
                    }
                    break;
                case 4:
                    {
                        S += "}";
                    }
                    break;
                case 5:
                    {
                        S += "]";
                    }
                    break;
                case 6:
                    {
                        S += "_";
                    }
                    break;
                case 7:
                    {
                        S += "[";
                    }
                    break;
                case 8:
                    {
                        S += "{";
                    }
                    break;
                case 9:
                    {
                        S += "<";
                    }
                    break;
                case 10:
                    {
                        S += "-";
                    }
                    break;
                case 11:
                    {
                        S += ">";
                    }
                    break;
                case 12:
                    {
                        S += "'";
                    }
                    break;
                case 13:
                    {
                        S += "'";
                    }
                    break;
                case 55:
                    {
                        S += "H";
                    }
                    break;
            }
            
            
            if (S.Length >= width)
            {
                
                w.WriteLine(S);
                S = "";
            }
        }

        w.Close();

        fs.Close();
    }

    public IEnumerator LvLCreate()
    {
        LvL = Main_3.ActivePlanet.LvL;
        
        Tile InsideTile = null;
        Tile CenterTile = null;
        Tile BackTile = null;
        Tile OutsideTile = null;

        WriteFile();
        yield return new WaitForEndOfFrame();

        for (int i = 0; LvL.Count > i; i++)
        {

            switch (LvL[i].type)
            {
                case 0:
                    {
                        InsideTile = null;
                        BackTile = null;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 1:
                    {
                        InsideTile = D1;
                        BackTile = D1;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 2:
                    {
                        InsideTile = D2;
                        BackTile = D2;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 3:
                    {
                        InsideTile = D3;
                        BackTile = D3;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 4:
                    {
                        InsideTile = D4;
                        BackTile = D4;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 5:
                    {
                        InsideTile = D5;
                        BackTile = D5;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 6:
                    {
                        InsideTile = D6;
                        BackTile = D6;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 7:
                    {
                        InsideTile = D7;
                        BackTile = D7;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 8:
                    {
                        InsideTile = D8;
                        BackTile = D8;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 9:
                    {
                        InsideTile = D9;
                        BackTile = D9;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 10:
                    {
                        InsideTile = D10;
                        BackTile = D10;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 11:
                    {
                        InsideTile = D11;
                        BackTile = D11;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 12:
                    {
                        InsideTile = D12;
                        BackTile = D12;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 13:
                    {
                        InsideTile = D13;
                        BackTile = D13;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 14:
                    {
                        InsideTile = D14;
                        BackTile = D14;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 15:
                    {
                        InsideTile = D15;
                        BackTile = D15;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 16:
                    {
                        InsideTile = D16;
                        BackTile = D16;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 17:
                    {
                        InsideTile = D17;
                        BackTile = D17;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 55:
                    {
                        InsideTile = null;
                        BackTile = D0;
                        OutsideTile = null;
                        CenterTile = D0;
                    }
                    break;
                case -1:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D1A;
                        CenterTile = null;
                    }
                    break;
                case -3:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D3A;
                        CenterTile = null;
                    }
                    break;
                case -4:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D4A;
                        CenterTile = null;
                    }
                    break;
                case -5:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D5A;
                        CenterTile = null;
                    }
                    break;
                case -6:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D6A;
                        CenterTile = null;
                    }
                    break;
                case -7:
                    {
                        InsideTile = D7A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -8:
                    {
                        InsideTile = D8A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -9:
                    {
                        InsideTile = D9A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -10:
                    {
                        InsideTile = D10A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -11:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D11A;
                        CenterTile = null;
                    }
                    break;
                case -12:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D12A;
                        CenterTile = null;
                    }
                    break;
                case -13:
                    {
                        InsideTile = D13A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -14:
                    {
                        InsideTile = D14A;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case -15:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D15A;
                        CenterTile = null;
                    }
                    break;
                case -16:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D16A;
                        CenterTile = null;
                    }
                    break;
                case -17:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D17A;
                        CenterTile = null;
                    }
                    break;
                case -18:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D18A;
                        CenterTile = null;
                    }
                    break;
                case -19:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D19A;
                        CenterTile = null;
                    }
                    break;
                case -20:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D20A;
                        CenterTile = null;
                    }
                    break;
                case -21:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D21A;
                        CenterTile = null;
                    }
                    break;
                case -22:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D22A;
                        CenterTile = null;
                    }
                    break;
                case -23:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D23A;
                        CenterTile = null;
                    }
                    break;
                case -24:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D24A;
                        CenterTile = null;
                    }
                    break;
                case -25:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = D25A;
                        CenterTile = null;
                    }
                    break;
                case 60:
                    {
                        InsideTile = null;
                        BackTile = D60;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                case 99:
                    {
                        InsideTile = null;
                        BackTile = Lava0;
                        OutsideTile = Lava0;
                        CenterTile = null;
                    }
                    break;
                case 98:
                    {
                        InsideTile = Lava1;
                        BackTile = Lava1;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
                
                default:
                    {
                        InsideTile = null;
                        BackTile = null;
                        OutsideTile = null;
                        CenterTile = null;
                    }
                    break;
            }




            TilemapInside.SetTile(LvL[i].pos, InsideTile);
            TilemapCenter.SetTile(LvL[i].pos, CenterTile);
            Back.SetTile(LvL[i].pos, BackTile);
            TilemapOutside.SetTile(LvL[i].pos, OutsideTile);


            /*string S = LvL[i].type.ToString();
            if (S.Contains("-") || LvL[i].type == 60)
            {
                Back.SetTile(LvL[i].pos, D60);
            }
            else if(LvL[i].type == 0)
            {
                
            }
            else if (!S.Contains("-"))
            {
                Back.SetTile(LvL[i].pos, DB);
            }
            else if (LvL[i].type == 99)
            {
                tilemap.SetTile(LvL[i].pos, Lava);
            }*/

        }

        StartCoroutine(LvLDecorCreater());

        yield return new WaitForEndOfFrame();
        ShadowCaster2DGenerator.GenerateShadowCasters();
    }

    public IEnumerator LvLDecorCreater()
    {
        yield return new WaitForEndOfFrame();

        LvLDecor = Main_3.ActivePlanet.LvLDecor;
        Tile InsideTile = null;

        for (int i = 0; LvLDecor.Count > i; i++)
        {
            switch (LvLDecor[i].type)
            {
                case 100:
                    {
                        InsideTile = F1_1;
                    }
                    break;
                case 101:
                    {
                        InsideTile = F1_2;
                    }
                    break;
                case 102:
                    {
                        InsideTile = F1_3;
                    }
                    break;
                case 103:
                    {
                        InsideTile = F1_4;
                    }
                    break;
                case 104:
                    {
                        InsideTile = F1_5;
                    }
                    break;
                case 105:
                    {
                        InsideTile = F2_1;
                    }
                    break;
                case 106:
                    {
                        InsideTile = F2_2;
                    }
                    break;
                case 107:
                    {
                        InsideTile = F2_3;
                    }
                    break;
                case 108:
                    {
                        InsideTile = F2_4;
                    }
                    break;
                case 109:
                    {
                        InsideTile = F2_5;
                    }
                    break;
                case 110:
                    {
                        InsideTile = F3_1;
                    }
                    break;
                case 111:
                    {
                        InsideTile = F3_2;
                    }
                    break;
                case 112:
                    {
                        InsideTile = F3_3;
                    }
                    break;
                case 113:
                    {
                        InsideTile = F3_4;
                    }
                    break;
                case 114:
                    {
                        InsideTile = F3_5;
                    }
                    break;
                case 115:
                    {
                        InsideTile = W1_1;
                    }
                    break;
                case 116:
                    {
                        InsideTile = W1_2;
                    }
                    break;
                case 117:
                    {
                        InsideTile = W1_3;
                    }
                    break;
                case 118:
                    {
                        InsideTile = W2_1;
                    }
                    break;
                case 119:
                    {
                        InsideTile = W2_2;
                    }
                    break;
                case 120:
                    {
                        InsideTile = W2_3;
                    }
                    break;
                case 121:
                    {
                        InsideTile = W3_1;
                    }
                    break;
                case 122:
                    {
                        InsideTile = W3_2;
                    }
                    break;
                case 123:
                    {
                        InsideTile = W3_3;
                    }
                    break;
                case 124:
                    {
                        InsideTile = DW1_1;
                    }
                    break;
                case 125:
                    {
                        InsideTile = DW1_2;
                    }
                    break;
                case 126:
                    {
                        InsideTile = DW1_3;
                    }
                    break;
                case 127:
                    {
                        InsideTile = DW2_1;
                    }
                    break;
                case 128:
                    {
                        InsideTile = DW2_2;
                    }
                    break;
                case 129:
                    {
                        InsideTile = DW3_1;
                    }
                    break;
                case 130:
                    {
                        InsideTile = DW3_2;
                    }
                    break;
                case 131:
                    {
                        InsideTile = DW4_1;
                    }
                    break;
                case 132:
                    {
                        InsideTile = DW4_2;
                    }
                    break;
                case 133:
                    {
                        InsideTile = R1_1;
                    }
                    break;
                case 134:
                    {
                        InsideTile = R1_2;
                    }
                    break;
                case 135:
                    {
                        InsideTile = K1;
                    }
                    break;
                case 136:
                    {
                        InsideTile = K2;
                    }
                    break;
                case 137:
                    {
                        InsideTile = K3;
                    }
                    break;
                case 138:
                    {
                        InsideTile = K4;
                    }
                    break;
                case 999:
                    {
                        InsideTile = null;
                    }
                    break;
                default:
                    {
                        InsideTile = null;
                    }
                    break;
            }

            Decor.SetTile(LvLDecor[i].pos, InsideTile);
        }
    }
    
    void Update()
    {
        
    }

    

    
}
