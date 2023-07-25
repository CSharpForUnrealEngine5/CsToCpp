#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUISettings.h")]
public partial class UCommonUISettings : UObject {
// CommonUISettings
	public bool bAutoLoadData;
	public TSoftObjectPtr<UObject> DefaultImageResourceObject;
	public TSoftObjectPtr<UMaterialInterface> DefaultThrobberMaterial;
	public TSoftObjectPtr<UClass> DefaultRichTextDataClass;
	public TArray<FGameplayTag> PlatformTraits;
	public UObject DefaultImageResourceObjectInstance;
	public UMaterialInterface DefaultThrobberMaterialInstance;
	public FSlateBrush DefaultThrobberBrush;
	public UCommonUIRichTextData RichTextDataInstance;
}
