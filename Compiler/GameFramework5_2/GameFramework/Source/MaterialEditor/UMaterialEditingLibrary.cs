#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditingLibrary.h")]
///<summary>Blueprint library for creating/editing Materials</summary>
public partial class UMaterialEditingLibrary : UBlueprintFunctionLibrary {
// MaterialEditingLibrary
	public int GetNumMaterialExpressions(UObject Material) { return default; }
	public void DeleteAllMaterialExpressions(UObject Material) {}
	public void DeleteMaterialExpression(UObject Material,UObject Expression) {}
	public UObject CreateMaterialExpression(UObject Material,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	public UObject DuplicateMaterialExpression(UObject Material,UObject MaterialFunction,UObject Expression) { return default; }
	public bool SetMaterialUsage(UObject Material,EMaterialUsage Usage,bool bNeedsRecompile) { return default; }
	public bool HasMaterialUsage(UObject Material,EMaterialUsage Usage) { return default; }
	public bool ConnectMaterialProperty(UObject FromExpression,string FromOutputName,EMaterialProperty Property) { return default; }
	public bool ConnectMaterialExpressions(UObject FromExpression,string FromOutputName,UObject ToExpression,string ToInputName) { return default; }
	public void RecompileMaterial(UObject Material) {}
	public void LayoutMaterialExpressions(UObject Material) {}
	public float GetMaterialDefaultScalarParameterValue(UObject Material,string ParameterName) { return default; }
	public UObject GetMaterialDefaultTextureParameterValue(UObject Material,string ParameterName) { return default; }
	public FLinearColor GetMaterialDefaultVectorParameterValue(UObject Material,string ParameterName) { return default; }
	public bool GetMaterialDefaultStaticSwitchParameterValue(UObject Material,string ParameterName) { return default; }
	public TSet<UObject> GetMaterialSelectedNodes(UObject Material) { return default; }
	public UObject GetMaterialPropertyInputNode(UObject Material,EMaterialProperty Property) { return default; }
	public string GetMaterialPropertyInputNodeOutputName(UObject Material,EMaterialProperty Property) { return default; }
	public TArray<UObject> GetInputsForMaterialExpression(UObject Material,UObject MaterialExpression) { return default; }
	public bool GetInputNodeOutputNameForMaterialExpression(UObject MaterialExpression,UObject InputNode,string OutputName) { return default; }
	public void GetMaterialExpressionNodePosition(UObject MaterialExpression,int NodePosX,int NodePosY) {}
	public TArray<UObject> GetUsedTextures(UObject Material) { return default; }
	public int GetNumMaterialExpressionsInFunction(UObject MaterialFunction) { return default; }
	public UObject CreateMaterialExpressionInFunction(UObject MaterialFunction,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	public void DeleteAllMaterialExpressionsInFunction(UObject MaterialFunction) {}
	public void DeleteMaterialExpressionInFunction(UObject MaterialFunction,UObject Expression) {}
	public void UpdateMaterialFunction(UObject MaterialFunction,UObject PreviewMaterial/*=nullptr*/) {}
	public void LayoutMaterialFunctionExpressions(UObject MaterialFunction) {}
	public void SetMaterialInstanceParent(UObject Instance,UObject NewParent) {}
	public void ClearAllMaterialInstanceParameters(UObject Instance) {}
	public float GetMaterialInstanceScalarParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceScalarParameterValue(UObject Instance,string ParameterName,float Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public UObject GetMaterialInstanceTextureParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceTextureParameterValue(UObject Instance,string ParameterName,UObject Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public UObject GetMaterialInstanceRuntimeVirtualTextureParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceRuntimeVirtualTextureParameterValue(UObject Instance,string ParameterName,UObject Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public UObject GetMaterialInstanceSparseVolumeTextureParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceSparseVolumeTextureParameterValue(UObject Instance,string ParameterName,UObject Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public FLinearColor GetMaterialInstanceVectorParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceVectorParameterValue(UObject Instance,string ParameterName,FLinearColor Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool GetMaterialInstanceStaticSwitchParameterValue(UObject Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public bool SetMaterialInstanceStaticSwitchParameterValue(UObject Instance,string ParameterName,bool Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public void UpdateMaterialInstance(UObject Instance) {}
	public void GetChildInstances(UObject Parent,TArray<FAssetData> ChildInstances) {}
	public void GetScalarParameterNames(UObject Material,TArray<string> ParameterNames) {}
	public void GetVectorParameterNames(UObject Material,TArray<string> ParameterNames) {}
	public void GetTextureParameterNames(UObject Material,TArray<string> ParameterNames) {}
	public void GetStaticSwitchParameterNames(UObject Material,TArray<string> ParameterNames) {}
	public bool GetScalarParameterSource(UObject Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public bool GetVectorParameterSource(UObject Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public bool GetTextureParameterSource(UObject Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public bool GetStaticSwitchParameterSource(UObject Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public FMaterialStatistics GetStatistics(UObject Material) { return default; }
}
