#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedObject : UARTrackedGeometry {
	///<summary>See: DetectedObject</summary>
	public  UARCandidateObject GetDetectedObject() { return default; }
	///<summary>The candidate object that was detected in the scene</summary>
	public UARCandidateObject DetectedObject;
}
