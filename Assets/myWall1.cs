using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myWall1 : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;
    void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            for (int z = 0; z < width; ++z)
            {
                Vector3 offset = new Vector3(0, y, z);
                Instantiate(block, transform.position + offset, Quaternion.identity);
            }
        }
    }
}
