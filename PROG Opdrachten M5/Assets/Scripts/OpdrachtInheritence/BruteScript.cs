using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BruteScript : EnemyParent
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move(1, 10, 1);
    }
}
