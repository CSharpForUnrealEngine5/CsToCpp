#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Links a Modifier with a Name for use in a Modifier Stack</summary>
[CppInclude("Modifier/ModifierStackEntry.h")]
public partial struct FModifierStackEntry {
	public string Name;
	public bool bEnabled;
	public UVCamModifier GeneratedModifier;
}
