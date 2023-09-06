using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger //°´Ã¼
{
    protected bool bun;
    protected bool patty;
    protected bool specialSauce;
    protected bool lettuce;
    protected bool cheese;
    protected bool pickle;
    protected bool onion;
    protected bool patty2;
    protected bool tomato;
    protected bool bacon;
    protected bool isChickenPatty;
    
    //±âº»
    public Hamburger(bool bun = true, bool patty = true)
    {
        this.bun = bun;
        this.patty = patty;
    }
    //¸ÆÄ¡Å²
    public Hamburger(bool bun, bool patty, bool specialSauce, bool lettuce, bool isChickenPatty = true)
    {
        this.bun = bun;
        this.patty = patty;
        this.specialSauce = specialSauce;
        this.lettuce = lettuce;
        this.isChickenPatty = isChickenPatty;
    }
    //Ä¡Áî¹ö°Å
    public Hamburger(bool bun, bool patty, bool specialSauce,bool cheese, bool pickle, bool onion)
    {
        this.bun = bun;
        this.patty = patty;
        this.specialSauce = specialSauce;
        this.cheese = cheese;
        this.pickle = pickle;
        this.onion = onion;
    }
    //ºò¸Æ
    public Hamburger(bool bun, bool patty, bool patty2, bool specialSauce, bool lettuce, bool cheese, bool pickle, bool onion)
    {
        this.bun = bun;
        this.patty = patty;
        this.patty2 = patty2;
        this.specialSauce = specialSauce;
        this.lettuce = lettuce;
        this.cheese = cheese;
        this.pickle = pickle;
        this.onion = onion;
    }
    //´Ù¶§·Á³ÖÀ½
    public Hamburger(bool bun, bool patty, bool patty2, bool specialSauce, bool lettuce, bool cheese, bool pickle, bool onion, bool tomato, bool bacon, bool isChickenPatty = false)
    {
        this.bun = bun;
        this.patty = patty;
        this.patty2 = patty2;
        this.specialSauce = specialSauce;
        this.lettuce = lettuce;
        this.cheese = cheese;
        this.pickle = pickle;
        this.onion = onion;
        this.bacon = bacon;
        this.tomato = tomato;
        this.isChickenPatty = isChickenPatty;
    }

    public bool SpecialSauce { get { return specialSauce; } }
    public bool Lettuce { get { return lettuce; } }
    public bool Cheese { get { return cheese; } }
    public bool Pickle { get { return pickle; } }
    public bool Onion { get { return onion; } }
    public bool Patty2 { get { return patty2; } }
    public bool Tomato { get { return tomato; } }
    public bool Bacon { get { return bacon; } }
    public bool IsChickenPatty { get { return specialSauce; } }
}
