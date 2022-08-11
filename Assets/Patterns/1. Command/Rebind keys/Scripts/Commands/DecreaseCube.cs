using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CommandPattern.RebindKeys
{
    public class DecreaseCube : Command
    {
        private ExpandObject expandObject;


        public DecreaseCube(ExpandObject expandObject)
        {
            this.expandObject = expandObject;
        }


        public override void Execute()
        {
            expandObject.DecreaseCubeSize();
        }

        //Undo is just the opposite
        public override void Undo()
        {
            expandObject.IncreaseCubeSize();
        }
    }
}