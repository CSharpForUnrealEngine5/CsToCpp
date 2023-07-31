#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
public enum EPropertyAccessCopyType {
	None=0,
	Plain=1,
	Complex=2,
	Bool=3,
	Struct=4,
	Object=5,
	Name=6,
	Array=7,
	PromoteBoolToByte=8,
	PromoteBoolToInt32=9,
	PromoteBoolToInt64=10,
	PromoteBoolToFloat=11,
	PromoteBoolToDouble=12,
	PromoteByteToInt32=13,
	PromoteByteToInt64=14,
	PromoteByteToFloat=15,
	PromoteByteToDouble=16,
	PromoteInt32ToInt64=17,
	PromoteInt32ToFloat=18,
	PromoteInt32ToDouble=19,
	PromoteFloatToDouble=20,
	DemoteDoubleToFloat=21,
	PromoteArrayFloatToDouble=22,
	DemoteArrayDoubleToFloat=23,
	PromoteMapValueFloatToDouble=24,
	DemoteMapValueDoubleToFloat=25,
}
