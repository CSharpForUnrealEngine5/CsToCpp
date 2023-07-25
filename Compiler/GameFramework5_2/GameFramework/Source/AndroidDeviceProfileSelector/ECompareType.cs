#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AndroidDeviceProfileMatchingRules.h")]
public enum ECompareType {
	CMP_Equal=0,
	CMP_Less=1,
	CMP_LessEqual=2,
	CMP_Greater=3,
	CMP_GreaterEqual=4,
	CMP_NotEqual=5,
	CMP_Regex=6,
	CMP_EqualIgnore=7,
	CMP_LessIgnore=8,
	CMP_LessEqualIgnore=9,
	CMP_GreaterIgnore=10,
	CMP_GreaterEqualIgnore=11,
	CMP_NotEqualIgnore=12,
	CMP_Hash=13,
	CMP_MAX=14,
}
