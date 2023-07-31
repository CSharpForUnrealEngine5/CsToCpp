#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Identifies a media mode.</summary>
[CppInclude("MediaIOCoreDefinitions.h")]
public partial struct FMediaIOMode {
	public FFrameRate FrameRate;
	public FIntPoint Resolution;
	public EMediaIOStandardType Standard;
	public int DeviceModeIdentifier;
}
