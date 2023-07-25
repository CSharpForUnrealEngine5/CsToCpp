#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMathLibrary.h")]
public partial class UKismetMathLibrary : UBlueprintFunctionLibrary {
// KismetMathLibrary
	public bool RandomBool() { return default; }
	public bool RandomBoolWithWeight(float Weight) { return default; }
	public bool RandomBoolWithWeightFromStream(FRandomStream RandomStream,float Weight) { return default; }
	public bool Not_PreBool(bool A) { return default; }
	public bool EqualEqual_BoolBool(bool A,bool B) { return default; }
	public bool NotEqual_BoolBool(bool A,bool B) { return default; }
	public bool BooleanAND(bool A,bool B) { return default; }
	public bool BooleanNAND(bool A,bool B) { return default; }
	public bool BooleanOR(bool A,bool B) { return default; }
	public bool BooleanXOR(bool A,bool B) { return default; }
	public bool BooleanNOR(bool A,bool B) { return default; }
	public byte Multiply_ByteByte(byte A,byte B) { return default; }
	public byte Divide_ByteByte(byte A,byte B/*=1*/) { return default; }
	public byte Percent_ByteByte(byte A,byte B/*=1*/) { return default; }
	public byte Add_ByteByte(byte A,byte B/*=1*/) { return default; }
	public byte Subtract_ByteByte(byte A,byte B/*=1*/) { return default; }
	public byte BMin(byte A,byte B) { return default; }
	public byte BMax(byte A,byte B) { return default; }
	public bool Less_ByteByte(byte A,byte B) { return default; }
	public bool Greater_ByteByte(byte A,byte B) { return default; }
	public bool LessEqual_ByteByte(byte A,byte B) { return default; }
	public bool GreaterEqual_ByteByte(byte A,byte B) { return default; }
	public bool EqualEqual_ByteByte(byte A,byte B) { return default; }
	public bool NotEqual_ByteByte(byte A,byte B) { return default; }
	public int Multiply_IntInt(int A,int B) { return default; }
	public int Divide_IntInt(int A,int B/*=1*/) { return default; }
	public int Percent_IntInt(int A,int B/*=1*/) { return default; }
	public int Add_IntInt(int A,int B/*=1*/) { return default; }
	public int Subtract_IntInt(int A,int B/*=1*/) { return default; }
	public bool Less_IntInt(int A,int B) { return default; }
	public bool Greater_IntInt(int A,int B) { return default; }
	public bool LessEqual_IntInt(int A,int B) { return default; }
	public bool GreaterEqual_IntInt(int A,int B) { return default; }
	public bool EqualEqual_IntInt(int A,int B) { return default; }
	public bool NotEqual_IntInt(int A,int B) { return default; }
	public bool InRange_IntInt(int Value,int Min,int Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public int And_IntInt(int A,int B) { return default; }
	public int Xor_IntInt(int A,int B) { return default; }
	public int Or_IntInt(int A,int B) { return default; }
	public int Not_Int(int A) { return default; }
	public int SignOfInteger(int A) { return default; }
	public int RandomInteger(int Max) { return default; }
	public int RandomIntegerInRange(int Min,int Max) { return default; }
	public int Min(int A,int B) { return default; }
	public int Max(int A,int B) { return default; }
	public int Clamp(int Value,int Min,int Max) { return default; }
	public int Wrap(int Value,int Min,int Max) { return default; }
	public int Abs_Int(int A) { return default; }
	public long Multiply_Int64Int64(long A,long B) { return default; }
	public long Divide_Int64Int64(long A,long B/*=1*/) { return default; }
	public long Percent_Int64Int64(long A,long B/*=1*/) { return default; }
	public long Add_Int64Int64(long A,long B/*=1*/) { return default; }
	public long Subtract_Int64Int64(long A,long B/*=1*/) { return default; }
	public bool Less_Int64Int64(long A,long B) { return default; }
	public bool Greater_Int64Int64(long A,long B) { return default; }
	public bool LessEqual_Int64Int64(long A,long B) { return default; }
	public bool GreaterEqual_Int64Int64(long A,long B) { return default; }
	public bool EqualEqual_Int64Int64(long A,long B) { return default; }
	public bool NotEqual_Int64Int64(long A,long B) { return default; }
	public bool InRange_Int64Int64(long Value,long Min,long Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public long And_Int64Int64(long A,long B) { return default; }
	public long Xor_Int64Int64(long A,long B) { return default; }
	public long Or_Int64Int64(long A,long B) { return default; }
	public long Not_Int64(long A) { return default; }
	public long SignOfInteger64(long A) { return default; }
	public long RandomInteger64(long Max) { return default; }
	public long RandomInteger64InRange(long Min,long Max) { return default; }
	public long MinInt64(long A,long B) { return default; }
	public long MaxInt64(long A,long B) { return default; }
	public long ClampInt64(long Value,long Min,long Max) { return default; }
	public long Abs_Int64(long A) { return default; }
	public double MultiplyMultiply_FloatFloat(double Base,double Exp) { return default; }
	public double Multiply_IntFloat(int A,double B) { return default; }
	public double Percent_FloatFloat(double A,double B/*=1.0f*/) { return default; }
	public double Fraction(double A) { return default; }
	public double Add_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public double Subtract_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public double Multiply_DoubleDouble(double A,double B) { return default; }
	public double Divide_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public bool Less_DoubleDouble(double A,double B) { return default; }
	public bool Greater_DoubleDouble(double A,double B) { return default; }
	public bool LessEqual_DoubleDouble(double A,double B) { return default; }
	public bool GreaterEqual_DoubleDouble(double A,double B) { return default; }
	public bool EqualEqual_DoubleDouble(double A,double B) { return default; }
	public bool NearlyEqual_FloatFloat(double A,double B,double ErrorTolerance/*=1.0e-6*/) { return default; }
	public bool NotEqual_DoubleDouble(double A,double B) { return default; }
	public bool InRange_FloatFloat(double Value,double Min,double Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public double Hypotenuse(double Width,double Height) { return default; }
	public double GridSnap_Float(double Location,double GridSize) { return default; }
	public double Abs(double A) { return default; }
	public double Sin(double A) { return default; }
	public double Asin(double A) { return default; }
	public double Cos(double A) { return default; }
	public double Acos(double A) { return default; }
	public double Tan(double A) { return default; }
	public double Atan(double A) { return default; }
	public double Atan2(double Y,double X) { return default; }
	public double Exp(double A) { return default; }
	public double Log(double A,double Base/*=1.0*/) { return default; }
	public double Loge(double A) { return default; }
	public double Sqrt(double A) { return default; }
	public double Square(double A) { return default; }
	public double RandomFloat() { return default; }
	public double RandomFloatInRange(double Min,double Max) { return default; }
	public double GetPI() { return default; }
	public double GetTAU() { return default; }
	public double DegreesToRadians(double A) { return default; }
	public double RadiansToDegrees(double A) { return default; }
	public double DegSin(double A) { return default; }
	public double DegAsin(double A) { return default; }
	public double DegCos(double A) { return default; }
	public double DegAcos(double A) { return default; }
	public double DegTan(double A) { return default; }
	public double DegAtan(double A) { return default; }
	public double DegAtan2(double Y,double X) { return default; }
	public double ClampAngle(double AngleDegrees,double MinAngleDegrees,double MaxAngleDegrees) { return default; }
	public double FMin(double A,double B) { return default; }
	public double FMax(double A,double B) { return default; }
	public double FClamp(double Value,double Min,double Max) { return default; }
	public double FWrap(double Value,double Min,double Max) { return default; }
	public double SafeDivide(double A,double B) { return default; }
	public void MaxOfIntArray(TArray<int> IntArray,int IndexOfMaxValue,int MaxValue) {}
	public void MinOfIntArray(TArray<int> IntArray,int IndexOfMinValue,int MinValue) {}
	public void MedianOfIntArray(TArray<int> IntArray,float MedianValue) {}
	public void AverageOfIntArray(TArray<int> IntArray,float AverageValue) {}
	public void MaxOfFloatArray(TArray<float> FloatArray,int IndexOfMaxValue,float MaxValue) {}
	public void MinOfFloatArray(TArray<float> FloatArray,int IndexOfMinValue,float MinValue) {}
	public void MaxOfByteArray(TArray<byte> ByteArray,int IndexOfMaxValue,byte MaxValue) {}
	public void MinOfByteArray(TArray<byte> ByteArray,int IndexOfMinValue,byte MinValue) {}
	public double Lerp(double A,double B,double Alpha) { return default; }
	public double Ease(double A,double B,double Alpha,byte EasingFunc,double BlendExp/*=2*/,int Steps/*=2*/) { return default; }
	public int Round(double A) { return default; }
	public int FFloor(double A) { return default; }
	public int FTrunc(double A) { return default; }
	public int FCeil(double A) { return default; }
	public long Round64(double A) { return default; }
	public long FFloor64(double A) { return default; }
	public long FTrunc64(double A) { return default; }
	public long FCeil64(double A) { return default; }
	public int FMod(double Dividend,double Divisor,double Remainder) { return default; }
	public long FMod64(double Dividend,double Divisor,double Remainder) { return default; }
	public double SignOfFloat(double A) { return default; }
	public double NormalizeToRange(double Value,double RangeMin,double RangeMax) { return default; }
	public double MapRangeUnclamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	public double MapRangeClamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	public double MultiplyByPi(double Value) { return default; }
	public double FInterpEaseInOut(double A,double B,double Alpha,double Exponent) { return default; }
	public float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond/*=1.0f*/,float InPhase/*=0.0f*/) { return default; }
	public float FixedTurn(float InCurrent,float InDesired,float InDeltaRate) { return default; }
	public FIntPoint IntPoint_Zero() { return default; }
	public FIntPoint IntPoint_One() { return default; }
	public FIntPoint IntPoint_Up() { return default; }
	public FIntPoint IntPoint_Left() { return default; }
	public FIntPoint IntPoint_Right() { return default; }
	public FIntPoint IntPoint_Down() { return default; }
	public FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint) { return default; }
	public FIntPoint Add_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public FIntPoint Add_IntPointInt(FIntPoint A,int B) { return default; }
	public FIntPoint Subtract_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public FIntPoint Subtract_IntPointInt(FIntPoint A,int B) { return default; }
	public FIntPoint Multiply_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public FIntPoint Multiply_IntPointInt(FIntPoint A,int B) { return default; }
	public FIntPoint Divide_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public FIntPoint Divide_IntPointInt(FIntPoint A,int B) { return default; }
	public bool Equal_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public bool NotEqual_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public FVector2D Vector2D_One() { return default; }
	public FVector2D Vector2D_Unit45Deg() { return default; }
	public FVector2D Vector2D_Zero() { return default; }
	public FVector2D MakeVector2D(double X,double Y) { return default; }
	public void BreakVector2D(FVector2D InVec,double X,double Y) {}
	public FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z/*=0f*/) { return default; }
	public FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D) { return default; }
	public FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public FVector2D Add_Vector2DFloat(FVector2D A,double B) { return default; }
	public FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public FVector2D Subtract_Vector2DFloat(FVector2D A,double B) { return default; }
	public FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public FVector2D Multiply_Vector2DFloat(FVector2D A,double B) { return default; }
	public FVector2D Divide_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public FVector2D Divide_Vector2DFloat(FVector2D A,double B/*=1.0f*/) { return default; }
	public bool EqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public FVector2D Negated2D(FVector2D A) { return default; }
	public void Set2D(FVector2D A,double X,double Y) {}
	public FVector2D ClampAxes2D(FVector2D A,double MinAxisVal,double MaxAxisVal) { return default; }
	public double CrossProduct2D(FVector2D A,FVector2D B) { return default; }
	public double Distance2D(FVector2D V1,FVector2D V2) { return default; }
	public double DistanceSquared2D(FVector2D V1,FVector2D V2) { return default; }
	public double DotProduct2D(FVector2D A,FVector2D B) { return default; }
	public FVector2D GetAbs2D(FVector2D A) { return default; }
	public double GetAbsMax2D(FVector2D A) { return default; }
	public double GetMax2D(FVector2D A) { return default; }
	public double GetMin2D(FVector2D A) { return default; }
	public FVector2D GetRotated2D(FVector2D A,float AngleDeg) { return default; }
	public bool IsNearlyZero2D(FVector2D A,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool IsZero2D(FVector2D A) { return default; }
	public FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	public FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	public FVector2D NormalSafe2D(FVector2D A,float Tolerance/*=1.0e-8f*/) { return default; }
	public FVector2D Normal2D(FVector2D A) { return default; }
	public void Normalize2D(FVector2D A,float Tolerance/*=1.0e-8f*/) {}
	public FVector Spherical2DToUnitCartesian(FVector2D A) { return default; }
	public void ToDirectionAndLength2D(FVector2D A,FVector2D OutDir,double OutLength) {}
	public FVector2D ToRounded2D(FVector2D A) { return default; }
	public FVector2D ToSign2D(FVector2D A) { return default; }
	public double VSize2D(FVector2D A) { return default; }
	public double VSize2DSquared(FVector2D A) { return default; }
	public FVector Vector_Zero() { return default; }
	public FVector Vector_One() { return default; }
	public FVector Vector_Forward() { return default; }
	public FVector Vector_Backward() { return default; }
	public FVector Vector_Up() { return default; }
	public FVector Vector_Down() { return default; }
	public FVector Vector_Right() { return default; }
	public FVector Vector_Left() { return default; }
	public FVector MakeVector(double X,double Y,double Z) { return default; }
	public FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length/*=1.0f*/) { return default; }
	public void Vector_Assign(FVector A,FVector InVector) {}
	public void Vector_Set(FVector A,double X,double Y,double Z) {}
	public void BreakVector(FVector InVec,double X,double Y,double Z) {}
	public void BreakVector3f(FVector3f InVec,float X,float Y,float Z) {}
	public FLinearColor Conv_VectorToLinearColor(FVector InVec) { return default; }
	public FTransform Conv_VectorToTransform(FVector InLocation) { return default; }
	public FVector2D Conv_VectorToVector2D(FVector InVector) { return default; }
	public FRotator Conv_VectorToRotator(FVector InVec) { return default; }
	public FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle) { return default; }
	public FQuat Conv_VectorToQuaternion(FVector InVec) { return default; }
	public FVector Vector_SlerpVectorToDirection(FVector Vector,FVector Direction,double Alpha) { return default; }
	public FVector Vector_SlerpNormals(FVector NormalA,FVector NormalB,double Alpha) { return default; }
	public FVector Add_VectorVector(FVector A,FVector B) { return default; }
	public FVector Add_VectorFloat(FVector A,double B) { return default; }
	public FVector Add_VectorInt(FVector A,int B) { return default; }
	public FVector Subtract_VectorVector(FVector A,FVector B) { return default; }
	public FVector Subtract_VectorFloat(FVector A,double B) { return default; }
	public FVector Subtract_VectorInt(FVector A,int B) { return default; }
	public FVector Multiply_VectorVector(FVector A,FVector B) { return default; }
	public FVector Multiply_VectorFloat(FVector A,double B) { return default; }
	public FVector Multiply_VectorInt(FVector A,int B) { return default; }
	public FVector Divide_VectorVector(FVector A,FVector B/*=new FVector(1.0f,1.0f,1.0f)*/) { return default; }
	public FVector Divide_VectorFloat(FVector A,double B/*=1.0f*/) { return default; }
	public FVector Divide_VectorInt(FVector A,int B/*=1*/) { return default; }
	public FVector NegateVector(FVector A) { return default; }
	public bool EqualExactly_VectorVector(FVector A,FVector B) { return default; }
	public bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqualExactly_VectorVector(FVector A,FVector B) { return default; }
	public bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public double Dot_VectorVector(FVector A,FVector B) { return default; }
	public FVector Cross_VectorVector(FVector A,FVector B) { return default; }
	public FVector GreaterGreater_VectorRotator(FVector A,FRotator B) { return default; }
	public FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis) { return default; }
	public FVector LessLess_VectorRotator(FVector A,FRotator B) { return default; }
	public void Vector_UnwindEuler(FVector A) {}
	public FVector ClampVectorSize(FVector A,double Min,double Max) { return default; }
	public FVector Vector_ClampSize2D(FVector A,double Min,double Max) { return default; }
	public FVector Vector_ClampSizeMax(FVector A,double Max) { return default; }
	public FVector Vector_ClampSizeMax2D(FVector A,double Max) { return default; }
	public double GetMinElement(FVector A) { return default; }
	public double GetMaxElement(FVector A) { return default; }
	public double Vector_GetAbsMax(FVector A) { return default; }
	public double Vector_GetAbsMin(FVector A) { return default; }
	public FVector Vector_GetAbs(FVector A) { return default; }
	public FVector Vector_ComponentMin(FVector A,FVector B) { return default; }
	public FVector Vector_ComponentMax(FVector A,FVector B) { return default; }
	public FVector Vector_GetSignVector(FVector A) { return default; }
	public FVector Vector_GetProjection(FVector A) { return default; }
	public double Vector_HeadingAngle(FVector A) { return default; }
	public double Vector_CosineAngle2D(FVector A,FVector B) { return default; }
	public FVector Vector_ToRadians(FVector A) { return default; }
	public FVector Vector_ToDegrees(FVector A) { return default; }
	public FVector2D Vector_UnitCartesianToSpherical(FVector A) { return default; }
	public FVector GetDirectionUnitVector(FVector From,FVector To) { return default; }
	public void GetYawPitchFromVector(FVector InVec,float Yaw,float Pitch) {}
	public void GetAzimuthAndElevation(FVector InDirection,FTransform ReferenceFrame,float Azimuth,float Elevation) {}
	public FVector GetVectorArrayAverage(TArray<FVector> Vectors) { return default; }
	public FIntVector FTruncVector(FVector InVector) { return default; }
	public double Vector_Distance(FVector V1,FVector V2) { return default; }
	public double Vector_DistanceSquared(FVector V1,FVector V2) { return default; }
	public double Vector_Distance2D(FVector V1,FVector V2) { return default; }
	public double Vector_Distance2DSquared(FVector V1,FVector V2) { return default; }
	public double VSize(FVector A) { return default; }
	public double VSizeSquared(FVector A) { return default; }
	public double VSizeXY(FVector A) { return default; }
	public double VSizeXYSquared(FVector A) { return default; }
	public bool Vector_IsNearlyZero(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool Vector_IsZero(FVector A) { return default; }
	public bool Vector_IsNAN(FVector A) { return default; }
	public bool Vector_IsUniform(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool Vector_IsUnit(FVector A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	public bool Vector_IsNormal(FVector A) { return default; }
	public FVector Normal(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public FVector Vector_Normal2D(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public FVector Vector_NormalUnsafe(FVector A) { return default; }
	public void Vector_Normalize(FVector A,float Tolerance/*=1.0e-8f*/) {}
	public FVector VLerp(FVector A,FVector B,float Alpha) { return default; }
	public FVector VEase(FVector A,FVector B,float Alpha,byte EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	public FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	public FVector VectorSpringInterp(FVector Current,FVector Target,FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,FVector MinValue/*=new FVector(-1.0f)*/,FVector MaxValue/*=new FVector(1.0f)*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public FQuat QuaternionSpringInterp(FQuat Current,FQuat Target,FQuaternionSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public FVector Vector_Reciprocal(FVector A) { return default; }
	public FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal) { return default; }
	public FVector MirrorVectorByNormal(FVector InVect,FVector InNormal) { return default; }
	public FVector Vector_MirrorByPlane(FVector A,FPlane InPlane) { return default; }
	public FVector Vector_SnappedToGrid(FVector InVect,float InGridSize) { return default; }
	public FVector Vector_BoundedToCube(FVector InVect,float InRadius) { return default; }
	public void Vector_AddBounded(FVector A,FVector InAddVect,float InRadius) {}
	public FVector Vector_BoundedToBox(FVector InVect,FVector InBoxMin,FVector InBoxMax) { return default; }
	public FVector Vector_ProjectOnToNormal(FVector V,FVector InNormal) { return default; }
	public FVector ProjectVectorOnToVector(FVector V,FVector Target) { return default; }
	public FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal) { return default; }
	public FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal) { return default; }
	public void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,FVector Segment1Point,FVector Segment2Point) {}
	public FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	public FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	public float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	public float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	public FVector RandomUnitVector() { return default; }
	public FVector RandomPointInBoundingBox(FVector Center,FVector HalfSize) { return default; }
	public FVector RandomPointInBoundingBox_Box(FBox Box) { return default; }
	public FVector RandomUnitVectorInConeInRadians(FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	public FVector RandomUnitVectorInConeInDegrees(FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	public FVector4 Vector4_Zero() { return default; }
	public FVector4 MakeVector4(double X,double Y,double Z,double W) { return default; }
	public void BreakVector4(FVector4 InVec,double X,double Y,double Z,double W) {}
	public FVector Conv_Vector4ToVector(FVector4 InVector4) { return default; }
	public FRotator Conv_Vector4ToRotator(FVector4 InVec) { return default; }
	public FQuat Conv_Vector4ToQuaternion(FVector4 InVec) { return default; }
	public FVector4 Add_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public FVector4 Subtract_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public FVector4 Multiply_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public FVector4 Divide_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public bool EqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public bool EqualEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public bool NotEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public FVector4 Vector4_Negated(FVector4 A) { return default; }
	public void Vector4_Assign(FVector4 A,FVector4 InVector) {}
	public void Vector4_Set(FVector4 A,double X,double Y,double Z,double W) {}
	public FVector4 Vector4_CrossProduct3(FVector4 A,FVector4 B) { return default; }
	public double Vector4_DotProduct(FVector4 A,FVector4 B) { return default; }
	public double Vector4_DotProduct3(FVector4 A,FVector4 B) { return default; }
	public bool Vector4_IsNAN(FVector4 A) { return default; }
	public bool Vector4_IsNearlyZero3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool Vector4_IsZero(FVector4 A) { return default; }
	public double Vector4_Size(FVector4 A) { return default; }
	public double Vector4_SizeSquared(FVector4 A) { return default; }
	public double Vector4_Size3(FVector4 A) { return default; }
	public double Vector4_SizeSquared3(FVector4 A) { return default; }
	public bool Vector4_IsUnit3(FVector4 A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	public bool Vector4_IsNormal3(FVector4 A) { return default; }
	public FVector4 Vector4_Normal3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	public FVector4 Vector4_NormalUnsafe3(FVector4 A) { return default; }
	public void Vector4_Normalize3(FVector4 A,float Tolerance/*=1.0e-8f*/) {}
	public FVector4 Vector4_MirrorByVector3(FVector4 Direction,FVector4 SurfaceNormal) { return default; }
	public FVector4 TransformVector4(FMatrix Matrix,FVector4 Vec4) { return default; }
	public FRotator MakeRotator(float Roll,float Pitch,float Yaw) { return default; }
	public FRotator MakeRotFromX(FVector X) { return default; }
	public FRotator MakeRotFromY(FVector Y) { return default; }
	public FRotator MakeRotFromZ(FVector Z) { return default; }
	public FRotator MakeRotFromXY(FVector X,FVector Y) { return default; }
	public FRotator MakeRotFromXZ(FVector X,FVector Z) { return default; }
	public FRotator MakeRotFromYX(FVector Y,FVector X) { return default; }
	public FRotator MakeRotFromYZ(FVector Y,FVector Z) { return default; }
	public FRotator MakeRotFromZX(FVector Z,FVector X) { return default; }
	public FRotator MakeRotFromZY(FVector Z,FVector Y) { return default; }
	public FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up) { return default; }
	public FRotator FindLookAtRotation(FVector Start,FVector Target) { return default; }
	public FRotator FindRelativeLookAtRotation(FTransform StartTransform,FVector TargetLocation) { return default; }
	public void BreakRotator(FRotator InRot,float Roll,float Pitch,float Yaw) {}
	public void BreakRotIntoAxes(FRotator InRot,FVector X,FVector Y,FVector Z) {}
	public bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public FRotator Multiply_RotatorFloat(FRotator A,float B) { return default; }
	public FRotator Multiply_RotatorInt(FRotator A,int B) { return default; }
	public FRotator ComposeRotators(FRotator A,FRotator B) { return default; }
	public FRotator NegateRotator(FRotator A) { return default; }
	public FVector GetForwardVector(FRotator InRot) { return default; }
	public FVector GetRightVector(FRotator InRot) { return default; }
	public FVector GetUpVector(FRotator InRot) { return default; }
	public FVector Conv_RotatorToVector(FRotator InRot) { return default; }
	public FTransform Conv_RotatorToTransform(FRotator InRotator) { return default; }
	public void GetAxes(FRotator A,FVector X,FVector Y,FVector Z) {}
	public FRotator RandomRotator(bool bRoll/*=false*/) { return default; }
	public FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath) { return default; }
	public FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,byte EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public FRotator NormalizedDeltaRotator(FRotator A,FRotator B) { return default; }
	public float ClampAxis(float Angle) { return default; }
	public float NormalizeAxis(float Angle) { return default; }
	public FTransform Conv_MatrixToTransform(FMatrix InMatrix) { return default; }
	public FRotator Conv_MatrixToRotator(FMatrix InMatrix) { return default; }
	public FVector Matrix_GetOrigin(FMatrix InMatrix) { return default; }
	public FMatrix Matrix_Identity() { return default; }
	public FMatrix Multiply_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	public FMatrix Add_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	public FMatrix Multiply_MatrixFloat(FMatrix A,double B) { return default; }
	public bool EqualEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	public FVector4 Matrix_TransformVector4(FMatrix M,FVector4 V) { return default; }
	public FVector4 Matrix_TransformPosition(FMatrix M,FVector V) { return default; }
	public FVector Matrix_InverseTransformPosition(FMatrix M,FVector V) { return default; }
	public FVector4 Matrix_TransformVector(FMatrix M,FVector V) { return default; }
	public FVector Matrix_InverseTransformVector(FMatrix M,FVector V) { return default; }
	public FMatrix Matrix_GetTransposed(FMatrix M) { return default; }
	public float Matrix_GetDeterminant(FMatrix M) { return default; }
	public float Matrix_GetRotDeterminant(FMatrix M) { return default; }
	public FMatrix Matrix_GetInverse(FMatrix M) { return default; }
	public FMatrix Matrix_GetTransposeAdjoint(FMatrix M) { return default; }
	public void Matrix_RemoveScaling(FMatrix M,float Tolerance/*=1.0e-8f*/) {}
	public FMatrix Matrix_GetMatrixWithoutScale(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	public FVector Matrix_GetScaleVector(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	public FMatrix Matrix_RemoveTranslation(FMatrix M) { return default; }
	public FMatrix Matrix_ConcatenateTranslation(FMatrix M,FVector Translation) { return default; }
	public bool Matrix_ContainsNaN(FMatrix M) { return default; }
	public FMatrix Matrix_ScaleTranslation(FMatrix M,FVector Scale3D) { return default; }
	public float Matrix_GetMaximumAxisScale(FMatrix M) { return default; }
	public FMatrix Matrix_ApplyScale(FMatrix M,float Scale) { return default; }
	public FVector Matrix_GetScaledAxis(FMatrix M,byte Axis) { return default; }
	public void Matrix_GetScaledAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public FVector Matrix_GetUnitAxis(FMatrix M,byte Axis) { return default; }
	public void Matrix_GetUnitAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public void Matrix_SetAxis(FMatrix M,byte Axis,FVector AxisVector) {}
	public void Matrix_SetOrigin(FMatrix M,FVector NewOrigin) {}
	public FVector Matrix_GetColumn(FMatrix M,byte Column) { return default; }
	public void Matrix_SetColumn(FMatrix M,byte Column,FVector Value) {}
	public FRotator Matrix_GetRotator(FMatrix M) { return default; }
	public FQuat Matrix_ToQuat(FMatrix M) { return default; }
	public bool Matrix_GetFrustumNearPlane(FMatrix M,FPlane OutPlane) { return default; }
	public bool Matrix_GetFrustumFarPlane(FMatrix M,FPlane OutPlane) { return default; }
	public bool Matrix_GetFrustumLeftPlane(FMatrix M,FPlane OutPlane) { return default; }
	public bool Matrix_GetFrustumRightPlane(FMatrix M,FPlane OutPlane) { return default; }
	public bool Matrix_GetFrustumTopPlane(FMatrix M,FPlane OutPlane) { return default; }
	public bool Matrix_GetFrustumBottomPlane(FMatrix M,FPlane OutPlane) { return default; }
	public FMatrix Matrix_Mirror(FMatrix M,byte MirrorAxis,byte FlipAxis) { return default; }
	public FQuat Quat_Identity() { return default; }
	public bool EqualEqual_QuatQuat(FQuat A,FQuat B,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool NotEqual_QuatQuat(FQuat A,FQuat B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public FQuat Add_QuatQuat(FQuat A,FQuat B) { return default; }
	public FQuat Subtract_QuatQuat(FQuat A,FQuat B) { return default; }
	public FQuat MakeQuat(float X,float Y,float Z,float W) { return default; }
	public void BreakQuat(FQuat InQuat,float X,float Y,float Z,float W) {}
	public FQuat Multiply_QuatQuat(FQuat A,FQuat B) { return default; }
	public bool Quat_IsIdentity(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool Quat_IsNormalized(FQuat Q) { return default; }
	public bool Quat_IsFinite(FQuat Q) { return default; }
	public bool Quat_IsNonFinite(FQuat Q) { return default; }
	public float Quat_AngularDistance(FQuat A,FQuat B) { return default; }
	public void Quat_EnforceShortestArcWith(FQuat A,FQuat B) {}
	public FVector Quat_Euler(FQuat Q) { return default; }
	public FQuat Quat_Exp(FQuat Q) { return default; }
	public float Quat_GetAngle(FQuat Q) { return default; }
	public FVector Quat_GetAxisX(FQuat Q) { return default; }
	public FVector Quat_GetAxisY(FQuat Q) { return default; }
	public FVector Quat_GetAxisZ(FQuat Q) { return default; }
	public FVector Quat_VectorForward(FQuat Q) { return default; }
	public FVector Quat_VectorRight(FQuat Q) { return default; }
	public FVector Quat_VectorUp(FQuat Q) { return default; }
	public void Quat_Normalize(FQuat Q,float Tolerance/*=1.0e-4f*/) {}
	public FQuat Quat_Normalized(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	public FVector Quat_GetRotationAxis(FQuat Q) { return default; }
	public FQuat Quat_Inversed(FQuat Q) { return default; }
	public FQuat Quat_Log(FQuat Q) { return default; }
	public void Quat_SetComponents(FQuat Q,float X,float Y,float Z,float W) {}
	public void Quat_SetFromEuler(FQuat Q,FVector Euler) {}
	public FQuat Quat_MakeFromEuler(FVector Euler) { return default; }
	public FRotator Quat_Rotator(FQuat Q) { return default; }
	public FQuat Conv_RotatorToQuaternion(FRotator InRot) { return default; }
	public float Quat_Size(FQuat Q) { return default; }
	public float Quat_SizeSquared(FQuat Q) { return default; }
	public FVector Quat_RotateVector(FQuat Q,FVector V) { return default; }
	public FVector Quat_UnrotateVector(FQuat Q,FVector V) { return default; }
	public FQuat Quat_Slerp(FQuat A,FQuat B,double Alpha) { return default; }
	public FQuat Quat_FindBetweenVectors(FVector Start,FVector End) { return default; }
	public FQuat Quat_FindBetweenNormals(FVector StartNormal,FVector EndNormal) { return default; }
	public FLinearColor LinearColor_White() { return default; }
	public FLinearColor LinearColor_Gray() { return default; }
	public FLinearColor LinearColor_Black() { return default; }
	public FLinearColor LinearColor_Red() { return default; }
	public FLinearColor LinearColor_Green() { return default; }
	public FLinearColor LinearColor_Blue() { return default; }
	public FLinearColor LinearColor_Yellow() { return default; }
	public FLinearColor LinearColor_Transparent() { return default; }
	public FLinearColor MakeColor(float R,float G,float B,float A/*=1.0f*/) { return default; }
	public void BreakColor(FLinearColor InColor,float R,float G,float B,float A) {}
	public void LinearColor_Set(FLinearColor InOutColor,FLinearColor InColor) {}
	public void LinearColor_SetRGBA(FLinearColor InOutColor,float R,float G,float B,float A/*=1.0f*/) {}
	public void LinearColor_SetFromHSV(FLinearColor InOutColor,float H,float S,float V,float A/*=1.0f*/) {}
	public void LinearColor_SetFromSRGB(FLinearColor InOutColor,FColor InSRGB) {}
	public void LinearColor_SetFromPow22(FLinearColor InOutColor,FColor InColor) {}
	public void LinearColor_SetTemperature(FLinearColor InOutColor,float InTemperature) {}
	public void LinearColor_SetRandomHue(FLinearColor InOutColor) {}
	public FLinearColor Conv_DoubleToLinearColor(double InDouble) { return default; }
	public FLinearColor HSVToRGB(float H,float S,float V,float A/*=1.0f*/) { return default; }
	public void HSVToRGB_Vector(FLinearColor HSV,FLinearColor RGB) {}
	public FLinearColor HSVToRGBLinear(FLinearColor HSV) { return default; }
	public void RGBToHSV(FLinearColor InColor,float H,float S,float V,float A) {}
	public void RGBToHSV_Vector(FLinearColor RGB,FLinearColor HSV) {}
	public FLinearColor RGBLinearToHSV(FLinearColor RGB) { return default; }
	public FVector Conv_LinearColorToVector(FLinearColor InLinearColor) { return default; }
	public FColor LinearColor_ToRGBE(FLinearColor InLinearColor) { return default; }
	public FColor Conv_LinearColorToColor(FLinearColor InLinearColor,bool InUseSRGB/*=true*/) { return default; }
	public FColor LinearColor_Quantize(FLinearColor InColor) { return default; }
	public FColor LinearColor_QuantizeRound(FLinearColor InColor) { return default; }
	public FLinearColor LinearColor_Desaturated(FLinearColor InColor,float InDesaturation) { return default; }
	public float LinearColor_Distance(FLinearColor C1,FLinearColor C2) { return default; }
	public FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor,float InOpacity) { return default; }
	public float LinearColor_GetLuminance(FLinearColor InColor) { return default; }
	public float LinearColor_GetMax(FLinearColor InColor) { return default; }
	public float LinearColor_GetMin(FLinearColor InColor) { return default; }
	public FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed) { return default; }
	public FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	public FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	public bool LinearColor_IsNearEqual(FLinearColor A,FLinearColor B,float Tolerance/*=1.0e-4f*/) { return default; }
	public bool EqualEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public bool NotEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public FLinearColor Add_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public FLinearColor Subtract_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B) { return default; }
	public FLinearColor Divide_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal) { return default; }
	public FDateTime MakeDateTime(int Year,int Month,int Day,int Hour/*=0*/,int Minute/*=0*/,int Second/*=0*/,int Millisecond/*=0*/) { return default; }
	public void BreakDateTime(FDateTime InDateTime,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond) {}
	public FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	public FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	public FDateTime Add_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool Greater_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool Less_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public FDateTime GetDate(FDateTime A) { return default; }
	public int GetDay(FDateTime A) { return default; }
	public int GetDayOfYear(FDateTime A) { return default; }
	public int GetHour(FDateTime A) { return default; }
	public int GetHour12(FDateTime A) { return default; }
	public int GetMillisecond(FDateTime A) { return default; }
	public int GetMinute(FDateTime A) { return default; }
	public int GetMonth(FDateTime A) { return default; }
	public int GetSecond(FDateTime A) { return default; }
	public FTimespan GetTimeOfDay(FDateTime A) { return default; }
	public int GetYear(FDateTime A) { return default; }
	public bool IsAfternoon(FDateTime A) { return default; }
	public bool IsMorning(FDateTime A) { return default; }
	public int DaysInMonth(int Year,int Month) { return default; }
	public int DaysInYear(int Year) { return default; }
	public bool IsLeapYear(int Year) { return default; }
	public FDateTime DateTimeMaxValue() { return default; }
	public FDateTime DateTimeMinValue() { return default; }
	public FDateTime Now() { return default; }
	public FDateTime Today() { return default; }
	public FDateTime UtcNow() { return default; }
	public bool DateTimeFromIsoString(string IsoString,FDateTime Result) { return default; }
	public bool DateTimeFromString(string DateTimeString,FDateTime Result) { return default; }
	public FTimespan TimespanMaxValue() { return default; }
	public FTimespan TimespanMinValue() { return default; }
	public FTimespan TimespanZeroValue() { return default; }
	public FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds) { return default; }
	public FTimespan MakeTimespan2(int Days,int Hours,int Minutes,int Seconds,int FractionNano) { return default; }
	public void BreakTimespan(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int Milliseconds) {}
	public void BreakTimespan2(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int FractionNano) {}
	public FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar) { return default; }
	public FTimespan Divide_TimespanFloat(FTimespan A,float Scalar) { return default; }
	public bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public bool Greater_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public bool Less_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public int GetDays(FTimespan A) { return default; }
	public FTimespan GetDuration(FTimespan A) { return default; }
	public int GetHours(FTimespan A) { return default; }
	public int GetMilliseconds(FTimespan A) { return default; }
	public int GetMinutes(FTimespan A) { return default; }
	public int GetSeconds(FTimespan A) { return default; }
	public float GetTotalDays(FTimespan A) { return default; }
	public float GetTotalHours(FTimespan A) { return default; }
	public float GetTotalMilliseconds(FTimespan A) { return default; }
	public float GetTotalMinutes(FTimespan A) { return default; }
	public float GetTotalSeconds(FTimespan A) { return default; }
	public FTimespan FromDays(float Days) { return default; }
	public FTimespan FromHours(float Hours) { return default; }
	public FTimespan FromMilliseconds(float Milliseconds) { return default; }
	public FTimespan FromMinutes(float Minutes) { return default; }
	public FTimespan FromSeconds(float Seconds) { return default; }
	public float TimespanRatio(FTimespan A,FTimespan B) { return default; }
	public bool TimespanFromString(string TimespanString,FTimespan Result) { return default; }
	public FQualifiedFrameTime MakeQualifiedFrameTime(FFrameNumber Frame,FFrameRate FrameRate,float SubFrame/*=0.0f*/) { return default; }
	public void BreakQualifiedFrameTime(FQualifiedFrameTime InFrameTime,FFrameNumber Frame,FFrameRate FrameRate,float SubFrame) {}
	public FFrameRate MakeFrameRate(int Numerator,int Denominator/*=1*/) { return default; }
	public void BreakFrameRate(FFrameRate InFrameRate,int Numerator,int Denominator) {}
	public double Conv_ByteToDouble(byte InByte) { return default; }
	public double Conv_IntToDouble(int InInt) { return default; }
	public long Conv_IntToInt64(int InInt) { return default; }
	public byte Conv_IntToByte(int InInt) { return default; }
	public int Conv_Int64ToInt(long InInt) { return default; }
	public float Conv_DoubleToFloat(double InDouble) { return default; }
	public double Conv_FloatToDouble(float InFloat) { return default; }
	public byte Conv_Int64ToByte(long InInt) { return default; }
	public long Conv_DoubleToInt64(double InDouble) { return default; }
	public double Conv_Int64ToDouble(long InInt) { return default; }
	public FIntVector Conv_IntToIntVector(int InInt) { return default; }
	public FVector Conv_IntToVector(int InInt) { return default; }
	public bool Conv_IntToBool(int InInt) { return default; }
	public int Conv_BoolToInt(bool InBool) { return default; }
	public double Conv_BoolToDouble(bool InBool) { return default; }
	public byte Conv_BoolToByte(bool InBool) { return default; }
	public int Conv_ByteToInt(byte InByte) { return default; }
	public long Conv_ByteToInt64(byte InByte) { return default; }
	public FLinearColor Conv_ColorToLinearColor(FColor InColor) { return default; }
	public FVector Conv_IntVectorToVector(FIntVector InIntVector) { return default; }
	public FVector Conv_DoubleToVector(double InDouble) { return default; }
	public FVector2D Conv_DoubleToVector2D(double InDouble) { return default; }
	public FBox MakeBox(FVector Min,FVector Max) { return default; }
	public FBox2D MakeBox2D(FVector2D Min,FVector2D Max) { return default; }
	public FBoxSphereBounds MakeBoxSphereBounds(FVector Origin,FVector BoxExtent,float SphereRadius) { return default; }
	public void BreakBoxSphereBounds(FBoxSphereBounds InBoxSphereBounds,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public FRandomStream MakeRandomStream(int InitialSeed) { return default; }
	public void BreakRandomStream(FRandomStream InRandomStream,int InitialSeed) {}
	public string SelectString(string A,string B,bool bPickA) { return default; }
	public int SelectInt(int A,int B,bool bPickA) { return default; }
	public double SelectFloat(double A,double B,bool bPickA) { return default; }
	public FVector SelectVector(FVector A,FVector B,bool bPickA) { return default; }
	public FRotator SelectRotator(FRotator A,FRotator B,bool bPickA) { return default; }
	public FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA) { return default; }
	public FTransform SelectTransform(FTransform A,FTransform B,bool bPickA) { return default; }
	public UObject SelectObject(UObject A,UObject B,bool bSelectA) { return default; }
	public UClass SelectClass(UClass A,UClass B,bool bSelectA) { return default; }
	public bool EqualEqual_ObjectObject(UObject A,UObject B) { return default; }
	public bool NotEqual_ObjectObject(UObject A,UObject B) { return default; }
	public bool EqualEqual_ClassClass(UClass A,UClass B) { return default; }
	public bool NotEqual_ClassClass(UClass A,UClass B) { return default; }
	public bool ClassIsChildOf(UClass TestClass,UClass ParentClass) { return default; }
	public bool EqualEqual_NameName(string A,string B) { return default; }
	public bool NotEqual_NameName(string A,string B) { return default; }
	public FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale/*=new FVector(1,1,1)*/) { return default; }
	public void BreakTransform(FTransform InTransform,FVector Location,FRotator Rotation,FVector Scale) {}
	public bool EqualEqual_TransformTransform(FTransform A,FTransform B) { return default; }
	public bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance/*=1.0e-4f*/,float RotationTolerance/*=1.0e-4f*/,float Scale3DTolerance/*=1.0e-4f*/) { return default; }
	public FTransform ComposeTransforms(FTransform A,FTransform B) { return default; }
	public FVector TransformLocation(FTransform T,FVector Location) { return default; }
	public FVector TransformDirection(FTransform T,FVector Direction) { return default; }
	public FRotator TransformRotation(FTransform T,FRotator Rotation) { return default; }
	public FVector InverseTransformLocation(FTransform T,FVector Location) { return default; }
	public FVector InverseTransformDirection(FTransform T,FVector Direction) { return default; }
	public FRotator InverseTransformRotation(FTransform T,FRotator Rotation) { return default; }
	public FTransform MakeRelativeTransform(FTransform A,FTransform RelativeTo) { return default; }
	public FTransform InvertTransform(FTransform T) { return default; }
	public FTransform TLerp(FTransform A,FTransform B,float Alpha,byte InterpMode/*=ELerpInterpolationMode.QuatInterp*/) { return default; }
	public FTransform TEase(FTransform A,FTransform B,float Alpha,byte EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed) { return default; }
	public float Transform_Determinant(FTransform Transform) { return default; }
	public FMatrix Conv_TransformToMatrix(FTransform Transform) { return default; }
	public double FInterpTo(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	public double FInterpTo_Constant(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	public FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	public FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	public float FloatSpringInterp(float Current,float Target,FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,float MinValue/*=-1.0f*/,float MaxValue/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public void ResetFloatSpringState(FFloatSpringState SpringState) {}
	public void ResetVectorSpringState(FVectorSpringState SpringState) {}
	public void ResetQuaternionSpringState(FQuaternionSpringState SpringState) {}
	public void SetFloatSpringStateVelocity(FFloatSpringState SpringState,float Velocity) {}
	public void SetVectorSpringStateVelocity(FVectorSpringState SpringState,FVector Velocity) {}
	public void SetQuaternionSpringStateAngularVelocity(FQuaternionSpringState SpringState,FVector AngularVelocity) {}
	public int RandomIntegerFromStream(FRandomStream Stream,int Max) { return default; }
	public int RandomIntegerInRangeFromStream(FRandomStream Stream,int Min,int Max) { return default; }
	public bool RandomBoolFromStream(FRandomStream Stream) { return default; }
	public float RandomFloatFromStream(FRandomStream Stream) { return default; }
	public float RandomFloatInRangeFromStream(FRandomStream Stream,float Min,float Max) { return default; }
	public FVector RandomUnitVectorFromStream(FRandomStream Stream) { return default; }
	public FVector RandomPointInBoundingBoxFromStream(FRandomStream Stream,FVector Center,FVector HalfSize) { return default; }
	public FVector RandomPointInBoundingBoxFromStream_Box(FRandomStream Stream,FBox Box) { return default; }
	public FRotator RandomRotatorFromStream(FRandomStream Stream,bool bRoll) { return default; }
	public void ResetRandomStream(FRandomStream Stream) {}
	public void SeedRandomStream(FRandomStream Stream) {}
	public void SetRandomStreamSeed(FRandomStream Stream,int NewSeed) {}
	public FVector RandomUnitVectorInConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	public FVector RandomUnitVectorInConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	public FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	public float PerlinNoise1D(float Value) { return default; }
	public void MinimumAreaRectangle(UObject WorldContextObject,TArray<FVector> InVerts,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutSideLengthX,float OutSideLengthY,bool bDebugDraw/*=false*/) {}
	public void MinAreaRectangle(UObject WorldContextObject,TArray<FVector> InPoints,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutRectLengthX,float OutRectLengthY,bool bDebugDraw/*=false*/) {}
	public bool PointsAreCoplanar(TArray<FVector> Points,float Tolerance/*=0.1f*/) { return default; }
	public bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent) { return default; }
	public bool IsPointInBox_Box(FVector Point,FBox Box) { return default; }
	public bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent) { return default; }
	public bool IsPointInBoxWithTransform_Box(FVector Point,FTransform BoxWorldTransform,FBox BoxExtent) { return default; }
	public void GetSlopeDegreeAngles(FVector MyRightYAxis,FVector FloorNormal,FVector UpVector,float OutSlopePitchDegreeAngle,float OutSlopeRollDegreeAngle) {}
	public bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,float T,FVector Intersection) { return default; }
	public bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,float T,FVector Intersection) { return default; }
	public float WeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float Weight) { return default; }
	public FVector WeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float Weight) { return default; }
	public FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float Weight) { return default; }
	public float DynamicWeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public FVector_NetQuantize MakeVector_NetQuantize(double X,double Y,double Z) { return default; }
	public FVector_NetQuantize10 MakeVector_NetQuantize10(double X,double Y,double Z) { return default; }
	public FVector_NetQuantize100 MakeVector_NetQuantize100(double X,double Y,double Z) { return default; }
	public FVector_NetQuantizeNormal MakeVector_NetQuantizeNormal(double X,double Y,double Z) { return default; }
	public void BreakVector_NetQuantize(FVector_NetQuantize InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantize10(FVector_NetQuantize10 InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantize100(FVector_NetQuantize100 InVec,double X,double Y,double Z) {}
	public void BreakVector_NetQuantizeNormal(FVector_NetQuantizeNormal InVec,double X,double Y,double Z) {}
}
