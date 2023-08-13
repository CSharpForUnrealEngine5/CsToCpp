namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A segment of a &#39;property path&#39; used to access an object&#39;s properties from another location</summary>
[CppInclude("PropertyAccess.h")]
public partial struct FPropertyAccessSegment {
	public string Name;
	public UStruct Struct;
	public object Property;
	public UFunction Function;
	public int ArrayIndex;
	public ushort Flags;
}
