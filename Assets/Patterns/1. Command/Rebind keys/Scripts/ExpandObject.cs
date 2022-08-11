using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    //This class handles all methods that moves the object it's attached to
    public class ExpandObject : MonoBehaviour
    {
     

        public void IncreaseCubeSize()
        {
            UpScale(transform.localScale);
        }
        
        public void DecreaseCubeSize()
        {
            DownScale(transform.localScale);
        }
        
        private void UpScale(Vector3 scale) {
 
            scale += new Vector3(0.1f,0.1f,0.1f);
            transform.localScale = scale;
            
        }
        private void DownScale(Vector3 scale)
        {
            scale -= new Vector3(0.1f, 0.1f, 0.1f);
            transform.localScale = scale;
            
        }
    }
}