using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCore
{
    public class BTCondition : BTNode
    {
        public BTCondition(string name) : base(name)
        {

        }
        sealed public override BTResult OnTick(BTBlackBoard blackBoard)
        {
            if(Evaluate(blackBoard))
            {
                return BTResult.Success;
            } 
            else
            {
                return BTResult.Failure;
            }
        }
        public virtual bool Evaluate(BTBlackBoard blackBoard) { return true; }
    }
}
