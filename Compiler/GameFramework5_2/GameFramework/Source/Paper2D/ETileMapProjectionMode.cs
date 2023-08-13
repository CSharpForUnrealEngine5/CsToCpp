namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PaperTileMap.h")]
///<summary>The different kinds of projection modes supported</summary>
[CppEnumInNamespace]
public enum ETileMapProjectionMode {
	Orthogonal=0,
	IsometricDiamond=1,
	IsometricStaggered=2,
	HexagonalStaggered=3,
}
