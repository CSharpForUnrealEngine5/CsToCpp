#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameplayDebuggerConfig.h")]
public partial struct FGameplayDebuggerExtensionConfig {
	public string ExtensionName;
	public EGameplayDebuggerOverrideMode UseExtension;
	public TArray<FGameplayDebuggerInputConfig> InputHandlers;
}
