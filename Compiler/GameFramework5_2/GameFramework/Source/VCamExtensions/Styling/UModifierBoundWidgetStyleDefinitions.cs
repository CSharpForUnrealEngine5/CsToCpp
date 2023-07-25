#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStyleDefinitions.h")]
///<summary>Associates information with modifiers and their connection points.</summary>
public partial class UModifierBoundWidgetStyleDefinitions : UObject {
// ModifierBoundWidgetStyleDefinitions
	public TArray<UObject> GetStylesForModifier(UObject Modifier) { return default; }
	public TArray<UObject> GetStylesForConnectionPoint(UObject Modifier,string ConnectionPoint) { return default; }
	public TArray<UObject> GetStylesForName(string Category) { return default; }
	public UObject GetStyleForModifierByClass(UObject Modifier,UClass Class) { return default; }
	public UObject GetStyleForConnectionPointByClass(UObject Modifier,string ConnectionPoint,UClass Class) { return default; }
	public UObject GetStyleForNameByClass(string Category,UClass Class) { return default; }
}
