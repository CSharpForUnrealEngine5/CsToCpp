#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMeshSocket.h")]
public partial class UStaticMeshSocket : UObject {
	///<summary>Defines a named attachment location on the UStaticMesh.</summary>
	public string SocketName;
	///<summary>RelativeLocation</summary>
	public FVector RelativeLocation;
	///<summary>RelativeRotation</summary>
	public FRotator RelativeRotation;
	///<summary>RelativeScale</summary>
	public FVector RelativeScale;
	///<summary>Tag</summary>
	public string Tag;
	///<summary>PreviewStaticMesh</summary>
	public UStaticMesh PreviewStaticMesh;
	///<summary>Whether the socket was imported with the asset or created in the editor. Importer will remove/modify only imported socket and will not touch any editor created socket.</summary>
	public bool bSocketCreatedAtImport;
}
