using UnityEngine;
using System.Collections;

public class increaser : MonoBehaviour
{
    public Transform pos1, pos2;
    public float speed;
    public Transform startPos;

    Vector3 nextPos;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.localScale;
        transform.localScale = new Vector3(nextPos.x,nextPos.y,nextPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.localScale== pos1.localScale)
        {
            nextPos = pos2.localScale;
        }
        if(transform.localScale== pos2.localScale)
        {
            nextPos = pos1.localScale;
        }

        transform.localScale = Vector3.MoveTowards(transform.localScale,nextPos,speed*Time.deltaTime);
    }
}