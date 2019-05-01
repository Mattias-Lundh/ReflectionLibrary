using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLibrary.DesignPatterns.Null_Object
{
    public interface ILog
    {
        void Info(string msg);
        void Warn(string msg);
    }
}
