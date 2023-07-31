#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDatasmithMeshElement defines an actual geometry.</summary>
[CppInclude("ObjectElements/DatasmithUObjectElements.h")]
public partial class UDatasmithMeshElement : UDatasmithObjectElement {
	///<summary>Get the output filename, it can be absolute or relative to the scene file</summary>
	public  string GetFile() { return default; }
	///<summary>Get the bounding box width</summary>
	public  float GetBoundingBoxWidth() { return default; }
	///<summary>Get the bounding box height</summary>
	public  float GetBoundingBoxHeight() { return default; }
	///<summary>Get the bounding box depth</summary>
	public  float GetBoundingBoxDepth() { return default; }
	///<summary>Get the bounding box represented by a Vector. X is Width, Y is Height, Z is Depth.</summary>
	public  FVector GetBoundingBoxSize() { return default; }
	///<summary>Get the total surface area</summary>
	public  float GetLightMapArea() { return default; }
	///<summary>Get the UV channel that will be used for the lightmap</summary>
	public  int GetLightmapCoordinateIndex() { return default; }
	///<summary>Set the UV channel that will be used for the lightmap</summary>
	public  void SetLightmapCoordinateIndex(int UVChannel) {}
	///<summary>Get the source UV channel that will be used at import to generate the lightmap UVs</summary>
	public  int GetLightmapSourceUV() { return default; }
	///<summary>Set the source UV channel that will be used at import to generate the lightmap UVs</summary>
	public  void SetLightmapSourceUV(int UVChannel) {}
	///<summary>Set the material name to associate with slot SlotId</summary>
	public  void SetMaterial(string MaterialName,int SlotId) {}
	///<summary>Get the material name in the material slot SlotId</summary>
	public  string GetMaterial(int SlotId) { return default; }
}
