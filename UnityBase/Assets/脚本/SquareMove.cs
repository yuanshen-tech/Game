using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMove : MonoBehaviour
{
    public E_move e_move;  
    public GameObject sq1;
    public GameObject sq2;
    private int index;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
        switch(e_move)
        {
            case E_move.yvnsu:
                index = 0; break;
            case E_move.change:
                index = 1; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        sq2.transform.Translate(Vector2.right * 8 * Time.deltaTime * Input.GetAxis("Horizontal"));
        sq2.transform.Translate(Vector2.up * 8 * Time.deltaTime * Input.GetAxis("Vertical"));
        if(index==1)
           sq1.transform.position = new Vector2(Mathf.Lerp(sq1.transform.position.x, sq2.transform.position.x, Time.deltaTime), Mathf.Lerp(sq1.transform.position.y, sq2.transform.position.y, Time.deltaTime));
        else if(index==0)
            sq1.transform.position = new Vector2(Mathf.Lerp(0,sq2.transform.position.x,time),Mathf.Lerp(0,sq2.transform.position.y, time));
    }

    
}
public enum E_move
{
    yvnsu,
    change
}
