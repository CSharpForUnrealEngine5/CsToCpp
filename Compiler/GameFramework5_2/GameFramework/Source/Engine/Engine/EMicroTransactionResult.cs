#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/MicroTransactionBase.h")]
///<summary>Result of a purchase.</summary>
public enum EMicroTransactionResult {
	MTR_Succeeded=0,
	MTR_Failed=1,
	MTR_Canceled=2,
	MTR_RestoredFromServer=3,
	MTR_MAX=4,
}
