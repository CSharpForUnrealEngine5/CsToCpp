#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a Timecode from Video</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOVideoTimecodeConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOAutoDetectableTimecodeFormat TimecodeFormat;
}
