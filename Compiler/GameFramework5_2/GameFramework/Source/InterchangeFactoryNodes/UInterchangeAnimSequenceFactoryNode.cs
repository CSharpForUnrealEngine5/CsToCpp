namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ns UE::Interchange</summary>
[CppInclude("InterchangeAnimSequenceFactoryNode.h")]
public partial class UInterchangeAnimSequenceFactoryNode : UInterchangeFactoryBaseNode {
	public static UClass StaticClass() {return default;}
	///<summary>Initialize node data</summary>
	public void InitializeAnimSequenceNode(string UniqueID,string DisplayLabel) {}
	///<summary>Get the class this node want to create</summary>
	public virtual UClass GetObjectClass() { return default; }
	///<summary>Get the skeleton factory node unique id. Return false if the attribute is not set.</summary>
	public bool GetCustomSkeletonFactoryNodeUid(string AttributeValue) { return default; }
	///<summary>Set the skeleton factory node unique id. Return false if the attribute cannot be set.</summary>
	public bool SetCustomSkeletonFactoryNodeUid(string AttributeValue) { return default; }
	///<summary>Get the import bone tracks state. The attribute will be true if we need to import bone tracks.</summary>
	public bool GetCustomImportBoneTracks(bool AttributeValue) { return default; }
	///<summary>Set the import bone tracks state. Pass true to import bone tracks, false to not import bone tracks.</summary>
	public bool SetCustomImportBoneTracks(bool AttributeValue) { return default; }
	///<summary>Get the import bone tracks sample rate. Return false if the attribute is not set.</summary>
	public bool GetCustomImportBoneTracksSampleRate(double AttributeValue) { return default; }
	///<summary>Set the import bone tracks sample rate. Return false if the attribute cannot be set.</summary>
	public bool SetCustomImportBoneTracksSampleRate(double AttributeValue) { return default; }
	///<summary>Get the import bone tracks start time in second. Return false if the attribute is not set.</summary>
	public bool GetCustomImportBoneTracksRangeStart(double AttributeValue) { return default; }
	///<summary>Set the import bone tracks start time in second. Return false if the attribute cannot be set.</summary>
	public bool SetCustomImportBoneTracksRangeStart(double AttributeValue) { return default; }
	///<summary>Get the import bone tracks end time in second. Return false if the attribute is not set.</summary>
	public bool GetCustomImportBoneTracksRangeStop(double AttributeValue) { return default; }
	///<summary>Set the import bone tracks end time in second. Return false if the attribute cannot be set.</summary>
	public bool SetCustomImportBoneTracksRangeStop(double AttributeValue) { return default; }
	///<summary>Get the import attribute curves state. If true this mean we want to import all user custom attributes</summary>
	public bool GetCustomImportAttributeCurves(bool AttributeValue) { return default; }
	///<summary>Set the import attribute curves state. Return false if the attribute cannot be set.</summary>
	public bool SetCustomImportAttributeCurves(bool AttributeValue) { return default; }
	///<summary>Get the custom attribute DoNotImportCurveWithZero, return false if the attribute is not set.</summary>
	public bool GetCustomDoNotImportCurveWithZero(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute DoNotImportCurveWithZero. Return false if the attribute cannot be set.</summary>
	public bool SetCustomDoNotImportCurveWithZero(bool AttributeValue) { return default; }
	///<summary>Get the custom attribute RemoveCurveRedundantKeys, return false if the attribute is not set.</summary>
	public bool GetCustomRemoveCurveRedundantKeys(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute RemoveCurveRedundantKeys. Return false if the attribute cannot be set.</summary>
	public bool SetCustomRemoveCurveRedundantKeys(bool AttributeValue) { return default; }
	///<summary>Get the custom attribute DeleteExistingMorphTargetCurves, return false if the attribute is not set.</summary>
	public bool GetCustomDeleteExistingMorphTargetCurves(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute DeleteExistingMorphTargetCurves. Return false if the attribute cannot be set.</summary>
	public bool SetCustomDeleteExistingMorphTargetCurves(bool AttributeValue) { return default; }
	///<summary>return how many animated moprh target (moprh target are translated into a mesh node and can be animated with a float curve) this anim sequence depends on.</summary>
	public int GetAnimatedMorphTargetDependeciesCount() { return default; }
	///<summary>Get all animated moprh target unique id (moprh target are translated into a mesh node and can be animated with a float curve) this anim sequence depends on.</summary>
	public void GetAnimatedMorphTargetDependencies(TArray<string> OutDependencies) {}
	///<summary>Get an animated moprh target unique id (moprh target are translated into a mesh node and can be animated with a float curve) point by the specified index.</summary>
	public void GetAnimatedMorphTargetDependency(int Index,string OutDependency) {}
	///<summary>Add an animated moprh target unique id (moprh target are translated into a mesh node and can be animated with a float curve).</summary>
	public bool SetAnimatedMorphTargetDependencyUid(string DependencyUid) { return default; }
	///<summary>Remove one animated moprh target unique id (moprh target are translated into a mesh node and can be animated with a float curve). Return false if we cannot remove the moprh target unique id.</summary>
	public bool RemoveAnimatedMorphTargetDependencyUid(string DependencyUid) { return default; }
	///<summary>Return how many animated attribute curve names this anim sequence drive (curve are FRichCurve of type float).</summary>
	public int GetAnimatedAttributeCurveNamesCount() { return default; }
	///<summary>Get all animated attribute curve names.</summary>
	public void GetAnimatedAttributeCurveNames(TArray<string> OutAttributeCurveNames) {}
	///<summary>Get an animated attribute curve name point by the specified index.</summary>
	public void GetAnimatedAttributeCurveName(int Index,string OutAttributeCurveName) {}
	///<summary>Add an animated attribute curve name.</summary>
	public bool SetAnimatedAttributeCurveName(string AttributeCurveName) { return default; }
	///<summary>Remove one animated attribute curve name.</summary>
	public bool RemoveAnimatedAttributeCurveName(string AttributeCurveName) { return default; }
	///<summary>Get the custom attribute MaterialDriveParameterOnCustomAttribute, return false if the attribute is not set.</summary>
	public bool GetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute MaterialDriveParameterOnCustomAttribute. Return false if the attribute cannot be set.</summary>
	public bool SetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue) { return default; }
	///<summary>Return how many animated material curve suffixes this anim sequence drive (curve are FRichCurve of type float).</summary>
	public int GetAnimatedMaterialCurveSuffixesCount() { return default; }
	///<summary>Get all animated material curve suffixes.</summary>
	public void GetAnimatedMaterialCurveSuffixes(TArray<string> OutMaterialCurveSuffixes) {}
	///<summary>Get an animated material curve suffixe point by the specified index.</summary>
	public void GetAnimatedMaterialCurveSuffixe(int Index,string OutMaterialCurveSuffixe) {}
	///<summary>Add an animated material curve suffixe.</summary>
	public bool SetAnimatedMaterialCurveSuffixe(string MaterialCurveSuffixe) { return default; }
	///<summary>Remove one animated material curve suffixe.</summary>
	public bool RemoveAnimatedMaterialCurveSuffixe(string MaterialCurveSuffixe) { return default; }
	///<summary>Return how many animated attribute step curve names this anim sequence drive.</summary>
	public int GetAnimatedAttributeStepCurveNamesCount() { return default; }
	///<summary>Get all animated attribute step curve names.</summary>
	public void GetAnimatedAttributeStepCurveNames(TArray<string> OutAttributeStepCurveNames) {}
	///<summary>Get an animated attribute step curve name point by the specified index.</summary>
	public void GetAnimatedAttributeStepCurveName(int Index,string OutAttributeStepCurveName) {}
	///<summary>Add an animated attribute step curve name.</summary>
	public bool SetAnimatedAttributeStepCurveName(string AttributeStepCurveName) { return default; }
	///<summary>Remove one animated attribute step curve name.</summary>
	public bool RemoveAnimatedAttributeStepCurveName(string AttributeStepCurveName) { return default; }
	///<summary>Get the custom attribute DeleteExistingCustomAttributeCurves, return false if the attribute is not set.</summary>
	public bool GetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute DeleteExistingCustomAttributeCurves. Return false if the attribute cannot be set.</summary>
	public bool SetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue) { return default; }
	///<summary>Get the custom attribute DeleteExistingNonCurveCustomAttributes, return false if the attribute is not set.</summary>
	public bool GetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue) { return default; }
	///<summary>Set the custom attribute DeleteExistingNonCurveCustomAttributes. Return false if the attribute cannot be set.</summary>
	public bool SetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue) { return default; }
	///<summary>Query the optional existing USkeleton this anim must use. The anim sequence factory will use this skeleton instead of the imported one</summary>
	public bool GetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>Set the optional existing USkeleton this anim must use. The AnimSequence factory will use this skeleton instead of the imported one</summary>
	public bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	///<summary>GetSceneNodeAnimationPayloadKeys</summary>
	public void GetSceneNodeAnimationPayloadKeys(TMap<string,string> OutSceneNodeAnimationPayloads) {}
	///<summary>GetAnimationPayloadKeyFromSceneNodeUid</summary>
	public bool GetAnimationPayloadKeyFromSceneNodeUid(string SceneNodeUid,string OutPayloadKey) { return default; }
	///<summary>SetAnimationPayloadKeyForSceneNodeUid</summary>
	public bool SetAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid,string PayloadKey) { return default; }
	///<summary>RemoveAnimationPayloadKeyForSceneNodeUid</summary>
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid) { return default; }
	///<summary>GetMorphTargetNodeAnimationPayloadKeys</summary>
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<string,string> OutMorphTargetNodeAnimationPayloads) {}
	///<summary>GetAnimationPayloadKeyFromMorphTargetNodeUid</summary>
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(string MorphTargetNodeUid,string OutPayloadKey) { return default; }
	///<summary>SetAnimationPayloadKeyForMorphTargetNodeUid</summary>
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid,string PayloadKey) { return default; }
	///<summary>RemoveAnimationPayloadKeyForMorphTargetNodeUid</summary>
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid) { return default; }
}
