#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangeAnimSequenceFactoryNode.h")]
///<summary>ns UE::Interchange</summary>
public partial class UInterchangeAnimSequenceFactoryNode : UInterchangeFactoryBaseNode {
// InterchangeAnimSequenceFactoryNode
	public void InitializeAnimSequenceNode(string UniqueID,string DisplayLabel) {}
	public UClass GetObjectClass() { return default; }
	public bool GetCustomSkeletonFactoryNodeUid(string AttributeValue) { return default; }
	public bool SetCustomSkeletonFactoryNodeUid(string AttributeValue) { return default; }
	public bool GetCustomImportBoneTracks(bool AttributeValue) { return default; }
	public bool SetCustomImportBoneTracks(bool AttributeValue) { return default; }
	public bool GetCustomImportBoneTracksSampleRate(double AttributeValue) { return default; }
	public bool SetCustomImportBoneTracksSampleRate(double AttributeValue) { return default; }
	public bool GetCustomImportBoneTracksRangeStart(double AttributeValue) { return default; }
	public bool SetCustomImportBoneTracksRangeStart(double AttributeValue) { return default; }
	public bool GetCustomImportBoneTracksRangeStop(double AttributeValue) { return default; }
	public bool SetCustomImportBoneTracksRangeStop(double AttributeValue) { return default; }
	public bool GetCustomImportAttributeCurves(bool AttributeValue) { return default; }
	public bool SetCustomImportAttributeCurves(bool AttributeValue) { return default; }
	public bool GetCustomDoNotImportCurveWithZero(bool AttributeValue) { return default; }
	public bool SetCustomDoNotImportCurveWithZero(bool AttributeValue) { return default; }
	public bool GetCustomRemoveCurveRedundantKeys(bool AttributeValue) { return default; }
	public bool SetCustomRemoveCurveRedundantKeys(bool AttributeValue) { return default; }
	public bool GetCustomDeleteExistingMorphTargetCurves(bool AttributeValue) { return default; }
	public bool SetCustomDeleteExistingMorphTargetCurves(bool AttributeValue) { return default; }
	public int GetAnimatedMorphTargetDependeciesCount() { return default; }
	public void GetAnimatedMorphTargetDependencies(TArray<string> OutDependencies) {}
	public void GetAnimatedMorphTargetDependency(int Index,string OutDependency) {}
	public bool SetAnimatedMorphTargetDependencyUid(string DependencyUid) { return default; }
	public bool RemoveAnimatedMorphTargetDependencyUid(string DependencyUid) { return default; }
	public int GetAnimatedAttributeCurveNamesCount() { return default; }
	public void GetAnimatedAttributeCurveNames(TArray<string> OutAttributeCurveNames) {}
	public void GetAnimatedAttributeCurveName(int Index,string OutAttributeCurveName) {}
	public bool SetAnimatedAttributeCurveName(string AttributeCurveName) { return default; }
	public bool RemoveAnimatedAttributeCurveName(string AttributeCurveName) { return default; }
	public bool GetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue) { return default; }
	public bool SetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue) { return default; }
	public int GetAnimatedMaterialCurveSuffixesCount() { return default; }
	public void GetAnimatedMaterialCurveSuffixes(TArray<string> OutMaterialCurveSuffixes) {}
	public void GetAnimatedMaterialCurveSuffixe(int Index,string OutMaterialCurveSuffixe) {}
	public bool SetAnimatedMaterialCurveSuffixe(string MaterialCurveSuffixe) { return default; }
	public bool RemoveAnimatedMaterialCurveSuffixe(string MaterialCurveSuffixe) { return default; }
	public int GetAnimatedAttributeStepCurveNamesCount() { return default; }
	public void GetAnimatedAttributeStepCurveNames(TArray<string> OutAttributeStepCurveNames) {}
	public void GetAnimatedAttributeStepCurveName(int Index,string OutAttributeStepCurveName) {}
	public bool SetAnimatedAttributeStepCurveName(string AttributeStepCurveName) { return default; }
	public bool RemoveAnimatedAttributeStepCurveName(string AttributeStepCurveName) { return default; }
	public bool GetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue) { return default; }
	public bool SetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue) { return default; }
	public bool GetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue) { return default; }
	public bool SetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue) { return default; }
	public bool GetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	public bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue) { return default; }
	public void GetSceneNodeAnimationPayloadKeys(TMap<string,string> OutSceneNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromSceneNodeUid(string SceneNodeUid,string OutPayloadKey) { return default; }
	public bool SetAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid,string PayloadKey) { return default; }
	public bool RemoveAnimationPayloadKeyForSceneNodeUid(string SceneNodeUid) { return default; }
	public void GetMorphTargetNodeAnimationPayloadKeys(TMap<string,string> OutMorphTargetNodeAnimationPayloads) {}
	public bool GetAnimationPayloadKeyFromMorphTargetNodeUid(string MorphTargetNodeUid,string OutPayloadKey) { return default; }
	public bool SetAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid,string PayloadKey) { return default; }
	public bool RemoveAnimationPayloadKeyForMorphTargetNodeUid(string MorphTargetNodeUid) { return default; }
}
