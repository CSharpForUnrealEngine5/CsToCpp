#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Units/Debug/RigUnit_ProfilingBracket.h")]
///<summary>Ends an existing profiling timer for debugging, used in conjunction with Start Profiling Timer</summary>
public partial struct FRigUnit_EndProfilingTimer {
// RigUnit_EndProfilingTimer
	public int NumberOfMeasurements;
	public string Prefix;
	public float AccumulatedTime;
	public int MeasurementsLeft;
	public bool bIsInitialized;
}
