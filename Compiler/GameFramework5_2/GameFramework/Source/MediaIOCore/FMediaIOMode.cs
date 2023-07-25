#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MediaIOCoreDefinitions.h")]
///<summary>Identifies a media mode.</summary>
public partial struct FMediaIOMode {
// MediaIOMode
	public FFrameRate FrameRate;
	public FIntPoint Resolution;
	public EMediaIOStandardType Standard;
	public int DeviceModeIdentifier;
}
