#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Ends an existing profiling timer for debugging, used in conjunction with Start Profiling Timer</summary>
[CppInclude("Units/Debug/RigUnit_ProfilingBracket.h")]
public partial struct FRigUnit_EndProfilingTimer {
	public int NumberOfMeasurements;
	public string Prefix;
	public float AccumulatedTime;
	public int MeasurementsLeft;
	public bool bIsInitialized;
}
