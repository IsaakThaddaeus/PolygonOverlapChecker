using System.Collections.Generic;
using UnityEngine;

public static class PolygonOverlapChecker
{
    public static bool isOverlaping(List<Vector2> polygonA, List<Vector2> polygonB)
    {
        // Check for intersection between edges of polygonA and polygonB
        for (int i = 0; i < polygonA.Count; i++)
        {
            for (int j = 0; j < polygonB.Count; j++)
            {
                // Get the endpoints of the edges
                Vector2 edgeAStart = polygonA[i];
                Vector2 edgeAEnd   = polygonA[(i + 1) % polygonA.Count];
                Vector2 edgeBStart = polygonB[j];
                Vector2 edgeBEnd   = polygonB[(j + 1) % polygonB.Count];

                // Check for intersection using a line intersection test
                if (LineIntersector.doIntersect(edgeAStart, edgeAEnd, edgeBStart, edgeBEnd))
                    return true;
            }
        }
        return false;
    }

}
