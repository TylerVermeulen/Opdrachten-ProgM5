using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towerspawner : MonoBehaviour
{
    public GameObject towerPrefab;
    // Start is called before the first frame update
    void Start()
    {
    }
    public void spawntower()
    {
        GameObject tower = Instantiate(towerPrefab);
        float a = Random.Range(-5f, 5f);
        float b = Random.Range(0f, 2f);
        float c = Random.Range(-5f, 5f);
        Vector3 position = new Vector3(a, 0f, c);
        Vector3 scale = new Vector3(1f, b, 1f);
        towerPrefab.transform.localScale = scale;/*new Vector3(1, Random.Range(1, 5), 1);*/
        towerPrefab.transform.position = position;
       
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spawntower();
        }
    }
}