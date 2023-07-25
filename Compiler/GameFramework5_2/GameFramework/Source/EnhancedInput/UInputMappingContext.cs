#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputMappingContext.h")]
///<summary>UInputMappingContext : A collection of key to action mappings for a specific input context</summary>
public partial class UInputMappingContext : UDataAsset {
// InputMappingContext
	public TArray<FEnhancedActionKeyMapping> Mappings;
	public string ContextDescription;
	public FEnhancedActionKeyMapping MapKey(UObject Action,FKey ToKey) { return default; }
	public void UnmapKey(UObject Action,FKey Key) {}
	public void UnmapAction(UObject Action) {}
	public void UnmapAllKeysFromAction(UObject Action) {}
	public void UnmapAll() {}
}
