namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialShared.h")]
public enum ELWCFunctionKind {
	Constructor=0,
	Promote=1,
	Demote=2,
	Add=3,
	Subtract=4,
	Divide=5,
	MultiplyVectorVector=6,
	MultiplyVectorMatrix=7,
	MultiplyMatrixMatrix=8,
	Other=9,
	Max=10,
}
