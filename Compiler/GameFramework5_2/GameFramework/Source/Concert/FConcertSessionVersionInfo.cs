#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ConcertVersion.h")]
///<summary>Holds version information for a session</summary>
public partial struct FConcertSessionVersionInfo {
// ConcertSessionVersionInfo
	public FConcertFileVersionInfo FileVersion;
	public FConcertEngineVersionInfo EngineVersion;
	public TArray<FConcertCustomVersionInfo> CustomVersions;
}
