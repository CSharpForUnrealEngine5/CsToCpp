namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A result of an intersection found during a hit-test.</summary>
[CppInclude("ARTraceResult.h")]
public partial struct FARTraceResult {
	public float DistanceFromCamera;
	public EARLineTraceChannels TraceChannel;
	public FTransform LocalTransform;
	public UARTrackedGeometry TrackedGeometry;
}
