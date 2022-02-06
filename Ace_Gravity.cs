using UnityEngine;

public class Ace_Gravity : MonoBehaviour
{
    [SerializeField] private float _gravityScale = 1.0f;
    [SerializeField] private static float _globalGravity = -9.81f;

    Rigidbody _rigidBody;

    private void Gravity()
    {
        Vector3 gravity = _globalGravity * _gravityScale * Vector3.up;
        _rigidBody.AddForce(gravity, ForceMode.Acceleration);
    }


    void OnEnable()
    {
        _rigidBody = GetComponent<Rigidbody>();
        _rigidBody.useGravity = false;
    }

    void FixedUpdate()
    {
        Gravity();
    }
}
