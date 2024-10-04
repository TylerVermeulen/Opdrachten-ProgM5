using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Elfscript : EnemyParent
{
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<Renderer>();
        StartCoroutine(cloak());
    }

    // Update is called once per frame
    void Update()
    {
        Move(1, 5, 2);
    }
    public IEnumerator cloak()
    {
        yield return new WaitForSeconds(3);
        renderer.enabled = false;
        yield return new WaitForSeconds(1);
        renderer.enabled = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("fghj");
    }
}
