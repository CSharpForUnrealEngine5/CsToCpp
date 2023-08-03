#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base CommonUI metadata implementation for specification in IMC&#39;s.</summary>
[CppInclude("CommonUITypes.h")]
public partial class UCommonMappingContextMetadata : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Fallback or default metadata CommonUI relies on if no per-action meta is found below</summary>
	public UCommonInputMetadata EnhancedInputMetadata;
	///<summary>Map of action to metadata, allows creation of single metadata asset rather than one per input action type</summary>
	public TMap<UInputAction,UCommonInputMetadata> PerActionEnhancedInputMetadata;
}
