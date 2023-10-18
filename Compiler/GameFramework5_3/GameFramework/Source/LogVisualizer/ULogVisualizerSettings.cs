namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSettings.h")]
public partial class ULogVisualizerSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether to show trivial logs, i.e. the ones with only one entry.</summary>
	public bool bIgnoreTrivialLogs;
	///<summary>Threshold for trivial Logs</summary>
	public int TrivialLogsThreshold;
	///<summary>Whether to show the recent data or not. Property disabled for now.</summary>
	public bool bStickToRecentData;
	///<summary>Whether to reset current data or not for each new session.</summary>
	public bool bResetDataWithNewSession;
	///<summary>Whether to show histogram labels inside graph or outside. Property disabled for now.</summary>
	public bool bShowHistogramLabelsOutside;
	///<summary>Camera distance used to setup location during reaction on log item double click</summary>
	public float DefaultCameraDistance;
	///<summary>Whether to search/filter categories or to get text vlogs into account too</summary>
	public bool bSearchInsideLogs;
	///<summary>Whether to only show events occuring within one of visual logger filter volumes currently in the level</summary>
	public bool bUseFilterVolumes;
	///<summary>Background color for 2d graphs visualization</summary>
	public FColor GraphsBackgroundColor;
	///<summary>Whether to store all filter settings on exit</summary>
	public bool bPersistentFilters;
	///<summary>Whether to extreme values on graph (data has to be provided for extreme values)</summary>
	public bool bDrawExtremesOnGraphs;
	///<summary>Graphs will be scaled around local Min/Max values (values being displayed) rather than all historic data</summary>
	public bool bConstrainGraphToLocalMinMax;
	///<summary>Whether to use PlayersOnly during Pause or not</summary>
	public bool bUsePlayersOnlyForPause;
	///<summary>Whether to dump Navigation Octree on Stop recording or not</summary>
	public bool bLogNavOctreeOnStop;
	///<summary>controls how we generate log names. When set to TRUE there&#39;s a lot lower</summary>
	public bool bForceUniqueLogNames;
	///<summary>PersistentFilters</summary>
	public FVisualLoggerFiltersData PersistentFilters;
	///<summary>A material used to render debug meshes with kind of flat shading, mostly used by Visual Logger tool.</summary>
	public UMaterial DebugMeshMaterialFakeLight;
	///<summary>@todo document</summary>
	public string DebugMeshMaterialFakeLightName;
}
