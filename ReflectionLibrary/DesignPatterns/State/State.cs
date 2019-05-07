using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.State
{
    public enum State
    {
        OffHook,
        Connecting,
        Connected,
        OnHold
    }

    public enum Trigger
    {
        CallDialied,
        HungUp,
        CallConnected,
        PlaceOnHold,
        TakenOffHold,
        LeftMessage
    }
}
