using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    //This class handles all methods that moves the object it's attached to
    public class ExpandObject : MonoBehaviour
    {
        public GameObject cube;

        public void IncreaseCubeSize()
        {
            UpScale(cube.transform.localScale);
        }
        
        public void DecreaseCubeSize()
        {
            DownScale(cube.transform.localScale);
        }
        
        private void UpScale(Vector3 scale) {
 
            scale += new Vector3(0.1f,0.1f,0.1f);
            cube.transform.localScale = scale;
            
        }
        private void DownScale(Vector3 scale)
        {
            scale -= new Vector3(0.1f, 0.1f, 0.1f);
            cube.transform.localScale = scale;
            
        }
    }
}