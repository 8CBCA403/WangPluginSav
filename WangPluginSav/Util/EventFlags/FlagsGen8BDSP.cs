﻿using PKHeX.Core;
namespace WangPluginSav.Util.EventFlags
{
    internal class FlagsGen8BDSP : FlagsOrganizer
    {
        static string? s_flagsList_res = null;

        BattleTrainerStatus8b? m_battleTrainerStatus;
        FlagWork8b? m_flagWork;

        const int Src_EventFlags = 0;
        const int Src_SysFlags = 1;
        const int Src_TrainerFlags = 2;

        protected override void InitFlagsData(SaveFile savFile, string? resData)
        {
            m_savFile = savFile;
            m_battleTrainerStatus = ((SAV8BS)m_savFile).BattleTrainer;
            m_flagWork = ((SAV8BS)m_savFile).FlagWork;

#if DEBUG
            // Force refresh
            s_flagsList_res = null;
#endif

            s_flagsList_res = resData ?? s_flagsList_res ?? ReadFlagsResFile("flags_gen8bdsp");

            int idxEventFlagsSection = s_flagsList_res.IndexOf("//\tEvent Flags");
            int idxSysFlagsSection = s_flagsList_res.IndexOf("//\tSys Flags");
            int idxTrainerFlagsSection = s_flagsList_res.IndexOf("//\tTrainer Flags");
            int idxEventWorkSection = s_flagsList_res.IndexOf("//\tEvent Work");

            var sysFlagsVals = new bool[m_flagWork.CountSystem];
            for (int i = 0; i < sysFlagsVals.Length; i++)
            {
                sysFlagsVals[i] = m_flagWork.GetSystemFlag(i);
            }

            var battleTrainerVals = new bool[707];
            for (int i = 0; i < battleTrainerVals.Length; i++)
            {
                battleTrainerVals[i] = m_battleTrainerStatus.GetIsWin(i);
            }

            bool[] eventFlags = ((IEventFlagArray)m_savFile!).GetEventFlags();

            AssembleList(s_flagsList_res[idxEventFlagsSection..], Src_EventFlags, "Event Flags", eventFlags);
            AssembleList(s_flagsList_res[idxSysFlagsSection..], Src_SysFlags, "Sys Flags", sysFlagsVals);
            AssembleList(s_flagsList_res[idxTrainerFlagsSection..], Src_TrainerFlags, "Trainer Flags", battleTrainerVals);

            AssembleWorkList(s_flagsList_res[idxEventWorkSection..], ((IEventWorkArray<int>)m_savFile).GetAllEventWork());
        }

        public override bool SupportsBulkEditingFlags(EventFlagType flagType) => flagType switch
        {
#if DEBUG
            EventFlagType.FieldItem or
            EventFlagType.HiddenItem or
            EventFlagType.TrainerBattle
                => true,
#endif
            _ => false
        };

        public override void BulkMarkFlags(EventFlagType flagType)
        {
            ChangeFlagsVal(flagType, value: true);
        }

        public override void BulkUnmarkFlags(EventFlagType flagType)
        {
            ChangeFlagsVal(flagType, value: false);
        }

        void ChangeFlagsVal(EventFlagType flagType, bool value)
        {
            if (SupportsBulkEditingFlags(flagType))
            {
                foreach (var f in m_flagsGroupsList[0].Flags)
                {
                    if (f.FlagTypeVal == flagType)
                    {
                        int idx = (int)f.FlagIdx;

                        f.IsSet = value;

                        switch (f.SourceIdx)
                        {
                            case Src_EventFlags:
                                m_flagWork!.SetFlag(idx, value);
                                break;

                            case Src_SysFlags:
                                m_flagWork!.SetSystemFlag(idx, value);
                                break;

                            case Src_TrainerFlags:
                                m_battleTrainerStatus!.SetIsWin(idx, value);
                                break;
                        }
                    }
                }
            }
        }

        public override void SyncEditedFlags(FlagsGroup fGroup)
        {
            switch (fGroup.SourceIdx)
            {
                case Src_EventFlags:
                    foreach (var f in fGroup.Flags)
                    {
                        m_flagWork!.SetFlag((int)f.FlagIdx, f.IsSet);
                    }
                    break;

                case Src_SysFlags:
                    foreach (var f in fGroup.Flags)
                    {
                        m_flagWork!.SetSystemFlag((int)f.FlagIdx, f.IsSet);
                    }
                    break;

                case Src_TrainerFlags:
                    foreach (var f in fGroup.Flags)
                    {
                        m_battleTrainerStatus!.SetIsWin((int)f.FlagIdx, f.IsSet);
                    }
                    break;
            }
        }

        public override void SyncEditedEventWork()
        {
            var eventWorkHelper = (IEventWorkArray<int>)m_savFile!;

            foreach (var w in m_eventWorkList)
            {
                eventWorkHelper.SetWork((int)w.WorkIdx, (int)w.Value);
            }
        }
    }
}
