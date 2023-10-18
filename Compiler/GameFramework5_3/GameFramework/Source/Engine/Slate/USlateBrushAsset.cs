namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An asset describing how a texture can exist in slate&#39;s DPI-aware environment</summary>
[CppInclude("Slate/SlateBrushAsset.h")]
public partial class USlateBrushAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The slate brush resource describing the texture&#39;s behavior.</summary>
	public FSlateBrush Brush;
}
