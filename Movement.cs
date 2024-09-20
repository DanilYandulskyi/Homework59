using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    
    private float _initialSpeed;
    
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>(); 
        _initialSpeed = _speed;
    }

    public void Move(Vector3 direction)
    {
        _speed = _initialSpeed;
        Vector3 offset = direction.normalized * (_speed * Time.deltaTime);
        _rigidbody.MovePosition(_rigidbody.position + offset);
    }

    public void Stop()
    {
        _speed = 0;
    }
}
