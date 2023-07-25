#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/EngineTypes.h")]
///<summary>Note: Must match r.ReflectionMethod, this is used in URendererSettings</summary>
[CppEnumInNamespace]
public enum EReflectionMethod {
	None=0,
	Lumen=1,
	ScreenSpace=2,
	RayTraced=3,
}
