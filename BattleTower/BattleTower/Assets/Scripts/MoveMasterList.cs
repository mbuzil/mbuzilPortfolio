using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* List of additional effects
 * 0 = nothing
 * 1 = 10% chance to paralyse
 * 2 = 10% chance to burn
 * 3 = 10% chance to freeze
 * 4 = 10% chance to poison
 * 5 = 30% chance to paralyse
 * 6 = 30% chance to burn
 * 7 = 30% chance to freeze
 * 8 = 30% chance to poison
 * 9 = 100% chance to paralyse
 * 10 = 100% chance to burn
 * 11 = 100% chance to sleep
 * 12 = 100% chance to poison
 * 13 = 100% chance to confuse
 * future - % to drop stats, drop your stats, increase critical hit, recoil
 */

//More moves to be added, possibly one file per type. For now before I finalize how much info I'm putting in each move just one per type

//ELECTRIC TYPE MOVES
public class Thunderbolt : Move
{
    public Thunderbolt()
    {
        ID = 1;
        name = "Thunderbolt";
        baseDamage = 90;
        type = "Electric";
        additionalEffect = 1;
        physical = false;
        contact = false;
    }
}
//ICE TYPE MOVES
public class IceBeam : Move
{
    public IceBeam()
    {
        ID = 2;
        name = "Ice Beam";
        baseDamage = 90;
        type = "ice";
        additionalEffect = 3;
        physical = false;
        contact = false;
    }
}
//FIRE TYPE MOVES
public class Flamethrower : Move
{
    public Flamethrower()
    {
        ID = 3;
        name = "Flamethrower";
        baseDamage = 90;
        type = "fire";
        additionalEffect = 2;
        physical = false;
        contact = false;
    }
}
//GHOST TYPE MOVES
public class ShadowBall : Move
{
    public ShadowBall()
    {
        ID = 4;
        name = "Shadow Ball";
        baseDamage = 80;
        type = "ghost";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//PSYCHIC TYPE MOVES
public class Psychic : Move
{
    public Psychic()
    {
        ID = 5;
        name = "Psychic";
        baseDamage = 90;
        type = "psychic";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//WATER TYPE MOVES
public class Surf : Move
{
    public Surf()
    {
        ID = 6;
        name = "Surf";
        baseDamage = 90;
        type = "water";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//FIGHTING TYPE MOVES
public class CloseCombat : Move
{
    public CloseCombat()
    {
        ID = 7;
        name = "Close Combat";
        baseDamage = 120;
        type = "fighting";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}
//POISON TYPE MOVES
public class SludgeBomb : Move
{
    public SludgeBomb()
    {
        ID = 8;
        name = "Sludge Bomb";
        baseDamage = 90;
        type = "poison";
        additionalEffect = 8;
        physical = false;
        contact = false;
    }
}
//BUG TYPE MOVES
public class XScissor : Move
{
    public XScissor()
    {
        ID = 9;
        name = "X-Scissor";
        baseDamage = 80;
        type = "bug";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}
//DARK TYPE MOVES
public class Crunch : Move
{
    public Crunch()
    {
        ID = 10;
        name = "Crunch";
        baseDamage = 80;
        type = "dark";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}
//STEEL TYPE MOVES
public class IronHead : Move
{
    public IronHead()
    {
        ID = 11;
        name = "Iron Head";
        baseDamage = 80;
        type = "steel";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}
//FAIRY TYPE MOVES
public class Moonblast : Move
{
    public Moonblast()
    {
        ID = 12;
        name = "Moonblast";
        baseDamage = 95;
        type = "fairy";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//GROUND TYPE MOVES
public class Earthquake : Move
{
    public Earthquake()
    {
        ID = 13;
        name = "Earthquake";
        baseDamage = 100;
        type = "ground";
        additionalEffect = 0;
        physical = true;
        contact = false;
    }
}
//ROCK TYPE MOVES
public class PowerGem : Move
{
    public PowerGem()
    {
        ID = 14;
        name = "Power Gem";
        baseDamage = 80;
        type = "rock";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//NORMAL TYPE MOVES
public class BodySlam : Move
{
    public BodySlam()
    {
        ID = 15;
        name = "Body Slam";
        baseDamage = 85;
        type = "normal";
        additionalEffect = 5;
        physical = true;
        contact = true;
    }
}
//FLYING TYPE MOVES
public class DrillPeck : Move
{
    public DrillPeck()
    {
        ID = 16;
        name = "Drill Peck";
        baseDamage = 80;
        type = "flying";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}
//DRAGON TYPE MOVES
public class DracoMeteor : Move
{
    public DracoMeteor()
    {
        ID = 17;
        name = "Draco Meteor";
        baseDamage = 130;
        type = "dragon";
        additionalEffect = 0;
        physical = false;
        contact = false;
    }
}
//GRASE TYPE MOVES
public class LeafBlade : Move
{
    public LeafBlade()
    {
        ID = 18;
        name = "Leaf Blade";
        baseDamage = 90;
        type = "grass";
        additionalEffect = 0;
        physical = true;
        contact = true;
    }
}