using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject player;
    private Vector3 offset = new Vector3(0, 4.8F, -4.2F);
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //a�adimos un offset para que la c�mara mantenga la posici�n mientras persigue el veh�culo
        transform.position = player.transform.position + offset;
    }
}
