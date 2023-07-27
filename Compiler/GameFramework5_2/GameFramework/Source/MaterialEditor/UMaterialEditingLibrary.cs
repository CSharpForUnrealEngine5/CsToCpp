#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MaterialEditingLibrary.h")]
///<summary>Blueprint library for creating/editing Materials</summary>
public partial class UMaterialEditingLibrary : UBlueprintFunctionLibrary {
// MaterialEditingLibrary
	public static int GetNumMaterialExpressions(UMaterial Material) { return default; }
	public static void DeleteAllMaterialExpressions(UMaterial Material) {}
	public static void DeleteMaterialExpression(UMaterial Material,UMaterialExpression Expression) {}
	public static UMaterialExpression CreateMaterialExpression(UMaterial Material,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	public static UMaterialExpression DuplicateMaterialExpression(UMaterial Material,UMaterialFunction MaterialFunction,UMaterialExpression Expression) { return default; }
	public static bool SetMaterialUsage(UMaterial Material,EMaterialUsage Usage,bool bNeedsRecompile) { return default; }
	public static bool HasMaterialUsage(UMaterial Material,EMaterialUsage Usage) { return default; }
	public static bool ConnectMaterialProperty(UMaterialExpression FromExpression,string FromOutputName,EMaterialProperty Property) { return default; }
	public static bool ConnectMaterialExpressions(UMaterialExpression FromExpression,string FromOutputName,UMaterialExpression ToExpression,string ToInputName) { return default; }
	public static void RecompileMaterial(UMaterial Material) {}
	public static void LayoutMaterialExpressions(UMaterial Material) {}
	public static float GetMaterialDefaultScalarParameterValue(UMaterial Material,string ParameterName) { return default; }
	public static UTexture GetMaterialDefaultTextureParameterValue(UMaterial Material,string ParameterName) { return default; }
	public static FLinearColor GetMaterialDefaultVectorParameterValue(UMaterial Material,string ParameterName) { return default; }
	public static bool GetMaterialDefaultStaticSwitchParameterValue(UMaterial Material,string ParameterName) { return default; }
	public static TSet<UObject> GetMaterialSelectedNodes(UMaterial Material) { return default; }
	public static UMaterialExpression GetMaterialPropertyInputNode(UMaterial Material,EMaterialProperty Property) { return default; }
	public static string GetMaterialPropertyInputNodeOutputName(UMaterial Material,EMaterialProperty Property) { return default; }
	public static TArray<UMaterialExpression> GetInputsForMaterialExpression(UMaterial Material,UMaterialExpression MaterialExpression) { return default; }
	public static bool GetInputNodeOutputNameForMaterialExpression(UMaterialExpression MaterialExpression,UMaterialExpression InputNode,string OutputName) { return default; }
	public static void GetMaterialExpressionNodePosition(UMaterialExpression MaterialExpression,int NodePosX,int NodePosY) {}
	public static TArray<UTexture> GetUsedTextures(UMaterial Material) { return default; }
	public static int GetNumMaterialExpressionsInFunction(UMaterialFunction MaterialFunction) { return default; }
	public static UMaterialExpression CreateMaterialExpressionInFunction(UMaterialFunction MaterialFunction,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	public static void DeleteAllMaterialExpressionsInFunction(UMaterialFunction MaterialFunction) {}
	public static void DeleteMaterialExpressionInFunction(UMaterialFunction MaterialFunction,UMaterialExpression Expression) {}
	public static void UpdateMaterialFunction(UMaterialFunctionInterface MaterialFunction,UMaterial PreviewMaterial/*=nullptr*/) {}
	public static void LayoutMaterialFunctionExpressions(UMaterialFunction MaterialFunction) {}
	public static void SetMaterialInstanceParent(UMaterialInstanceConstant Instance,UMaterialInterface NewParent) {}
	public static void ClearAllMaterialInstanceParameters(UMaterialInstanceConstant Instance) {}
	public static float GetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance,string ParameterName,float Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static UTexture GetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,UTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static URuntimeVirtualTexture GetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,URuntimeVirtualTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static USparseVolumeTexture GetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,USparseVolumeTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static FLinearColor GetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance,string ParameterName,FLinearColor Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool GetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static bool SetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance,string ParameterName,bool Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	public static void UpdateMaterialInstance(UMaterialInstanceConstant Instance) {}
	public static void GetChildInstances(UMaterialInterface Parent,TArray<FAssetData> ChildInstances) {}
	public static void GetScalarParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	public static void GetVectorParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	public static void GetTextureParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	public static void GetStaticSwitchParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	public static bool GetScalarParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public static bool GetVectorParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public static bool GetTextureParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public static bool GetStaticSwitchParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	public static FMaterialStatistics GetStatistics(UMaterialInterface Material) { return default; }
}
