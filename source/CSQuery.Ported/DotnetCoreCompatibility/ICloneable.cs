using System.Runtime.InteropServices;

namespace CSQuery.Ported.DotnetCoreCompatibility
{
    [ComVisible(true)]
    public interface ICloneable
    {
        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// 
        /// <returns>
        /// A new object that is a copy of this instance.
        /// </returns>
        /// <filterpriority>2</filterpriority>
        object Clone();
    }
}
