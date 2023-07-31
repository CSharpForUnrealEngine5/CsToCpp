#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Associates information with modifiers and their connection points.</summary>
[CppInclude("Styling/ModifierBoundWidgetStyleDefinitions.h")]
public partial class UModifierBoundWidgetStyleDefinitions : UObject {
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
	public  UWidgetStyleData GetStyleForNameByClass(string Category,UClass Class) { return default; }
}
