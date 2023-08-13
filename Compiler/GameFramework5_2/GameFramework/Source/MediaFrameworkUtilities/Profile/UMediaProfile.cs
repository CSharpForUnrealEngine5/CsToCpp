namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A media profile that configures the inputs, outputs, timecode provider and custom time step.</summary>
[CppInclude("Profile/MediaProfile.h")]
public partial class UMediaProfile : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Media sources.</summary>
	public TArray<UMediaSource> MediaSources;
	///<summary>Media outputs.</summary>
	public TArray<UMediaOutput> MediaOutputs;
	///<summary>Override the Engine&#39;s Timecode provider defined in the project settings.</summary>
	public bool bOverrideTimecodeProvider;
	///<summary>Timecode provider.</summary>
	public UTimecodeProvider TimecodeProvider;
	///<summary>Override the Engine&#39;s Custom time step defined in the project settings.</summary>
	public bool bOverrideCustomTimeStep;
	///<summary>Custom time step</summary>
	public UEngineCustomTimeStep CustomTimeStep;
	///<summary>AppliedTimecodeProvider</summary>
	public UTimecodeProvider AppliedTimecodeProvider;
	///<summary>PreviousTimecodeProvider</summary>
	public UTimecodeProvider PreviousTimecodeProvider;
	///<summary>AppliedCustomTimeStep</summary>
	public UEngineCustomTimeStep AppliedCustomTimeStep;
	///<summary>PreviousCustomTimeStep</summary>
	public UEngineCustomTimeStep PreviousCustomTimeStep;
}
