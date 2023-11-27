using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster
{
    public string name;
    public string type1;
    public string type2;
    public int[] baseStats = new int[6];
    public int[] IV = new int[6]; //Individual Value
    public int[] EV = new int[6]; //Effort Value
    public int[] finalStats = new int[6]; //calculated stats
    public List<int> moveList = new List<int>();
    public int[] availableMove = new int[4];
    //future - ability & nature



    public void setIVs()
    {
        for(int i = 0; i < IV.Length; i++)
        {
            IV[i] = Random.Range(0, 31);
        }
    }

    public int EVCount()
    {
        int count = 0;
        for(int i = 0; i < EV.Length; i++)
        {
            count += EV[i];
        }
        return count;
    }

    public void addEV(int num, int stat)
    {
        if(stat <= 6)
            EV[stat] += num;
    }

    public void addToMoveList(int move)//for special cases
    {
        moveList.Add(move);
    }

    public void setMove(int move, int i)
    {
        availableMove[i] = move;
    }

    public int calculateStat(int stat)
    {
        float final = 2f;
        final *= baseStats[stat];
        final += IV[stat];
        final += (EV[stat] / 4f);
        if (stat == 1) //HP is calculated differently
            final += 110;
        else
            final += 5;
        //final *= 1.1 || 0.9 for nature
        int finalNum = (int)final;
        return finalNum;
    }
}

public class Move
{
    public int ID;//what the ints mean in the list and array
    public string name;
    public int baseDamage;
    public string type;
    public int additionalEffect;
    public bool physical;
    public bool contact;
    //future - priority & accuracy
}