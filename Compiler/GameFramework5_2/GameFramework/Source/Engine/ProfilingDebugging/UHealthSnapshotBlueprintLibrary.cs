#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProfilingDebugging/HealthSnapshot.h")]
public partial class UHealthSnapshotBlueprintLibrary : UBlueprintFunctionLibrary {
// HealthSnapshotBlueprintLibrary
	public static void StartPerformanceSnapshots() {}
	public static void StopPerformanceSnapshots() {}
	public static void LogPerformanceSnapshot(string SnapshotTitle,bool bResetStats/*=true*/) {}
}
