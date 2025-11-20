using Unity.VisualScripting;
using UnityEngine;

public class PlayerAwarenessController : MonoBehaviour
{
    public bool AwareOfPlayer {get; private set;}

    public Vector2 DirectionToPlayer {get; private set;}

    [SerializeField] private float _playerAwarenessDistance;
    private Transform _player;

    private void Awake()
    {
        if (_player == null)
        {
            MotherDuckCode motherDuck = FindFirstObjectByType<MotherDuckCode>();
            if (motherDuck != null)
            {
                _player = motherDuck.transform;
            }
            else
            {
                Debug.LogError("PlayerAwarenessController: Cannot find MotherDuckCode in scene!");
            }
        }
    }

    void Update()
    {
        Vector2 enemyToPlayerVector = _player.position - transform.position;
        DirectionToPlayer = enemyToPlayerVector.normalized;

        if (enemyToPlayerVector.magnitude <= _playerAwarenessDistance)
        {
            AwareOfPlayer = true;
        }
        else
        {
            AwareOfPlayer = false;
        }
    }
}
