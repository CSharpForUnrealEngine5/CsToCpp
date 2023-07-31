#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Returns the current time (year, month, day, hour, minute)</summary>
[CppInclude("RigVMFunctions/Animation/RigVMFunction_GetWorldTime.h")]
public partial struct FRigVMFunction_GetWorldTime {
	public float Year;
	public float Month;
	public float Day;
	public float WeekDay;
	public float Hours;
	public float Minutes;
	public float Seconds;
	public float OverallSeconds;
}
