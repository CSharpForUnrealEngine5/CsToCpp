#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Any constant/folded class data an anim node can be accessed via this struct</summary>
[CppInclude("Animation/AnimNodeData.h")]
public partial struct FAnimNodeData {
	public object /*AnimClassInterface*/ AnimClassInterface;
	public TArray<uint> Entries;
	public int NodeIndex;
	public uint Flags;
}
