#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Data/SnapshotVersion.h")]
///<summary>Holds version information for a session</summary>
public partial struct FSnapshotVersionInfo {
// SnapshotVersionInfo
	public FSnapshotFileVersionInfo FileVersion;
	public FSnapshotEngineVersionInfo EngineVersion;
	public TArray<FSnapshotCustomVersionInfo> CustomVersions;
}
