#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MediaPlate is an actor that can play and show media in the world.</summary>
[CppInclude("MediaPlate.h")]
public partial class AMediaPlate : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>MediaPlateComponent</summary>
	public UMediaPlateComponent MediaPlateComponent;
	///<summary>Holds the mesh.</summary>
	public UStaticMeshComponent StaticMeshComponent;
}
