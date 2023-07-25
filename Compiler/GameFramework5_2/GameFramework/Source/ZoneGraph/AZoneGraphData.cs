#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphData.h")]
public partial class AZoneGraphData : AActor {
// ZoneGraphData
	public bool bEnableDrawing;
	public UZoneGraphRenderingComponent RenderingComp;
	public FZoneGraphStorage ZoneStorage;
	public uint CombinedShapeHash;
}
