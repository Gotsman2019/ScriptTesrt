using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Boss
{
    private int hp = 100;
    private int power = 25;
    private int mp = 52;

    public void magic()
    {

        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");

        }
        else { Debug.Log("MPが足りない為魔法が使えない"); }
    }
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを受けた");
    }
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージ受けた");
        this.hp -= damage;
    }
}


public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        
        lastboss.Attack();
        lastboss.Defence(3);

        for (int x = 1; x<= 10; x++) 
        { 
        lastboss.magic();
        }

        lastboss.magic();





        int[] array = { 1, 2, 3, 4, 5 };
        for (int i = 0; i < array.Length; i++)
        {
            if( array[i] <= 5)
            {
                Debug.Log(array[i]);
            }
        }
        for(int i = array.Length-1; i >=0; i--)
        {
            if( array[i] >= 1)
            {
                Debug.Log(array[i]);
            }

        }
    }

       

    // Update is called once per frame
    void Update()
    {
        
    }
}
