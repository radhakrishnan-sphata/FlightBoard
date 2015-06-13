// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.Signature
// Assembly: FlightBoard.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 00E69042-272F-4CC6-8791-14EADF11FA6E
// Assembly location: C:\Users\radhakrishnan\Desktop\Flight Board\FlightBoard.Core.dll

using System;
using System.Collections.Generic;
using System.Linq;

namespace System.Linq.Dynamic
{
    internal class Signature : IEquatable<Signature>
    {
        public DynamicProperty[] properties;
        public int hashCode;

        public Signature(IEnumerable<DynamicProperty> properties)
        {
            this.properties = Enumerable.ToArray<DynamicProperty>(properties);
            this.hashCode = 0;
            foreach (DynamicProperty dynamicProperty in properties)
                this.hashCode ^= dynamicProperty.Name.GetHashCode() ^ dynamicProperty.Type.GetHashCode();
        }

        public override int GetHashCode()
        {
            return this.hashCode;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Signature))
                return false;
            return this.Equals((Signature)obj);
        }

        public bool Equals(Signature other)
        {
            if (this.properties.Length != other.properties.Length)
                return false;
            for (int index = 0; index < this.properties.Length; ++index)
            {
                if (this.properties[index].Name != other.properties[index].Name || this.properties[index].Type != other.properties[index].Type)
                    return false;
            }
            return true;
        }
    }
}
