#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UMGEditorProjectSettings.h")]
public partial struct FDirectoryWidgetCompilerOptions {
// DirectoryWidgetCompilerOptions
	public FDirectoryPath Directory;
	public TArray<TSoftObjectPtr<UWidgetBlueprint>> IgnoredWidgets;
	public FWidgetCompilerOptions Options;
}
