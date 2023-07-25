#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Styling/TargetBasedWidgetStyleDefinitions.h")]
public partial class UTargetBasedWidgetStyleDefinitions : UModifierBoundWidgetStyleDefinitions {
// TargetBasedWidgetStyleDefinitions
	public TMap<string,FTargettedModifierStyleConfig> ModifierToStyle;
	public TMap<string,FWidgetStyleDataArray> CategoriesWithoutModifier;
}
