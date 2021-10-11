using UnityEngine;

public static class GizmoUtils
{
    public static void DrawWireCircle(Vector3 position, float radius, int segmentCount, Color color)
    {
        Gizmos.color = color;
        var theta = 0f;
        var x = radius * Mathf.Cos(theta);
        var y = radius * Mathf.Sin(theta);
        var start = position + new Vector3(x, y, 0f);
        var end = start;
        for (int i = 0; i <= segmentCount; i++)
        {
            theta = Mathf.PI * 2 * i / (float)segmentCount;
            x = radius * Mathf.Cos(theta);
            y = radius * Mathf.Sin(theta);
            end = position + new Vector3(x, y, 0f);
            Gizmos.DrawLine(start, end);
            start = end;
        }
    }

    public static void DrawWireCube(Vector3 position, Quaternion rotation, Vector3 scale, Vector3 size, Color color)
    {
        Gizmos.color = color;
        // Draw spawn zone
        Matrix4x4 cubeTransform = Matrix4x4.TRS(position, rotation, scale);
        Matrix4x4 oldGizmosMatrix = Gizmos.matrix;

        Gizmos.matrix *= cubeTransform;

        Gizmos.DrawWireCube(Vector3.zero, size);

        Gizmos.matrix = oldGizmosMatrix;
    }
}