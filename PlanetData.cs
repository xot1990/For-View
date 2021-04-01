using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class PlanetData 
{
    [System.Serializable]
    public class Planet
    {
        public int Id { get; set; }

        public string SName;

        public string LendType;

        public List<TileData.Tiles> TileSet;

        public string Name
        {
            get
            {
                string vs = "";
                string First = ""; 
                string Second = "";

                if (SName != null)
                {
                    vs = SName;
                }
                else
                {
                    if (_Name == null)
                    {
                        if (Id >= 0 && Id <= 4)
                        {
                            if (Scalefactor >= 20 && Scalefactor <= 23)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor >= 24 && Scalefactor <= 27)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor >= 28)
                            {
                                First = "Big";
                            }
                            LendType = "Gas Giant";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(90, 99);
                            Second = "Gas Giant";
                        }

                        else if (Id >= 5 && Id <= 8)
                        {

                            if (Scalefactor >= 5 && Scalefactor <= 6)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor >= 7 && Scalefactor <= 8)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor >= 9)
                            {
                                First = "Big";
                            }
                            LendType = "Sandy Desert";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Sandy Desert";
                        }

                        else if (Id >= 9 && Id <= 12)
                        {

                            if (Scalefactor >= 5 && Scalefactor <= 6)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor >= 7 && Scalefactor <= 8)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor >= 9)
                            {
                                First = "Big";
                            }
                            LendType = "Ice Desert";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Ice Desert";
                        }

                        else if (Id >= 13 && Id <= 15)
                        {

                            if (Scalefactor >= 5 && Scalefactor <= 6)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor >= 7 && Scalefactor <= 8)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor >= 9)
                            {
                                First = "Big";
                            }
                            LendType = "Rock Planet";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Rock Planet";
                        }

                        else if (Id >= 16 && Id <= 18)
                        {

                            if (Scalefactor == 8)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor == 9)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor == 10)
                            {
                                First = "Big";
                            }
                            LendType = "Forest World";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Forest World";
                        }

                        else if (Id >= 19 && Id <= 21)
                        {

                            if (Scalefactor == 10)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor == 11)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor == 12)
                            {
                                First = "Big";
                            }
                            LendType = "Ocean World";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Ocean World";
                        }

                        else if (Id >= 22 && Id <= 25)
                        {
                            if (Scalefactor == 10)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor == 11)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor == 12)
                            {
                                First = "Big";
                            }
                            LendType = "Lava World";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 5);
                            Second = "Lava World";
                        }

                        else if (Id == 29)
                        {

                            if (Scalefactor == 8)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor == 9)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor == 10)
                            {
                                First = "Big";
                            }
                            LendType = "Riven World";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Riven World";
                        }

                        else if (Id >= 26 && Id <= 28)
                        {
                            if (Scalefactor >= 7 && Scalefactor <= 9)
                            {
                                First = "Small";
                            }
                            else if (Scalefactor >= 10 && Scalefactor <= 11)
                            {
                                First = "Medium";
                            }
                            else if (Scalefactor == 12)
                            {
                                First = "Big";
                            }
                            LendType = "Dangerous World";
                            TileSet = TileData.TileMaps.PlanetTypes.Find(X => X.Name == LendType).tiles;
                            Sponginess = Random.Range(0, 1);
                            Second = "Dangerous World";
                        }

                        vs = First + " " + Second + " " + NumberOrbit;
                        _Name = vs;
                    }
                    else
                    {
                        vs = _Name;
                    }
                }

                
                return vs;
            }
            
        }

        private string _Name;

        public float Angle;

        public int NumberOrbit;

        public int Scalefactor
        {
            get
            {
                return _ScaleFactor;
            }
            set
            {
                int a = 0;

                if (Id >= 0 && Id <= 4)
                {
                    a = Mathf.Clamp(value, 20, 30);
                   
                }

                else if (Id >= 5 && Id <= 8)
                {
                    a = Mathf.Clamp(value, 5, 10);
                    
                }

                else if (Id >= 9 && Id <= 12)
                {
                    a = Mathf.Clamp(value, 5, 10);
                    
                }

                else if (Id >= 13 && Id <= 15)
                {
                    a = Mathf.Clamp(value, 5, 10);
                }

                else if (Id >= 16 && Id <= 18)
                {
                    a = Mathf.Clamp(value, 8, 10);
                }

                else if (Id >= 19 && Id <= 21)
                {
                    a = Mathf.Clamp(value, 10, 12);
                }

                else if (Id >= 22 && Id <= 25)
                {
                    a = Mathf.Clamp(value, 10, 12);
                }

                else if (Id == 29)
                {
                    a = Mathf.Clamp(value, 8, 10);
                }

                else if (Id >= 26 && Id <= 28)
                {
                    a = Mathf.Clamp(value, 7, 12);
                }

                _ScaleFactor = a;
            }
        }

        private int _ScaleFactor;

        public List<float> Scale
        {
            get
            {
                List<float> vs = new List<float>();

                if (Id >= 0 &&  Id <= 4)
                {
                    int a = Mathf.Clamp(Scalefactor,20,30);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if(Id >= 5 && Id <= 8)
                {
                    int a = Mathf.Clamp(Scalefactor, 5, 10);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 9 && Id <= 12)
                {
                    int a = Mathf.Clamp(Scalefactor, 5, 10);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 13 && Id <= 15)
                {
                    int a = Mathf.Clamp(Scalefactor, 5, 10);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 16 && Id <= 18)
                {
                    int a = Mathf.Clamp(Scalefactor, 8, 10);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 19 && Id <= 21)
                {
                    int a = Mathf.Clamp(Scalefactor, 10, 12);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 22 && Id <= 25)
                {
                    int a = Mathf.Clamp(Scalefactor, 10, 12);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id == 29)
                {
                    int a = Mathf.Clamp(Scalefactor, 8, 10);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                else if (Id >= 26 && Id <= 28)
                {
                    int a = Mathf.Clamp(Scalefactor, 7, 12);
                    vs.Add(a);
                    vs.Add(a);
                    vs.Add(a);
                }

                return vs;
            }         
        }

        public float orbit
        {
            get
            {
                return _orbit;
            }
            set
            {
                float A = 0;
                if (NumberOrbit == 0) A = Mathf.Clamp(value, 120, 260);
                if (NumberOrbit == 1) A = Mathf.Clamp(value, 300, 400);
                if (NumberOrbit == 2) A = Mathf.Clamp(value, 440, 540);
                if (NumberOrbit == 3) A = Mathf.Clamp(value, 580, 620);
                if (NumberOrbit == 4) A = Mathf.Clamp(value, 660, 700);
                if (NumberOrbit == 5) A = Mathf.Clamp(value, 740, 760);
                
                _orbit = A;
            }
        }

        private float _orbit;

        public string Link
        {
            get
            {
                string vs = "";

                if (Id >= 0 && Id <= 4)
                {
                    vs = "Sprites/Planets/G";
                }

                else if (Id >= 5 && Id <= 8)
                {
                    vs = "Sprites/Planets/P";
                }

                else if (Id >= 9 && Id <= 12)
                {
                    vs = "Sprites/Planets/S";
                }

                else if (Id >= 13 && Id <= 15)
                {
                    vs = "Sprites/Planets/K";
                }

                else if (Id >= 16 && Id <= 18)
                {
                    vs = "Sprites/Planets/Les";
                }

                else if (Id >= 19 && Id <= 21)
                {
                    vs = "Sprites/Planets/V";
                }

                else if (Id >= 22 && Id <= 25)
                {
                    vs = "Sprites/Planets/L";
                }

                else if (Id == 29)
                {
                    vs = "Sprites/Planets/R";
                }

                else if (Id >= 26 && Id <= 28)
                {
                    vs = "Sprites/Planets/T";
                }

                return vs;
            }
        }

        public List<float> Pos;

        public bool CanPlaseStation;

        public float Sponginess;

        public float Mountainousness = 50;

        public int StationId;

        public List<LvLTile> LvL
        {
            get
            {
                List<LvLTile> lvl = new List<LvLTile>();
                if (_LvL == null)
                {
                    int width = (int)Scale[0] * 35;
                    int height = (int)Scale[0] * 10;

                    switch (LendType)
                    {
                        case "Forest World":
                            {
                                lvl = ForestLvLCreater(width, height);
                            }
                            break;
                        case "Ice Desert":
                            {
                                lvl = FrostLvLCreater(width, height,Sponginess,Mountainousness);
                            }
                            break;
                    }
                    
                    _LvL = lvl;
                }
                else lvl = _LvL;

                return lvl;
            }
        }

        private List<LvLTile> _LvL;

        public List<LvLTile> LvLDecor
        {
            get
            {
                List<LvLTile> lvl = new List<LvLTile>();
                if (_LvLDecor == null)
                {
                    int width = (int)Scale[0] * 35;
                    int height = (int)Scale[0] * 10;

                    switch (LendType)
                    {
                        case "Forest World":
                            {
                                lvl = DecorLvLCreater(width, height, LvL);
                            }
                            break;
                        case "Ice Desert":
                            {
                                lvl = DecorLvLCreater(width, height, LvL);
                            }
                            break;
                    }

                    _LvLDecor = lvl;
                }
                else lvl = _LvLDecor;

                return lvl;
            }
        }

        private List<LvLTile> _LvLDecor;
    }

    public class LvLTile
    {
        public int type;
        public Vector3Int pos;
        public bool S = false;
        public float HP
        {
            get
            {
                float hp = 0;
                
                if (_HP == 0)
                {
                    switch(type)
                    {
                        case 1:
                            {
                                hp = 5;
                            }
                            break;
                        case 2:
                            {
                                hp = 5;
                            }
                            break;
                        case 3:
                            {
                                hp = 5;
                            }
                            break;
                        case 4:
                            {
                                hp = 5;
                            }
                            break;
                        case 5:
                            {
                                hp = 5;
                            }
                            break;
                        case 6:
                            {
                                hp = 5;
                            }
                            break;
                        case 7:
                            {
                                hp = 5;
                            }
                            break;
                        case 8:
                            {
                                hp = 5;
                            }
                            break;
                        case 9:
                            {
                                hp = 5;
                            }
                            break;
                        case 10:
                            {
                                hp = 5;
                            }
                            break;
                        case 11:
                            {
                                hp = 5;
                            }
                            break;
                        case 12:
                            {
                                hp = 5;
                            }
                            break;
                        case 13:
                            {
                                hp = 5;
                            }
                            break;
                        case 14:
                            {
                                hp = 2;
                            }
                            break;
                        case 15:
                            {
                                hp = 2;
                            }
                            break;
                        case 55:
                            {
                                hp = 2;
                            }
                            break;
                        default:
                            {
                                hp = -1;
                            }
                            break;
                    }

                    _HP = hp;
                }
                else
                {
                    hp = _HP;
                }

                return hp;
            }
        }
        private float _HP;
    }

    public static List<LvLTile> ForestLvLCreater(int width, int height)
    {
        List<LvLTile> num = new List<LvLTile>();

        List<int> num1 = new List<int> { 0, 7, 9 };
        List<int> num2 = new List<int> { 8, 1 };
        List<int> num3 = new List<int> { 6, 5 };
        List<int> num4 = new List<int> { 10, 11 };
        List<int> num5 = new List<int> { 10, 14, 11 };
        List<int> num6 = new List<int> { 55, 4, 15 };
        List<int> num7 = new List<int> { 2, 14 };
        List<int> num8 = new List<int> { 55, 15 };

        for (int i = 0; height > i; i++)
        {
            for (int j = 0; width > j; j++)
            {
                if (i == 1)
                {
                    if (j == 0)
                    {
                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                    }
                    else
                    {
                        switch (num[j - 1].type)
                        {
                            case 0:
                                {
                                    num.Add(new LvLTile { type = num1[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 5:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 6:
                                {
                                    num.Add(new LvLTile { type = num3[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 7:
                                {
                                    num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 9:
                                {
                                    num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 10:
                                {
                                    num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 11:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            default:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;

                        }
                    }
                }
                else if (i == 0)
                {
                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                }
                else if (j == 0 && i != 0)
                {
                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                }
                else if (j < width - 2)
                {
                    if (i > 0 && i <= height - 10)
                    {
                        switch (num[j + width * i - 1].type)
                        {
                            case 0:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 5:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = num1[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 11:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = num1[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 9:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 1:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 5:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 11:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 0:
                                                                    {
                                                                        if (j < width - 2) num.Add(new LvLTile { type = num1[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 9:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = num2[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0), S = true });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = num2[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0), S = true });
                                            }
                                            break;
                                        case 11:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 10:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 12:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 2:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 3:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 1:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 13:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 14:
                                            {
                                                num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;

                                    }
                                }
                                break;
                            case 1:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 3:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 4:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 5:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 55:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });

                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });

                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 6:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 8:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 1:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 11:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 0:
                                                                    {
                                                                        num.Add(new LvLTile { type = num3[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                            }

                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 7:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 8:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 1:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 11:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 0:
                                                                    {
                                                                        num.Add(new LvLTile { type = num3[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                            }

                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 8:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 9:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 10:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;

                                    }
                                }
                                break;
                            case 11:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 12:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = num7[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = num7[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 13, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 13, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;

                                    }
                                }
                                break;
                            case 13:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;

                                    }
                                }
                                break;
                            case 14:
                                {

                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 15:
                                {

                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            default:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                        }
                    }
                    else if (i > 0 && i == height - 9)
                    {
                        switch (num[j + (i - 1) * width].type)
                        {
                            case 0:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 1:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 2:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 3:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 4:
                                {
                                    num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 5:
                                {
                                    num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 55:
                                {
                                    num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 6:
                                {
                                    num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 7:
                                {
                                    num.Add(new LvLTile { type = 1, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 8:
                                {
                                    num.Add(new LvLTile { type = 1, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 9:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 10:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 11:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 12:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 13:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 14:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                            case 15:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });

                                }
                                break;
                        }

                    }
                    else if (i > 0 && i > height - 9)
                    {
                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                    }

                }
                else if (j >= width - 2)
                {
                    switch (num[j + width * i - 1].type)
                    {
                        case 0:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 1:
                            {
                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 2:
                            {
                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 3:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 4:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 5:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 55:
                            {
                                num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 6:
                            {
                                num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 7:
                            {
                                num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 8:
                            {
                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 9:
                            {
                                num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 10:
                            {
                                num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        case 11:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;
                        default:
                            {
                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                            }
                            break;

                    }

                }
             
            }
        }

        return num;
    }

    public static List<LvLTile> FrostLvLCreater(int width, int height, float Sponginess, float Mountainousness)
    {
        List<LvLTile> num = new List<LvLTile>();

        List<int> num1 = new List<int> { 0, 7, 9 };
        List<int> num2 = new List<int> { 8, 1 };
        List<int> num3 = new List<int> { 6, 5 };
        List<int> num4 = new List<int> { 10, 11 };
        List<int> num5 = new List<int> { 10, 14, 11 };
        List<int> num6 = new List<int> { 55, 4, 15 };
        List<int> num7 = new List<int> { 2, 14 };
        List<int> num8 = new List<int> { 55, 15 };
        List<int> num9 = new List<int> { 4, 17,15 };
        List<int> num10 = new List<int> { 0, 7 };

        List<int> numA = new List<int> { 55, -18};
        List<int> numB = new List<int> { -3, 55 };
        List<int> numD = new List<int> { -1, 55 };
        List<int> numC = new List<int> { -5, -6 };
        List<int> numI = new List<int> { 60, -4 };
        List<int> numF = new List<int> { -21, -4 };
        List<int> numG = new List<int> { -22, -23 };
        List<int> numJ = new List<int> { -19, -8 };

        int caveleght = 0;
        //int moutansheight = 0;
        int mountanswidth = 0;

        for (int i = 0; height > i; i++)
        {
            for (int j = 0; width > j; j++)
            {
                if (i == 4)
                {
                    if (j == 0)
                    {
                        num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                    }
                    else
                    {
                        if (j < width - 1)
                        {
                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                        }
                        else
                        {
                            num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                        }
                    
                    }
                }
                else if (i == 3)
                {
                    num.Add(new LvLTile { type = 98, pos = new Vector3Int(j, i, 0) });
                }
                else if (i < 3)
                {
                    num.Add(new LvLTile { type = 99, pos = new Vector3Int(j, i, 0) });
                }
                else if (i > 4 && i < 30)
                {                    
                    if (j == 0)
                    {
                        num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j >= width - 1)
                    {
                        num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j > 0 && j < width - 1)
                    {
                        if (j > 5 && j < width - 10)
                        {                            
                            switch (num[j + width * i - 1].type)
                            {
                                case 60:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case -20:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 60:
                                                {
                                                    switch(num[j + (i - 1) * width + 1].type)
                                                    {
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = numF[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = numI[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case 60:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -21:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width + 1].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case -19:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -18:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -1:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -3:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 55:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -5:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -21:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -22:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -23:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case 55:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 55:
                                                {
                                                    float A = Random.Range(0, 500);
                                                    if (A > Sponginess)
                                                    {
                                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                    }
                                                    else
                                                    {
                                                        num.Add(new LvLTile { type = -18, pos = new Vector3Int(j, i, 0) });
                                                    }
                                                    
                                                }
                                                break;
                                            case 6:
                                                {
                                                    float A = Random.Range(0, 500);
                                                    if (A > Sponginess)
                                                    {
                                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                    }
                                                    else
                                                    {
                                                        num.Add(new LvLTile { type = -18, pos = new Vector3Int(j, i, 0) });
                                                    }
                                                }
                                                break;
                                            case -6:
                                                {
                                                    switch(num[j + (i - 1) * width +2].type)
                                                    {
                                                        case 60:
                                                            {
                                                                num.Add(new LvLTile { type = numB[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -21:
                                                            {
                                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);

                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case -3:
                                                {
                                                    switch (num[j + (i - 1) * width + 2].type)
                                                    {
                                                        case 60:
                                                            {
                                                                num.Add(new LvLTile { type = numB[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -21:
                                                            {
                                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case 60:
                                                {
                                                    switch(num[j + (i - 1) * width + 1].type)
                                                        {
                                                        case 60:
                                                            {
                                                                switch (num[j + (i - 1) * width + 2].type)
                                                                {
                                                                    case 60:
                                                                        {
                                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                                        }
                                                                        break;
                                                                    case -4:
                                                                        {
                                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                                        }
                                                                        break;
                                                                    case -21:
                                                                        {
                                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                                        }
                                                                        break;
                                                                    case -1:
                                                                        {
                                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                                        }
                                                                        break;
                                                                    default:
                                                                        {
                                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                                        }
                                                                        break;
                                                                }
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -21:
                                                            {
                                                                num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case -20:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -19:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -18:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -1:
                                                {
                                                    num.Add(new LvLTile { type = numD[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -5:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num ="+ num[j + (i - 1) * width].type);
                                                }
                                                break;
                                        }

                                    }
                                    break;
                                case -1:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -3:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -4:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -5:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case -3:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 60:
                                                {
                                                    switch (num[j + (i - 1) * width + 1].type)
                                                    {
                                                        case 60:
                                                            {
                                                                num.Add(new LvLTile { type = numC[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -21:
                                                            {
                                                                num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case 55:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -1:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -5:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -6:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case 6:
                                    {
                                        num.Add(new LvLTile { type = numA[Random.Range(0, 26)], pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -18:
                                    {
                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -20:
                                    {
                                        if (caveleght < 9)
                                        {
                                            switch(num[j + (i - 1) * width].type)
                                            {
                                                case 60:
                                                    {
                                                        num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                                        caveleght++;
                                                        float A = Random.Range(0, 10);
                                                        if (caveleght > A) caveleght = 10;
                                                    }
                                                    break;
                                                case 55:
                                                    {
                                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                        caveleght++;
                                                        float A = Random.Range(0, 10);
                                                        if (caveleght > A) caveleght = 10;
                                                    }
                                                    break;
                                                case 6:
                                                    {
                                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                        caveleght++;
                                                        float A = Random.Range(0, 10);
                                                        if (caveleght > A) caveleght = 10;
                                                    }
                                                    break;
                                                case -5:
                                                    {
                                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                        caveleght++;
                                                        float A = Random.Range(0, 10);
                                                        if (caveleght > A) caveleght = 10;
                                                    }
                                                    break;
                                                case -6:
                                                    {
                                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                        caveleght++;
                                                        float A = Random.Range(0, 10);
                                                        if (caveleght > A) caveleght = 10;
                                                    }
                                                    break;
                                                case -3:
                                                    {
                                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -4:
                                                    {
                                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -1:
                                                    {
                                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -18:
                                                    {
                                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -20:
                                                    {
                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -22:
                                                    {
                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -21:
                                                    {
                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                case -23:
                                                    {
                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        caveleght = 0;
                                                    }
                                                    break;
                                                default:
                                                    {
                                                        Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width].type);
                                                    }
                                                    break;
                                            }
                                            
                                        }
                                        else
                                        {
                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                            caveleght = 0;
                                        }                                       
                                        
                                    }
                                    break;
                                case -19:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = numC[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 55:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -3:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -5:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -6:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -1:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 6:
                                                {
                                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -20:
                                                {
                                                    num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -18:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);

                                                }
                                                break;
                                        }
                                        
                                    }
                                    break;
                                case -21:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -22:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = numG[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -23:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                default:
                                    {
                                        Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + width * i - 1].type);

                                    }
                                    break;
                            }
                        }

                        else if (j <= 5)
                        {
                            switch (num[j + width * i - 1].type)
                            {
                                case 8:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case 55:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                            }
                        }
                        else if (j >= width - 10 && j < width - 1)
                        {
                            switch (num[j + width * i - 1].type)
                            {
                                case -20:
                                    {
                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case 55:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case 60:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case -20:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 60:
                                                {
                                                    switch (num[j + (i - 1) * width + 1].type)
                                                    {
                                                        case -1:
                                                            {
                                                                num.Add(new LvLTile { type = -4, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case -4:
                                                            {
                                                                num.Add(new LvLTile { type = numI[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        case 60:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width + 1].type);
                                                            }
                                                            break;
                                                    }

                                                }
                                                break;
                                            case -19:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -18:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -1:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case -3:
                                                {
                                                    num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            case 55:
                                                {
                                                    num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -3:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -19:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -18:
                                    {
                                        num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -1:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case 6:
                                    {
                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -5:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -6:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -4:
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                case -21:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -22:
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = numG[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                            default:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                }
                                                break;
                                        }
                                    }
                                    break;
                                case -23:
                                    {
                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                    }
                                    break;
                                default:
                                    {
                                        Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + width * i - 1].type);
                                    }
                                    break;
                            }
                        }
                    }
                    
                }
                else if (i == 30)
                {
                    if (j == 0)
                    {
                        num.Add(new LvLTile { type = 1, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j >= width - 1)
                    {
                        num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j > 0 && j < width - 1)
                    {
                        int B = Random.Range(0, 30);
                        switch (num[j + width * i - 1].type)
                        {
                            case 2:
                                {
                                    float A = Random.Range(0, 500);
                                    if (A > Mountainousness)
                                    {
                                        num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                    }
                                    else
                                    {
                                        mountanswidth = B;
                                        num.Add(new LvLTile { type = 14, pos = new Vector3Int(j, i, 0) });
                                    }
                                }
                                break;
                            case 1:
                                {
                                    num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 14:
                                {
                                    num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 15:
                                {
                                    num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 55:
                                {
                                    if (mountanswidth > 0)
                                    {
                                        num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                        mountanswidth--;
                                    }
                                    else
                                    {
                                        num.Add(new LvLTile { type = 15, pos = new Vector3Int(j, i, 0) });
                                    }
                                    
                                }
                                break;
                            default:
                                {
                                    Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + width * i - 1].type);
                                }
                                break;
                        }
                    }
                }
                
                else if (i > 30 && i < height - 5)
                {
                    if (j == 0)
                    {
                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j >= width - 1)
                    {
                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                    }
                    else if (j > 0 && j < width - 1)
                    {
                        switch (num[j + width * i - 1].type)
                        {
                            case 0:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                int k = 0;
                                                bool done = false;
                                                while(k < 2)
                                                {
                                                    if (num[j + (i - 1) * width + k].type != 0)
                                                    {
                                                        switch(num[j + (i - 1) * width + k].type)
                                                        {
                                                            case 1:
                                                                {
                                                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                    done = true;
                                                                }
                                                                break;
                                                            case 8:
                                                                {
                                                                    num.Add(new LvLTile { type = num10[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                    done = true;
                                                                }
                                                                break;
                                                        } 
                                                        break;
                                                    }
                                                    k++;
                                                }
                                                
                                                if (done)
                                                {
                                                    break;
                                                }
                                                else
                                                {
                                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                }

                                                        
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = num2[Random.Range(0,2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 1:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 2:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 3:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 12:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 11:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 10:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 9:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = num2[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 14:
                                            {
                                                num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -9:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 60:
                                            {
                                                switch (num[j + (i - 2) * width].type)
                                                {
                                                    case -9:
                                                        {
                                                            num.Add(new LvLTile { type = -13, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                                        }
                                                        break;
                                                }
                                                
                                            }
                                            break;
                                        case -13:
                                            {
                                                num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -16:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 1:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 2:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                switch (num[j + (i - 1) * width +1].type)
                                                {
                                                    case 4:
                                                        {
                                                            num.Add(new LvLTile { type = num7[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -3:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 55:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 15:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 17:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -18:
                                                        {
                                                            num.Add(new LvLTile { type = -9, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -5:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -6:
                                                        {
                                                            num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width+1].type);
                                                        }
                                                        break;
                                                }
                                                        
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 17:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -18:
                                            {
                                                num.Add(new LvLTile { type = -9, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -3:
                                            {
                                                num.Add(new LvLTile { type = -9, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 60:
                                            {
                                                switch (num[j + (i - 2) * width].type)
                                                {
                                                    case -8:
                                                        {
                                                            num.Add(new LvLTile { type = -17, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -10:
                                                        {
                                                            num.Add(new LvLTile { type = -17, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -25:
                                                        {
                                                            num.Add(new LvLTile { type = -16, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 60:
                                                        {
                                                            num.Add(new LvLTile { type = -16, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = -16, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 2) * width].type);
                                                        }
                                                        break;
                                                }
                                                        
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 12:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                    
                                }
                                break;
                            case 8:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 2:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 10:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 1:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }

                                }
                                break;
                            case 14:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 15:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 13, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 13, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                    
                                }
                                break;
                            case 16:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }                                    
                                }
                                break;
                            case 17:
                                {
                                    num.Add(new LvLTile { type = num3[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 4:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 7:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 0:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 1:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                        Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 16, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 17:
                                            {
                                                num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 6:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 0:
                                                                    {
                                                                        num.Add(new LvLTile { type = num3[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 8:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 1:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 7:
                                                                    {
                                                                        num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 9:
                                                                    {
                                                                        num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                                        Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 16, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 16, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 5:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 3:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 9:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 14, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }

                                }
                                break;
                            case 10:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 0:
                                                                    {
                                                                        switch (num[j + (i - 1) * width + 3].type)
                                                                        {
                                                                            case 0:
                                                                                {
                                                                                    num.Add(new LvLTile { type = num4[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                                }
                                                                                break;
                                                                            default:
                                                                                {
                                                                                    num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                                                }
                                                                                break;
                                                                        }                                                                        
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                            }                                                            
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 10, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 8:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 7:
                                            {
                                                num.Add(new LvLTile { type = 12, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -13:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                    
                                }
                                break;
                            case 11:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 13:
                                {
                                    num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case 55:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = num9[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                switch (num[j + (i - 1) * width +1].type)
                                                {
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 55:
                                                        {
                                                            int S = 0;
                                                            int T = 0;
                                                            while (S < 10)
                                                            {
                                                                if (num[j + (i - 1) * width + S].type == 55)
                                                                {
                                                                    T++;
                                                                }
                                                                S++;
                                                            }

                                                            if (T >= 9)
                                                            {
                                                                num.Add(new LvLTile { type = numA[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                            }
                                                            else
                                                            {
                                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                            }
                                                        }
                                                        break;
                                                    case 4:
                                                        {
                                                            num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 3:
                                                        {
                                                            num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 15:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 17:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -18:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -3:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -5:
                                                        {
                                                            num.Add(new LvLTile { type = -18, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -6:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width+1].type);
                                                        }
                                                        break;

                                                }
                                            }
                                            break;
                                        case 0:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = 6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 8:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 1:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 7:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 9:
                                                        {
                                                            num.Add(new LvLTile { type = 5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }
                                            }
                                            break;
                                        case 2:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 1:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 14:
                                            {
                                                num.Add(new LvLTile { type = 8, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 10:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 11:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 16:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 17:
                                            {
                                                num.Add(new LvLTile { type = num8[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = num9[Random.Range(0, 3)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -6:
                                            {
                                                switch (num[j + (i - 1) * width + 2].type)
                                                {
                                                    case 60:
                                                        {
                                                            num.Add(new LvLTile { type = numB[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -1:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -21:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);

                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case -3:
                                            {
                                                switch (num[j + (i - 1) * width + 2].type)
                                                {
                                                    case 60:
                                                        {
                                                            num.Add(new LvLTile { type = numB[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -21:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -25:
                                                        {
                                                            num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -1:
                                                        {
                                                            num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case 60:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 60:
                                                        {
                                                            switch (num[j + (i - 1) * width + 2].type)
                                                            {
                                                                case 60:
                                                                    {
                                                                        num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -4:
                                                                    {
                                                                        num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -21:
                                                                    {
                                                                        num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -1:
                                                                    {
                                                                        num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -25:
                                                                    {
                                                                        num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case 0:
                                                                    {
                                                                        num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                        Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 2].type);
                                                                    }
                                                                    break;
                                                            }
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -21:
                                                        {
                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -1:
                                                        {
                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case -20:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -14:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -19:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -18:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -1:
                                            {
                                                num.Add(new LvLTile { type = numD[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -4:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case 60:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 2:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 3:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -20:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 60:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case -1:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 60:
                                                        {
                                                            switch (num[j + (i - 2) * width + 1].type)
                                                            {
                                                                case 60:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -20:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -8:
                                                                    {
                                                                        num.Add(new LvLTile { type = -4, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -10:
                                                                    {
                                                                        num.Add(new LvLTile { type = -4, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -25:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                case -24:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                    }
                                                                    break;
                                                                default:
                                                                    {
                                                                        num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                        Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 2) * width + 1].type);
                                                                    }
                                                                    break;
                                                            }
                                                                   
                                                        }
                                                        break;
                                                    case -21:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -25:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case -19:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -18:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -1:
                                            {
                                                switch (num[j + (i - 1) * width+1].type)
                                                {
                                                    case 4:
                                                        {
                                                            num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 5:
                                                        {
                                                            num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 55:
                                                        {
                                                            num.Add(new LvLTile { type = -25, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -3:
                                                        {
                                                            num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width+1].type);
                                                        }
                                                        break;
                                                }
                                                       
                                            }
                                            break;
                                        case -4:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -3:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -21:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -22:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -23:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -24:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -25:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -8:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -10:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error j + (i - 1) * width; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -1:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 13:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -3:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -6:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -14:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                            
                                }
                                break;
                            case -3:
                                {
                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                }
                                break;                            
                            case -4:
                                {
                                    switch (num[j + (i - 2) * width].type)
                                    {
                                        case -8:
                                            {
                                                num.Add(new LvLTile { type = -14, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -10:
                                            {
                                                num.Add(new LvLTile { type = -14, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -5:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case -3:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 60:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 60:
                                                        {
                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -21:
                                                        {
                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 0:
                                                        {
                                                            num.Add(new LvLTile { type = -14, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -1:
                                                        {
                                                            num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -25:
                                                        {
                                                            num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = -1, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -1:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -4:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -6:
                                {
                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -8:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 0:
                                            {
                                                num.Add(new LvLTile { type = 11, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 5:
                                            {
                                                num.Add(new LvLTile { type = 3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -9:
                                {
                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -10:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -13:
                                {
                                    num.Add(new LvLTile { type = -5, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -14:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -16:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 60:
                                            {
                                                switch (num[j + (i - 2) * width].type)
                                                {
                                                    case -8:
                                                        {
                                                            num.Add(new LvLTile { type = -17, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case -10:
                                                        {
                                                            num.Add(new LvLTile { type = -17, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    case 60:
                                                        {
                                                            num.Add(new LvLTile { type = -16, pos = new Vector3Int(j, i, 0) });
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 2) * width].type);
                                                        }
                                                        break;
                                                }
                                                        
                                            }
                                            break;
                                        case -1:
                                            {
                                                num.Add(new LvLTile { type = 2, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -17:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -18:
                                {
                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -19:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 60:
                                            {
                                                num.Add(new LvLTile { type = numC[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -3:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -4:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -5:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -6:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -1:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 6:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 15:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -20:
                                            {
                                                num.Add(new LvLTile { type = -6, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -18:
                                            {
                                                num.Add(new LvLTile { type = -3, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case -14:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 4:
                                            {
                                                num.Add(new LvLTile { type = 4, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 17:
                                            {
                                                num.Add(new LvLTile { type = 55, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + (i - 1) * width].type);

                                            }
                                            break;
                                    }

                                }
                                break;
                            case -20:
                                {
                                    if (caveleght < 9)
                                    {
                                        switch (num[j + (i - 1) * width].type)
                                        {
                                            case 60:
                                                {
                                                    num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                                    caveleght++;
                                                    float A = Random.Range(0, 10);
                                                    if (caveleght > A) caveleght = 10;
                                                }
                                                break;
                                            case 55:
                                                {
                                                    switch (num[j + (i - 1) * width +1].type)
                                                    {
                                                        case 55:
                                                            {
                                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                                caveleght++;
                                                                float A = Random.Range(0, 10);
                                                                if (caveleght > A) caveleght = 10;
                                                            }
                                                            break;
                                                        case -5:
                                                            {
                                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                                caveleght++;
                                                                float A = Random.Range(0, 10);
                                                                if (caveleght > A) caveleght = 10;
                                                            }
                                                            break;
                                                        case 15:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case 17:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case -3:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case -18:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case 4:
                                                            {
                                                                num.Add(new LvLTile { type = numJ[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case 5:
                                                            {
                                                                num.Add(new LvLTile { type = numJ[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width+1].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case 17:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                    caveleght++;
                                                    float A = Random.Range(0, 10);
                                                    if (caveleght > A) caveleght = 10;
                                                }
                                                break;
                                            case 6:
                                                {
                                                    num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                    caveleght++;
                                                    float A = Random.Range(0, 10);
                                                    if (caveleght > A) caveleght = 10;
                                                }
                                                break;
                                            case -5:
                                                {
                                                    switch (num[j + (i - 1) * width + 1].type)
                                                    {
                                                        case -14:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case -6:
                                                            {
                                                                num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                                caveleght = 0;
                                                            }
                                                            break;
                                                        case -5:
                                                            {
                                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                                caveleght++;
                                                                float A = Random.Range(0, 10);
                                                                if (caveleght > A) caveleght = 10;
                                                            }
                                                            break;
                                                        case 55:
                                                            {
                                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                                caveleght++;
                                                                float A = Random.Range(0, 10);
                                                                if (caveleght > A) caveleght = 10;
                                                            }
                                                            break;
                                                        default:
                                                            {
                                                                num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                                Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width + 1].type);
                                                            }
                                                            break;
                                                    }
                                                    
                                                }
                                                break;
                                            case -6:
                                                {
                                                    num.Add(new LvLTile { type = -24, pos = new Vector3Int(j, i, 0) });
                                                    caveleght++;
                                                    float A = Random.Range(0, 10);
                                                    if (caveleght > A) caveleght = 10;
                                                }
                                                break;
                                            case -3:
                                                {
                                                    num.Add(new LvLTile { type = -24, pos = new Vector3Int(j, i, 0) });
                                                    caveleght = 0;
                                                }
                                                break;
                                            case -4:
                                                {
                                                    num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                    caveleght = 0;
                                                }
                                                break;
                                            case 4:
                                                {
                                                    num.Add(new LvLTile { type = -10, pos = new Vector3Int(j, i, 0) });
                                                    caveleght = 0;
                                                }
                                                break;
                                            case 5:
                                                {
                                                    num.Add(new LvLTile { type = -10, pos = new Vector3Int(j, i, 0) });
                                                    caveleght = 0;
                                                }
                                                break;

                                            default:
                                                {
                                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                    Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width].type);
                                                }
                                                break;
                                        }

                                    }
                                    else
                                    {
                                        num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });                                        
                                        caveleght = 0;
                                    }

                                }
                                break;
                            case -21:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 60:
                                            {
                                                num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -22:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 60:
                                            {
                                                num.Add(new LvLTile { type = numG[Random.Range(0, 2)], pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            case -23:
                                {
                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -24:
                                {
                                    num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                }
                                break;
                            case -25:
                                {
                                    switch (num[j + (i - 1) * width].type)
                                    {
                                        case 60:
                                            {
                                                num.Add(new LvLTile { type = -22, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                        case 55:
                                            {
                                                switch (num[j + (i - 1) * width + 1].type)
                                                {
                                                    case 55:
                                                        {
                                                            num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                                            caveleght++;
                                                            float A = Random.Range(0, 10);
                                                            if (caveleght > A) caveleght = 10;
                                                        }
                                                        break;
                                                    case 15:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    case 17:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    case -3:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    case -18:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    case -4:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    case 4:
                                                        {
                                                            num.Add(new LvLTile { type = -19, pos = new Vector3Int(j, i, 0) });
                                                            caveleght = 0;
                                                        }
                                                        break;
                                                    default:
                                                        {
                                                            num.Add(new LvLTile { type = 60, pos = new Vector3Int(j, i, 0) });
                                                            Debug.Log("Construct Error ; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num = " + num[j + (i - 1) * width + 1].type);
                                                        }
                                                        break;
                                                }

                                            }
                                            break;
                                        default:
                                            {
                                                num.Add(new LvLTile { type = -20, pos = new Vector3Int(j, i, 0) });
                                            }
                                            break;
                                    }
                                }
                                break;
                            default:
                                {
                                    num.Add(new LvLTile { type = 0, pos = new Vector3Int(j, i, 0) });
                                    Debug.Log("Construct Error; Num Count =" + num.Count + ", j =" + j + ",i =" + i + " Num =" + num[j + width * i - 1].type);
                                }
                                break;
                        }
                    }
                        
                }

            }
        }

        

        return num;
    }

    public static List<LvLTile> DecorLvLCreater(int width, int height, List<LvLTile> LvL)
    {
        List<LvLTile> num = new List<LvLTile>();

        List<int> Wood = new List<int> { 115, 118, 121 };
        List<int> DeadWood = new List<int> { 124, 127, 129, 131 };
        List<int> Kust = new List<int> { 135, 136, 137, 138 };
        List<int> Rock = new List<int> { 133 };

        for (int i = 0; num.Count < LvL.Count;i++)
        {
            num.Add(LvL[i]);
        }

        for (int i = 0; height - 10 > i; i++)
        {
            for (int j = 0; width > j; j++)
            {                
                switch (num[j + width * i].type)
                {
                    case 0:
                        {
                            
                            switch (num[j + (i - 1) * width].type)
                            {
                                case 2:
                                    {
                                        switch (num[j + i * width - 1].type)
                                        {
                                            
                                            case 103:
                                                {

                                                    int L = 0;
                                                    int H = 0;

                                                    for (int a = 0; a < 3; a++)
                                                    {
                                                        for (int b = 0; b < 4; b++)
                                                        {
                                                            if (num[j + (i + b) * width + a].type == 0) L++;
                                                            if (num[j + (i + b - 1) * width + a].type == 2) H++;
                                                        }
                                                    }

                                                    if (L >= 9 && H >= 3)
                                                    {
                                                        for (int a = 0; a < 3; a++)
                                                        {
                                                            num[j + width * i + a].type = 101 + a;

                                                        }
                                                    }
                                                    else
                                                    {
                                                        num[j + width * i].type = 104;
                                                    }
                                                }
                                                break;
                                            case 104:
                                                {
                                                    num[j + width * i].type = 0;
                                                }
                                                break;
                                            default:
                                                {
                                                    int rnd = Random.Range(0, 100);
                                                    if (rnd <= 10)
                                                    {
                                                        int L = 0;
                                                        int H = 0;

                                                        for (int a = 0; a < 5; a++)
                                                        {
                                                            for (int b = 0; b < 4; b++)
                                                            {
                                                                if (num[j + (i + b) * width + a].type == 0) L++;
                                                                if (num[j + (i + b - 1) * width + a].type == 2) H++;
                                                            }
                                                        }

                                                        if (L >= 20 && H >= 5)
                                                        {
                                                            for (int a = 0; a < 4; a++)
                                                            {
                                                                num[j + width * i + a].type = 100 + a;

                                                            }
                                                        }
                                                    }
                                                    else if (rnd > 10 && rnd <= 20)
                                                    {
                                                        int H = 0;

                                                        for (int a = 0; a < 3; a++)
                                                        {
                                                            if (num[j + (i + a) * width + a].type == 0) H++;
                                                        }

                                                        if (H >= 3) num[j + width * i].type = Wood[Random.Range(0, 3)];
                                                    }
                                                    else if (rnd > 20 && rnd <= 40)
                                                    {
                                                        int H = 0;

                                                        for (int a = 0; a < 3; a++)
                                                        {
                                                            if (num[j + (i + a) * width + a].type == 0) H++;
                                                        }

                                                        if (H >= 3) num[j + width * i].type = DeadWood[Random.Range(0, 3)];
                                                    }
                                                    else if (rnd > 40 && rnd <= 80)
                                                    {
                                                        int H = 0;

                                                        for (int a = 0; a < 3; a++)
                                                        {
                                                            if (num[j + (i + a) * width + a].type == 0) H++;
                                                        }

                                                        if (H >= 3) num[j + width * i].type = Kust[Random.Range(0, 4)];
                                                    }
                                                    else if (rnd > 80)
                                                    {
                                                        int H = 0;

                                                        for (int a = 0; a < 3; a++)
                                                        {
                                                            if (num[j + (i + a) * width + a].type == 0) H++;
                                                        }

                                                        if (H >= 3) num[j + width * i].type = Rock[Random.Range(0, 1)];
                                                    }
                                                }
                                                break;
                                        }
                                                
                                    }
                                    break;
                                case 100:
                                    {
                                        num[j + width * i].type = 105;
                                    }
                                    break;
                                case 101:
                                    {
                                        num[j + width * i].type = 106;
                                    }
                                    break;
                                case 102:
                                    {
                                        num[j + width * i].type = 107;
                                    }
                                    break;
                                case 103:
                                    {
                                        num[j + width * i].type = 108;
                                    }
                                    break;
                                case 104:
                                    {
                                        num[j + width * i].type = 109;
                                    }
                                    break;
                                case 105:
                                    {
                                        num[j + width * i].type = 110;
                                    }
                                    break;
                                case 106:
                                    {
                                        num[j + width * i].type = 111;
                                    }
                                    break;
                                case 107:
                                    {
                                        num[j + width * i].type = 112;
                                    }
                                    break;
                                case 108:
                                    {
                                        num[j + width * i].type = 113;
                                    }
                                    break;
                                case 109:
                                    {
                                        num[j + width * i].type = 114;
                                    }
                                    break;
                                case 115:
                                    {
                                        num[j + width * i].type = 116;
                                    }
                                    break;
                                case 116:
                                    {
                                        num[j + width * i].type = 117;
                                    }
                                    break;
                                case 118:
                                    {
                                        num[j + width * i].type = 119;
                                    }
                                    break;
                                case 119:
                                    {
                                        num[j + width * i].type = 120;
                                    }
                                    break;
                                case 121:
                                    {
                                        num[j + width * i].type = 122;
                                    }
                                    break;
                                case 122:
                                    {
                                        num[j + width * i].type = 123;
                                    }
                                    break;
                                case 124:
                                    {
                                        num[j + width * i].type = 125;
                                    }
                                    break;
                                case 125:
                                    {
                                        num[j + width * i].type = 126;
                                    }
                                    break;
                                case 127:
                                    {
                                        num[j + width * i].type = 128;
                                    }
                                    break;
                                case 129:
                                    {
                                        num[j + width * i].type = 130;
                                    }
                                    break;
                                case 131:
                                    {
                                        num[j + width * i].type = 132;
                                    }
                                    break;
                                case 133:
                                    {
                                        num[j + width * i].type = 134;
                                    }
                                    break;
                            }
                        }
                        break;
                    
                }
            }
        }

        return num;
    }
}
