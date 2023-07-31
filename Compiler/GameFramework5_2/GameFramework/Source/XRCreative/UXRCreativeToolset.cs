#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativeToolset : UPrimaryDataAsset {
	///<summary>Avatar</summary>
	public UClass Avatar;
	///<summary>Tools</summary>
	public TArray<FXRCreativeToolEntry> Tools;
	///<summary>Palette</summary>
	public UClass Palette;
	///<summary>Style</summary>
	public TSoftObjectPtr<UXRCreativeStyle> Style;
}
