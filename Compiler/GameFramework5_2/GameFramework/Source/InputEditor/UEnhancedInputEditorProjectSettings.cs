#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EnhancedInputEditorSettings.h")]
///<summary>Settings for the Enhanced Input Editor Subsystem that are persistent between a project's users</summary>
public partial class UEnhancedInputEditorProjectSettings : UDeveloperSettings {
// EnhancedInputEditorProjectSettings
	public TSoftObjectPtr<UClass> DefaultEditorInputClass;
	public TArray<FDefaultContextSetting> DefaultMappingContexts;
}
