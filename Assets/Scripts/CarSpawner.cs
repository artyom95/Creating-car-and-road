
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
   
    [SerializeField] private GameObject _prefab;
 
    private void Awake()
    {
        var rotation = Quaternion.Euler(0, 0, 0);
        Instantiate(_prefab, new Vector3(24,0,0), rotation);
        
    }
}
