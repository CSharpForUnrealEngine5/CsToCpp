namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VirtualHeightfieldMeshActor.h")]
public partial class AVirtualHeightfieldMesh : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>Component for rendering the big mesh.</summary>
	public UVirtualHeightfieldMeshComponent VirtualHeightfieldMeshComponent;
	///<summary>Box for visualizing virtual texture extents.</summary>
	public UBoxComponent Box;
}
