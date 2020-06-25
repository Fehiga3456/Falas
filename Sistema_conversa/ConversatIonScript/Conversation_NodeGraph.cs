using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XNode;

[CreateAssetMenu]
public class Conversation_NodeGraph : NodeGraph { 
	public StartNode GetStartingNode()
    {
        return (StartNode)this.nodes.Find(n => n.name == "Start");
    }
}