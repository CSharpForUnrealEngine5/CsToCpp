#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UInputMappingContext : A collection of key to action mappings for a specific input context</summary>
[CppInclude("InputMappingContext.h")]
public partial class UInputMappingContext : UDataAsset {
	///<summary>List of key to action mappings.</summary>
	public TArray<FEnhancedActionKeyMapping> Mappings;
	///<summary>Localized context descriptor</summary>
	public string ContextDescription;
	///<summary>Map a key to an action within the mapping context.</summary>
	public  FEnhancedActionKeyMapping MapKey(UInputAction Action,FKey ToKey) { return default; }
	///<summary>Unmap a key from an action within the mapping context.</summary>
	public  void UnmapKey(UInputAction Action,FKey Key) {}
	///<summary>UnmapAction</summary>
	public  void UnmapAction(UInputAction Action) {}
	///<summary>Unmap all key maps to an action within the mapping context.</summary>
	public  void UnmapAllKeysFromAction(UInputAction Action) {}
	///<summary>Unmap everything within the mapping context.</summary>
	public  void UnmapAll() {}
}
