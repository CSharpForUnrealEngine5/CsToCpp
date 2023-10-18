namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Assigns meta data based on modifier class. To every modifier class you can assign meta data.</summary>
[CppInclude("Styling/ClassBasedWidgetStyleDefinitions.h")]
public partial class UClassBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions {
	public static UClass StaticClass() {return default;}
	///<summary>Config</summary>
	public TMap<UClass,FPerModifierClassWidgetSytleData> Config;
	///<summary>Meta data that is not bound to any modifier but just to a simple name.</summary>
	public TMap<FName,FWidgetStyleDataArray> CategoriesWithoutModifier;
}
