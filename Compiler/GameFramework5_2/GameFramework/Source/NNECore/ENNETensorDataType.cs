#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NNECoreTypes.h")]
///<summary>The enum lists all tensor data types used in NNE</summary>
public enum ENNETensorDataType {
	None=0,
	Char=1,
	Boolean=2,
	Half=3,
	Float=4,
	Double=5,
	Int8=6,
	Int16=7,
	Int32=8,
	Int64=9,
	UInt8=10,
	UInt16=11,
	UInt32=12,
	UInt64=13,
	Complex64=14,
	Complex128=15,
	BFloat16=16,
}
