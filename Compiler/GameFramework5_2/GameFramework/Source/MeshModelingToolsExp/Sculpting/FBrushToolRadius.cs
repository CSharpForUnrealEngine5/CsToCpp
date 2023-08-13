namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>FBrushToolRadius is used to define the size of 3D &quot;brushes&quot; used in (eg) sculpting tools.</summary>
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial struct FBrushToolRadius {
	public EBrushToolSizeType SizeType;
	public float AdaptiveSize;
	public float WorldRadius;
}
