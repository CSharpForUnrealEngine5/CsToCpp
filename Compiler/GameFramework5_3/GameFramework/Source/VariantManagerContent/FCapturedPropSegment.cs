namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Describes one link in a full property path</summary>
[CppInclude("PropertyValue.h")]
public partial struct FCapturedPropSegment {
	public string PropertyName;
	public int PropertyIndex;
	public string ComponentName;
}
