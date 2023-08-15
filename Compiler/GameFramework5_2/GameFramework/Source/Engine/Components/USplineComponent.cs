namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A spline component is a spline shape which can be used for other purposes (e.g. animating objects). It contains debug rendering capabilities.</summary>
[CppInclude("Components/SplineComponent.h")]
public partial class USplineComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SplineCurves</summary>
	public FSplineCurves SplineCurves;
	///<summary>Deprecated - please use GetSplinePointsPosition() to fetch this FInterpCurve</summary>
	public FInterpCurveVector SplineInfo_DEPRECATED;
	///<summary>Deprecated - please use GetSplinePointsRotation() to fetch this FInterpCurve</summary>
	public FInterpCurveQuat SplineRotInfo_DEPRECATED;
	///<summary>Deprecated - please use GetSplinePointsScale() to fetch this FInterpCurve</summary>
	public FInterpCurveVector SplineScaleInfo_DEPRECATED;
	///<summary>SplineReparamTable_DEPRECATED</summary>
	public FInterpCurveFloat SplineReparamTable_DEPRECATED;
	///<summary>bAllowSplineEditingPerInstance_DEPRECATED</summary>
	public bool bAllowSplineEditingPerInstance_DEPRECATED;
	///<summary>Number of steps per spline segment to place in the reparameterization table</summary>
	public int ReparamStepsPerSegment;
	///<summary>Specifies the duration of the spline in seconds</summary>
	public float Duration;
	///<summary>Whether the endpoints of the spline are considered stationary when traversing the spline at non-constant velocity.  Essentially this sets the endpoints&#39; tangents to zero vectors.</summary>
	public bool bStationaryEndpoints;
	///<summary>Whether the spline has been edited from its default by the spline component visualizer</summary>
	public bool bSplineHasBeenEdited;
	///<summary>Whether the UCS has made changes to the spline points</summary>
	public bool bModifiedByConstructionScript;
	///<summary>Whether the spline points should be passed to the User Construction Script so they can be further manipulated by it.</summary>
	public bool bInputSplinePointsToConstructionScript;
	///<summary>If true, the spline will be rendered if the Splines showflag is set.</summary>
	public bool bDrawDebug;
	///<summary>Whether the spline is to be considered as a closed loop.</summary>
	public bool bClosedLoop;
	///<summary>bLoopPositionOverride</summary>
	public bool bLoopPositionOverride;
	///<summary>LoopPosition</summary>
	public float LoopPosition;
	///<summary>Default up vector in local space to be used when calculating transforms along the spline</summary>
	public FVector DefaultUpVector;
	///<summary>Color of unselected spline component parts in the editor</summary>
	public FLinearColor EditorUnselectedSplineSegmentColor;
	///<summary>Color of selected spline component parts in the editor</summary>
	public FLinearColor EditorSelectedSplineSegmentColor;
	///<summary>Color of spline point tangents in the editor</summary>
	public FLinearColor EditorTangentColor;
	///<summary>Whether the spline&#39;s leave and arrive tangents can be different</summary>
	public bool bAllowDiscontinuousSpline;
	///<summary>Whether scale visualization should be displayed</summary>
	public bool bShouldVisualizeScale;
	///<summary>Width of spline in editor for use with scale visualization</summary>
	public float ScaleVisualizationWidth;
	///<summary>Update the spline tangents and SplineReparamTable</summary>
	public virtual void UpdateSpline() {}
	///<summary>Get location along spline at the provided input key value</summary>
	public FVector GetLocationAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get tangent along spline at the provided input key value</summary>
	public FVector GetTangentAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get unit direction along spline at the provided input key value</summary>
	public FVector GetDirectionAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get rotator corresponding to rotation along spline at the provided input key value</summary>
	public FRotator GetRotationAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get up vector at the provided input key value</summary>
	public FVector GetUpVectorAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get right vector at the provided input key value</summary>
	public FVector GetRightVectorAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get transform at the provided input key value</summary>
	public FTransform GetTransformAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	///<summary>Get roll in degrees at the provided input key value</summary>
	public float GetRollAtSplineInputKey(float InKey,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get scale at the provided input key value</summary>
	public FVector GetScaleAtSplineInputKey(float InKey) { return default; }
	///<summary>Get distance along the spline at the provided input key value</summary>
	public float GetDistanceAlongSplineAtSplineInputKey(float InKey) { return default; }
	///<summary>Get a metadata property float value along the spline at spline input key</summary>
	public float GetFloatPropertyAtSplineInputKey(float InKey,FName PropertyName) { return default; }
	///<summary>Get a metadata property vector value along the spline at spline input key</summary>
	public FVector GetVectorPropertyAtSplineInputKey(float InKey,FName PropertyName) { return default; }
	///<summary>Specify unselected spline component segment color in the editor</summary>
	public void SetUnselectedSplineSegmentColor(FLinearColor SegmentColor) {}
	///<summary>Specify selected spline component segment color in the editor</summary>
	public void SetSelectedSplineSegmentColor(FLinearColor SegmentColor) {}
	///<summary>Specify selected spline component segment color in the editor</summary>
	public void SetTangentColor(FLinearColor TangentColor) {}
	///<summary>Specify whether this spline should be rendered when the Editor/Game spline show flag is set</summary>
	public void SetDrawDebug(bool bShow) {}
	///<summary>Specify whether the spline is a closed loop or not. The loop position will be at 1.0 after the last point&#39;s input key</summary>
	public void SetClosedLoop(bool bInClosedLoop,bool bUpdateSpline/*=true*/) {}
	///<summary>Specify whether the spline is a closed loop or not, and if so, the input key corresponding to the loop point</summary>
	public void SetClosedLoopAtPosition(bool bInClosedLoop,float Key,bool bUpdateSpline/*=true*/) {}
	///<summary>Check whether the spline is a closed loop or not</summary>
	public bool IsClosedLoop() { return default; }
	///<summary>Clears all the points in the spline</summary>
	public void ClearSplinePoints(bool bUpdateSpline/*=true*/) {}
	///<summary>Adds an FSplinePoint to the spline. This contains its input key, position, tangent, rotation and scale.</summary>
	public void AddPoint(FSplinePoint Point,bool bUpdateSpline/*=true*/) {}
	///<summary>Adds an array of FSplinePoints to the spline.</summary>
	public void AddPoints(TArray<FSplinePoint> Points,bool bUpdateSpline/*=true*/) {}
	///<summary>Adds a point to the spline</summary>
	public void AddSplinePoint(FVector Position,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Adds a point to the spline at the specified index</summary>
	public void AddSplinePointAtIndex(FVector Position,int Index,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Removes point at specified index from the spline</summary>
	public void RemoveSplinePoint(int Index,bool bUpdateSpline/*=true*/) {}
	///<summary>Adds a world space point to the spline</summary>
	public void AddSplineWorldPoint(FVector Position) {}
	///<summary>Adds a local space point to the spline</summary>
	public void AddSplineLocalPoint(FVector Position) {}
	///<summary>Sets the spline to an array of points</summary>
	public void SetSplinePoints(TArray<FVector> Points,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Sets the spline to an array of world space points</summary>
	public void SetSplineWorldPoints(TArray<FVector> Points) {}
	///<summary>Sets the spline to an array of local space points</summary>
	public void SetSplineLocalPoints(TArray<FVector> Points) {}
	///<summary>Move an existing point to a new location</summary>
	public void SetLocationAtSplinePoint(int PointIndex,FVector InLocation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Move an existing point to a new world location</summary>
	public void SetWorldLocationAtSplinePoint(int PointIndex,FVector InLocation) {}
	///<summary>Specify the tangent at a given spline point</summary>
	public void SetTangentAtSplinePoint(int PointIndex,FVector InTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Specify the tangents at a given spline point</summary>
	public void SetTangentsAtSplinePoint(int PointIndex,FVector InArriveTangent,FVector InLeaveTangent,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Specify the up vector at a given spline point</summary>
	public void SetUpVectorAtSplinePoint(int PointIndex,FVector InUpVector,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Set the rotation of an existing spline point</summary>
	public void SetRotationAtSplinePoint(int PointIndex,FRotator InRotation,ESplineCoordinateSpace CoordinateSpace,bool bUpdateSpline/*=true*/) {}
	///<summary>Set the scale at a given spline point</summary>
	public void SetScaleAtSplinePoint(int PointIndex,FVector InScaleVector,bool bUpdateSpline/*=true*/) {}
	///<summary>Get the type of a spline point</summary>
	public ESplinePointType GetSplinePointType(int PointIndex) { return default; }
	///<summary>Specify the type of a spline point</summary>
	public void SetSplinePointType(int PointIndex,ESplinePointType Type,bool bUpdateSpline/*=true*/) {}
	///<summary>Get the number of points that make up this spline</summary>
	public int GetNumberOfSplinePoints() { return default; }
	///<summary>Get the number of segments that make up this spline</summary>
	public int GetNumberOfSplineSegments() { return default; }
	///<summary>Get the location at spline point</summary>
	public FVector GetLocationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the world location at spline point</summary>
	public FVector GetWorldLocationAtSplinePoint(int PointIndex) { return default; }
	///<summary>Get the direction at spline point</summary>
	public FVector GetDirectionAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the tangent at spline point. This fetches the Leave tangent of the point.</summary>
	public FVector GetTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the arrive tangent at spline point</summary>
	public FVector GetArriveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the leave tangent at spline point</summary>
	public FVector GetLeaveTangentAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the rotation at spline point as a rotator</summary>
	public FRotator GetRotationAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the up vector at spline point</summary>
	public FVector GetUpVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the right vector at spline point</summary>
	public FVector GetRightVectorAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the amount of roll at spline point, in degrees</summary>
	public float GetRollAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Get the scale at spline point</summary>
	public FVector GetScaleAtSplinePoint(int PointIndex) { return default; }
	///<summary>Get the transform at spline point</summary>
	public FTransform GetTransformAtSplinePoint(int PointIndex,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	///<summary>Get location and tangent at a spline point</summary>
	public void GetLocationAndTangentAtSplinePoint(int PointIndex,FVector Location,FVector Tangent,ESplineCoordinateSpace CoordinateSpace) {}
	///<summary>Get local location and tangent at a spline point</summary>
	public void GetLocalLocationAndTangentAtSplinePoint(int PointIndex,FVector LocalLocation,FVector LocalTangent) {}
	///<summary>Get the distance along the spline at the spline point</summary>
	public float GetDistanceAlongSplineAtSplinePoint(int PointIndex) { return default; }
	///<summary>Get a metadata property float value along the spline at spline point</summary>
	public float GetFloatPropertyAtSplinePoint(int Index,FName PropertyName) { return default; }
	///<summary>Get a metadata property vector value along the spline at spline point</summary>
	public FVector GetVectorPropertyAtSplinePoint(int Index,FName PropertyName) { return default; }
	///<summary>Returns total length along this spline</summary>
	public float GetSplineLength() { return default; }
	///<summary>Sets the default up vector used by this spline</summary>
	public void SetDefaultUpVector(FVector UpVector,ESplineCoordinateSpace CoordinateSpace) {}
	///<summary>Gets the default up vector used by this spline</summary>
	public FVector GetDefaultUpVector(ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>This method has been deprecated because it was incorrectly returning the input key at time. To maintain the same behavior,</summary>
	public float GetInputKeyAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return the corresponding input key at that point</summary>
	public float GetInputKeyValueAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return the corresponding time at that point</summary>
	public float GetTimeAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return the point in space where this puts you</summary>
	public FVector GetLocationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return the point in world space where this puts you</summary>
	public FVector GetWorldLocationAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there.</summary>
	public FVector GetDirectionAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return a unit direction vector of the spline tangent there, in world space.</summary>
	public FVector GetWorldDirectionAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return the tangent vector of the spline there.</summary>
	public FVector GetTangentAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return the tangent vector of the spline there, in world space.</summary>
	public FVector GetWorldTangentAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return a rotation corresponding to the spline&#39;s rotation there.</summary>
	public FRotator GetRotationAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return a rotation corresponding to the spline&#39;s rotation there, in world space.</summary>
	public FRotator GetWorldRotationAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline&#39;s up vector there.</summary>
	public FVector GetUpVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return a unit direction vector corresponding to the spline&#39;s right vector there.</summary>
	public FVector GetRightVectorAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return the spline&#39;s roll there, in degrees.</summary>
	public float GetRollAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a distance along the length of this spline, return the spline&#39;s scale there.</summary>
	public FVector GetScaleAtDistanceAlongSpline(float Distance) { return default; }
	///<summary>Given a distance along the length of this spline, return an FTransform corresponding to that point on the spline.</summary>
	public FTransform GetTransformAtDistanceAlongSpline(float Distance,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
	public FVector GetLocationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the point in space where this puts you</summary>
	public FVector GetWorldLocationAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
	public FVector GetDirectionAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return a unit direction vector of the spline tangent there.</summary>
	public FVector GetWorldDirectionAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s tangent there.</summary>
	public FVector GetTangentAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline&#39;s position and direction there.</summary>
	public FRotator GetRotationAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return a rotation corresponding to the spline&#39;s position and direction there, in world space.</summary>
	public FRotator GetWorldRotationAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s up vector there.</summary>
	public FVector GetUpVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s right vector there.</summary>
	public FVector GetRightVectorAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s transform at the corresponding position.</summary>
	public FTransform GetTransformAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/,bool bUseScale/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s roll there, in degrees.</summary>
	public float GetRollAtTime(float Time,ESplineCoordinateSpace CoordinateSpace,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a time from 0 to the spline duration, return the spline&#39;s scale there.</summary>
	public FVector GetScaleAtTime(float Time,bool bUseConstantVelocity/*=false*/) { return default; }
	///<summary>Given a location, in world space, return the input key closest to that location.</summary>
	public float FindInputKeyClosestToWorldLocation(FVector WorldLocation) { return default; }
	///<summary>Given a location, in world space, return the point on the curve that is closest to the location.</summary>
	public FVector FindLocationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return a unit direction vector of the spline tangent closest to the location.</summary>
	public FVector FindDirectionClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return the tangent vector of the spline closest to the location.</summary>
	public FVector FindTangentClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return rotation corresponding to the spline&#39;s rotation closest to the location.</summary>
	public FRotator FindRotationClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return a unit direction vector corresponding to the spline&#39;s up vector closest to the location.</summary>
	public FVector FindUpVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return a unit direction vector corresponding to the spline&#39;s right vector closest to the location.</summary>
	public FVector FindRightVectorClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return the spline&#39;s roll closest to the location, in degrees.</summary>
	public float FindRollClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace) { return default; }
	///<summary>Given a location, in world space, return the spline&#39;s scale closest to the location.</summary>
	public FVector FindScaleClosestToWorldLocation(FVector WorldLocation) { return default; }
	///<summary>Given a location, in world space, return an FTransform closest to that location.</summary>
	public FTransform FindTransformClosestToWorldLocation(FVector WorldLocation,ESplineCoordinateSpace CoordinateSpace,bool bUseScale/*=false*/) { return default; }
	///<summary>Given a threshold, recursively sub-divides the spline section until the list of segments (polyline) matches the spline shape.</summary>
	public bool DivideSplineIntoPolylineRecursive(float StartDistanceAlongSpline,float EndDistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
	///<summary>Given a threshold, recursively sub-divides the spline section until the list of segments (polyline) matches the spline shape.</summary>
	public bool DivideSplineIntoPolylineRecursiveWithDistances(float StartDistanceAlongSpline,float EndDistanceAlongSpline,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints,TArray<double> OutDistancesAlongSpline) { return default; }
	///<summary>Given a threshold, returns a list of vertices along the spline segment that, treated as a list of segments (polyline), matches the spline shape.</summary>
	public bool ConvertSplineSegmentToPolyLine(int SplinePointStartIndex,ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
	///<summary>Given a threshold, returns a list of vertices along the spline that, treated as a list of segments (polyline), matches the spline shape.</summary>
	public bool ConvertSplineToPolyLine(ESplineCoordinateSpace CoordinateSpace,float MaxSquareDistanceFromSpline,TArray<FVector> OutPoints) { return default; }
}
