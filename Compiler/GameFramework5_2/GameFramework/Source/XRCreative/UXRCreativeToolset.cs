namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativeToolset : UPrimaryDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Avatar</summary>
	public UClass Avatar;
	///<summary>Tools</summary>
	public TArray<FXRCreativeToolEntry> Tools;
	///<summary>Palette</summary>
	public UClass Palette;
	///<summary>Style</summary>
	public TSoftObjectPtr<UXRCreativeStyle> Style;
}
