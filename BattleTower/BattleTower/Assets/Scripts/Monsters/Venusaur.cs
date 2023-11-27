using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venusaur : Monster
{
    public Venusaur()
    {
        name = "Venusaur";
        type1 = "Grass";
        type2 = "Poison";
        baseStats[0] = 80;
        baseStats[1] = 82;
        baseStats[2] = 83;
        baseStats[3] = 100;
        baseStats[4] = 100;
        baseStats[5] = 80;
        moveList.Add(8);
        moveList.Add(10);
        moveList.Add(13);
        moveList.Add(18);
        EV[0] = 0;
        EV[1] = 0;
        EV[2] = 0;
        EV[3] = 0;
        EV[4] = 0;
        EV[5] = 0;
    }
}
