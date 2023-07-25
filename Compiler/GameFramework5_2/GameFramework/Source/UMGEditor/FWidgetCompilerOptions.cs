#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
public partial struct FWidgetCompilerOptions {
// WidgetCompilerOptions
	public bool bAllowBlueprintTick;
	public bool bAllowBlueprintPaint;
	public EPropertyBindingPermissionLevel PropertyBindingRule;
	public TArray<TSoftObjectPtr<UClass>> Rules;
}
