#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/CustomAttributes.h")]
///<summary>Settings that identify the names of custom attributes that represent the individual components of a timecode and a subframe along with a take name.</summary>
public partial struct FTimecodeCustomAttributeNameSettings {
// TimecodeCustomAttributeNameSettings
	public string HourAttributeName;
	public string MinuteAttributeName;
	public string SecondAttributeName;
	public string FrameAttributeName;
	public string SubframeAttributeName;
	public string RateAttributeName;
	public string TakenameAttributeName;
}
