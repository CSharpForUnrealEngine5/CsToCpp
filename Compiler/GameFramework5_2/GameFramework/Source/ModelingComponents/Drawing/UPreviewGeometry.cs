#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Drawing/PreviewGeometryActor.h")]
///<summary>UPreviewGeometry creates and manages an APreviewGeometryActor and a set of preview geometry Components.</summary>
public partial class UPreviewGeometry : UObject {
// PreviewGeometry
	public  void CreateInWorld(UWorld World,FTransform WithTransform) {}
	public  void Disconnect() {}
	public  APreviewGeometryActor GetActor() { return default; }
	public  ULineSetComponent AddLineSet(string LineSetIdentifier) { return default; }
	public  ULineSetComponent FindLineSet(string LineSetIdentifier) { return default; }
	public  bool RemoveLineSet(string LineSetIdentifier,bool bDestroy) { return default; }
	public  void RemoveAllLineSets(bool bDestroy) {}
	public  bool SetLineSetVisibility(string LineSetIdentifier,bool bVisible) { return default; }
	public  bool SetLineSetMaterial(string LineSetIdentifier,UMaterialInterface NewMaterial) { return default; }
	public  void SetAllLineSetsMaterial(UMaterialInterface Material) {}
	public  UPointSetComponent AddPointSet(string PointSetIdentifier) { return default; }
	public  UPointSetComponent FindPointSet(string PointSetIdentifier) { return default; }
	public  bool RemovePointSet(string PointSetIdentifier,bool bDestroy) { return default; }
	public  void RemoveAllPointSets(bool bDestroy) {}
	public  bool SetPointSetVisibility(string PointSetIdentifier,bool bVisible) { return default; }
	public  bool SetPointSetMaterial(string PointSetIdentifier,UMaterialInterface NewMaterial) { return default; }
	public  void SetAllPointSetsMaterial(UMaterialInterface Material) {}
	public APreviewGeometryActor ParentActor;
	public TMap<string,ULineSetComponent> LineSets;
	public TMap<string,UPointSetComponent> PointSets;
}
