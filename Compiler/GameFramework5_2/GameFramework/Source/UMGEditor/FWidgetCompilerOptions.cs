#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
public partial struct FWidgetCompilerOptions {
	public bool bAllowBlueprintTick;
	public bool bAllowBlueprintPaint;
	public EPropertyBindingPermissionLevel PropertyBindingRule;
	public TArray<TSoftObjectPtr<UClass>> Rules;
}
