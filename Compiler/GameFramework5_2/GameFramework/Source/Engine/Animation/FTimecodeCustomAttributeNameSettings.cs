namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings that identify the names of custom attributes that represent the individual components of a timecode and a subframe along with a take name.</summary>
[CppInclude("Animation/CustomAttributes.h")]
public partial struct FTimecodeCustomAttributeNameSettings {
	public FName HourAttributeName;
	public FName MinuteAttributeName;
	public FName SecondAttributeName;
	public FName FrameAttributeName;
	public FName SubframeAttributeName;
	public FName RateAttributeName;
	public FName TakenameAttributeName;
}
