using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BfsTraversal : MonoBehaviour
{
    public void Traverse()
    {
        Queue<Node> q = new Queue<Node>();
        Node node = MazeGenerator.GetRoot();
        q.Enqueue(node);
        while (q.Count > 0)
        {
            node = q.Dequeue();
            Debug.Log(node.x + "/" + node.y);
            if (node.Left != null)
                q.Enqueue(node.Left);
            if (node.Right != null)
                q.Enqueue(node.Right);
            if (node.Up != null)
                q.Enqueue(node.Up);
            if (node.Down != null)
                q.Enqueue(node.Down);
        }
    }
}
