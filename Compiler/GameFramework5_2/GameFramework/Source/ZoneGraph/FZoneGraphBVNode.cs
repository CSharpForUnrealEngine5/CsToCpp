#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphBVTree.h")]
///<summary>Quantized BV-tree node.</summary>
public partial struct FZoneGraphBVNode {
// ZoneGraphBVNode
	public ushort MinX;
	public ushort MinY;
	public ushort MinZ;
	public ushort MaxX;
	public ushort MaxY;
	public ushort MaxZ;
	public int Index;
}
