using System;

namespace LensorRadii.U_Puzel
{
    public interface ILevelConditions
    {
        bool ifLevelConditionsMet { get; set; }
        Action<bool> levelConditionsMet { get; set; }
    }
}