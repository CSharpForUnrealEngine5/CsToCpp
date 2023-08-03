#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the Engine TimeStep via the AJA card.</summary>
[CppInclude("AjaCustomTimeStep.h")]
public partial class UAjaCustomTimeStep : UGenlockedCustomTimeStep {
	public static UClass StaticClass() {return default;}
	///<summary>If true, the Engine will wait for a signal coming in from the Reference In pin.</summary>
	public bool bUseReferenceIn;
	///<summary>The device, port and video settings that correspond to where the Genlock signal will be coming from</summary>
	public FMediaIOConfiguration MediaConfiguration;
	///<summary>If true, the Engine will wait for the frame to be read.</summary>
	public bool bWaitForFrameToBeReady;
	///<summary>The type of Timecode to read from SDI stream.</summary>
	public EMediaIOTimecodeFormat TimecodeFormat;
	///<summary>Enable mechanism to detect Engine loop overrunning the source</summary>
	public bool bEnableOverrunDetection;
	///<summary>Engine used to initialize the CustomTimeStep</summary>
	public UEngine InitializedEngine;
}
