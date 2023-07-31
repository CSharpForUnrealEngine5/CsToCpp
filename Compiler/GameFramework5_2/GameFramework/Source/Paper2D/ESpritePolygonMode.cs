#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpriteEditorOnlyTypes.h")]
///<summary>Method of specifying polygons for a sprite&#39;s render or collision data</summary>
[CppEnumInNamespace]
public enum ESpritePolygonMode {
	SourceBoundingBox=0,
	TightBoundingBox=1,
	ShrinkWrapped=2,
	FullyCustom=3,
	Diced=4,
}
