namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Phonon Geometry components are used to tag an actor as containing geometry relevant to acoustics calculations.</summary>
[CppInclude("PhononGeometryComponent.h")]
public partial class UPhononGeometryComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Whether or not to export all actors attached to this actor.</summary>
	public bool ExportAllChildren;
	///<summary>The number of vertices exported to Steam Audio.</summary>
	public uint NumVertices;
	///<summary>The number of triangles exported to Steam Audio.</summary>
	public uint NumTriangles;
}
