#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphBVTree.h")]
///<summary>Quantized BV-Tree</summary>
public partial struct FZoneGraphBVTree {
// ZoneGraphBVTree
	public FVector Origin;
	public float QuantizationScale;
	public TArray<FZoneGraphBVNode> Nodes;
}
