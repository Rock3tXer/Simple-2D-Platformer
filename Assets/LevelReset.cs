using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelReset : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
     if(other.gameObject.tag == "Spikes")
          Application.LoadLevel(Application.loadedLevel);
    }
}
