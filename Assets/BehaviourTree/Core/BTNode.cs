using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BTCore
{
    public enum BTResult
    {
        Running,
        Finish
    }
    abstract public class BTNode {

        private BTPreCondition _condition;
        public BTNode() : this(null) { }
        public BTNode(BTPreCondition preCondition = null)
        {
            _condition = preCondition;
        }

        public bool Evaluate(BTBlackBoard blackBoard)
        {
            return (_condition == null || _condition.ExtraEvaluate(blackBoard)) && DoEvaluate(blackBoard);
        }

        public virtual bool DoEvaluate(BTBlackBoard bloackBoard){   return true;    }

        public virtual BTResult OnTick(BTBlackBoard blackBoard){    return BTResult.Finish; }

        public virtual void Clear() { }

    }
}
