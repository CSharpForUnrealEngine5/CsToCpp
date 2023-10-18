namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SpriteEditorOnlyTypes.h")]
///<summary>The kind of collision that a Paper2D asset or component might participate in</summary>
[CppEnumInNamespace]
public enum ESpriteCollisionMode {
	None=0,
	Use2DPhysics=1,
	Use3DPhysics=2,
}
