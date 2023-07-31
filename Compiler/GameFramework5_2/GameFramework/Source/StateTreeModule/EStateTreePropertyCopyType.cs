#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>Describes how the copy should be performed.</summary>
public enum EStateTreePropertyCopyType {
	None=0,
	CopyPlain=1,
	CopyComplex=2,
	CopyBool=3,
	CopyStruct=4,
	CopyObject=5,
	CopyName=6,
	CopyFixedArray=7,
	StructReference=8,
	PromoteBoolToByte=9,
	PromoteBoolToInt32=10,
	PromoteBoolToUInt32=11,
	PromoteBoolToInt64=12,
	PromoteBoolToFloat=13,
	PromoteBoolToDouble=14,
	PromoteByteToInt32=15,
	PromoteByteToUInt32=16,
	PromoteByteToInt64=17,
	PromoteByteToFloat=18,
	PromoteByteToDouble=19,
	PromoteInt32ToInt64=20,
	PromoteInt32ToFloat=21,
	PromoteInt32ToDouble=22,
	PromoteUInt32ToInt64=23,
	PromoteUInt32ToFloat=24,
	PromoteUInt32ToDouble=25,
	PromoteFloatToInt32=26,
	PromoteFloatToInt64=27,
	PromoteFloatToDouble=28,
	DemoteDoubleToInt32=29,
	DemoteDoubleToInt64=30,
	DemoteDoubleToFloat=31,
}
