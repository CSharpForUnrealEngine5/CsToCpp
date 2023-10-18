namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPreviewGeometry creates and manages an APreviewGeometryActor and a set of preview geometry Components.</summary>
[CppInclude("Drawing/PreviewGeometryActor.h")]
public partial class UPreviewGeometry : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Create preview mesh in the World with the given transform</summary>
	public void CreateInWorld(UWorld World,FTransform WithTransform) {}
	///<summary>Remove and destroy preview mesh</summary>
	public void Disconnect() {}
	///<summary>@return the preview geometry actor created by this class</summary>
	public APreviewGeometryActor GetActor() { return default; }
	///<summary>Create a new triangle set with the given TriangleSetIdentifier and return it</summary>
	public UTriangleSetComponent AddTriangleSet(string TriangleSetIdentifier) { return default; }
	///<summary>@return the TriangleSetComponent with the given TriangleSetIdentifier, or nullptr if not found</summary>
	public UTriangleSetComponent FindTriangleSet(string TriangleSetIdentifier) { return default; }
	///<summary>Create a new line set with the given LineSetIdentifier and return it</summary>
	public ULineSetComponent AddLineSet(string LineSetIdentifier) { return default; }
	///<summary>@return the LineSetComponent with the given LineSetIdentifier, or nullptr if not found</summary>
	public ULineSetComponent FindLineSet(string LineSetIdentifier) { return default; }
	///<summary>Remove the LineSetComponent with the given LineSetIdentifier</summary>
	public bool RemoveLineSet(string LineSetIdentifier,bool bDestroy) { return default; }
	///<summary>Remove all LineSetComponents</summary>
	public void RemoveAllLineSets(bool bDestroy) {}
	///<summary>Set the visibility of the LineSetComponent with the given LineSetIdentifier</summary>
	public bool SetLineSetVisibility(string LineSetIdentifier,bool bVisible) { return default; }
	///<summary>Set the Material of the LineSetComponent with the given LineSetIdentifier</summary>
	public bool SetLineSetMaterial(string LineSetIdentifier,UMaterialInterface NewMaterial) { return default; }
	///<summary>Set the Material of all LineSetComponents</summary>
	public void SetAllLineSetsMaterial(UMaterialInterface Material) {}
	///<summary>Create a new point set with the given PointSetIdentifier and return it</summary>
	public UPointSetComponent AddPointSet(string PointSetIdentifier) { return default; }
	///<summary>@return the PointSetComponent with the given PointSetIdentifier, or nullptr if not found</summary>
	public UPointSetComponent FindPointSet(string PointSetIdentifier) { return default; }
	///<summary>Remove the PointSetComponent with the given PointSetIdentifier</summary>
	public bool RemovePointSet(string PointSetIdentifier,bool bDestroy) { return default; }
	///<summary>Remove all PointSetComponents</summary>
	public void RemoveAllPointSets(bool bDestroy) {}
	///<summary>Set the visibility of the PointSetComponent with the given PointSetIdentifier</summary>
	public bool SetPointSetVisibility(string PointSetIdentifier,bool bVisible) { return default; }
	///<summary>Set the Material of the PointSetComponent with the given PointSetIdentifier</summary>
	public bool SetPointSetMaterial(string PointSetIdentifier,UMaterialInterface NewMaterial) { return default; }
	///<summary>Set the Material of all PointSetComponents</summary>
	public void SetAllPointSetsMaterial(UMaterialInterface Material) {}
	///<summary>Actor created and managed by the UPreviewGeometry</summary>
	public APreviewGeometryActor ParentActor;
	///<summary>TriangleSetComponents created and owned by the UPreviewGeometry, and added as child components of the ParentActor</summary>
	public TMap<string,UTriangleSetComponent> TriangleSets;
	///<summary>LineSetComponents created and owned by the UPreviewGeometry, and added as child components of the ParentActor</summary>
	public TMap<string,ULineSetComponent> LineSets;
	///<summary>PointSetComponents created and owned by the UPreviewGeometry, and added as child components of the ParentActor</summary>
	public TMap<string,UPointSetComponent> PointSets;
}
