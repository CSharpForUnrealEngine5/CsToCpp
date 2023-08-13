namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cached vertex information at the time the mesh was painted.</summary>
[CppInclude("Components/StaticMeshComponent.h")]
public partial struct FPaintedVertex {
	public FVector Position;
	public FColor Color;
	public FVector4 Normal;
}
