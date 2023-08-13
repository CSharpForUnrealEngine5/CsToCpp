namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UStruct version of settings struct used to initialized a clock</summary>
[CppInclude("Sound/QuartzQuantizationUtilities.h")]
public partial struct FQuartzClockSettings {
	public FQuartzTimeSignature TimeSignature;
	public bool bIgnoreLevelChange;
}
