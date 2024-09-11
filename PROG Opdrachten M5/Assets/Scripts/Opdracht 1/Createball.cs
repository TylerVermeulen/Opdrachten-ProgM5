using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Createball : MonoBehaviour
{
    public GameObject prefab;
    private float elapsedTime = 0f;

    private GameObject CreateBall(Color c, Vector3 position)
    {

        GameObject ball = Instantiate(prefab, position, Quaternion.identity);
        Material material = ball.GetComponent<MeshRenderer>().material;
        material.SetColor("_Color", c);

        

        return ball;

    }
    IEnumerator DestroyBall(GameObject ball)
    {
        yield return new WaitForSeconds(3);
        Destroy(ball);
    }

    void Update()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        Color randColor = new Color(r, g, b, 1f);

        elapsedTime += Time.deltaTime;
        if (elapsedTime > 1f)
        {
            float x = Random.Range(-10f, 10f);
            float y = Random.Range(10f, 20f);
            float z = Random.Range(-10f, 10f);
            GameObject ball = CreateBall(randColor, new Vector3(x, y, z));
            StartCoroutine(DestroyBall(ball));

            elapsedTime = 0f;

        }

    }

}
