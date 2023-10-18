namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SmartObjectComponent.h")]
public partial class USmartObjectComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>OnSmartObjectEvent</summary>
	public FSmartObjectComponentEventSignature OnSmartObjectEvent;
	///<summary>ReceiveOnEvent</summary>
	public void ReceiveOnEvent(FSmartObjectEventData EventData,AActor Interactor) {}
	///<summary>DefinitionAsset</summary>
	public USmartObjectDefinition DefinitionAsset;
	///<summary>RegisteredHandle != FSmartObjectHandle::Invalid when registered into a collection by SmartObjectSubsystem</summary>
	public FSmartObjectHandle RegisteredHandle;
	///<summary>Controls whether a given SmartObject can be aggregated in SmartObjectPersistentCollections. SOs in collections</summary>
	public bool bCanBePartOfCollection;
}
