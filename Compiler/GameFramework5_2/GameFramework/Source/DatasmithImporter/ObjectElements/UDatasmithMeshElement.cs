#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
///<summary>UDatasmithMeshElement defines an actual geometry.</summary>
public partial class UDatasmithMeshElement : UDatasmithObjectElement {
// DatasmithMeshElement
	public  string GetFile() { return default; }
	public  float GetBoundingBoxWidth() { return default; }
	public  float GetBoundingBoxHeight() { return default; }
	public  float GetBoundingBoxDepth() { return default; }
	public  FVector GetBoundingBoxSize() { return default; }
	public  float GetLightMapArea() { return default; }
	public  int GetLightmapCoordinateIndex() { return default; }
	public  void SetLightmapCoordinateIndex(int UVChannel) {}
	public  int GetLightmapSourceUV() { return default; }
	public  void SetLightmapSourceUV(int UVChannel) {}
	public  void SetMaterial(string MaterialName,int SlotId) {}
	public  string GetMaterial(int SlotId) { return default; }
}
