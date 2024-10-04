using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    protected int health;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Move(int direction, int health, int movespeed)
    {
        transform.position += transform.right * movespeed * Time.deltaTime * direction;
    }
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("!!");
        if (collider.transform.tag == "ball")
        {
            if (health != 0)
            {
                health = health - 1;
            }
            else 
            { 
                Destroy(gameObject);
            }
        }
    }
}
