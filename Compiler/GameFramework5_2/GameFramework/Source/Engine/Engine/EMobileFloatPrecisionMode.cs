#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/RendererSettings.h")]
///<summary>The default float precision for material&#39;s pixel shaders on mobile devices</summary>
[CppEnumInNamespace]
public enum EMobileFloatPrecisionMode {
	Half=0,
	Full_MaterialExpressionOnly=1,
	Full=2,
}
