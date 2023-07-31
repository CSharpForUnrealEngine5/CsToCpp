#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
public partial struct FDirectoryWidgetCompilerOptions {
	public FDirectoryPath Directory;
	public TArray<TSoftObjectPtr<UWidgetBlueprint>> IgnoredWidgets;
	public FWidgetCompilerOptions Options;
}
