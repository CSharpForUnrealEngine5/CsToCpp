namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint library for creating/editing Materials</summary>
[CppInclude("MaterialEditingLibrary.h")]
public partial class UMaterialEditingLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns number of material expressions in the supplied material</summary>
	public static int GetNumMaterialExpressions(UMaterial Material) { return default; }
	///<summary>Delete all material expressions in the supplied material</summary>
	public static void DeleteAllMaterialExpressions(UMaterial Material) {}
	///<summary>Delete a specific expression from a material. Will disconnect from other expressions.</summary>
	public static void DeleteMaterialExpression(UMaterial Material,UMaterialExpression Expression) {}
	///<summary>Create a new material expression node within the supplied material</summary>
	public static UMaterialExpression CreateMaterialExpression(UMaterial Material,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	///<summary>Duplicates the provided material expression adding it to the same material / material function, and copying parameters.</summary>
	public static UMaterialExpression DuplicateMaterialExpression(UMaterial Material,UMaterialFunction MaterialFunction,UMaterialExpression Expression) { return default; }
	///<summary>Enable a particular usage for the supplied material (e.g. SkeletalMesh, ParticleSprite etc)</summary>
	public static bool SetMaterialUsage(UMaterial Material,EMaterialUsage Usage,bool bNeedsRecompile) { return default; }
	///<summary>Check if a particular usage is enabled for the supplied material (e.g. SkeletalMesh, ParticleSprite etc)</summary>
	public static bool HasMaterialUsage(UMaterial Material,EMaterialUsage Usage) { return default; }
	///<summary>Connect a material expression output to one of the material property inputs (e.g. diffuse color, opacity etc)</summary>
	public static bool ConnectMaterialProperty(UMaterialExpression FromExpression,string FromOutputName,EMaterialProperty Property) { return default; }
	///<summary>Create connection between two material expressions</summary>
	public static bool ConnectMaterialExpressions(UMaterialExpression FromExpression,string FromOutputName,UMaterialExpression ToExpression,string ToInputName) { return default; }
	///<summary>Trigger a recompile of a material. Must be performed after making changes to the graph to have changes reflected.</summary>
	public static void RecompileMaterial(UMaterial Material) {}
	///<summary>Layouts the expressions in a grid pattern</summary>
	public static void LayoutMaterialExpressions(UMaterial Material) {}
	///<summary>Get the default scalar (float) parameter value from a Material</summary>
	public static float GetMaterialDefaultScalarParameterValue(UMaterial Material,string ParameterName) { return default; }
	///<summary>Get the default texture parameter value from a Material</summary>
	public static UTexture GetMaterialDefaultTextureParameterValue(UMaterial Material,string ParameterName) { return default; }
	///<summary>Get the default vector parameter value from a Material</summary>
	public static FLinearColor GetMaterialDefaultVectorParameterValue(UMaterial Material,string ParameterName) { return default; }
	///<summary>Get the default static switch parameter value from a Material</summary>
	public static bool GetMaterialDefaultStaticSwitchParameterValue(UMaterial Material,string ParameterName) { return default; }
	///<summary>Get the set of selected nodes from an active material editor</summary>
	public static TSet<UObject> GetMaterialSelectedNodes(UMaterial Material) { return default; }
	///<summary>Get the node providing the output for a given material property from an active material editor</summary>
	public static UMaterialExpression GetMaterialPropertyInputNode(UMaterial Material,EMaterialProperty Property) { return default; }
	///<summary>Get the node output name providing the output for a given material property from an active material editor</summary>
	public static string GetMaterialPropertyInputNodeOutputName(UMaterial Material,EMaterialProperty Property) { return default; }
	///<summary>Get the set of nodes acting as inputs to a node from an active material editor</summary>
	public static TArray<UMaterialExpression> GetInputsForMaterialExpression(UMaterial Material,UMaterialExpression MaterialExpression) { return default; }
	///<summary>Get the output name of input node connected to MaterialExpression from an active material editor</summary>
	public static bool GetInputNodeOutputNameForMaterialExpression(UMaterialExpression MaterialExpression,UMaterialExpression InputNode,string OutputName) { return default; }
	///<summary>Get the position of the MaterialExpression node.</summary>
	public static void GetMaterialExpressionNodePosition(UMaterialExpression MaterialExpression,int NodePosX,int NodePosY) {}
	///<summary>Get the list of textures used by a material</summary>
	public static TArray<UTexture> GetUsedTextures(UMaterial Material) { return default; }
	///<summary>Returns number of material expressions in the supplied material</summary>
	public static int GetNumMaterialExpressionsInFunction(UMaterialFunction MaterialFunction) { return default; }
	///<summary>Create a new material expression node within the supplied material function</summary>
	public static UMaterialExpression CreateMaterialExpressionInFunction(UMaterialFunction MaterialFunction,UClass ExpressionClass,int NodePosX/*=0*/,int NodePosY/*=0*/) { return default; }
	///<summary>Delete all material expressions in the supplied material function</summary>
	public static void DeleteAllMaterialExpressionsInFunction(UMaterialFunction MaterialFunction) {}
	///<summary>Delete a specific expression from a material function. Will disconnect from other expressions.</summary>
	public static void DeleteMaterialExpressionInFunction(UMaterialFunction MaterialFunction,UMaterialExpression Expression) {}
	///<summary>Update a Material Function after edits have been made.</summary>
	public static void UpdateMaterialFunction(UMaterialFunctionInterface MaterialFunction,UMaterial PreviewMaterial/*=nullptr*/) {}
	///<summary>Layouts the expressions in a grid pattern</summary>
	public static void LayoutMaterialFunctionExpressions(UMaterialFunction MaterialFunction) {}
	///<summary>Set the parent Material or Material Instance to use for this Material Instance</summary>
	public static void SetMaterialInstanceParent(UMaterialInstanceConstant Instance,UMaterialInterface NewParent) {}
	///<summary>Clears all material parameters set by this Material Instance</summary>
	public static void ClearAllMaterialInstanceParameters(UMaterialInstanceConstant Instance) {}
	///<summary>Get the current scalar (float) parameter value from a Material Instance</summary>
	public static float GetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the scalar (float) parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceScalarParameterValue(UMaterialInstanceConstant Instance,string ParameterName,float Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Get the current texture parameter value from a Material Instance</summary>
	public static UTexture GetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the texture parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,UTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Get the current texture parameter value from a Material Instance</summary>
	public static URuntimeVirtualTexture GetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the texture parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceRuntimeVirtualTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,URuntimeVirtualTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Get the current texture parameter value from a Material Instance</summary>
	public static USparseVolumeTexture GetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the texture parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceSparseVolumeTextureParameterValue(UMaterialInstanceConstant Instance,string ParameterName,USparseVolumeTexture Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Get the current vector parameter value from a Material Instance</summary>
	public static FLinearColor GetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the vector parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceVectorParameterValue(UMaterialInstanceConstant Instance,string ParameterName,FLinearColor Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Get the current static switch parameter value from a Material Instance</summary>
	public static bool GetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance,string ParameterName,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Set the static switch parameter value for a Material Instance</summary>
	public static bool SetMaterialInstanceStaticSwitchParameterValue(UMaterialInstanceConstant Instance,string ParameterName,bool Value,EMaterialParameterAssociation Association/*=EMaterialParameterAssociation.GlobalParameter*/) { return default; }
	///<summary>Called after making modifications to a Material Instance to recompile shaders etc.</summary>
	public static void UpdateMaterialInstance(UMaterialInstanceConstant Instance) {}
	///<summary>Gets all direct child mat instances</summary>
	public static void GetChildInstances(UMaterialInterface Parent,TArray<FAssetData> ChildInstances) {}
	///<summary>Gets all scalar parameter names</summary>
	public static void GetScalarParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	///<summary>Gets all vector parameter names</summary>
	public static void GetVectorParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	///<summary>Gets all texture parameter names</summary>
	public static void GetTextureParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	///<summary>Gets all static switch parameter names</summary>
	public static void GetStaticSwitchParameterNames(UMaterialInterface Material,TArray<string> ParameterNames) {}
	///<summary>Returns the path of the asset where the parameter originated, as well as true/false if it was found</summary>
	public static bool GetScalarParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	///<summary>Returns the path of the asset where the parameter originated, as well as true/false if it was found</summary>
	public static bool GetVectorParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	///<summary>Returns the path of the asset where the parameter originated, as well as true/false if it was found</summary>
	public static bool GetTextureParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	///<summary>Returns the path of the asset where the parameter originated, as well as true/false if it was found</summary>
	public static bool GetStaticSwitchParameterSource(UMaterialInterface Material,string ParameterName,FSoftObjectPath ParameterSource) { return default; }
	///<summary>Returns statistics about the given material</summary>
	public static FMaterialStatistics GetStatistics(UMaterialInterface Material) { return default; }
}
