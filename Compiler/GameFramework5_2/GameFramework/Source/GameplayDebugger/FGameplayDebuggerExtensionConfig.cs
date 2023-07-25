#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial struct FGameplayDebuggerExtensionConfig {
// GameplayDebuggerExtensionConfig
	public string ExtensionName;
	public EGameplayDebuggerOverrideMode UseExtension;
	public TArray<FGameplayDebuggerInputConfig> InputHandlers;
}
