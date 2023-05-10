using UnityEngine;
using UnityEngine.Events;
public class TriggerEventBehavior : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();

    }
    
    public Object mainObject;
    void Start()
    {
        mainObject = GetComponent<Rigidbody>();
    }

    public void DestroyMainObject()
    {
        Destroy(mainObject);
    }
}