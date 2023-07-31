#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset intended to be referenced by Slate widgets.</summary>
[CppInclude("Styling/ModifierBoundWidgetStylesAsset.h")]
public partial class UModifierBoundWidgetStylesAsset : UObject {
	///<summary>Rules</summary>
	public UModifierBoundWidgetStyleDefinitions Rules;
	///<summary>Retrieves all meta data that is associated for a given modifier.</summary>
	public  TArray<UWidgetStyleData> GetStylesForModifier(UVCamModifier Modifier) { return default; }
	///<summary>Retrieves all meta data that is associated for a given modifier and a sub-category name.</summary>
	public  TArray<UWidgetStyleData> GetStylesForConnectionPoint(UVCamModifier Modifier,string ConnectionPoint) { return default; }
	///<summary>Retrieves all meta data that is associated with a given a category name; this data is not associated with any kind of modifier.</summary>
	public  TArray<UWidgetStyleData> GetStylesForName(string Category) { return default; }
	///<summary>GetStyleForModifierByClass</summary>
	public  UWidgetStyleData GetStyleForModifierByClass(UVCamModifier Modifier,UClass Class) { return default; }
	///<summary>GetStyleForConnectionPointByClass</summary>
	public  UWidgetStyleData GetStyleForConnectionPointByClass(UVCamModifier Modifier,string ConnectionPoint,UClass Class) { return default; }
	///<summary>GetStyleForNameByClass</summary>
	public  UWidgetStyleData GetStyleForNameByClass(string Name,UClass Class) { return default; }
}
