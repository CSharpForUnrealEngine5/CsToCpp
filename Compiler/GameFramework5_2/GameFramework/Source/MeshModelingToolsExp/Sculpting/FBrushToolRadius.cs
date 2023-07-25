#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
///<summary>FBrushToolRadius is used to define the size of 3D "brushes" used in (eg) sculpting tools.</summary>
public partial struct FBrushToolRadius {
// BrushToolRadius
	public EBrushToolSizeType SizeType;
	public float AdaptiveSize;
	public float WorldRadius;
}
