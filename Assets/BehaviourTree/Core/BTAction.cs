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
        protected BTActionResult m_eActionResult;
        public BTAction(string name) : base(name)
        {
            m_eActionResult = BTActionResult.Ready;
        }
        sealed public override BTResult OnTick(BTBlackBoard blackBoard)
        {
            if(m_eActionResult == BTActionResult.Ready)
            {
                OnEnter(blackBoard);
                m_eActionResult = BTActionResult.Running;
            }
            m_eActionResult = OnRun(blackBoard);
            if(m_eActionResult == BTActionResult.Ready)
            {
                OnExit(blackBoard);
            }
            if(m_eActionResult == BTActionResult.Running)
            {
                return BTResult.Running;
            }
            return BTResult.Success;
        }

        public virtual void OnEnter(BTBlackBoard blackBoard) { }
        public virtual BTActionResult OnRun(BTBlackBoard blackBoard) { return BTActionResult.Running; }
        public virtual void OnExit(BTBlackBoard blackBoard) { }

        public override void Clear()
        {
            m_eActionResult = BTActionResult.Ready;
        }
    }
}
