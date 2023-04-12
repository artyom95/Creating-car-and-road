
using UnityEngine;



public class Car : MonoBehaviour

{
   
    
    [SerializeField] private float _speed;

   
    private void Update()
    {
        var position = gameObject.transform.position;
      
        var step = _speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            position.x -= step;   
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
            position.x += step;
        }
        if (Input.GetKey(KeyCode.D))
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 45, 0);
            position.z += step;
        }

        if (Input.GetKey(KeyCode.A))
        {
           gameObject.transform.rotation = Quaternion.Euler(0, -45, 0);
           position.z -= step;
        }
        transform.position = position;
       
    }

    
}
