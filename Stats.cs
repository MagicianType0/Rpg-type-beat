using System;
using UnityEngine;

public class Stats : Life
{
    #region structs
    [Serializable]
    public struct StatBlock
    {
        public string name;
        public int value;
        public int tempValue;
    }
    #endregion
    #region Variables
    public StatBlock[] characterStats = new StatBlock[6];
    #endregion
}
