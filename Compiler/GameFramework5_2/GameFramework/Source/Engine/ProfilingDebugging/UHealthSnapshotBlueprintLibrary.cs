#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProfilingDebugging/HealthSnapshot.h")]
public partial class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary {
// HealthSnapshotBlueprintLibrary
	public void StartPerformanceSnapshots() {}
	public void StopPerformanceSnapshots() {}
	public void LogPerformanceSnapshot(string SnapshotTitle,bool bResetStats/*=true*/) {}
}
