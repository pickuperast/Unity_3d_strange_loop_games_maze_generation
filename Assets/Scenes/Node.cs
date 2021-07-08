using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public Node Left;
    public Node Right;
    public Node Up;
    public Node Down;
    public int x;
    public int y;
    public bool isVisited = false;

    public Node(int newX, int newY)
    {
        x = newX;
        y = newY;
    }
}
