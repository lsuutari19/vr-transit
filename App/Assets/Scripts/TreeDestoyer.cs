using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeDestoyer : MonoBehaviour
{
    public float treeSpeed = 400.0f;
    private float xplus = 500.0f;
    private float xminus = -500.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 20.0f)
        {
            transform.Translate(Vector3.right * Time.deltaTime * treeSpeed);
        }
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * treeSpeed);
        }

        if (transform.position.x > xplus || transform.position.x < xminus)
        {
            Destroy(gameObject);
        }
        
    }
}
