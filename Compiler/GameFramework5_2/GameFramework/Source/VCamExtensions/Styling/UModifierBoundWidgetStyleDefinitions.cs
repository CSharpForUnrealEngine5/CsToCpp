#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStyleDefinitions.h")]
///<summary>Associates information with modifiers and their connection points.</summary>
public partial class UModifierBoundWidgetStyleDefinitions : UObject {
// ModifierBoundWidgetStyleDefinitions
	public  TArray<UWidgetStyleData> GetStylesForModifier(UVCamModifier Modifier) { return default; }
	public  TArray<UWidgetStyleData> GetStylesForConnectionPoint(UVCamModifier Modifier,string ConnectionPoint) { return default; }
	public  TArray<UWidgetStyleData> GetStylesForName(string Category) { return default; }
	public  UWidgetStyleData GetStyleForModifierByClass(UVCamModifier Modifier,UClass Class) { return default; }
	public  UWidgetStyleData GetStyleForConnectionPointByClass(UVCamModifier Modifier,string ConnectionPoint,UClass Class) { return default; }
	public  UWidgetStyleData GetStyleForNameByClass(string Category,UClass Class) { return default; }
}
