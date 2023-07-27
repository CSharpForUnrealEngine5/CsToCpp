#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataController.h")]
public partial class UAnimationDataController : UInterface {
// AnimationDataController
	public  void SetModel(object /*InModel*/ InModel) {}
	public  object /*ReturnValue*/ GetModelInterface() { return default; }
	public  void OpenBracket(string InTitle,bool bShouldTransact/*=true*/) {}
	public  void CloseBracket(bool bShouldTransact/*=true*/) {}
	public  void SetNumberOfFrames(FFrameNumber NewLengthInFrames,bool bShouldTransact/*=true*/) {}
	public  void SetPlayLength(float Length,bool bShouldTransact/*=true*/) {}
	public  void ResizeNumberOfFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact/*=true*/) {}
	public  void ResizePlayLength(float NewLength,float T0,float T1,bool bShouldTransact/*=true*/) {}
	public  void ResizeInFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact/*=true*/) {}
	public  void Resize(float Length,float T0,float T1,bool bShouldTransact/*=true*/) {}
	public  void SetFrameRate(FFrameRate FrameRate,bool bShouldTransact/*=true*/) {}
	public  int AddBoneTrack(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	public  bool AddBoneCurve(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	public  int InsertBoneTrack(string BoneName,int DesiredIndex,bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveBoneTrack(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	public  void RemoveAllBoneTracks(bool bShouldTransact/*=true*/) {}
	public  bool SetBoneTrackKeys(string BoneName,TArray<FVector> PositionalKeys,TArray<FQuat> RotationalKeys,TArray<FVector> ScalingKeys,bool bShouldTransact/*=true*/) { return default; }
	public  bool AddCurve(FAnimationCurveIdentifier CurveId,int CurveFlags/*=0x00000004*/,bool bShouldTransact/*=true*/) { return default; }
	public  bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveCurve(FAnimationCurveIdentifier CurveId,bool bShouldTransact/*=true*/) { return default; }
	public  void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	public  bool SetCurveFlag(FAnimationCurveIdentifier CurveId,EAnimAssetCurveFlags Flag,bool bState/*=true*/,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetCurveFlags(FAnimationCurveIdentifier CurveId,int Flags,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FTransform> TransformValues,TArray<float> TimeKeys,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,FTransform Value,bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact/*=true*/) { return default; }
	public  bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetCurveColor(FAnimationCurveIdentifier CurveId,FLinearColor Color,bool bShouldTransact/*=true*/) { return default; }
	public  bool ScaleCurve(FAnimationCurveIdentifier CurveId,float Origin,float Factor,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetCurveKey(FAnimationCurveIdentifier CurveId,FRichCurveKey Key,bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact/*=true*/) { return default; }
	public  bool SetCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FRichCurveKey> CurveKeys,bool bShouldTransact/*=true*/) { return default; }
	public  void UpdateCurveNamesFromSkeleton(USkeleton Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	public  void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	public  bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
	public  int RemoveAllAttributesForBone(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	public  int RemoveAllAttributes(bool bShouldTransact/*=true*/) { return default; }
	public  bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier,float Time,bool bShouldTransact/*=true*/) { return default; }
	public  bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier,FAnimationAttributeIdentifier NewAttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
}
