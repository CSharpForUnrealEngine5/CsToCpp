namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint API interface implementation</summary>
[CppInclude("Blueprints/PFMExporterBlueprintAPIImpl.h")]
public partial class UPFMExporterAPIImpl : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Generate PFM file from static mesh.</summary>
	public virtual bool ExportPFM(UStaticMeshComponent SrcMesh,USceneComponent Origin,int Width,int Height,string FileName) { return default; }
}
