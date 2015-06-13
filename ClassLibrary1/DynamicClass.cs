using System.Reflection;
using System.Text;

namespace System.Linq.Dynamic
{
    public abstract class DynamicClass
    {
        public override string ToString()
        {
            PropertyInfo[] properties = this.GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("{");
            for (int index = 0; index < properties.Length; ++index)
            {
                if (index > 0)
                    stringBuilder.Append(", ");
                stringBuilder.Append(properties[index].Name);
                stringBuilder.Append("=");
                stringBuilder.Append(properties[index].GetValue((object)this, (object[])null));
            }
            stringBuilder.Append("}");
            return stringBuilder.ToString();
        }
    }
}
