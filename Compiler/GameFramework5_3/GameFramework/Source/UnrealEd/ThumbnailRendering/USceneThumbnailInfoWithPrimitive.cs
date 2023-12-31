namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/SceneThumbnailInfoWithPrimitive.h")]
public partial class USceneThumbnailInfoWithPrimitive : USceneThumbnailInfo {
	public static UClass StaticClass() {return default;}
	///<summary>The type of primitive used in this thumbnail</summary>
	public EThumbnailPrimType PrimitiveType;
	///<summary>The custom mesh used when the primitive type is TPT_None</summary>
	public FSoftObjectPath PreviewMesh;
	///<summary>bUserModifiedShape</summary>
	public bool bUserModifiedShape;
}
