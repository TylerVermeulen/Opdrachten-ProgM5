using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject Enemy;
    public List<GameObject> enemies = new List<GameObject>();
   
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(autospawner());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                enemies.Add(Instantiate(Enemy));
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            foreach(GameObject e in enemies)
            {
                Destroy(e);
            }
        }

           

    }
    public IEnumerator autospawner()
    {
        enemies.Add(Instantiate(Enemy));
        yield return new WaitForSeconds(3);
    }

}
