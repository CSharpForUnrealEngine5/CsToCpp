namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObject.h")]
public partial class UCustomizableObjectNodeObject : UCustomizableObjectNode {
	public static UClass StaticClass() {return default;}
	///<summary>ObjectName</summary>
	public string ObjectName;
	///<summary>ParamUIMetadata</summary>
	public FMutableParamUIMetadata ParamUIMetadata;
	///<summary>NumLODs</summary>
	public int NumLODs;
	///<summary>AutoLODStrategy</summary>
	public ECustomizableObjectAutomaticLODStrategy AutoLODStrategy;
	///<summary>NumMeshComponents</summary>
	public int NumMeshComponents;
	///<summary>States</summary>
	public TArray<FCustomizableObjectState> States;
	///<summary>ParentObject</summary>
	public UCustomizableObject ParentObject;
	///<summary>ParentObjectGroupId</summary>
	public FGuid ParentObjectGroupId;
	///<summary>Identifier</summary>
	public FGuid Identifier;
	///<summary>Soft references SkeletalMeshes found in the provoius compilation.</summary>
	public TArray<FSoftObjectPath> ReferencedSkeletalMeshes;
	///<summary>Information about the realtime morph targets usage. It indexes to ReferncedSkeletakMeshes array</summary>
	public TArray<FRealTimeMorphSelectionOverride> RealTimeMorphSelectionOverrides;
	///<summary>Own interface</summary>
	public bool bIsBase;
}
