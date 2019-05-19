using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.HDPipeline;
using UnityEngine.Rendering;

public class focusPull : MonoBehaviour
{
    
    DepthOfField dofComponent;
    public MinFloatParameter focDist;
    public float focDistAnim;
    
     
    
    // Start is called before the first frame update
    void Start()
    {
        Volume volume = gameObject.GetComponent<Volume>();
        DepthOfField tmp;
        if(volume.profile.TryGet<DepthOfField>(out tmp))
        {
            dofComponent = tmp;
        }           
        
    }

    // Update is called once per frame
    void Update()
    {
        focDist = dofComponent.focusDistance;
        focDist.value = focDistAnim;
    }
}
