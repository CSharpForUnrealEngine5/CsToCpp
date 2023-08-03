#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonUISettings.h")]
public partial class UCommonUISettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Controls if the data referenced is automatically loaded.</summary>
	public bool bAutoLoadData;
	///<summary>The Default Image Resource, newly created CommonImage Widgets will use this style.</summary>
	public TSoftObjectPtr<UObject> DefaultImageResourceObject;
	///<summary>The Default Throbber Material, newly created CommonLoadGuard Widget will use this style.</summary>
	public TSoftObjectPtr<UMaterialInterface> DefaultThrobberMaterial;
	///<summary>The Default Data for rich text to show inline icon and others.</summary>
	public TSoftObjectPtr<UClass> DefaultRichTextDataClass;
	///<summary>The set of traits defined per-platform (e.g., the default input mode, whether or not you can exit the application, etc...)</summary>
	public TArray<FGameplayTag> PlatformTraits;
	///<summary>DefaultImageResourceObjectInstance</summary>
	public UObject DefaultImageResourceObjectInstance;
	///<summary>DefaultThrobberMaterialInstance</summary>
	public UMaterialInterface DefaultThrobberMaterialInstance;
	///<summary>DefaultThrobberBrush</summary>
	public FSlateBrush DefaultThrobberBrush;
	///<summary>RichTextDataInstance</summary>
	public UCommonUIRichTextData RichTextDataInstance;
}
