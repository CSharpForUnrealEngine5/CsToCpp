#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUITypes.h")]
///<summary>Base CommonUI metadata implementation for specification in IMC's.</summary>
public partial class UCommonMappingContextMetadata : UDataAsset {
// CommonMappingContextMetadata
	public UCommonInputMetadata EnhancedInputMetadata;
	public TMap<UInputAction,UCommonInputMetadata> PerActionEnhancedInputMetadata;
}
