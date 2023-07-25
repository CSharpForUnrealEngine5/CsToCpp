#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>A segment of a 'property path' used to access an object's properties from another location</summary>
public partial struct FPropertyAccessSegment {
// PropertyAccessSegment
	public string Name;
	public UStruct Struct;
	public object Property;
	public UFunction Function;
	public int ArrayIndex;
	public ushort Flags;
}
