#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTraceResult.h")]
///<summary>A result of an intersection found during a hit-test.</summary>
public partial struct FARTraceResult {
// ARTraceResult
	public float DistanceFromCamera;
	public EARLineTraceChannels TraceChannel;
	public FTransform LocalTransform;
	public UARTrackedGeometry TrackedGeometry;
}
