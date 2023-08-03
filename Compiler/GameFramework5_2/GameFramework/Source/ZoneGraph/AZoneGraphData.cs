#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphData.h")]
public partial class AZoneGraphData : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>if set to true then this zone graph data will be drawing itself when requested as part of &quot;show navigation&quot;</summary>
	public bool bEnableDrawing;
	///<summary>RenderingComp</summary>
	public UZoneGraphRenderingComponent RenderingComp;
	///<summary>ZoneStorage</summary>
	public FZoneGraphStorage ZoneStorage;
	///<summary>Combined hash of all ZoneShapes that were used to build the data.</summary>
	public uint CombinedShapeHash;
}
