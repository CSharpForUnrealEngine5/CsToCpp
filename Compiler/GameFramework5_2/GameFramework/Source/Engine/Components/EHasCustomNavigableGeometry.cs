#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PrimitiveComponent.h")]
///<summary>Determines if a primitive component contains custom collision for navigation/AI</summary>
[CppEnumInNamespace]
public enum EHasCustomNavigableGeometry {
	No=0,
	Yes=1,
	EvenIfNotCollidable=2,
	DontExport=3,
}
