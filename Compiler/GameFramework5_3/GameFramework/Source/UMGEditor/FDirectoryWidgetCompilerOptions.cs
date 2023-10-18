namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WidgetEditingProjectSettings.h")]
public partial struct FDirectoryWidgetCompilerOptions {
	public FDirectoryPath Directory;
	public TArray<TSoftObjectPtr<UWidgetBlueprint>> IgnoredWidgets;
	public FWidgetCompilerOptions Options;
}
