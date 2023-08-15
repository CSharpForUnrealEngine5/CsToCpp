namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/SCS_Node.h")]
public partial class USCS_Node : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Component class</summary>
	public UClass ComponentClass;
	///<summary>Template for the component to create</summary>
	public UActorComponent ComponentTemplate;
	///<summary>Cached data for faster runtime instancing (only used in cooked builds)</summary>
	public FBlueprintCookedComponentInstancingData CookedComponentInstancingData;
	///<summary>If non-None, the assigned category name</summary>
	public FText CategoryName;
	///<summary>Socket/Bone that Node might attach to</summary>
	public FName AttachToName;
	///<summary>Component template or variable that Node might be parented to</summary>
	public FName ParentComponentOrVariableName;
	///<summary>If the node is attached to another node inherited from a parent Blueprint, this contains the name of the Blueprint parent class that owns the component template //@TODO: We can potentially remove this if/when inherited SCS component template instances are included in subobject serialization, as we could then infer that the owner class is always the same as the BP class.</summary>
	public FName ParentComponentOwnerClassName;
	///<summary>If the node is parented, this indicates whether or not the template is found in the CDO&#39;s Components array</summary>
	public bool bIsParentComponentNative;
	///<summary>Set of child nodes</summary>
	public TArray<USCS_Node> ChildNodes;
	///<summary>Metadata information for this Node</summary>
	public TArray<FBPVariableMetaDataEntry> MetaDataArray;
	///<summary>VariableGuid</summary>
	public FGuid VariableGuid;
	///<summary>(DEPRECATED) Indicates if this is a native component or not</summary>
	public bool bIsNative_DEPRECATED;
	///<summary>(DEPRECATED) If this is a native component, this is the name of the UActorComponent</summary>
	public FName NativeComponentName_DEPRECATED;
	///<summary>(DEPRECATED) If true, the variable name was a autogenerated and is not presented to the user</summary>
	public bool bVariableNameAutoGenerated_DEPRECATED;
	///<summary>Internal variable name. This is used for:</summary>
	public FName InternalVariableName;
}
