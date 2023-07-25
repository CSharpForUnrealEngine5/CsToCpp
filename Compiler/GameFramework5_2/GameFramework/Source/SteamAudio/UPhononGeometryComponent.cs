#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PhononGeometryComponent.h")]
///<summary>Phonon Geometry components are used to tag an actor as containing geometry relevant to acoustics calculations.</summary>
public partial class UPhononGeometryComponent : USceneComponent {
// PhononGeometryComponent
	public bool ExportAllChildren;
	public uint NumVertices;
	public uint NumTriangles;
}
