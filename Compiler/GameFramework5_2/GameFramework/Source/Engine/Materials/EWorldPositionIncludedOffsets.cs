#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Materials/MaterialExpressionWorldPosition.h")]
///<summary>Specifies which shader generated offsets should included in the world position (displacement/WPO etc.)</summary>
public enum EWorldPositionIncludedOffsets {
	WPT_Default=0,
	WPT_ExcludeAllShaderOffsets=1,
	WPT_CameraRelative=2,
	WPT_CameraRelativeNoOffsets=3,
	WPT_MAX=4,
}
