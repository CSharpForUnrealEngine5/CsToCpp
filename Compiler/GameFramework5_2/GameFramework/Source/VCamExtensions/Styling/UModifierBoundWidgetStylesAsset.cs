#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStylesAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierBoundWidgetStylesAsset : UObject {
// ModifierBoundWidgetStylesAsset
	public UModifierBoundWidgetStyleDefinitions Rules;
	public TArray<UObject> GetStylesForModifier(UObject Modifier) { return default; }
	public TArray<UObject> GetStylesForConnectionPoint(UObject Modifier,string ConnectionPoint) { return default; }
	public TArray<UObject> GetStylesForName(string Category) { return default; }
	public UObject GetStyleForModifierByClass(UObject Modifier,UClass Class) { return default; }
	public UObject GetStyleForConnectionPointByClass(UObject Modifier,string ConnectionPoint,UClass Class) { return default; }
	public UObject GetStyleForNameByClass(string Name,UClass Class) { return default; }
}
