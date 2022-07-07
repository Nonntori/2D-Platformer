using UnityEngine;

public class Player : MonoBehaviour 
{
    [SerializeField] private Vector3 _spawnPoint;

    public Vector3 Die()
    {
        return _spawnPoint;
    }
}
