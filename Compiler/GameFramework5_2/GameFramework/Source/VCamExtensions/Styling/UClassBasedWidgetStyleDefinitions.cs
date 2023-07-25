#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/ClassBasedWidgetStyleDefinitions.h")]
///<summary>Assigns meta data based on modifier class. To every modifier class you can assign meta data.</summary>
public partial class UClassBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions {
// ClassBasedWidgetStyleDefinitions
	public TMap<UClass,FPerModifierClassWidgetSytleData> Config;
	public TMap<string,FWidgetStyleDataArray> CategoriesWithoutModifier;
}
