#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NavigationData.h")]
///<summary>Represents abstract Navigation Data (sub-classed as NavMesh, NavGraph, etc)</summary>
public partial class ANavigationData : AActor {
// NavigationData
	public UPrimitiveComponent RenderingComp;
	public FNavDataConfig NavDataConfig;
	public bool bEnableDrawing;
	public bool bForceRebuildOnLoad;
	public bool bAutoDestroyWhenNoNavigation;
	public bool bCanBeMainNavData;
	public bool bCanSpawnOnRebuild;
	public bool bRebuildAtRuntime_DEPRECATED;
	public ERuntimeGenerationType RuntimeGeneration;
	public float ObservedPathsTickInterval;
	public uint DataVersion;
	public TArray<FSupportedAreaData> SupportedAreas;
}
