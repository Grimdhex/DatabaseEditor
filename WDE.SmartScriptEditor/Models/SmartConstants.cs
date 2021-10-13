﻿namespace WDE.SmartScriptEditor.Models
{
    // this is bad we use hardcoded constants here :/
    public static class SmartConstants
    {
        public const int SourceNone = 0;
        public const int SourceSelf = 1;
        public const int SourceStoredObject = 12;
        public const int TargetNone = 0;
        public const int TargetSelf = 1;
        public const int ActionNone = 0;
        public const int ActionCallTimedActionList = 80;
        public const int ActionCallRandomTimedActionList = 87;
        public const int ActionCallRandomRangeTimedActionList = 88;
        public const int ActionComment = 9998;
        public const int EventTriggerTimed = 59;
        public const int EventAiInitialize = 37;
        public const int EventUpdateInCombat = 0;
        public const int EventWaypointsEnded = 58;
        public const int EventLink = 61;
        public const int ActionStartWaypointsPath = 53;
        public const int ActionCreateTimed = 67;
        public const int ActionTriggerTimed = 73;
        public const int ActionRemoveTimed = 74;
        public const int ActionTriggerRandomTimed = 125;
        public const int ActionWait = 9999;
        public const int ActionAfter = 9996;
        public const int ActionAfterMovement = 9995;
        public const int ActionBeginInlineActionList = 9997;
        public const string CommentInlineActionList = "-inline";
        public const string CommentInlineMovementActionList = "-inline_wp";
        public const string CommentWait = "-meta_wait";
        public const string CommentComment = "-meta_comment";
        public const int ConditionSourceSmartScript = 22;
        public const int ConditionOr = -1;
    }
}