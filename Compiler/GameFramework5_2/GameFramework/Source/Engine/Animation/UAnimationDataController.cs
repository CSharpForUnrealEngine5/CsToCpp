#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataController.h")]
public partial class UAnimationDataController : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Sets the AnimDataModel instance this controller is supposed to be targeting</summary>
	public  void SetModel(object /*InModel*/ InModel) {}
	///<summary>@return               The IAnimationDataModel instance this controller is currently targeting</summary>
	public  object /*ReturnValue*/ GetModelInterface() { return default; }
	///<summary>Opens an interaction bracket, used for combining a set of controller actions. Broadcasts a EAnimDataModelNotifyType::BracketOpened notify,</summary>
	public  void OpenBracket(string InTitle,bool bShouldTransact/*=true*/) {}
	///<summary>Closes a previously opened interaction bracket, used for combining a set of controller actions. Broadcasts a EAnimDataModelNotifyType::BracketClosed notify.</summary>
	public  void CloseBracket(bool bShouldTransact/*=true*/) {}
	///<summary>Sets the total play-able length in seconds. Broadcasts a EAnimDataModelNotifyType::SequenceLengthChanged notify if successful.</summary>
	public  void SetNumberOfFrames(FFrameNumber NewLengthInFrames,bool bShouldTransact/*=true*/) {}
	///<summary>SetPlayLength</summary>
	public  void SetPlayLength(float Length,bool bShouldTransact/*=true*/) {}
	///<summary>Sets the total play-able length in seconds. Broadcasts a EAnimDataModelNotifyType::SequenceLengthChanged notify if successful.</summary>
	public  void ResizeNumberOfFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact/*=true*/) {}
	///<summary>ResizePlayLength</summary>
	public  void ResizePlayLength(float NewLength,float T0,float T1,bool bShouldTransact/*=true*/) {}
	///<summary>Sets the total play-able length in seconds and resizes curves. Broadcasts EAnimDataModelNotifyType::SequenceLengthChanged</summary>
	public  void ResizeInFrames(FFrameNumber NewLengthInFrames,FFrameNumber T0,FFrameNumber T1,bool bShouldTransact/*=true*/) {}
	///<summary>Resize</summary>
	public  void Resize(float Length,float T0,float T1,bool bShouldTransact/*=true*/) {}
	///<summary>Sets the frame rate according to which the bone animation is expected to be sampled. Broadcasts a EAnimDataModelNotifyType::FrameRateChanged notify if successful.</summary>
	public  void SetFrameRate(FFrameRate FrameRate,bool bShouldTransact/*=true*/) {}
	///<summary>AddBoneTrack</summary>
	public  int AddBoneTrack(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	///<summary>AddBoneCurve</summary>
	public  bool AddBoneCurve(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	///<summary>InsertBoneTrack</summary>
	public  int InsertBoneTrack(string BoneName,int DesiredIndex,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes an existing bone animation track with the provided name. Broadcasts a EAnimDataModelNotifyType::TrackRemoved notify if successful.</summary>
	public  bool RemoveBoneTrack(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes all existing Bone Animation tracks. Broadcasts a EAnimDataModelNotifyType::TrackRemoved for each removed track, wrapped within BracketOpened/BracketClosed notifies.</summary>
	public  void RemoveAllBoneTracks(bool bShouldTransact/*=true*/) {}
	///<summary>Removes an existing bone animation track with the provided name. Broadcasts a EAnimDataModelNotifyType::TrackChanged notify if successful.</summary>
	public  bool SetBoneTrackKeys(string BoneName,TArray<FVector> PositionalKeys,TArray<FQuat> RotationalKeys,TArray<FVector> ScalingKeys,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Adds a new curve with the provided information. Broadcasts a EAnimDataModelNotifyType::CurveAdded notify if successful.</summary>
	public  bool AddCurve(FAnimationCurveIdentifier CurveId,int CurveFlags/*=0x00000004*/,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Duplicated the curve with the identifier. Broadcasts a EAnimDataModelNotifyType::CurveAdded notify if successful.</summary>
	public  bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Remove the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveRemoved notify if successful.</summary>
	public  bool RemoveCurve(FAnimationCurveIdentifier CurveId,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes all the curves of the provided type. Broadcasts a EAnimDataModelNotifyType::CurveRemoved for each removed curve, wrapped within BracketOpened/BracketClosed notifies.</summary>
	public  void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	///<summary>Set an individual flag for the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveFlagsChanged notify if successful.</summary>
	public  bool SetCurveFlag(FAnimationCurveIdentifier CurveId,EAnimAssetCurveFlags Flag,bool bState/*=true*/,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Replace the flags for the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveFlagsChanged notify if successful.</summary>
	public  bool SetCurveFlags(FAnimationCurveIdentifier CurveId,int Flags,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Replace the keys for the transform curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FTransform> TransformValues,TArray<float> TimeKeys,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Sets a single key for the transform curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,FTransform Value,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes a single key for the transform curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Renames the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveRenamed notify if successful.</summary>
	public  bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId,FAnimationCurveIdentifier NewCurveId,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Changes the color of the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveRenamed notify if successful.</summary>
	public  bool SetCurveColor(FAnimationCurveIdentifier CurveId,FLinearColor Color,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Scales the curve with provided identifier. Broadcasts a EAnimDataModelNotifyType::CurveScaled notify if successful.</summary>
	public  bool ScaleCurve(FAnimationCurveIdentifier CurveId,float Origin,float Factor,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Sets a single key for the curve with provided identifier and name. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool SetCurveKey(FAnimationCurveIdentifier CurveId,FRichCurveKey Key,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Remove a single key from the curve with provided identifier and name. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool RemoveCurveKey(FAnimationCurveIdentifier CurveId,float Time,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Replace the keys for the curve with provided identifier and name. Broadcasts a EAnimDataModelNotifyType::CurveChanged notify if successful.</summary>
	public  bool SetCurveKeys(FAnimationCurveIdentifier CurveId,TArray<FRichCurveKey> CurveKeys,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Updates the display name values for any stored curve, with the names being retrieved from the provided skeleton. Broadcasts a EAnimDataModelNotifyType::CurveRenamed for each to-be-updated curve name, wrapped within BracketOpened/BracketClosed notifies.</summary>
	public  void UpdateCurveNamesFromSkeleton(USkeleton Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	///<summary>Updates the curve names with the provided skeleton, if a display name is not found it will be added thus modifying the skeleton. Broadcasts a EAnimDataModelNotifyType::CurveRenamed for each curve name for which the UID was different or if it was added as a new smart-name, wrapped within BracketOpened/BracketClosed notifies.</summary>
	public  void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton,ERawCurveTrackTypes SupportedCurveType,bool bShouldTransact/*=true*/) {}
	///<summary>Adds a new attribute with the provided information. Broadcasts a EAnimDataModelNotifyType::AttributeAdded notify if successful.</summary>
	public  bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes an attribute, if found, with the provided information. Broadcasts a EAnimDataModelNotifyType::AttributeRemoved notify if successful.</summary>
	public  bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes all attributes for the specified bone name, if any. Broadcasts a EAnimDataModelNotifyType::AttributeRemoved notify for each removed attribute.</summary>
	public  int RemoveAllAttributesForBone(string BoneName,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Removes all stored attributes. Broadcasts a EAnimDataModelNotifyType::AttributeRemoved notify for each removed attribute.</summary>
	public  int RemoveAllAttributes(bool bShouldTransact/*=true*/) { return default; }
	///<summary>Remove a single key from the attribute with provided identifier. Broadcasts a EAnimDataModelNotifyType::AttributeChanged notify if successful.</summary>
	public  bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier,float Time,bool bShouldTransact/*=true*/) { return default; }
	///<summary>Duplicated the attribute (curve) with the identifier. Broadcasts a EAnimDataModelNotifyType::AttributeAdded notify if successful.</summary>
	public  bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier,FAnimationAttributeIdentifier NewAttributeIdentifier,bool bShouldTransact/*=true*/) { return default; }
}
