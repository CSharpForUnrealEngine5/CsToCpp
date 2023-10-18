namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Links a Modifier with a Name for use in a Modifier Stack</summary>
[CppInclude("Modifier/ModifierStackEntry.h")]
public partial struct FModifierStackEntry {
	public FName Name;
	public bool bEnabled;
	public UVCamModifier GeneratedModifier;
}
