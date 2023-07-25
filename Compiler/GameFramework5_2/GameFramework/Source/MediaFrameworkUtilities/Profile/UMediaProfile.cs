#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Profile/MediaProfile.h")]
///<summary>A media profile that configures the inputs, outputs, timecode provider and custom time step.</summary>
public partial class UMediaProfile : UObject {
// MediaProfile
	public TArray<UMediaSource> MediaSources;
	public TArray<UMediaOutput> MediaOutputs;
	public bool bOverrideTimecodeProvider;
	public UTimecodeProvider TimecodeProvider;
	public bool bOverrideCustomTimeStep;
	public UEngineCustomTimeStep CustomTimeStep;
	public UTimecodeProvider AppliedTimecodeProvider;
	public UTimecodeProvider PreviousTimecodeProvider;
	public UEngineCustomTimeStep AppliedCustomTimeStep;
	public UEngineCustomTimeStep PreviousCustomTimeStep;
}
