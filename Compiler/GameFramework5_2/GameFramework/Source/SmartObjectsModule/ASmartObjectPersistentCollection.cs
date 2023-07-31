#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor holding smart object persistent data</summary>
[CppInclude("SmartObjectPersistentCollection.h")]
public partial class ASmartObjectPersistentCollection : AActor {
	///<summary>Removes all entries from the collection.</summary>
	public  void ClearCollection() {}
	///<summary>Rebuild entries in the collection using all the SmartObjectComponents currently loaded in the level.</summary>
	public  void RebuildCollection() {}
	///<summary>SmartObjectContainer</summary>
	public FSmartObjectContainer SmartObjectContainer;
	///<summary>SpriteComponent</summary>
	public UBillboardComponent SpriteComponent;
	///<summary>RenderingComponent</summary>
	public USmartObjectContainerRenderingComponent RenderingComponent;
	///<summary>bUpdateCollectionOnSmartObjectsChange</summary>
	public bool bUpdateCollectionOnSmartObjectsChange;
	///<summary>bEnableDebugDrawing</summary>
	public bool bEnableDebugDrawing;
}
