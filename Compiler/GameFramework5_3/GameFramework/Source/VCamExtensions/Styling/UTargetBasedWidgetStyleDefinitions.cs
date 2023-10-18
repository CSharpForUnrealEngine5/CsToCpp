namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/TargetBasedWidgetStyleDefinitions.h")]
public partial class UTargetBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions {
	public static UClass StaticClass() {return default;}
	///<summary>Key: Name of a modifier in a VCam&#39;s stack entry.</summary>
	public TMap<FName,FTargettedModifierStyleConfig> ModifierToStyle;
	///<summary>Styles that is not bound to any modifier but just to a name.</summary>
	public TMap<FName,FWidgetStyleDataArray> CategoriesWithoutModifier;
}
