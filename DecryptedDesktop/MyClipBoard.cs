using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static DecryptedDesktop.MyClipBoard;

namespace DecryptedDesktop
{
    public static class MyClipBoard
    {
        public enum OperationType 
        {
            Cut = 0,
            Copy = 1
        };
        public static CList<FileHead, OperationType> All = new CList<FileHead, OperationType>();
    }

    public class CList<Tkey, TValue> : Dictionary<Tkey, TValue>
    {
        public CList() : base()
        {

        }

        public new void Add(Tkey Key, TValue Value)
        {
            Clear();
            base.Add(Key, Value);
        }

        public new void Remove(Tkey Key)
        {
            base.Remove(Key);
        }

        public void GroupAdd(TValue OT, params Tkey[] FH)
        {
            Clear();
            foreach (Tkey nFH in FH)
            {
                base.Add(nFH, OT);
            }
        }
    }
}
