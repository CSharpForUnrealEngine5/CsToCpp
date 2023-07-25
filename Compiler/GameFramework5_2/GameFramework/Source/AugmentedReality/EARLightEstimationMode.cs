#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARSessionConfig.h")]
///<summary>Options for how light is estimated based on the camera capture. This feature is used by ARCore and ARKit.</summary>
public enum EARLightEstimationMode {
	None=0,
	AmbientLightEstimate=1,
	DirectionalLightEstimate=2,
}
