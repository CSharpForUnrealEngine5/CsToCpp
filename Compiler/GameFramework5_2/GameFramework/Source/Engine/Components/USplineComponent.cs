#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
///<summary>A spline component is a spline shape which can be used for other purposes (e.g. animating objects). It contains debug rendering capabilities.</summary>
public partial class USplineComponent : UPrimitiveComponent {
// SplineComponent
	public FSplineCurves SplineCurves;
	public FInterpCurveVector SplineInfo_DEPRECATED;
	public FInterpCurveQuat SplineRotInfo_DEPRECATED;
	public FInterpCurveVector SplineScaleInfo_DEPRECATED;
	public FInterpCurveFloat SplineReparamTable_DEPRECATED;
	public bool bAllowSplineEditingPerInstance_DEPRECATED;
	public int ReparamStepsPerSegment;
	public float Duration;
	public bool bStationaryEndpoints;
	public bool bSplineHasBeenEdited;
	public bool bModifiedByConstructionScript;
	public bool bInputSplinePointsToConstructionScript;
	public bool bDrawDebug;
	public bool bClosedLoop;
	public bool bLoopPositionOverride;
	public float LoopPosition;
	public FVector DefaultUpVector;
	public FLinearColor EditorUnselectedSplineSegmentColor;
	public FLinearColor EditorSelectedSplineSegmentColor;
	public FLinearColor EditorTangentColor;
	public bool bAllowDiscontinuousSpline;
	public bool bShouldVisualizeScale;
	public float ScaleVisualizationWidth;
	public void UpdateSpline() {}
	public FVector GetLocationAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetTangentAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetDirectionAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FRotator GetRotationAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetUpVectorAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetRightVectorAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FTransform GetTransformAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	public float GetRollAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetScaleAtSplineInputKey(float InKey) { return default; }
	public float GetDistanceAlongSplineAtSplineInputKey(float InKey) { return default; }
	public float GetFloatPropertyAtSplineInputKey(float InKey,string PropertyName) { return default; }
	public FVector GetVectorPropertyAtSplineInputKey(float InKey,string PropertyName) { return default; }
	public void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor) {}
	public void SetSelectedSplineSegmentColor(FLinearColor SegmentColor) {}
	public void SetTangentColor(FLinearColor TangentColor) {}
	public void SetDrawDebug(bool bShow) {}
	public void SetClosedLoop(bool bInClosedLoop,bool bUpdateSpline/*=true*/) {}
	public void SetClosedLoopAtPosition(bool bInClosedLoop,float Key,bool bUpdateSpline/*=true*/) {}
	public bool IsClosedLoop() { return default; }
	public void ClearSplinePoints(bool bUpdateSpline/*=true*/) {}
	public void AddPoint(FSplinePoint Point,bool bUpdateSpline/*=true*/) {}
	public void AddPoints(TArray<FSplinePoint> Points,bool bUpdateSpline/*=true*/) {}
	public void AddSplinePoint(FVector Position,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void AddSplinePointAtIndex(FVector Position,int Index,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void RemoveSplinePoint(int Index,bool bUpdateSpline/*=true*/) {}
	public void AddSplineWorldPoint(FVector Position) {}
	public void AddSplineLocalPoint(FVector Position) {}
	public void SetSplinePoints(TArray<FVector> Points,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetSplineWorldPoints(TArray<FVector> Points) {}
	public void SetSplineLocalPoints(TArray<FVector> Points) {}
	public void SetLocationAtSplinePoint(int PointIndex,FVector InLocation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetWorldLocationAtSplinePoint(int PointIndex,FVector InLocation) {}
	public void SetTangentAtSplinePoint(int PointIndex,FVector InTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetTangentsAtSplinePoint(int PointIndex,FVector InArriveTangent,FVector InLeaveTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetUpVectorAtSplinePoint(int PointIndex,FVector InUpVector,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetRotationAtSplinePoint(int PointIndex,FRotator InRotation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	public void SetScaleAtSplinePoint(int PointIndex,FVector InScaleVector,bool bUpdateSpline/*=true*/) {}
	public ESplinePointType GetSplinePointType(int PointIndex) { return default; }
	public void SetSplinePointType(int PointIndex,ESplinePointType Type,bool bUpdateSpline/*=true*/) {}
	public int GetNumberOfSplinePoints() { return default; }
	public int GetNumberOfSplineSegments() { return default; }
	public FVector GetLocationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetWorldLocationAtSplinePoint(int PointIndex) { return default; }
	public FVector GetDirectionAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetArriveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetLeaveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FRotator GetRotationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetUpVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetRightVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public float GetRollAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetScaleAtSplinePoint(int PointIndex) { return default; }
	public FTransform GetTransformAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	public void GetLocationAndTangentAtSplinePoint(int PointIndex,FVector Location,FVector Tangent,ESplineCoordinateSpace CoordinateSpace) {}
	public void GetLocalLocationAndTangentAtSplinePoint(int PointIndex,FVector LocalLocation,FVector LocalTangent) {}
	public float GetDistanceAlongSplineAtSplinePoint(int PointIndex) { return default; }
	public float GetFloatPropertyAtSplinePoint(int Index,string PropertyName) { return default; }
	public FVector GetVectorPropertyAtSplinePoint(int Index,string PropertyName) { return default; }
	public float GetSplineLength() { return default; }
	public void SetDefaultUpVector(FVector UpVector,ESplineCoordinateSpace CoordinateSpace) {}
	public FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace) { return default; }
	public float GetInputKeyAtDistanceAlongSpline(float Distance) { return default; }
	public float GetInputKeyValueAtDistanceAlongSpline(float Distance) { return default; }
	public float GetTimeAtDistanceAlongSpline(float Distance) { return default; }
	public FVector GetLocationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetWorldLocationAtDistanceAlongSpline(float Distance) { return default; }
	public FVector GetDirectionAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetWorldDirectionAtDistanceAlongSpline(float Distance) { return default; }
	public FVector GetTangentAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetWorldTangentAtDistanceAlongSpline(float Distance) { return default; }
	public FRotator GetRotationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FRotator GetWorldRotationAtDistanceAlongSpline(float Distance) { return default; }
	public FVector GetUpVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetRightVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public float GetRollAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector GetScaleAtDistanceAlongSpline(float Distance) { return default; }
	public FTransform GetTransformAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	public FVector GetLocationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetWorldLocationAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetDirectionAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetWorldDirectionAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetTangentAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FRotator GetRotationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FRotator GetWorldRotationAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetUpVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetRightVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FTransform GetTransformAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/,bool bUseScale/*=false*/) { return default; }
	public float GetRollAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	public FVector GetScaleAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	public float FindInputKeyClosestToWorldLocation(FVector WorldLocation) { return default; }
	public FVector FindLocationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector FindDirectionClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector FindTangentClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FRotator FindRotationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public float FindRollClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	public FVector FindScaleClosestToWorldLocation(FVector WorldLocation) { return default; }
	public FTransform FindTransformClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	public bool DivideSplineIntoPolylineRecursive(float StartDistanceAlongSpline,float EndDistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
	public bool DivideSplineIntoPolylineRecursiveWithDistances(float StartDistanceAlongSpline,float EndDistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints,TArray<double> OutDistancesAlongSpline) { return default; }
	public bool ConvertSplineSegmentToPolyLine(int SplinePointStartIndex,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
	public bool ConvertSplineToPolyLine(ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
}
