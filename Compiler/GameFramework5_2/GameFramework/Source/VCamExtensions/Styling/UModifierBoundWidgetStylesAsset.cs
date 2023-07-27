#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ModifierBoundWidgetStylesAsset.h")]
///<summary>An asset intended to be referenced by Slate widgets.</summary>
public partial class UModifierBoundWidgetStylesAsset : UObject {
// ModifierBoundWidgetStylesAsset
	public UModifierBoundWidgetStyleDefinitions Rules;
	public  TArray<UWidgetStyleData> GetStylesForModifier(UVCamModifier Modifier) { return default; }
	public  TArray<UWidgetStyleData> GetStylesForConnectionPoint(UVCamModifier Modifier,string ConnectionPoint) { return default; }
	public  TArray<UWidgetStyleData> GetStylesForName(string Category) { return default; }
	public  UWidgetStyleData GetStyleForModifierByClass(UVCamModifier Modifier,UClass Class) { return default; }
	public  UWidgetStyleData GetStyleForConnectionPointByClass(UVCamModifier Modifier,string ConnectionPoint,UClass Class) { return default; }
	public  UWidgetStyleData GetStyleForNameByClass(string Name,UClass Class) { return default; }
}
