#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AjaTimecodeProvider.h")]
///<summary>Class to fetch a timecode via an AJA card.</summary>
public partial class UAjaTimecodeProvider : UGenlockedTimecodeProvider {
// AjaTimecodeProvider
	public bool bUseDedicatedPin;
	public bool bUseReferenceIn;
	public FAjaMediaTimecodeReference LTCConfiguration;
	public FAjaMediaTimecodeConfiguration VideoConfiguration_DEPRECATED;
	public FMediaIOVideoTimecodeConfiguration TimecodeConfiguration;
	public bool bAutoDetectTimecode;
	public UEngine InitializedEngine;
}
