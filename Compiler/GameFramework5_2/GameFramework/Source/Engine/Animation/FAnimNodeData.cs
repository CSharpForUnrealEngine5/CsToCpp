#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimNodeData.h")]
///<summary>Any constant/folded class data an anim node can be accessed via this struct</summary>
public partial struct FAnimNodeData {
// AnimNodeData
	public object /*AnimClassInterface*/ AnimClassInterface;
	public TArray<uint> Entries;
	public int NodeIndex;
	public uint Flags;
}
