#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API interface implementation</summary>
[CppInclude("Blueprints/PFMExporterBlueprintAPIImpl.h")]
public partial class UPFMExporterAPIImpl : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Generate PFM file from static mesh.</summary>
	public  bool ExportPFM(UStaticMeshComponent SrcMesh,USceneComponent Origin,int Width,int Height,string FileName) { return default; }
}
