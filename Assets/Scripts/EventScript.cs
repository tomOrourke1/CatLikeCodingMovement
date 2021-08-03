using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EventScript : MonoBehaviour
{
    private void OnValidate()
    {
        
        CustomEvent.Trigger(this.gameObject, "MyOnValidate", null);
        
    }
}
