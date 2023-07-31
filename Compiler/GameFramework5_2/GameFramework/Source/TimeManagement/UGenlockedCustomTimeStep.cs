#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to control the Engine Timestep from a Genlock signal.</summary>
[CppInclude("GenlockedCustomTimeStep.h")]
public partial class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep {
	///<summary>Whether this custom time step should autodetect the video format if supported.</summary>
	public bool bAutoDetectFormat;
}
