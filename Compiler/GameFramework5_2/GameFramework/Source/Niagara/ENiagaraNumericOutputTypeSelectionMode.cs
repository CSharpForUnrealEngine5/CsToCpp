#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraTypes.h")]
///<summary>Defines different modes for selecting the output numeric type of a function or operation based on the types of the inputs.</summary>
public enum ENiagaraNumericOutputTypeSelectionMode {
	None=0,
	Largest=1,
	Smallest=2,
	Scalar=3,
	Custom=4,
}
