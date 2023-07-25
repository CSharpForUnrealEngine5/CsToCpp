#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ProceduralMeshComponent.h")]
///<summary>One section of the procedural mesh. Each material has its own section.</summary>
public partial struct FProcMeshSection {
// ProcMeshSection
	public TArray<FProcMeshVertex> ProcVertexBuffer;
	public TArray<uint> ProcIndexBuffer;
	public FBox SectionLocalBox;
	public bool bEnableCollision;
	public bool bSectionVisible;
}
