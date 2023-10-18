namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Information about the sprite category, used for visualization in the editor</summary>
[CppInclude("Components/PrimitiveComponent.h")]
public partial struct FSpriteCategoryInfo {
	public FName Category;
	public FText DisplayName;
	public FText Description;
}
