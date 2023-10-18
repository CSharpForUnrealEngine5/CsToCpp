namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectInstance.h")]
public partial class UCustomizableObjectInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Broadcast at the beginning of an Instance update.</summary>
	public FBeginUpdateDelegate BeginUpdateDelegate;
	///<summary>Broadcast when the Customizable Object Instance is updated.</summary>
	public FObjectInstanceUpdatedDelegate UpdatedDelegate;
	///<summary>Broadcast when UObject::BeginDestroy is being called.</summary>
	public FBeginDestroyDelegate BeginDestroyDelegate;
	///<summary>The generated skeletal meshes for this Instance, one for each component</summary>
	public TArray<USkeletalMesh> SkeletalMeshes;
	///<summary>Will store status description of current skeletal mesh generation (for instance, &quot;EmptyLOD0&quot; or &quot;EmptyMesh&quot;</summary>
	public string SkeletalMeshStatus;
	///<summary>SetObject</summary>
	public void SetObject(UCustomizableObject InObject) {}
	///<summary>Get the current CustomizableObject</summary>
	public UCustomizableObject GetCustomizableObject() { return default; }
	///<summary>GetBuildParameterDecorations</summary>
	public bool GetBuildParameterDecorations() { return default; }
	///<summary>SetBuildParameterDecorations</summary>
	public void SetBuildParameterDecorations(bool Value) {}
	///<summary>GetBuildParameterRelevancy</summary>
	public bool GetBuildParameterRelevancy() { return default; }
	///<summary>SetBuildParameterRelevancy</summary>
	public void SetBuildParameterRelevancy(bool Value) {}
	///<summary>GetCurrentState</summary>
	public string GetCurrentState() { return default; }
	///<summary>SetCurrentState</summary>
	public void SetCurrentState(string StateName) {}
	///<summary>GetSkeletalMesh</summary>
	public USkeletalMesh GetSkeletalMesh(int ComponentIndex/*=0*/) { return default; }
	///<summary>HasAnySkeletalMesh</summary>
	public bool HasAnySkeletalMesh() { return default; }
	///<summary>GetBoolParameters</summary>
	public TArray<FCustomizableObjectBoolParameterValue> GetBoolParameters() { return default; }
	///<summary>GetIntParameters</summary>
	public TArray<FCustomizableObjectIntParameterValue> GetIntParameters() { return default; }
	///<summary>GetFloatParameters</summary>
	public TArray<FCustomizableObjectFloatParameterValue> GetFloatParameters() { return default; }
	///<summary>GetTextureParameters</summary>
	public TArray<FCustomizableObjectTextureParameterValue> GetTextureParameters() { return default; }
	///<summary>GetVectorParameters</summary>
	public TArray<FCustomizableObjectVectorParameterValue> GetVectorParameters() { return default; }
	///<summary>GetProjectorParameters</summary>
	public TArray<FCustomizableObjectProjectorParameterValue> GetProjectorParameters() { return default; }
	///<summary>See FCustomizableObjectInstanceDescriptor::HasAnyParameters.</summary>
	public bool HasAnyParameters() { return default; }
	///<summary>Set random values to the parameters. Useful for testing only.</summary>
	public void SetRandomValues() {}
	///<summary>Update Skeletal Mesh asynchronously.</summary>
	public void UpdateSkeletalMeshAsync(bool bIgnoreCloseDist/*=false*/,bool bForceHighPriority/*=false*/) {}
	///<summary>Update Skeletal Mesh asynchronously. Callback will be called once the update finishes, even if it fails.</summary>
	public void UpdateSkeletalMeshAsyncResult(FInstanceUpdateDelegate Callback,bool bIgnoreCloseDist/*=false*/,bool bForceHighPriority/*=false*/) {}
	///<summary>Clones the instance creating a new identical transient instance.</summary>
	public UCustomizableObjectInstance Clone() { return default; }
	///<summary>Clones the instance creating a new identical static instance.</summary>
	public UCustomizableObjectInstance CloneStatic(UObject Outer) { return default; }
	///<summary>Returns de description texture (ex: color bar) for this parameter and DescIndex</summary>
	public UTexture2D GetParameterDescription(string ParamName,int DescIndex) { return default; }
	///<summary>IsParameterRelevant</summary>
	public bool IsParameterRelevant(string ParamName) { return default; }
	///<summary>IsParamMultidimensional</summary>
	public bool IsParamMultidimensional(string ParamName) { return default; }
	///<summary>GetProjectorValueRange</summary>
	public int GetProjectorValueRange(string ParamName) { return default; }
	///<summary>GetIntValueRange</summary>
	public int GetIntValueRange(string ParamName) { return default; }
	///<summary>GetFloatValueRange</summary>
	public int GetFloatValueRange(string ParamName) { return default; }
	///<summary>GetTextureValueRange</summary>
	public int GetTextureValueRange(string ParamName) { return default; }
	///<summary>DEPRECATED: Use the method in the CustomizableObject instead which takes an index among all parameters</summary>
	public string GetIntParameterSelectedOption(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Sets the selected option of an int parameter, by the option&#39;s name</summary>
	public void SetIntParameterSelectedOption(string ParamName,string SelectedOptionName,int RangeIndex/*=-1*/) {}
	///<summary>Gets the value of a float parameter with name &quot;FloatParamName&quot;</summary>
	public float GetFloatParameterSelectedOption(string FloatParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Sets the float value &quot;FloatValue&quot; of a float parameter with index &quot;FloatParamIndex&quot;</summary>
	public void SetFloatParameterSelectedOption(string FloatParamName,float FloatValue,int RangeIndex/*=-1*/) {}
	///<summary>Gets the value of a texture parameter with name &quot;TextureParamName&quot;.</summary>
	public FName GetTextureParameterSelectedOption(string TextureParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Sets the texture value &quot;TextureValue&quot; of a texture parameter with index &quot;TextureParamIndex&quot;.</summary>
	public void SetTextureParameterSelectedOption(string TextureParamName,string TextureValue,int RangeIndex/*=-1*/) {}
	///<summary>@deprecated Use SetTextureParameterSelectedOption instead.</summary>
	public void SetTextureParameterSelectedOptionT(string TextureParamName,UTexture2D TextureValue,int RangeIndex/*=-1*/) {}
	///<summary>Gets the value of a color parameter with name &quot;ColorParamName&quot;</summary>
	public FLinearColor GetColorParameterSelectedOption(string ColorParamName) { return default; }
	///<summary>Sets the color value &quot;ColorValue&quot; of a color parameter with index &quot;ColorParamIndex&quot;</summary>
	public void SetColorParameterSelectedOption(string ColorParamName,FLinearColor ColorValue) {}
	///<summary>Sets the bool value &quot;BoolValue&quot; of a bool parameter with name &quot;BoolParamName&quot;</summary>
	public bool GetBoolParameterSelectedOption(string BoolParamName) { return default; }
	///<summary>Sets the bool value &quot;BoolValue&quot; of a bool parameter with name &quot;BoolParamName&quot;</summary>
	public void SetBoolParameterSelectedOption(string BoolParamName,bool BoolValue) {}
	///<summary>Sets the vector value &quot;VectorValue&quot; of a bool parameter with index &quot;VectorParamIndex&quot;</summary>
	public void SetVectorParameterSelectedOption(string VectorParamName,FLinearColor VectorValue) {}
	///<summary>Sets the projector values of a projector parameter with index &quot;ProjectorParamIndex&quot;</summary>
	public void SetProjectorValue(string ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,int RangeIndex/*=-1*/) {}
	///<summary>Get the projector values of a projector parameter with index &quot;ProjectorParamIndex&quot;</summary>
	public void GetProjectorValue(string ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,ECustomizableObjectProjectorType OutType,int RangeIndex/*=-1*/) {}
	///<summary>Get the current projector position for the parameter with the given name</summary>
	public FVector GetProjectorPosition(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Get the current projector direction vector for the parameter with the given name</summary>
	public FVector GetProjectorDirection(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Get the current projector up vector for the parameter with the given name</summary>
	public FVector GetProjectorUp(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Get the current projector scale for the parameter with the given name</summary>
	public FVector GetProjectorScale(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Get the current cylindrical projector angle for the parameter with the given name</summary>
	public float GetProjectorAngle(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Get the current projector type for the parameter with the given name</summary>
	public ECustomizableObjectProjectorType GetProjectorParameterType(string ParamName,int RangeIndex/*=-1*/) { return default; }
	///<summary>Finds in IntParameters a parameter with name ParamName, returns the index if found, -1 otherwise</summary>
	public int FindIntParameterNameIndex(string ParamName) { return default; }
	///<summary>Finds in FloatParameters a parameter with name ParamName, returns the index if found, -1 otherwise</summary>
	public int FindFloatParameterNameIndex(string ParamName) { return default; }
	///<summary>Finds in BoolParameters a parameter with name ParamName, returns the index if found, -1 otherwise</summary>
	public int FindBoolParameterNameIndex(string ParamName) { return default; }
	///<summary>Finds in VectorParameters a parameter with name ParamName, returns the index if found, -1 otherwise</summary>
	public int FindVectorParameterNameIndex(string ParamName) { return default; }
	///<summary>Finds in ProjectorParameters a parameter with name ParamName, returns the index if found, -1 otherwise</summary>
	public int FindProjectorParameterNameIndex(string ParamName) { return default; }
	///<summary>Increases the range of values of the integer with ParamName, returns the index of the new integer value, -1 otherwise.</summary>
	public int AddValueToIntRange(string ParamName) { return default; }
	///<summary>Increases the range of values of the float with ParamName, returns the index of the new float value, -1 otherwise.</summary>
	public int AddValueToFloatRange(string ParamName) { return default; }
	///<summary>Increases the range of values of the projector with ParamName, returns the index of the new projector value, -1 otherwise.</summary>
	public int AddValueToProjectorRange(string ParamName) { return default; }
	///<summary>Remove the last of the integer range of values from the parameter ParamName, returns the index of the last valid integer, -1 if no values left.</summary>
	public int RemoveValueFromIntRange(string ParamName) { return default; }
	///<summary>Remove the last of the float range of values from the parameter ParamName, returns the index of the last valid float, -1 if no values left.</summary>
	public int RemoveValueFromFloatRange(string ParamName) { return default; }
	///<summary>Remove the last of the projector range of values from the parameter ParamName, returns the index of the last valid projector, -1 if no values left.</summary>
	public int RemoveValueFromProjectorRange(string ParamName) { return default; }
	///<summary>Given Multilayer Projector name, create a new Multilayer Projector Helper (if non-existent). See FMultilayerProjector.</summary>
	public bool CreateMultiLayerProjector(FName ProjectorParamName) { return default; }
	///<summary>Given Multilayer Projector name, remove a Multilayer Projector Helper. See FMultilayerProjector.</summary>
	public void RemoveMultilayerProjector(FName ProjectorParamName) {}
	///<summary>See FMultilayerProjector::NumLayers.</summary>
	public int MultilayerProjectorNumLayers(FName ProjectorParamName) { return default; }
	///<summary>See FMultilayerProjector::CreateLayer.</summary>
	public void MultilayerProjectorCreateLayer(FName ProjectorParamName,int Index) {}
	///<summary>See FMultilayerProjector::RemoveLayerAt.</summary>
	public void MultilayerProjectorRemoveLayerAt(FName ProjectorParamName,int Index) {}
	///<summary>See FMultilayerProjector::GetLayer.</summary>
	public FMultilayerProjectorLayer MultilayerProjectorGetLayer(FName ProjectorParamName,int Index) { return default; }
	///<summary>See FMultilayerProjector::UpdateLayer.</summary>
	public void MultilayerProjectorUpdateLayer(FName ProjectorParamName,int Index,FMultilayerProjectorLayer Layer) {}
	///<summary>See FMultilayerProjector::GetVirtualLayers.</summary>
	public TArray<FName> MultilayerProjectorGetVirtualLayers(FName ProjectorParamName) { return default; }
	///<summary>See FMultilayerProjector::VirtualLayer.</summary>
	public void MultilayerProjectorCreateVirtualLayer(FName ProjectorParamName,FName Id) {}
	///<summary>See FMultilayerProjector::FindOrCreateVirtualLayer.</summary>
	public FMultilayerProjectorVirtualLayer MultilayerProjectorFindOrCreateVirtualLayer(FName ProjectorParamName,FName Id) { return default; }
	///<summary>See FMultilayerProjector::RemoveVirtualLayer.</summary>
	public void MultilayerProjectorRemoveVirtualLayer(FName ProjectorParamName,FName Id) {}
	///<summary>See FMultilayerProjector::GetVirtualLayer.</summary>
	public FMultilayerProjectorVirtualLayer MultilayerProjectorGetVirtualLayer(FName ProjectorParamName,FName Id) { return default; }
	///<summary>See FMultilayerProjector::UpdateVirtualLayer.</summary>
	public void MultilayerProjectorUpdateVirtualLayer(FName ProjectorParamName,FName Id,FMultilayerProjectorVirtualLayer Layer) {}
	///<summary>Returns the animation BP for the parameter component and slot, gathered from all the meshes that compose this instance</summary>
	public UClass GetAnimBP(int ComponentIndex,FName Slot) { return default; }
	///<summary>GetAnimationGameplayTags</summary>
	public FGameplayTagContainer GetAnimationGameplayTags() { return default; }
	///<summary>ForEachAnimInstance</summary>
	public void ForEachAnimInstance(int ComponentIndex,FEachComponentAnimInstanceClassDelegate Delegate) {}
	///<summary>Enable physics asset replacement so that generated skeletal meshes have the merged physics assets of their skeletal mesh parts and reference mesh</summary>
	public void SetReplacePhysicsAssets(bool bReplaceEnabled) {}
	///<summary>GetNumComponents</summary>
	public int GetNumComponents() { return default; }
	///<summary>Descriptor</summary>
	public FCustomizableObjectInstanceDescriptor Descriptor;
	///<summary>PrivateData</summary>
	public UCustomizableInstancePrivateData PrivateData;
	///<summary>Textures used in the Texture Parameters.</summary>
	public TArray<UTexture2D> TextureParameterDeclarations;
	///<summary>Deprecated properties</summary>
	public UCustomizableObject CustomizableObject_DEPRECATED;
	///<summary>BoolParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters_DEPRECATED;
	///<summary>IntParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectIntParameterValue> IntParameters_DEPRECATED;
	///<summary>FloatParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters_DEPRECATED;
	///<summary>TextureParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters_DEPRECATED;
	///<summary>VectorParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters_DEPRECATED;
	///<summary>ProjectorParameters_DEPRECATED</summary>
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters_DEPRECATED;
	///<summary>MultilayerProjectors_DEPRECATED</summary>
	public TMap<FName,FMultilayerProjector> MultilayerProjectors_DEPRECATED;
}
