namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LandscapeMeshCollisionComponent.h")]
public partial class ULandscapeMeshCollisionComponent : ULandscapeHeightfieldCollisionComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Guid used to share PhysX heightfield objects in the editor</summary>
	public FGuid MeshGuid;
}
