namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ThumbnailRendering/ThumbnailManager.h")]
public partial class UThumbnailManager : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The render info to share across all object types when the object doesn&#39;t</summary>
	public FThumbnailRenderingInfo NotSupported;
	///<summary>All these meshes/materials/textures are preloaded via default properties</summary>
	public UStaticMesh EditorCube;
	///<summary>EditorSphere</summary>
	public UStaticMesh EditorSphere;
	///<summary>EditorCylinder</summary>
	public UStaticMesh EditorCylinder;
	///<summary>EditorPlane</summary>
	public UStaticMesh EditorPlane;
	///<summary>EditorSkySphere</summary>
	public UStaticMesh EditorSkySphere;
	///<summary>FloorPlaneMaterial</summary>
	public UMaterial FloorPlaneMaterial;
	///<summary>AmbientCubemap</summary>
	public UTextureCube AmbientCubemap;
	///<summary>CheckerboardTexture</summary>
	public UTexture2D CheckerboardTexture;
	///<summary>The array of thumbnail rendering information entries. Each type that supports</summary>
	public TArray<FThumbnailRenderingInfo> RenderableThumbnailTypes;
	///<summary>Holds the name of the thumbnail manager singleton class to instantiate</summary>
	public string ThumbnailManagerClassName;
}
