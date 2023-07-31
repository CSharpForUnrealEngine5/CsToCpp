#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/PrimitiveComponent.h")]
///<summary>Determines whether a Character can attempt to step up onto a component when they walk in to it.</summary>
public enum ECanBeCharacterBase {
	ECB_No=0,
	ECB_Yes=1,
	ECB_Owner=2,
	ECB_MAX=3,
}
