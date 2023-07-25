#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Modifier/ModifierStackEntry.h")]
///<summary>Links a Modifier with a Name for use in a Modifier Stack</summary>
public partial struct FModifierStackEntry {
// ModifierStackEntry
	public string Name;
	public bool bEnabled;
	public UVCamModifier GeneratedModifier;
}
