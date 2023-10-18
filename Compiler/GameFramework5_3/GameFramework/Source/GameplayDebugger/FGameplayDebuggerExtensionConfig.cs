namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial struct FGameplayDebuggerExtensionConfig {
	public string ExtensionName;
	public EGameplayDebuggerOverrideMode UseExtension;
	public TArray<FGameplayDebuggerInputConfig> InputHandlers;
}
