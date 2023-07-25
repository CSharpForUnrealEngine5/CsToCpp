#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Enum indicating how each type should respond</summary>
public enum ECollisionResponse {
	ECR_Ignore=0,
	ECR_Overlap=1,
	ECR_Block=2,
	ECR_MAX=3,
}
