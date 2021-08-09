using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GetMinDotNode : MonoBehaviour
{
    
    
    
    public bool GetMinDot (int layer, LayerMask stairsMask) 
    {
    	return (stairsMask & (1 << layer)) == 0;
    }


    public int ConditionalLeaps(bool a, bool b, bool c)
    {
	    if (a)
	    {
		    return 1;
	    }
	    else if (b)
	    {
		    return 2;
	    }
	    else if (c)
	    {
		    return 3;
	    }
	    else
	    {
		    return 4; 
	    }
    }
    	
}
