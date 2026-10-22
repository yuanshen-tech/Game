using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sin : MonoBehaviour
{
    public GameObject sq1;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sq1.transform.position = new Vector2(time * 3, 10*Mathf.Sin(time * 30 * Mathf.Deg2Rad));
        time += Time.deltaTime;
    }
}
