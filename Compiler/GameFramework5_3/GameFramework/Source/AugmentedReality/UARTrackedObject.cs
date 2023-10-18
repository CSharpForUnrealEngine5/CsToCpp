namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARTrackedObject : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>See: DetectedObject</summary>
	public UARCandidateObject GetDetectedObject() { return default; }
	///<summary>The candidate object that was detected in the scene</summary>
	public UARCandidateObject DetectedObject;
}
