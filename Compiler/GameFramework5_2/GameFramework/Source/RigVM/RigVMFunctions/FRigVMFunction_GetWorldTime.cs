#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RigVMFunctions/Animation/RigVMFunction_GetWorldTime.h")]
///<summary>Returns the current time (year, month, day, hour, minute)</summary>
public partial struct FRigVMFunction_GetWorldTime {
// RigVMFunction_GetWorldTime
	public float Year;
	public float Month;
	public float Day;
	public float WeekDay;
	public float Hours;
	public float Minutes;
	public float Seconds;
	public float OverallSeconds;
}
