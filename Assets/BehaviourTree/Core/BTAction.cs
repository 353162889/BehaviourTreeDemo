using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTCore
{
    public enum BTActionResult
    {
        Ready,
        Running,
    }
    public class BTAction : BTNode
    {
        public override BTResult OnTick(BTBlackBoard blackBoard)
        {
            return base.OnTick(blackBoard);
        }

        public virtual void OnEnter(BTBlackBoard blackBoard) { }
        public virtual BTActionResult OnRun(BTBlackBoard blackBoard) { return BTActionResult.Running; }
        public virtual void OnExit(BTBlackBoard blackBoard) { }

        public override void Clear()
        {
            base.Clear();
        }
    }
}
