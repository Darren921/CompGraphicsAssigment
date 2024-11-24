using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceCheck : MonoBehaviour
{
   [SerializeField] private MeshRenderer[] Shed;
    float distance;
    Player _player;
    // Start is called before the first frame update
    void Start()
    {
        _player = FindObjectOfType<Player>();
        Shed = this.gameObject.GetComponentsInChildren<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position,_player.transform.position );


        if (distance > 30)
        {
            for (int i = 0; i < Shed.Length; i++)
            {
                Shed[i].enabled = false;
            }
        }
        else
        {
            for (int i = 0; i < Shed.Length; i++)
            {
                Shed[i].enabled = true;

            }
        }

    }
}
