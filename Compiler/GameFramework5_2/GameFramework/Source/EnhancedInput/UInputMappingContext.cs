#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InputMappingContext.h")]
///<summary>UInputMappingContext : A collection of key to action mappings for a specific input context</summary>
public partial class UInputMappingContext : UDataAsset {
// InputMappingContext
	public TArray<FEnhancedActionKeyMapping> Mappings;
	public string ContextDescription;
	public  FEnhancedActionKeyMapping MapKey(UInputAction Action,FKey ToKey) { return default; }
	public  void UnmapKey(UInputAction Action,FKey Key) {}
	public  void UnmapAction(UInputAction Action) {}
	public  void UnmapAllKeysFromAction(UInputAction Action) {}
	public  void UnmapAll() {}
}
