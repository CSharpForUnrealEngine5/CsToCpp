#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Control the Engine TimeStep via the Blackmagic Design card.</summary>
[CppInclude("BlackmagicCustomTimeStep.h")]
public partial class UBlackmagicCustomTimeStep : UGenlockedCustomTimeStep {
	public static UClass StaticClass() {return default;}
	///<summary>The device, port and video settings that correspond to where the Genlock signal will be coming from</summary>
	public FMediaIOConfiguration MediaConfiguration;
	///<summary>Enable mechanism to detect Engine loop overrunning the source</summary>
	public bool bEnableOverrunDetection;
}
