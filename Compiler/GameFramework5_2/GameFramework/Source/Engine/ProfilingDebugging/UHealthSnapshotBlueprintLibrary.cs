#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProfilingDebugging/HealthSnapshot.h")]
public partial class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Begins capturing FPS charts that can be used to include performance data in a HealthSnapshot. If snapshots are already running clears all accumulated performance data</summary>
	public static void StartPerformanceSnapshots() {}
	///<summary>Stops capturing FPS charts only if StartHealthSnapshotChart has first been called. Does nothing if FPS charts are not running. HealthSnapshots captured after this is called will not include performance stats.</summary>
	public static void StopPerformanceSnapshots() {}
	///<summary>Writes a snapshot to the log. Captures memory stats by default. Also captures performance stats if called after StartHealthSnapshotChart and before SopHealthSnapshotChart.</summary>
	public static void LogPerformanceSnapshot(string SnapshotTitle,bool bResetStats/*=true*/) {}
}
