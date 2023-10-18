namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Class to control the Engine Timestep from a Genlock signal.</summary>
[CppInclude("GenlockedCustomTimeStep.h")]
public partial class UGenlockedCustomTimeStep : UFixedFrameRateCustomTimeStep {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this custom time step should autodetect the video format if supported.</summary>
	public bool bAutoDetectFormat;
}
