using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonManager : MonoBehaviour
{
    // Start is called before the first frame update




    static public Pokemon Magikarp;
    public static Ability SwiftSwim;
    public Sprite MagiKarpBack;
    public Sprite MagiKarpFront;


    void Start()
    {
        SwiftSwim = new Ability("Swift Swim", false, "It doubled Magikarp's speed!", 0);




        Magikarp = new Pokemon("Magikarp", 30, SwiftSwim, null, MagiKarpBack, MagiKarpFront);




    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public class Pokemon
    {
        public string name;

        public int HitPoint;

        public Ability ability1;

        public Ability ability2;

        //public int level;

        public Sprite front;

        public Sprite back;

        public Pokemon(string nm, int hp, Ability ab1, Ability ab2, Sprite sprite1, Sprite sprite2)
        {
            name = nm;
            HitPoint = hp;
            ability1 = ab1;
            ability2 = ab2;
           // level = lv;
            front = sprite1;
            back = sprite2;
        }

    }

    public class Ability
    {
        public string name;

        public bool dealdamage;

        public string effect;

        public int damage;

        public Ability(string nm, bool dd, string eft, int dmg)
        {
            name = nm;
            dealdamage = dd;
            effect = eft;
            damage = dmg;
        }


    }

    public class LivePokemon
    {
        public Pokemon pokemon;

        public int level;

        public LivePokemon(Pokemon pkm, int lv)
        {
            pokemon = pkm;
            level = lv;
        }
    }
}
