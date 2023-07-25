#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCOE/Nodes/CustomizableObjectNodeObject.h")]
public partial class UCustomizableObjectNodeObject : UCustomizableObjectNode {
// CustomizableObjectNodeObject
	public string ObjectName;
	public FMutableParamUIMetadata ParamUIMetadata;
	public int NumLODs;
	public ECustomizableObjectAutomaticLODStrategy AutoLODStrategy;
	public int NumMeshComponents;
	public TArray<FCustomizableObjectState> States;
	public UCustomizableObject ParentObject;
	public FGuid ParentObjectGroupId;
	public FGuid Identifier;
	public TArray<FSoftObjectPath> ReferencedSkeletalMeshes;
	public TArray<FRealTimeMorphSelectionOverride> RealTimeMorphSelectionOverrides;
	public bool bIsBase;
}
