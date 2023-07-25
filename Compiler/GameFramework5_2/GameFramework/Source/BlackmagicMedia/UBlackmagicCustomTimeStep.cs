#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BlackmagicCustomTimeStep.h")]
///<summary>Control the Engine TimeStep via the Blackmagic Design card.</summary>
public partial class UBlackmagicCustomTimeStep : UGenlockedCustomTimeStep {
// BlackmagicCustomTimeStep
	public FMediaIOConfiguration MediaConfiguration;
	public bool bEnableOverrunDetection;
}
