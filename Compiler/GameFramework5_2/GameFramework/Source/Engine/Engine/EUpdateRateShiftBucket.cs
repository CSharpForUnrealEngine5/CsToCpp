#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enum for controlling buckets for update rate optimizations if we need to stagger</summary>
public enum EUpdateRateShiftBucket {
	ShiftBucket0=0,
	ShiftBucket1=1,
	ShiftBucket2=2,
	ShiftBucket3=3,
	ShiftBucket4=4,
	ShiftBucket5=5,
	ShiftBucketMax=6,
}
