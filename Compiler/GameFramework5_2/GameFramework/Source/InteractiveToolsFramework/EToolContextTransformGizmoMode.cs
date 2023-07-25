#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ToolContextInterfaces.h")]
///<summary>High-level configuration options for a standard 3D translate/rotate/scale Gizmo, like is commonly used in 3D DCC tools, game editors, etc</summary>
public enum EToolContextTransformGizmoMode {
	NoGizmo=0,
	Translation=1,
	Rotation=2,
	Scale=3,
	Combined=8,
}
