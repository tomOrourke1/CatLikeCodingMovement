using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetMinDotNode : MonoBehaviour
{
    
    
    
    public bool GetMinDot (int layer, LayerMask stairsMask) 
    {
    	return (stairsMask & (1 << layer)) == 0;
    }
    	
    	
    	
}
