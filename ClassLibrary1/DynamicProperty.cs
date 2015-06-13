// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.DynamicProperty
// Assembly: FlightBoard.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00E69042-272F-4CC6-8791-14EADF11FA6E
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Core.dll

using System;

namespace System.Linq.Dynamic
{
    public class DynamicProperty
    {
        private string name;
        private Type type;

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public Type Type
        {
            get
            {
                return this.type;
            }
        }

        public DynamicProperty(string name, Type type)
        {
            if (name == null)
                throw new ArgumentNullException("name");
            if (type == (Type)null)
                throw new ArgumentNullException("type");
            this.name = name;
            this.type = type;
        }
    }
}
