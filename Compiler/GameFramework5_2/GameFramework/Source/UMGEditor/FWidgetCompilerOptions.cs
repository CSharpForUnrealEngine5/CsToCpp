namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
public partial struct FWidgetCompilerOptions {
	public bool bAllowBlueprintTick;
	public bool bAllowBlueprintPaint;
	public EPropertyBindingPermissionLevel PropertyBindingRule;
	public TArray<TSoftObjectPtr<UClass>> Rules;
}
