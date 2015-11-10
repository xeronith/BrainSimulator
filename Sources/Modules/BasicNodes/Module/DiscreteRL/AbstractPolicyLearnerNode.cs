﻿using GoodAI.Core.Nodes;
using GoodAI.Core.Task;
using GoodAI.Core.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodAI.BasicNodes.Harm
{
    /// <summary>
    /// Something that learns a policy what to do (mapping of states to actions).
    /// </summary>
    public abstract class AbstractPolicyLearnerNode : MyWorkingNode
    {
        /// <summary>
        /// Method creates 2D array of max action utilities and max action labels over across selected dimensions.
        /// The values in the memory are automatically scaled into the interval 0,1. Realtime values are multiplied by motivations.
        /// </summary>
        /// <param name="values">array passed by reference for storing utilities of best action</param>
        /// <param name="labelIndexes">array of the same size for best action indexes</param>
        /// <param name="XVarIndex">global index of state variable in the VariableManager</param>
        /// <param name="YVarIndex">the same: y axis</param>
        /// <param name="showRealtimeUtilities">show current utilities (scaled by the current motivation)</param>
        /// <param name="policyNumber">optinal parameter. In case that the agent has more strategies, you can choose which one to read from.</param>
        public abstract void ReadTwoDimensions(ref float[,] values, ref int[,] labelIndexes,
            int XVarIndex, int YVarIndex, bool showRealtimeUtilities = false, int policyNumber = 0);
    }
}
