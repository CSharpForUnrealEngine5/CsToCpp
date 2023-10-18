namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/BlueprintGeneratedClass.h")]
public partial class UBlueprintGeneratedClass : UClass {
	public static UClass StaticClass() {return default;}
	///<summary>NumReplicatedProperties</summary>
	public int NumReplicatedProperties;
	///<summary>bHasNativizedParent_DEPRECATED</summary>
	public bool bHasNativizedParent_DEPRECATED;
	///<summary>Flag used to indicate if this class has data to support the component instancing fast path.</summary>
	public bool bHasCookedComponentInstancingData;
	///<summary>Used to check if this class has sparse data that can be serialized. This will be false when loading the data if it hasn&#39;t already been saved out.</summary>
	public bool bIsSparseClassDataSerializable;
	///<summary>Array of objects containing information for dynamically binding delegates to functions in this blueprint</summary>
	public TArray<UDynamicBlueprintBinding> DynamicBindingObjects;
	///<summary>Array of component template objects, used by AddComponent function</summary>
	public TArray<UActorComponent> ComponentTemplates;
	///<summary>Array of templates for timelines that should be created</summary>
	public TArray<UTimelineTemplate> Timelines;
	///<summary>Array of blueprint overrides of component classes in parent classes</summary>
	public TArray<FBPComponentClassOverride> ComponentClassOverrides;
	///<summary>The name of the properties with FieldNotify</summary>
	public TArray<FFieldNotificationId> FieldNotifies;
	///<summary>&#39;Simple&#39; construction script - graph of components to instance</summary>
	public USimpleConstructionScript SimpleConstructionScript;
	///<summary>Stores data to override (in children classes) components (created by SCS) from parent classes</summary>
	public UInheritableComponentHandler InheritableComponentHandler;
	///<summary>UberGraphFramePointerProperty_DEPRECATED</summary>
	public UStructProperty UberGraphFramePointerProperty_DEPRECATED;
	///<summary>UberGraphFunction</summary>
	public UFunction UberGraphFunction;
	///<summary>This is a list of event graph call function nodes that are simple (no argument) thunks into the event graph (typically used for animation delegates, etc...)</summary>
	public TArray<FEventGraphFastCallPair> FastCallPairs_DEPRECATED;
	///<summary>OverridenArchetypeForCDO</summary>
	public UObject OverridenArchetypeForCDO;
	///<summary>Property guid map</summary>
	public TMap<FName,FGuid> PropertyGuids;
	///<summary>CalledFunctions</summary>
	public TArray<UFunction> CalledFunctions;
	///<summary>Property guid map (if any), for use only when this BP is cooked</summary>
	public TMap<FName,FGuid> CookedPropertyGuids;
	///<summary>Mapping of changed properties &amp; data to apply when instancing components in a cooked build (one entry per named AddComponent node template for fast lookup at runtime).</summary>
	public TMap<FName,FBlueprintCookedComponentInstancingData> CookedComponentInstancingData;
	///<summary>CachedCookedMetaDataPtr</summary>
	public UClassCookedMetaData CachedCookedMetaDataPtr;
}
