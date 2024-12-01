using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttak : MonoBehaviour
{
    private float timeBtwAttack;
    public float startTimeBtwAttack;

    public Transform attackPos;
    public LayerMask enemy;
    public float attackRange;
    public int damage;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if (name == "player_1" && Input.anyKey)
            {
                if (Input.GetKeyDown(KeyCode.KeypadEnter)) 
                {
                    anim.SetTrigger("attack");
                }
            }

            if (name == "player_2" && Input.anyKey)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    anim.SetTrigger("attack2");
                }
            }
        }
    }
}
