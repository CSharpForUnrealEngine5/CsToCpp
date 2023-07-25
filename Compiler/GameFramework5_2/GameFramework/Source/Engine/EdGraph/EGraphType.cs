#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EdGraph/EdGraphSchema.h")]
///<summary>Distinguishes between different graph types. Graphs can have different properties; for example: functions have one entry point, ubergraphs can have multiples.</summary>
public enum EGraphType {
	GT_Function=0,
	GT_Ubergraph=1,
	GT_Macro=2,
	GT_Animation=3,
	GT_StateMachine=4,
	GT_MAX=5,
}
