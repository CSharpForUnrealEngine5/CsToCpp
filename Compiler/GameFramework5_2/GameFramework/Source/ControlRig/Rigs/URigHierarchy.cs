#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchy.h")]
public partial class URigHierarchy : UObject {
// RigHierarchy
	public void Reset() {}
	public void ResetToDefault() {}
	public void CopyHierarchy(UObject InHierarchy) {}
	public void CopyPose(UObject InHierarchy,bool bCurrent,bool bInitial,bool bWeights,bool bMatchPoseInGlobalIfNeeded/*=false*/) {}
	public void ResetPoseToInitial(ERigElementType InTypeFilter) {}
	public void ResetCurveValues() {}
	public int Num() { return default; }
	public bool IsValidIndex(int InElementIndex) { return default; }
	public bool Contains_ForBlueprint(FRigElementKey InKey) { return default; }
	public bool IsProcedural(FRigElementKey InKey) { return default; }
	public int GetIndex_ForBlueprint(FRigElementKey InKey) { return default; }
	public int GetLocalIndex_ForBlueprint(FRigElementKey InKey) { return default; }
	public FRigElementKey GetKey(int InElementIndex) { return default; }
	public TArray<FRigElementKey> GetKeys(TArray<int> InElementIndices) { return default; }
	public FRigBoneElement FindBone_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	public FRigControlElement FindControl_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	public FRigNullElement FindNull_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	public TArray<FRigElementKey> GetBoneKeys(bool bTraverse/*=true*/) { return default; }
	public TArray<FRigElementKey> GetNullKeys(bool bTraverse/*=true*/) { return default; }
	public TArray<FRigElementKey> GetControlKeys(bool bTraverse/*=true*/) { return default; }
	public TArray<FRigElementKey> GetCurveKeys() { return default; }
	public TArray<FRigElementKey> GetRigidBodyKeys(bool bTraverse/*=true*/) { return default; }
	public TArray<FRigElementKey> GetReferenceKeys(bool bTraverse/*=true*/) { return default; }
	public TArray<FRigElementKey> GetRootElementKeys() { return default; }
	public TArray<string> GetMetadataNames(FRigElementKey InItem) { return default; }
	public ERigMetadataType GetMetadataType(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool RemoveMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool RemoveAllMetadata(FRigElementKey InItem) { return default; }
	public bool GetBoolMetadata(FRigElementKey InItem,string InMetadataName,bool DefaultValue) { return default; }
	public TArray<bool> GetBoolArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetBoolMetadata(FRigElementKey InItem,string InMetadataName,bool InValue) { return default; }
	public bool SetBoolArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<bool> InValue) { return default; }
	public float GetFloatMetadata(FRigElementKey InItem,string InMetadataName,float DefaultValue) { return default; }
	public TArray<float> GetFloatArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetFloatMetadata(FRigElementKey InItem,string InMetadataName,float InValue) { return default; }
	public bool SetFloatArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<float> InValue) { return default; }
	public int GetInt32Metadata(FRigElementKey InItem,string InMetadataName,int DefaultValue) { return default; }
	public TArray<int> GetInt32ArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetInt32Metadata(FRigElementKey InItem,string InMetadataName,int InValue) { return default; }
	public bool SetInt32ArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<int> InValue) { return default; }
	public string GetNameMetadata(FRigElementKey InItem,string InMetadataName,string DefaultValue) { return default; }
	public TArray<string> GetNameArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetNameMetadata(FRigElementKey InItem,string InMetadataName,string InValue) { return default; }
	public bool SetNameArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<string> InValue) { return default; }
	public FVector GetVectorMetadata(FRigElementKey InItem,string InMetadataName,FVector DefaultValue) { return default; }
	public TArray<FVector> GetVectorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetVectorMetadata(FRigElementKey InItem,string InMetadataName,FVector InValue) { return default; }
	public bool SetVectorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FVector> InValue) { return default; }
	public FRotator GetRotatorMetadata(FRigElementKey InItem,string InMetadataName,FRotator DefaultValue) { return default; }
	public TArray<FRotator> GetRotatorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetRotatorMetadata(FRigElementKey InItem,string InMetadataName,FRotator InValue) { return default; }
	public bool SetRotatorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FRotator> InValue) { return default; }
	public FQuat GetQuatMetadata(FRigElementKey InItem,string InMetadataName,FQuat DefaultValue) { return default; }
	public TArray<FQuat> GetQuatArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetQuatMetadata(FRigElementKey InItem,string InMetadataName,FQuat InValue) { return default; }
	public bool SetQuatArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FQuat> InValue) { return default; }
	public FTransform GetTransformMetadata(FRigElementKey InItem,string InMetadataName,FTransform DefaultValue) { return default; }
	public TArray<FTransform> GetTransformArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetTransformMetadata(FRigElementKey InItem,string InMetadataName,FTransform InValue) { return default; }
	public bool SetTransformArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FTransform> InValue) { return default; }
	public FLinearColor GetLinearColorMetadata(FRigElementKey InItem,string InMetadataName,FLinearColor DefaultValue) { return default; }
	public TArray<FLinearColor> GetLinearColorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetLinearColorMetadata(FRigElementKey InItem,string InMetadataName,FLinearColor InValue) { return default; }
	public bool SetLinearColorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FLinearColor> InValue) { return default; }
	public FRigElementKey GetRigElementKeyMetadata(FRigElementKey InItem,string InMetadataName,FRigElementKey DefaultValue) { return default; }
	public TArray<FRigElementKey> GetRigElementKeyArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	public bool SetRigElementKeyMetadata(FRigElementKey InItem,string InMetadataName,FRigElementKey InValue) { return default; }
	public bool SetRigElementKeyArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FRigElementKey> InValue) { return default; }
	public TArray<string> GetTags(FRigElementKey InItem) { return default; }
	public bool HasTag(FRigElementKey InItem,string InTag) { return default; }
	public bool SetTag(FRigElementKey InItem,string InTag) { return default; }
	public TArray<FRigElementKey> GetSelectedKeys(ERigElementType InTypeFilter/*=ERigElementType.All*/) { return default; }
	public bool IsSelected(FRigElementKey InKey) { return default; }
	public bool IsSelectedByIndex(int InIndex) { return default; }
	public TArray<FRigElementKey> SortKeys(TArray<FRigElementKey> InKeys) { return default; }
	public FTransform GetLocalTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetLocalTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public void SetLocalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetLocalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public FTransform GetGlobalTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetGlobalTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public void SetGlobalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) {}
	public void SetGlobalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) {}
	public FTransform GetGlobalControlOffsetTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetGlobalControlOffsetTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public FTransform GetLocalControlShapeTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetLocalControlShapeTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public FTransform GetGlobalControlShapeTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetGlobalControlShapeTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public FRigControlValue GetControlValue(FRigElementKey InKey,ERigControlValueType InValueType/*=ERigControlValueType.Current*/) { return default; }
	public FRigControlValue GetControlValueByIndex(int InElementIndex,ERigControlValueType InValueType/*=ERigControlValueType.Current*/) { return default; }
	public FRotator GetControlPreferredRotator(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FRotator GetControlPreferredRotatorByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public void SetControlPreferredRotator(FRigElementKey InKey,FRotator InValue,bool bInitial/*=false*/,bool bFixEulerFlips/*=false*/) {}
	public void SetControlPreferredRotatorByIndex(int InElementIndex,FRotator InValue,bool bInitial/*=false*/,bool bFixEulerFlips/*=false*/) {}
	public void SetControlValue(FRigElementKey InKey,FRigControlValue InValue,ERigControlValueType InValueType/*=ERigControlValueType.Current*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetControlValueByIndex(int InElementIndex,FRigControlValue InValue,ERigControlValueType InValueType/*=ERigControlValueType.Current*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetControlVisibility(FRigElementKey InKey,bool bVisibility) {}
	public void SetControlVisibilityByIndex(int InElementIndex,bool bVisibility) {}
	public float GetCurveValue(FRigElementKey InKey) { return default; }
	public float GetCurveValueByIndex(int InElementIndex) { return default; }
	public bool IsCurveValueSet(FRigElementKey InKey) { return default; }
	public bool IsCurveValueSetByIndex(int InElementIndex) { return default; }
	public void SetCurveValue(FRigElementKey InKey,float InValue,bool bSetupUndo/*=false*/) {}
	public void SetCurveValueByIndex(int InElementIndex,float InValue,bool bSetupUndo/*=false*/) {}
	public void UnsetCurveValue(FRigElementKey InKey,bool bSetupUndo/*=false*/) {}
	public void UnsetCurveValueByIndex(int InElementIndex,bool bSetupUndo/*=false*/) {}
	public void SetControlOffsetTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetControlOffsetTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetControlShapeTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bSetupUndo/*=false*/) {}
	public void SetControlShapeTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bSetupUndo/*=false*/) {}
	public void SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo/*=false*/,bool bForce/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public void SetControlSettingsByIndex(int InElementIndex,FRigControlSettings InSettings,bool bSetupUndo/*=false*/,bool bForce/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	public FTransform GetParentTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	public FTransform GetParentTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	public TArray<FRigElementKey> GetChildren(FRigElementKey InKey,bool bRecursive/*=false*/) { return default; }
	public TArray<FRigElementKey> GetParents(FRigElementKey InKey,bool bRecursive/*=false*/) { return default; }
	public FRigElementKey GetDefaultParent(FRigElementKey InKey) { return default; }
	public FRigElementKey GetFirstParent(FRigElementKey InKey) { return default; }
	public int GetNumberOfParents(FRigElementKey InKey) { return default; }
	public FRigElementWeight GetParentWeight(FRigElementKey InChild,FRigElementKey InParent,bool bInitial/*=false*/) { return default; }
	public TArray<FRigElementWeight> GetParentWeightArray(FRigElementKey InChild,bool bInitial/*=false*/) { return default; }
	public bool SetParentWeight(FRigElementKey InChild,FRigElementKey InParent,FRigElementWeight InWeight,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	public bool SetParentWeightArray(FRigElementKey InChild,TArray<FRigElementWeight> InWeights,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	public bool SwitchToParent(FRigElementKey InChild,FRigElementKey InParent,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	public bool SwitchToDefaultParent(FRigElementKey InChild,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	public bool SwitchToWorldSpace(FRigElementKey InChild,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	public bool IsParentedTo(FRigElementKey InChild,FRigElementKey InParent) { return default; }
	public TArray<FRigElementKey> GetAllKeys_ForBlueprint(bool bTraverse/*=true*/) { return default; }
	public void SendAutoKeyEvent(FRigElementKey InElement,float InOffsetInSeconds/*=0.0f*/,bool bAsynchronous/*=true*/) {}
	public bool IsControllerAvailable() { return default; }
	public UObject GetController(bool bCreateIfNeeded/*=true*/) { return default; }
	public FRigPose GetPose(bool bInitial/*=false*/) { return default; }
	public void SetPose_ForBlueprint(FRigPose InPose) {}
	public FRigControlValue MakeControlValueFromBool(bool InValue) { return default; }
	public FRigControlValue MakeControlValueFromFloat(float InValue) { return default; }
	public float GetFloatFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromInt(int InValue) { return default; }
	public int GetIntFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromVector2D(FVector2D InValue) { return default; }
	public FVector2D GetVector2DFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromVector(FVector InValue) { return default; }
	public FVector GetVectorFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromRotator(FRotator InValue) { return default; }
	public FRotator GetRotatorFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromTransform(FTransform InValue) { return default; }
	public FTransform GetTransformFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromEulerTransform(FEulerTransform InValue) { return default; }
	public FEulerTransform GetEulerTransformFromControlValue(FRigControlValue InValue) { return default; }
	public FRigControlValue MakeControlValueFromTransformNoScale(FTransformNoScale InValue) { return default; }
	public FTransformNoScale GetTransformNoScaleFromControlValue(FRigControlValue InValue) { return default; }
	public string GetPreviousName(FRigElementKey InKey) { return default; }
	public FRigElementKey GetPreviousParent(FRigElementKey InKey) { return default; }
	public ushort TopologyVersion;
	public ushort MetadataVersion;
	public ushort MetadataTagVersion;
	public bool bEnableDirtyPropagation;
	public int TransformStackIndex;
	public URigHierarchyController HierarchyController;
	public TMap<FRigElementKey,FRigElementKey> PreviousNameMap;
	public URigHierarchy HierarchyForCacheValidation;
}
