using UnityEngine;
using UnityEngine.AI;

public class LevelGenerator : MonoBehaviour {

    public int width = 18;
    public int height = 18;
    public Vector3 offset;

    public GameObject wall;

    public NavMeshSurface surface;

    // Use this for initialization
    void Start () {
        GenerateLevel();

        surface.BuildNavMesh();
    }
    
    // Create a grid based level
    void GenerateLevel()
    {
        // Loop over the grid
        for (int x = 0; x <= width; x+=2)
        {
            for (int y = 0; y <= height; y+=2)
            {
                // Should we place a wall?
                if (Random.value > .7f)
                {
                    // Spawn a wall
                    Vector3 pos = new Vector3(offset.x + x - width / 2f, offset.y + 1f, offset.z + y - height / 2f);
                    Instantiate(wall, pos, Quaternion.identity, transform);
                }
            }
        }
    }

}