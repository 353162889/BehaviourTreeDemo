using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCore
{
    public class BTPreCondition : BTNode
    {
        public virtual bool ExtraEvaluate(BTBlackBoard blackBoard) { return true; }
    }
}
