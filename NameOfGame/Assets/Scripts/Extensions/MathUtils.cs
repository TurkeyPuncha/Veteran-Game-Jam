using UnityEngine;

public static class MathUtils
{
    public static Vector3 RandomInsideBox(Vector3 size)
    {
        size *= 0.5f;
        return new Vector3(Random.Range(-size.x, size.x), Random.Range(-size.y, size.y), Random.Range(-size.z, size.z));
    }
}
