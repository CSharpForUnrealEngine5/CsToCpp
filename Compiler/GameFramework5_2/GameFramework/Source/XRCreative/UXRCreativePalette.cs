namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("XRCreativeToolset.h")]
public partial class UXRCreativePalette : UCommonUserWidget {
	public static UClass StaticClass() {return default;}
	///<summary>Tabs</summary>
	public TArray<UXRCreativePaletteTab> Tabs;
	///<summary>Owner</summary>
	public AXRCreativeAvatar Owner;
}
