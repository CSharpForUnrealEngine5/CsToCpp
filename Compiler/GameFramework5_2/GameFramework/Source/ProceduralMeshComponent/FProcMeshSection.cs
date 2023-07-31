#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>One section of the procedural mesh. Each material has its own section.</summary>
[CppInclude("ProceduralMeshComponent.h")]
public partial struct FProcMeshSection {
	public TArray<FProcMeshVertex> ProcVertexBuffer;
	public TArray<uint> ProcIndexBuffer;
	public FBox SectionLocalBox;
	public bool bEnableCollision;
	public bool bSectionVisible;
}
