namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Rigs/RigHierarchy.h")]
public partial class URigHierarchy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Clears the whole hierarchy and removes all elements.</summary>
	public void Reset() {}
	///<summary>Resets the hierarchy to the state of its default. This refers to the</summary>
	public void ResetToDefault() {}
	///<summary>Copies the contents of a hierarchy onto this one</summary>
	public void CopyHierarchy(URigHierarchy InHierarchy) {}
	///<summary>Copies the contents of a hierarchy onto this one</summary>
	public void CopyPose(URigHierarchy InHierarchy,bool bCurrent,bool bInitial,bool bWeights,bool bMatchPoseInGlobalIfNeeded/*=false*/) {}
	///<summary>Resets the current pose of a filtered list of elements to the initial / ref pose.</summary>
	public void ResetPoseToInitial(ERigElementType InTypeFilter) {}
	///<summary>Resets all curves to 0.0</summary>
	public void ResetCurveValues() {}
	///<summary>Returns the number of elements in the Hierarchy.</summary>
	public int Num() { return default; }
	///<summary>Returns true if the provided element index is valid</summary>
	public bool IsValidIndex(int InElementIndex) { return default; }
	///<summary>Returns true if the provided element key is valid</summary>
	public bool Contains_ForBlueprint(FRigElementKey InKey) { return default; }
	///<summary>Returns true if the provided element is procedural.</summary>
	public bool IsProcedural(FRigElementKey InKey) { return default; }
	///<summary>Returns the index of an element given its key</summary>
	public int GetIndex_ForBlueprint(FRigElementKey InKey) { return default; }
	///<summary>Returns the index of an element given its key within its default parent (or root)</summary>
	public int GetLocalIndex_ForBlueprint(FRigElementKey InKey) { return default; }
	///<summary>Returns the key of an element given its index</summary>
	public FRigElementKey GetKey(int InElementIndex) { return default; }
	///<summary>Returns the keys of an array of indices</summary>
	public TArray<FRigElementKey> GetKeys(TArray<int> InElementIndices) { return default; }
	///<summary>Returns bone element for a given key, for scripting purpose only, for cpp usage, use Find&lt;FRigBoneElement&gt;()</summary>
	public FRigBoneElement FindBone_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	///<summary>Returns control element for a given key, for scripting purpose only, for cpp usage, use Find&lt;FRigControlElement&gt;()</summary>
	public FRigControlElement FindControl_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	///<summary>Returns null element for a given key, for scripting purpose only, for cpp usage, use Find&lt;FRigControlElement&gt;()</summary>
	public FRigNullElement FindNull_ForBlueprintOnly(FRigElementKey InKey) { return default; }
	///<summary>Returns all Bone elements</summary>
	public TArray<FRigElementKey> GetBoneKeys(bool bTraverse/*=true*/) { return default; }
	///<summary>Returns all Null elements</summary>
	public TArray<FRigElementKey> GetNullKeys(bool bTraverse/*=true*/) { return default; }
	///<summary>Returns all Control elements</summary>
	public TArray<FRigElementKey> GetControlKeys(bool bTraverse/*=true*/) { return default; }
	///<summary>Returns all Curve elements</summary>
	public TArray<FRigElementKey> GetCurveKeys() { return default; }
	///<summary>Returns all RigidBody elements</summary>
	public TArray<FRigElementKey> GetRigidBodyKeys(bool bTraverse/*=true*/) { return default; }
	///<summary>Returns all references</summary>
	public TArray<FRigElementKey> GetReferenceKeys(bool bTraverse/*=true*/) { return default; }
	///<summary>Returns all root element keys</summary>
	public TArray<FRigElementKey> GetRootElementKeys() { return default; }
	///<summary>Returns the name of metadata for a given element</summary>
	public TArray<string> GetMetadataNames(FRigElementKey InItem) { return default; }
	///<summary>Returns the type of metadata given its name the item it is stored under</summary>
	public ERigMetadataType GetMetadataType(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Removes the metadata under a given element</summary>
	public bool RemoveMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Removes all of the metadata under a given item</summary>
	public bool RemoveAllMetadata(FRigElementKey InItem) { return default; }
	///<summary>Queries and returns the value of bool metadata</summary>
	public bool GetBoolMetadata(FRigElementKey InItem,string InMetadataName,bool DefaultValue) { return default; }
	///<summary>Queries and returns the value of bool array metadata</summary>
	public TArray<bool> GetBoolArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a bool value</summary>
	public bool SetBoolMetadata(FRigElementKey InItem,string InMetadataName,bool InValue) { return default; }
	///<summary>Sets the metadata to a bool array value</summary>
	public bool SetBoolArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<bool> InValue) { return default; }
	///<summary>Queries and returns the value of float metadata</summary>
	public float GetFloatMetadata(FRigElementKey InItem,string InMetadataName,float DefaultValue) { return default; }
	///<summary>Queries and returns the value of float array metadata</summary>
	public TArray<float> GetFloatArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a float value</summary>
	public bool SetFloatMetadata(FRigElementKey InItem,string InMetadataName,float InValue) { return default; }
	///<summary>Sets the metadata to a float array value</summary>
	public bool SetFloatArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<float> InValue) { return default; }
	///<summary>Queries and returns the value of int32 metadata</summary>
	public int GetInt32Metadata(FRigElementKey InItem,string InMetadataName,int DefaultValue) { return default; }
	///<summary>Queries and returns the value of int32 array metadata</summary>
	public TArray<int> GetInt32ArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a int32 value</summary>
	public bool SetInt32Metadata(FRigElementKey InItem,string InMetadataName,int InValue) { return default; }
	///<summary>Sets the metadata to a int32 array value</summary>
	public bool SetInt32ArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<int> InValue) { return default; }
	///<summary>Queries and returns the value of FName metadata</summary>
	public string GetNameMetadata(FRigElementKey InItem,string InMetadataName,string DefaultValue) { return default; }
	///<summary>Queries and returns the value of FName array metadata</summary>
	public TArray<string> GetNameArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FName value</summary>
	public bool SetNameMetadata(FRigElementKey InItem,string InMetadataName,string InValue) { return default; }
	///<summary>Sets the metadata to a FName array value</summary>
	public bool SetNameArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<string> InValue) { return default; }
	///<summary>Queries and returns the value of FVector metadata</summary>
	public FVector GetVectorMetadata(FRigElementKey InItem,string InMetadataName,FVector DefaultValue) { return default; }
	///<summary>Queries and returns the value of FVector array metadata</summary>
	public TArray<FVector> GetVectorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FVector value</summary>
	public bool SetVectorMetadata(FRigElementKey InItem,string InMetadataName,FVector InValue) { return default; }
	///<summary>Sets the metadata to a FVector array value</summary>
	public bool SetVectorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FVector> InValue) { return default; }
	///<summary>Queries and returns the value of FRotator metadata</summary>
	public FRotator GetRotatorMetadata(FRigElementKey InItem,string InMetadataName,FRotator DefaultValue) { return default; }
	///<summary>Queries and returns the value of FRotator array metadata</summary>
	public TArray<FRotator> GetRotatorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FRotator value</summary>
	public bool SetRotatorMetadata(FRigElementKey InItem,string InMetadataName,FRotator InValue) { return default; }
	///<summary>Sets the metadata to a FRotator array value</summary>
	public bool SetRotatorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FRotator> InValue) { return default; }
	///<summary>Queries and returns the value of FQuat metadata</summary>
	public FQuat GetQuatMetadata(FRigElementKey InItem,string InMetadataName,FQuat DefaultValue) { return default; }
	///<summary>Queries and returns the value of FQuat array metadata</summary>
	public TArray<FQuat> GetQuatArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FQuat value</summary>
	public bool SetQuatMetadata(FRigElementKey InItem,string InMetadataName,FQuat InValue) { return default; }
	///<summary>Sets the metadata to a FQuat array value</summary>
	public bool SetQuatArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FQuat> InValue) { return default; }
	///<summary>Queries and returns the value of FTransform metadata</summary>
	public FTransform GetTransformMetadata(FRigElementKey InItem,string InMetadataName,FTransform DefaultValue) { return default; }
	///<summary>Queries and returns the value of FTransform array metadata</summary>
	public TArray<FTransform> GetTransformArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FTransform value</summary>
	public bool SetTransformMetadata(FRigElementKey InItem,string InMetadataName,FTransform InValue) { return default; }
	///<summary>Sets the metadata to a FTransform array value</summary>
	public bool SetTransformArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FTransform> InValue) { return default; }
	///<summary>Queries and returns the value of FLinearColor metadata</summary>
	public FLinearColor GetLinearColorMetadata(FRigElementKey InItem,string InMetadataName,FLinearColor DefaultValue) { return default; }
	///<summary>Queries and returns the value of FLinearColor array metadata</summary>
	public TArray<FLinearColor> GetLinearColorArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FLinearColor value</summary>
	public bool SetLinearColorMetadata(FRigElementKey InItem,string InMetadataName,FLinearColor InValue) { return default; }
	///<summary>Sets the metadata to a FLinearColor array value</summary>
	public bool SetLinearColorArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FLinearColor> InValue) { return default; }
	///<summary>Queries and returns the value of FRigElementKey metadata</summary>
	public FRigElementKey GetRigElementKeyMetadata(FRigElementKey InItem,string InMetadataName,FRigElementKey DefaultValue) { return default; }
	///<summary>Queries and returns the value of FRigElementKey array metadata</summary>
	public TArray<FRigElementKey> GetRigElementKeyArrayMetadata(FRigElementKey InItem,string InMetadataName) { return default; }
	///<summary>Sets the metadata to a FRigElementKey value</summary>
	public bool SetRigElementKeyMetadata(FRigElementKey InItem,string InMetadataName,FRigElementKey InValue) { return default; }
	///<summary>Sets the metadata to a FRigElementKey array value</summary>
	public bool SetRigElementKeyArrayMetadata(FRigElementKey InItem,string InMetadataName,TArray<FRigElementKey> InValue) { return default; }
	///<summary>* Returns the tags for a given item</summary>
	public TArray<string> GetTags(FRigElementKey InItem) { return default; }
	///<summary>* Returns true if a given item has a certain tag</summary>
	public bool HasTag(FRigElementKey InItem,string InTag) { return default; }
	///<summary>* Sets a tag on an element in the hierarchy</summary>
	public bool SetTag(FRigElementKey InItem,string InTag) { return default; }
	///<summary>Returns the keys of selected elements</summary>
	public TArray<FRigElementKey> GetSelectedKeys(ERigElementType InTypeFilter/*=ERigElementType.All*/) { return default; }
	///<summary>Returns true if a given element is selected</summary>
	public bool IsSelected(FRigElementKey InKey) { return default; }
	///<summary>Returns true if a given element is selected</summary>
	public bool IsSelectedByIndex(int InIndex) { return default; }
	///<summary>Sorts the input key list by traversing the hierarchy</summary>
	public TArray<FRigElementKey> SortKeys(TArray<FRigElementKey> InKeys) { return default; }
	///<summary>Returns the local current or initial value for a given key.</summary>
	public FTransform GetLocalTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the local current or initial value for a element index.</summary>
	public FTransform GetLocalTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Sets the local current or initial transform for a given key.</summary>
	public void SetLocalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets the local current or initial transform for a given element index.</summary>
	public void SetLocalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Returns the global current or initial value for a given key.</summary>
	public FTransform GetGlobalTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the global current or initial value for a element index.</summary>
	public FTransform GetGlobalTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Sets the global current or initial transform for a given key.</summary>
	public void SetGlobalTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) {}
	///<summary>Sets the global current or initial transform for a given element index.</summary>
	public void SetGlobalTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommand/*=false*/) {}
	///<summary>Returns the global offset transform for a given control element.</summary>
	public FTransform GetGlobalControlOffsetTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the global offset transform for a given control element.</summary>
	public FTransform GetGlobalControlOffsetTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the local shape transform for a given control element.</summary>
	public FTransform GetLocalControlShapeTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the local shape transform for a given control element.</summary>
	public FTransform GetLocalControlShapeTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the global shape transform for a given control element.</summary>
	public FTransform GetGlobalControlShapeTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the global shape transform for a given control element.</summary>
	public FTransform GetGlobalControlShapeTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Returns a control&#39;s current value given its key</summary>
	public FRigControlValue GetControlValue(FRigElementKey InKey,ERigControlValueType InValueType/*=ERigControlValueType.Current*/) { return default; }
	///<summary>Returns a control&#39;s current value given its index</summary>
	public FRigControlValue GetControlValueByIndex(int InElementIndex,ERigControlValueType InValueType/*=ERigControlValueType.Current*/) { return default; }
	///<summary>Returns a control&#39;s preferred rotator (local transform rotation)</summary>
	public FRotator GetControlPreferredRotator(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns a control&#39;s preferred rotator (local transform rotation)</summary>
	public FRotator GetControlPreferredRotatorByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Sets a control&#39;s preferred rotator (local transform rotation)</summary>
	public void SetControlPreferredRotator(FRigElementKey InKey,FRotator InValue,bool bInitial/*=false*/,bool bFixEulerFlips/*=false*/) {}
	///<summary>Sets a control&#39;s preferred rotator (local transform rotation)</summary>
	public void SetControlPreferredRotatorByIndex(int InElementIndex,FRotator InValue,bool bInitial/*=false*/,bool bFixEulerFlips/*=false*/) {}
	///<summary>Sets a control&#39;s current value given its key</summary>
	public void SetControlValue(FRigElementKey InKey,FRigControlValue InValue,ERigControlValueType InValueType/*=ERigControlValueType.Current*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets a control&#39;s current value given its index</summary>
	public void SetControlValueByIndex(int InElementIndex,FRigControlValue InValue,ERigControlValueType InValueType/*=ERigControlValueType.Current*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets a control&#39;s current visibility based on a key</summary>
	public void SetControlVisibility(FRigElementKey InKey,bool bVisibility) {}
	///<summary>Sets a control&#39;s current visibility based on a key</summary>
	public void SetControlVisibilityByIndex(int InElementIndex,bool bVisibility) {}
	///<summary>Returns a curve&#39;s value given its key</summary>
	public float GetCurveValue(FRigElementKey InKey) { return default; }
	///<summary>Returns a curve&#39;s value given its index</summary>
	public float GetCurveValueByIndex(int InElementIndex) { return default; }
	///<summary>Returns whether a curve&#39;s value is set, given its key</summary>
	public bool IsCurveValueSet(FRigElementKey InKey) { return default; }
	///<summary>Returns a curve&#39;s value given its index</summary>
	public bool IsCurveValueSetByIndex(int InElementIndex) { return default; }
	///<summary>Sets a curve&#39;s value given its key</summary>
	public void SetCurveValue(FRigElementKey InKey,float InValue,bool bSetupUndo/*=false*/) {}
	///<summary>Sets a curve&#39;s value given its index</summary>
	public void SetCurveValueByIndex(int InElementIndex,float InValue,bool bSetupUndo/*=false*/) {}
	///<summary>Sets a curve&#39;s value given its key</summary>
	public void UnsetCurveValue(FRigElementKey InKey,bool bSetupUndo/*=false*/) {}
	///<summary>Sets a curve&#39;s value given its index</summary>
	public void UnsetCurveValueByIndex(int InElementIndex,bool bSetupUndo/*=false*/) {}
	///<summary>Sets the offset transform for a given control element by key</summary>
	public void SetControlOffsetTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets the local offset transform for a given control element by index</summary>
	public void SetControlOffsetTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bAffectChildren/*=true*/,bool bSetupUndo/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets the shape transform for a given control element by key</summary>
	public void SetControlShapeTransform(FRigElementKey InKey,FTransform InTransform,bool bInitial/*=false*/,bool bSetupUndo/*=false*/) {}
	///<summary>Sets the local shape transform for a given control element by index</summary>
	public void SetControlShapeTransformByIndex(int InElementIndex,FTransform InTransform,bool bInitial/*=false*/,bool bSetupUndo/*=false*/) {}
	///<summary>Sets the control settings for a given control element by key</summary>
	public void SetControlSettings(FRigElementKey InKey,FRigControlSettings InSettings,bool bSetupUndo/*=false*/,bool bForce/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Sets the control settings for a given control element by index</summary>
	public void SetControlSettingsByIndex(int InElementIndex,FRigControlSettings InSettings,bool bSetupUndo/*=false*/,bool bForce/*=false*/,bool bPrintPythonCommands/*=false*/) {}
	///<summary>Returns the global current or initial value for a given key.</summary>
	public FTransform GetParentTransform(FRigElementKey InKey,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the global current or initial value for a given element index.</summary>
	public FTransform GetParentTransformByIndex(int InElementIndex,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the child elements of a given element key</summary>
	public TArray<FRigElementKey> GetChildren(FRigElementKey InKey,bool bRecursive/*=false*/) { return default; }
	///<summary>Returns the parent elements of a given element key</summary>
	public TArray<FRigElementKey> GetParents(FRigElementKey InKey,bool bRecursive/*=false*/) { return default; }
	///<summary>Returns the default parent element&#39;s key of a given child key</summary>
	public FRigElementKey GetDefaultParent(FRigElementKey InKey) { return default; }
	///<summary>Returns the first parent element of a given element key</summary>
	public FRigElementKey GetFirstParent(FRigElementKey InKey) { return default; }
	///<summary>Returns the number of parents of an element</summary>
	public int GetNumberOfParents(FRigElementKey InKey) { return default; }
	///<summary>Returns the weight of a parent below a multi parent element</summary>
	public FRigElementWeight GetParentWeight(FRigElementKey InChild,FRigElementKey InParent,bool bInitial/*=false*/) { return default; }
	///<summary>Returns the weights of all parents below a multi parent element</summary>
	public TArray<FRigElementWeight> GetParentWeightArray(FRigElementKey InChild,bool bInitial/*=false*/) { return default; }
	///<summary>Sets the weight of a parent below a multi parent element</summary>
	public bool SetParentWeight(FRigElementKey InChild,FRigElementKey InParent,FRigElementWeight InWeight,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	///<summary>Sets the all of the weights of the parents of a multi parent element</summary>
	public bool SetParentWeightArray(FRigElementKey InChild,TArray<FRigElementWeight> InWeights,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	///<summary>Switches a multi parent element to a single parent.</summary>
	public bool SwitchToParent(FRigElementKey InChild,FRigElementKey InParent,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	///<summary>Switches a multi parent element to its first parent</summary>
	public bool SwitchToDefaultParent(FRigElementKey InChild,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	///<summary>Switches a multi parent element to world space.</summary>
	public bool SwitchToWorldSpace(FRigElementKey InChild,bool bInitial/*=false*/,bool bAffectChildren/*=true*/) { return default; }
	///<summary>Returns true if an element is parented to another element</summary>
	public bool IsParentedTo(FRigElementKey InChild,FRigElementKey InParent) { return default; }
	///<summary>Returns all element keys of this hierarchy</summary>
	public TArray<FRigElementKey> GetAllKeys_ForBlueprint(bool bTraverse/*=true*/) { return default; }
	///<summary>Sends an autokey event from the hierarchy to the world</summary>
	public void SendAutoKeyEvent(FRigElementKey InElement,float InOffsetInSeconds/*=0.0f*/,bool bAsynchronous/*=true*/) {}
	///<summary>Returns true if the hierarchy controller is currently available</summary>
	public bool IsControllerAvailable() { return default; }
	///<summary>Returns a controller for this hierarchy.</summary>
	public URigHierarchyController GetController(bool bCreateIfNeeded/*=true*/) { return default; }
	///<summary>Returns the current / initial pose of the hierarchy</summary>
	public FRigPose GetPose(bool bInitial/*=false*/) { return default; }
	///<summary>Sets the current / initial pose of the hierarchy</summary>
	public void SetPose_ForBlueprint(FRigPose InPose) {}
	///<summary>Creates a rig control value from a bool value</summary>
	public static FRigControlValue MakeControlValueFromBool(bool InValue) { return default; }
	///<summary>Creates a rig control value from a float value</summary>
	public static FRigControlValue MakeControlValueFromFloat(float InValue) { return default; }
	///<summary>Returns the contained float value from a a Rig Control Value</summary>
	public static float GetFloatFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a int32 value</summary>
	public static FRigControlValue MakeControlValueFromInt(int InValue) { return default; }
	///<summary>Returns the contained int32 value from a a Rig Control Value</summary>
	public static int GetIntFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FVector2D value</summary>
	public static FRigControlValue MakeControlValueFromVector2D(FVector2D InValue) { return default; }
	///<summary>Returns the contained FVector2D value from a a Rig Control Value</summary>
	public static FVector2D GetVector2DFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FVector value</summary>
	public static FRigControlValue MakeControlValueFromVector(FVector InValue) { return default; }
	///<summary>Returns the contained FVector value from a a Rig Control Value</summary>
	public static FVector GetVectorFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FRotator value</summary>
	public static FRigControlValue MakeControlValueFromRotator(FRotator InValue) { return default; }
	///<summary>Returns the contained FRotator value from a a Rig Control Value</summary>
	public static FRotator GetRotatorFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FTransform value</summary>
	public static FRigControlValue MakeControlValueFromTransform(FTransform InValue) { return default; }
	///<summary>Returns the contained FTransform value from a a Rig Control Value</summary>
	public static FTransform GetTransformFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FEulerTransform value</summary>
	public static FRigControlValue MakeControlValueFromEulerTransform(FEulerTransform InValue) { return default; }
	///<summary>Returns the contained FEulerTransform value from a a Rig Control Value</summary>
	public static FEulerTransform GetEulerTransformFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Creates a rig control value from a FTransformNoScale value</summary>
	public static FRigControlValue MakeControlValueFromTransformNoScale(FTransformNoScale InValue) { return default; }
	///<summary>Returns the contained FTransformNoScale value from a a Rig Control Value</summary>
	public static FTransformNoScale GetTransformNoScaleFromControlValue(FRigControlValue InValue) { return default; }
	///<summary>Returns the previous name of an element prior to a rename operation</summary>
	public string GetPreviousName(FRigElementKey InKey) { return default; }
	///<summary>Returns the previous parent of an element prior to a reparent operation</summary>
	public FRigElementKey GetPreviousParent(FRigElementKey InKey) { return default; }
	///<summary>The topology version of the hierarchy changes when elements are</summary>
	public ushort TopologyVersion;
	///<summary>The metadata version of the hierarchy changes when metadata is being</summary>
	public ushort MetadataVersion;
	///<summary>The metadata version of the hierarchy changes when metadata is being</summary>
	public ushort MetadataTagVersion;
	///<summary>If set to false the dirty flag propagation will be disabled</summary>
	public bool bEnableDirtyPropagation;
	///<summary>The index identifying where we stand with the stack</summary>
	public int TransformStackIndex;
	///<summary>HierarchyController</summary>
	public URigHierarchyController HierarchyController;
	///<summary>We save this so Sequencer can remap this after load</summary>
	public TMap<FRigElementKey,FRigElementKey> PreviousNameMap;
	///<summary>HierarchyForCacheValidation</summary>
	public URigHierarchy HierarchyForCacheValidation;
}
