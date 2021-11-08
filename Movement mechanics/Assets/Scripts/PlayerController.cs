using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform movePoint;
    private Vector3 originOffSet;

    private Grid grid;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        originOffSet = new Vector3(-1.5f,-0.5f,-1.5f) + transform.position;
        grid = new Grid(3, 3, 1f, originOffSet);

    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f);
                grid.MoveGrid(new Vector3(Input.GetAxisRaw("Horizontal"), 0f, 0f));
            }

            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
                grid.MoveGrid(new Vector3(Input.GetAxisRaw("Vertical"), 0f, 0f));
            }
        }
    }
}
