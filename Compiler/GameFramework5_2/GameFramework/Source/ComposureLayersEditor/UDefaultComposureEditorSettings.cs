namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ComposureEditorSettings.h")]
public partial class UDefaultComposureEditorSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>FeaturedCompShotClasses</summary>
	public TArray<FSoftObjectPath> FeaturedCompShotClasses;
	///<summary>FeaturedElementClasses</summary>
	public TArray<FSoftObjectPath> FeaturedElementClasses;
	///<summary>DefaultElementNames</summary>
	public TMap<FName,string> DefaultElementNames;
}
