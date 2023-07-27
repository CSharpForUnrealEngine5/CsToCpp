#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectPersistentCollection.h")]
///<summary>Actor holding smart object persistent data</summary>
public partial class ASmartObjectPersistentCollection : AActor {
// SmartObjectPersistentCollection
	public  void ClearCollection() {}
	public  void RebuildCollection() {}
	public FSmartObjectContainer SmartObjectContainer;
	public UBillboardComponent SpriteComponent;
	public USmartObjectContainerRenderingComponent RenderingComponent;
	public bool bUpdateCollectionOnSmartObjectsChange;
	public bool bEnableDebugDrawing;
}
