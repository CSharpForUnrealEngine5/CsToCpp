namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents abstract Navigation Data (sub-classed as NavMesh, NavGraph, etc)</summary>
[CppInclude("NavigationData.h")]
public partial class ANavigationData : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>RenderingComp</summary>
	public UPrimitiveComponent RenderingComp;
	///<summary>NavDataConfig</summary>
	public FNavDataConfig NavDataConfig;
	///<summary>if set to true then this navigation data will be drawing itself when requested as part of &quot;show navigation&quot;</summary>
	public bool bEnableDrawing;
	///<summary>By default navigation will skip the first update after being successfully loaded</summary>
	public bool bForceRebuildOnLoad;
	///<summary>Should this instance auto-destroy when there&#39;s no navigation system on</summary>
	public bool bAutoDestroyWhenNoNavigation;
	///<summary>If set, navigation data can act as default one in navigation system&#39;s queries</summary>
	public bool bCanBeMainNavData;
	///<summary>If set, navigation data will be spawned in persistent level during rebuild if actor doesn&#39;t exist</summary>
	public bool bCanSpawnOnRebuild;
	///<summary>If true, the NavMesh can be dynamically rebuilt at runtime.</summary>
	public bool bRebuildAtRuntime_DEPRECATED;
	///<summary>Navigation data runtime generation options</summary>
	public ERuntimeGenerationType RuntimeGeneration;
	///<summary>all observed paths will be processed every ObservedPathsTickInterval seconds</summary>
	public float ObservedPathsTickInterval;
	///<summary>Navigation data versioning.</summary>
	public uint DataVersion;
	///<summary>serialized area class - ID mapping</summary>
	public TArray<FSupportedAreaData> SupportedAreas;
}
