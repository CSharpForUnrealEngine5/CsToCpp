namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeometryScript/MeshPrimitiveFunctions.h")]
public partial class UGeometryScriptLibrary_MeshPrimitiveFunctions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>AppendBox</summary>
	public static UDynamicMesh AppendBox(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float DimensionX/*=100f*/,float DimensionY/*=100f*/,float DimensionZ/*=100f*/,int StepsX/*=0*/,int StepsY/*=0*/,int StepsZ/*=0*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendSphereLatLong</summary>
	public static UDynamicMesh AppendSphereLatLong(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float Radius/*=50f*/,int StepsPhi/*=10*/,int StepsTheta/*=16*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Center*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendSphereBox</summary>
	public static UDynamicMesh AppendSphereBox(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float Radius/*=50f*/,int StepsX/*=6*/,int StepsY/*=6*/,int StepsZ/*=6*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Center*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendCapsule</summary>
	public static UDynamicMesh AppendCapsule(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float Radius/*=30f*/,float LineLength/*=75f*/,int HemisphereSteps/*=5*/,int CircleSteps/*=8*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendCylinder</summary>
	public static UDynamicMesh AppendCylinder(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float Radius/*=50f*/,float Height/*=100f*/,int RadialSteps/*=12*/,int HeightSteps/*=0*/,bool bCapped/*=true*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendCone</summary>
	public static UDynamicMesh AppendCone(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float BaseRadius/*=50f*/,float TopRadius/*=5f*/,float Height/*=100f*/,int RadialSteps/*=12*/,int HeightSteps/*=4*/,bool bCapped/*=true*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendTorus</summary>
	public static UDynamicMesh AppendTorus(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,FGeometryScriptRevolveOptions RevolveOptions,float MajorRadius/*=50f*/,float MinorRadius/*=25f*/,int MajorSteps/*=16*/,int MinorSteps/*=8*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>In the coordinate system of the revolve polygon, +X is towards the &quot;outside&quot; of the revolve donut, and +Y is &quot;up&quot; (ie +Z in local space)</summary>
	public static UDynamicMesh AppendRevolvePolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,FGeometryScriptRevolveOptions RevolveOptions,float Radius/*=100f*/,int Steps/*=8*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendSpiralRevolvePolygon</summary>
	public static UDynamicMesh AppendSpiralRevolvePolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,FGeometryScriptRevolveOptions RevolveOptions,float Radius/*=100f*/,int Steps/*=18*/,float RisePerRevolution/*=50f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendRevolvePath</summary>
	public static UDynamicMesh AppendRevolvePath(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PathVertices,FGeometryScriptRevolveOptions RevolveOptions,int Steps/*=8*/,bool bCapped/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sweep the given 2D PolylineVertices along the SweepPath specified as a set of FTransforms</summary>
	public static UDynamicMesh AppendSweepPolyline(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolylineVertices,TArray<FTransform> SweepPath,TArray<float> PolylineTexParamU,TArray<float> SweepPathTexParamV,bool bLoop/*=false*/,float StartScale/*=1.0f*/,float EndScale/*=1.0f*/,float RotationAngleDeg/*=0.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Polygon should be oriented counter-clockwise to produce a correctly-oriented shape, otherwise it will be inside-out</summary>
	public static UDynamicMesh AppendSimpleExtrudePolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,float Height/*=100f*/,int HeightSteps/*=0*/,bool bCapped/*=true*/,EGeometryScriptPrimitiveOriginMode Origin/*=EGeometryScriptPrimitiveOriginMode.Base*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendSimpleSweptPolygon</summary>
	public static UDynamicMesh AppendSimpleSweptPolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,TArray<FVector> SweepPath,bool bLoop/*=false*/,bool bCapped/*=true*/,float StartScale/*=1.0f*/,float EndScale/*=1.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Sweep the given 2D PolygonVertices along the SweepPath specified as a set of FTransforms</summary>
	public static UDynamicMesh AppendSweepPolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,TArray<FTransform> SweepPath,bool bLoop/*=false*/,bool bCapped/*=true*/,float StartScale/*=1.0f*/,float EndScale/*=1.0f*/,float RotationAngleDeg/*=0.0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendRectangleXY</summary>
	public static UDynamicMesh AppendRectangleXY(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float DimensionX/*=100f*/,float DimensionY/*=100f*/,int StepsWidth/*=0*/,int StepsHeight/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendRoundRectangleXY</summary>
	public static UDynamicMesh AppendRoundRectangleXY(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float DimensionX/*=100f*/,float DimensionY/*=100f*/,float CornerRadius/*=5f*/,int StepsWidth/*=0*/,int StepsHeight/*=0*/,int StepsRound/*=4*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendDisc</summary>
	public static UDynamicMesh AppendDisc(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float Radius/*=50f*/,int AngleSteps/*=16*/,int SpokeSteps/*=0*/,float StartAngle/*=0f*/,float EndAngle/*=360f*/,float HoleRadius/*=0f*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>Polygon should be oriented counter-clockwise to produce a correctly-oriented shape, otherwise it will be inside-out</summary>
	public static UDynamicMesh AppendTriangulatedPolygon(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> PolygonVertices,bool bAllowSelfIntersections/*=true*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendLinearStairs</summary>
	public static UDynamicMesh AppendLinearStairs(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float StepWidth/*=100.0f*/,float StepHeight/*=20.0f*/,float StepDepth/*=30.0f*/,int NumSteps/*=8*/,bool bFloating/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendCurvedStairs</summary>
	public static UDynamicMesh AppendCurvedStairs(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float StepWidth/*=100.0f*/,float StepHeight/*=20.0f*/,float InnerRadius/*=150.0f*/,float CurveAngle/*=90.0f*/,int NumSteps/*=8*/,bool bFloating/*=false*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>AppendVoronoiDiagram2D</summary>
	public static UDynamicMesh AppendVoronoiDiagram2D(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,TArray<FVector2D> VoronoiSites,FGeometryScriptVoronoiOptions VoronoiOptions,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>5.0 Preview 1 Compatibility version of AppendRectangleXY. Incorrectly interprets the input dimensions.</summary>
	public static UDynamicMesh AppendRectangle_Compatibility_5_0(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float DimensionX/*=100f*/,float DimensionY/*=100f*/,int StepsWidth/*=0*/,int StepsHeight/*=0*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
	///<summary>5.0 Preview 1 Compatibility version of AppendRoundRectangleXY.</summary>
	public static UDynamicMesh AppendRoundRectangle_Compatibility_5_0(UDynamicMesh TargetMesh,FGeometryScriptPrimitiveOptions PrimitiveOptions,FTransform Transform,float DimensionX/*=100f*/,float DimensionY/*=100f*/,float CornerRadius/*=5f*/,int StepsWidth/*=0*/,int StepsHeight/*=0*/,int StepsRound/*=4*/,UGeometryScriptDebug Debug/*=nullptr*/) { return default; }
}
