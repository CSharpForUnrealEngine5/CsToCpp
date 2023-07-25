#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LogVisualizerSettings.h")]
public partial class ULogVisualizerSettings : UObject {
// LogVisualizerSettings
	public bool bIgnoreTrivialLogs;
	public int TrivialLogsThreshold;
	public bool bStickToRecentData;
	public bool bResetDataWithNewSession;
	public bool bShowHistogramLabelsOutside;
	public float DefaultCameraDistance;
	public bool bSearchInsideLogs;
	public bool bUseFilterVolumes;
	public FColor GraphsBackgroundColor;
	public bool bPersistentFilters;
	public bool bDrawExtremesOnGraphs;
	public bool bConstrainGraphToLocalMinMax;
	public bool bUsePlayersOnlyForPause;
	public bool bLogNavOctreeOnStop;
	public bool bForceUniqueLogNames;
	public FVisualLoggerFiltersData PersistentFilters;
	public UMaterial DebugMeshMaterialFakeLight;
	public string DebugMeshMaterialFakeLightName;
}
