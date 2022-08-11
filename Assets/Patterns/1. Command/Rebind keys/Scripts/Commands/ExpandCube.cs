using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class ExpandCube : Command
    {
        private ExpandObject expandObject;


        public ExpandCube(ExpandObject expandObject)
        {
            this.expandObject = expandObject;
        }


        public override void Execute()
        {
            expandObject.IncreaseCubeSize();
        }


        //Undo is just the opposite
        public override void Undo()
        {
            expandObject.DecreaseCubeSize();
        }
    }
}