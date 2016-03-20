using UnityEngine;
public class Player2 : MonoBehaviour
{
    public float rotationSpeed = 60;
    void Start()
    {
        Transform current = transform;
        for (int i = 0; i < 3; i++)
        {
            
            tail tail = GameObject.CreatePrimitive(PrimitiveType.Cube).AddComponent<tail>();            
            
            tail.transform.position = current.transform.position - current.transform.forward * 2;
            
            tail.transform.rotation = transform.rotation;
            
            tail.target = current.transform;
            
            tail.targetDistance = 2;
            
            Destroy(tail.GetComponent<Collider>());
            
            current = tail.transform;
            //float horizontal = Input.GetAxis("Horizontal");
           // tail.transform.Rotate(10, rotationSpeed * Time.deltaTime * horizontal, 10);
        }
    }    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 2);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(Vector3.left);
        }
    }
}