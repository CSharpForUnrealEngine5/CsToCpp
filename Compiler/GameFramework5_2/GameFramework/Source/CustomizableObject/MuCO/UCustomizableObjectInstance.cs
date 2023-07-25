#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObjectInstance.h")]
public partial class UCustomizableObjectInstance : UObject {
// CustomizableObjectInstance
	public FBeginUpdateDelegate BeginUpdateDelegate;
	public FObjectInstanceUpdatedDelegate UpdatedDelegate;
	public FBeginDestroyDelegate BeginDestroyDelegate;
	public TArray<USkeletalMesh> SkeletalMeshes;
	public string SkeletalMeshStatus;
	public void SetObject(UObject InObject) {}
	public UObject GetCustomizableObject() { return default; }
	public bool GetBuildParameterDecorations() { return default; }
	public void SetBuildParameterDecorations(bool Value) {}
	public string GetCurrentState() { return default; }
	public void SetCurrentState(string StateName) {}
	public UObject GetSkeletalMesh(int ComponentIndex/*=0*/) { return default; }
	public bool HasAnySkeletalMesh() { return default; }
	public TArray<FCustomizableObjectBoolParameterValue> GetBoolParameters() { return default; }
	public TArray<FCustomizableObjectIntParameterValue> GetIntParameters() { return default; }
	public TArray<FCustomizableObjectFloatParameterValue> GetFloatParameters() { return default; }
	public TArray<FCustomizableObjectTextureParameterValue> GetTextureParameters() { return default; }
	public TArray<FCustomizableObjectVectorParameterValue> GetVectorParameters() { return default; }
	public TArray<FCustomizableObjectProjectorParameterValue> GetProjectorParameters() { return default; }
	public bool HasAnyParameters() { return default; }
	public void SetRandomValues() {}
	public void UpdateSkeletalMeshAsync(bool bIgnoreCloseDist/*=false*/,bool bForceHighPriority/*=false*/) {}
	public UObject Clone() { return default; }
	public UObject CloneStatic(UObject Outer) { return default; }
	public UObject GetParameterDescription(string ParamName,int DescIndex) { return default; }
	public bool IsParameterRelevant(string ParamName) { return default; }
	public bool IsParamMultidimensional(string ParamName) { return default; }
	public int GetProjectorValueRange(string ParamName) { return default; }
	public string GetIntParameterSelectedOption(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public void SetIntParameterSelectedOption(string ParamName,string SelectedOptionName,int RangeIndex/*=-1*/) {}
	public float GetFloatParameterSelectedOption(string FloatParamName,int RangeIndex/*=-1*/) { return default; }
	public void SetFloatParameterSelectedOption(string FloatParamName,float FloatValue,int RangeIndex/*=-1*/) {}
	public UObject GetTextureParameterSelectedOptionT(string TextureParamName,int RangeIndex/*=-1*/) { return default; }
	public void SetTextureParameterSelectedOptionT(string TextureParamName,UObject TextureValue,int RangeIndex/*=-1*/) {}
	public FLinearColor GetColorParameterSelectedOption(string ColorParamName) { return default; }
	public void SetColorParameterSelectedOption(string ColorParamName,FLinearColor ColorValue) {}
	public bool GetBoolParameterSelectedOption(string BoolParamName) { return default; }
	public void SetBoolParameterSelectedOption(string BoolParamName,bool BoolValue) {}
	public void SetVectorParameterSelectedOption(string VectorParamName,FLinearColor VectorValue) {}
	public void SetProjectorValue(string ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,int RangeIndex/*=-1*/) {}
	public void GetProjectorValue(string ProjectorParamName,FVector OutPos,FVector OutDirection,FVector OutUp,FVector OutScale,float OutAngle,ECustomizableObjectProjectorType OutType,int RangeIndex/*=-1*/) {}
	public FVector GetProjectorPosition(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public FVector GetProjectorDirection(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public FVector GetProjectorUp(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public FVector GetProjectorScale(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public float GetProjectorAngle(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public ECustomizableObjectProjectorType GetProjectorParameterType(string ParamName,int RangeIndex/*=-1*/) { return default; }
	public int FindIntParameterNameIndex(string ParamName) { return default; }
	public int FindFloatParameterNameIndex(string ParamName) { return default; }
	public int FindBoolParameterNameIndex(string ParamName) { return default; }
	public int FindVectorParameterNameIndex(string ParamName) { return default; }
	public int FindProjectorParameterNameIndex(string ParamName) { return default; }
	public int AddValueToIntRange(string ParamName) { return default; }
	public int AddValueToFloatRange(string ParamName) { return default; }
	public int AddValueToProjectorRange(string ParamName) { return default; }
	public int RemoveValueFromIntRange(string ParamName) { return default; }
	public int RemoveValueFromFloatRange(string ParamName) { return default; }
	public int RemoveValueFromProjectorRange(string ParamName) { return default; }
	public bool CreateMultiLayerProjector(string ProjectorParamName) { return default; }
	public void RemoveMultilayerProjector(string ProjectorParamName) {}
	public int MultilayerProjectorNumLayers(string ProjectorParamName) { return default; }
	public void MultilayerProjectorCreateLayer(string ProjectorParamName,int Index) {}
	public void MultilayerProjectorRemoveLayerAt(string ProjectorParamName,int Index) {}
	public FMultilayerProjectorLayer MultilayerProjectorGetLayer(string ProjectorParamName,int Index) { return default; }
	public void MultilayerProjectorUpdateLayer(string ProjectorParamName,int Index,FMultilayerProjectorLayer Layer) {}
	public TArray<string> MultilayerProjectorGetVirtualLayers(string ProjectorParamName) { return default; }
	public void MultilayerProjectorCreateVirtualLayer(string ProjectorParamName,string Id) {}
	public FMultilayerProjectorVirtualLayer MultilayerProjectorFindOrCreateVirtualLayer(string ProjectorParamName,string Id) { return default; }
	public void MultilayerProjectorRemoveVirtualLayer(string ProjectorParamName,string Id) {}
	public FMultilayerProjectorVirtualLayer MultilayerProjectorGetVirtualLayer(string ProjectorParamName,string Id) { return default; }
	public void MultilayerProjectorUpdateVirtualLayer(string ProjectorParamName,string Id,FMultilayerProjectorVirtualLayer Layer) {}
	public UClass GetAnimBP(int ComponentIndex,int SlotIndex) { return default; }
	public FGameplayTagContainer GetAnimationGameplayTags() { return default; }
	public void ForEachAnimInstance(int ComponentIndex,FEachComponentAnimInstanceClassDelegate Delegate) {}
	public void SetReplacePhysicsAssets(bool bReplaceEnabled) {}
	public FCustomizableObjectInstanceDescriptor Descriptor;
	public UCustomizableInstancePrivateData PrivateData;
	public TArray<UTexture2D> TextureParameterDeclarations;
	public UCustomizableObject CustomizableObject_DEPRECATED;
	public TArray<FCustomizableObjectBoolParameterValue> BoolParameters_DEPRECATED;
	public TArray<FCustomizableObjectIntParameterValue> IntParameters_DEPRECATED;
	public TArray<FCustomizableObjectFloatParameterValue> FloatParameters_DEPRECATED;
	public TArray<FCustomizableObjectTextureParameterValue> TextureParameters_DEPRECATED;
	public TArray<FCustomizableObjectVectorParameterValue> VectorParameters_DEPRECATED;
	public TArray<FCustomizableObjectProjectorParameterValue> ProjectorParameters_DEPRECATED;
	public TMap<string,FMultilayerProjector> MultilayerProjectors_DEPRECATED;
	public bool bBuildParameterDecorations_DEPRECATED;
}
