using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Kollision : MonoBehaviour
{
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Cube8" || col.gameObject.name == "Cube7" || col.gameObject.name == "Cube6" || col.gameObject.name == "Cube5")
         {
             Destroy(col.gameObject);
        }
    }    
}
