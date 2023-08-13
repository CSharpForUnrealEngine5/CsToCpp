namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings that identify the names of custom attributes that represent the individual components of a timecode and a subframe along with a take name.</summary>
[CppInclude("Animation/CustomAttributes.h")]
public partial struct FTimecodeCustomAttributeNameSettings {
	public string HourAttributeName;
	public string MinuteAttributeName;
	public string SecondAttributeName;
	public string FrameAttributeName;
	public string SubframeAttributeName;
	public string RateAttributeName;
	public string TakenameAttributeName;
}
