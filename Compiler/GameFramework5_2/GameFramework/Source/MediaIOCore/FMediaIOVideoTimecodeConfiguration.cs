namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Configuration of a Timecode from Video</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOVideoTimecodeConfiguration {
	public FMediaIOConfiguration MediaConfiguration;
	public EMediaIOAutoDetectableTimecodeFormat TimecodeFormat;
}
