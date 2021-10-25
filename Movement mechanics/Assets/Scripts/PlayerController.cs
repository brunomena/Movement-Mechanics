using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public Transform movePoint;
    public Grid testGrid;
    public Tilemap tileMap;
    public TileBase yellowTile;

    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, movePoint.position) <= 0.05f)
        {
            if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) == 1f)
            {
                movePoint.position += new Vector3(Input.GetAxisRaw("Horizontal"),0f,0f);
                tileMap.SetColor(Vector3Int.FloorToInt(transform.position), Color.yellow);
            }

            if (Mathf.Abs(Input.GetAxisRaw("Vertical")) == 1f)
            {
                movePoint.position += new Vector3(0f, 0f, Input.GetAxisRaw("Vertical"));
            }
        }
    }
}
