#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds version information for a session</summary>
[CppInclude("Data/SnapshotVersion.h")]
public partial struct FSnapshotVersionInfo {
	public FSnapshotFileVersionInfo FileVersion;
	public FSnapshotEngineVersionInfo EngineVersion;
	public TArray<FSnapshotCustomVersionInfo> CustomVersions;
}
