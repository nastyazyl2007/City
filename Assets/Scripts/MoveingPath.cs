using System.Collections.Generic;
using UnityEngine;

public class MoveingPath : MonoBehaviour
{
    public enum PathType
    {
        line,
        circle
    }

    public PathType pathType;
    public Transform[] pathPoints;
    private int moveingVariant = 1; //1 - движение вперёд/по часовой, -1 - движенеи назад/против часовой

    private void OnDrawGizmos()
    {
        
    }

    public IEnumerator<Transform> NextMovementPoint()
    {
        yield break;
    }


}
