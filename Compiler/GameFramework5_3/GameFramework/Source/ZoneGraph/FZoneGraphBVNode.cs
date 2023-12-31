namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Quantized BV-tree node.</summary>
[CppInclude("ZoneGraphBVTree.h")]
public partial struct FZoneGraphBVNode {
	public ushort MinX;
	public ushort MinY;
	public ushort MinZ;
	public ushort MaxX;
	public ushort MaxY;
	public ushort MaxZ;
	public int Index;
}
