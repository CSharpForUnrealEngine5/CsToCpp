#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Quantized BV-Tree</summary>
[CppInclude("ZoneGraphBVTree.h")]
public partial struct FZoneGraphBVTree {
	public FVector Origin;
	public float QuantizationScale;
	public TArray<FZoneGraphBVNode> Nodes;
}
