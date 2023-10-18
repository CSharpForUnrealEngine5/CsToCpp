namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset intended to be referenced by Slate widgets.</summary>
[CppInclude("Styling/ModifierBoundWidgetStylesAsset.h")]
public partial class UModifierBoundWidgetStylesAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Rules</summary>
	public UModifierBoundWidgetStyleDefinitions Rules;
	///<summary>Retrieves all meta data that is associated for a given modifier.</summary>
	public TArray<UWidgetStyleData> GetStylesForModifier(UVCamModifier Modifier) { return default; }
	///<summary>Retrieves all meta data that is associated for a given modifier and a sub-category name.</summary>
	public TArray<UWidgetStyleData> GetStylesForConnectionPoint(UVCamModifier Modifier,FName ConnectionPoint) { return default; }
	///<summary>Retrieves all meta data that is associated with a given a category name; this data is not associated with any kind of modifier.</summary>
	public TArray<UWidgetStyleData> GetStylesForName(FName Category) { return default; }
	///<summary>GetStyleForModifierByClass</summary>
	public UWidgetStyleData GetStyleForModifierByClass(UVCamModifier Modifier,UClass Class) { return default; }
	///<summary>GetStyleForConnectionPointByClass</summary>
	public UWidgetStyleData GetStyleForConnectionPointByClass(UVCamModifier Modifier,FName ConnectionPoint,UClass Class) { return default; }
	///<summary>GetStyleForNameByClass</summary>
	public UWidgetStyleData GetStyleForNameByClass(FName Name,UClass Class) { return default; }
}
