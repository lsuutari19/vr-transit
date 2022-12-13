using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinMaxc : MonoBehaviour
{
    public GameObject obj;

    private Vector3 baseScale;
    private Vector3 changeScale;

    // Start is called before the first frame update
    void Start()
    {
        baseScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        changeScale = getScale();
        transform.localScale = Vector3.Lerp(transform.localScale, changeScale, 1);
    }

    
    Vector3 getScale()
    {
        float scaler = 0.0f;
        if (transform.localPosition.x < 0)
        {
            scaler = (80.0f + transform.localPosition.x) / 80.0f;
        }
        else if (transform.localPosition.x > 0)
        {
            scaler = 1 + (transform.localPosition.x / 60.0f);
        }
        else { scaler = 1; }
        Vector3 toScale = new Vector3(baseScale.x * scaler, baseScale.y * scaler, baseScale.z * scaler);
        return toScale;
    }

}
