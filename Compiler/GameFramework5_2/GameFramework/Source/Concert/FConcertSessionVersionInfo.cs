#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Holds version information for a session</summary>
[CppInclude("ConcertVersion.h")]
public partial struct FConcertSessionVersionInfo {
	public FConcertFileVersionInfo FileVersion;
	public FConcertEngineVersionInfo EngineVersion;
	public TArray<FConcertCustomVersionInfo> CustomVersions;
}
