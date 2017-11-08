using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BTCore
{
    public enum BTResult
    {
        Success,
        Running,
        Failure,
    }
    abstract public class BTNode {

        protected string m_sNodeName;
        public string nodeName {
            get { return m_sNodeName; }
        }
        public BTNode(string name) {
            m_sNodeName = name;
            if(string.IsNullOrEmpty(m_sNodeName))
            {
                m_sNodeName = GetType().ToString();
            }
        }

        public BTNode():this(null) {
          
        }

        public virtual BTResult OnTick(BTBlackBoard blackBoard){    return BTResult.Success; }

        public virtual void Clear() { }

    }
}
