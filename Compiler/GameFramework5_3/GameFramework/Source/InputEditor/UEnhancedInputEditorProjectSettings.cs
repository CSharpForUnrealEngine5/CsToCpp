namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Settings for the Enhanced Input Editor Subsystem that are persistent between a project&#39;s users</summary>
[CppInclude("EnhancedInputEditorSettings.h")]
public partial class UEnhancedInputEditorProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>The default player input class that the Enhanced Input Editor subsystem will use.</summary>
	public TSoftObjectPtr<UClass> DefaultEditorInputClass;
	///<summary>Array of any input mapping contexts that you want to always be applied to the Enhanced Input Editor Subsystem.</summary>
	public TArray<FDefaultContextSetting> DefaultMappingContexts;
}
