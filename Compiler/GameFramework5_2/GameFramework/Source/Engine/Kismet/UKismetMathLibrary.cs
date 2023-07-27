#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMathLibrary.h")]
public partial class UKismetMathLibrary : UBlueprintFunctionLibrary {
// KismetMathLibrary
	public static bool RandomBool() { return default; }
	public static bool RandomBoolWithWeight(float Weight) { return default; }
	public static bool RandomBoolWithWeightFromStream(FRandomStream RandomStream,float Weight) { return default; }
	public static bool Not_PreBool(bool A) { return default; }
	public static bool EqualEqual_BoolBool(bool A,bool B) { return default; }
	public static bool NotEqual_BoolBool(bool A,bool B) { return default; }
	public static bool BooleanAND(bool A,bool B) { return default; }
	public static bool BooleanNAND(bool A,bool B) { return default; }
	public static bool BooleanOR(bool A,bool B) { return default; }
	public static bool BooleanXOR(bool A,bool B) { return default; }
	public static bool BooleanNOR(bool A,bool B) { return default; }
	public static byte Multiply_ByteByte(byte A,byte B) { return default; }
	public static byte Divide_ByteByte(byte A,byte B/*=1*/) { return default; }
	public static byte Percent_ByteByte(byte A,byte B/*=1*/) { return default; }
	public static byte Add_ByteByte(byte A,byte B/*=1*/) { return default; }
	public static byte Subtract_ByteByte(byte A,byte B/*=1*/) { return default; }
	public static byte BMin(byte A,byte B) { return default; }
	public static byte BMax(byte A,byte B) { return default; }
	public static bool Less_ByteByte(byte A,byte B) { return default; }
	public static bool Greater_ByteByte(byte A,byte B) { return default; }
	public static bool LessEqual_ByteByte(byte A,byte B) { return default; }
	public static bool GreaterEqual_ByteByte(byte A,byte B) { return default; }
	public static bool EqualEqual_ByteByte(byte A,byte B) { return default; }
	public static bool NotEqual_ByteByte(byte A,byte B) { return default; }
	public static int Multiply_IntInt(int A,int B) { return default; }
	public static int Divide_IntInt(int A,int B/*=1*/) { return default; }
	public static int Percent_IntInt(int A,int B/*=1*/) { return default; }
	public static int Add_IntInt(int A,int B/*=1*/) { return default; }
	public static int Subtract_IntInt(int A,int B/*=1*/) { return default; }
	public static bool Less_IntInt(int A,int B) { return default; }
	public static bool Greater_IntInt(int A,int B) { return default; }
	public static bool LessEqual_IntInt(int A,int B) { return default; }
	public static bool GreaterEqual_IntInt(int A,int B) { return default; }
	public static bool EqualEqual_IntInt(int A,int B) { return default; }
	public static bool NotEqual_IntInt(int A,int B) { return default; }
	public static bool InRange_IntInt(int Value,int Min,int Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public static int And_IntInt(int A,int B) { return default; }
	public static int Xor_IntInt(int A,int B) { return default; }
	public static int Or_IntInt(int A,int B) { return default; }
	public static int Not_Int(int A) { return default; }
	public static int SignOfInteger(int A) { return default; }
	public static int RandomInteger(int Max) { return default; }
	public static int RandomIntegerInRange(int Min,int Max) { return default; }
	public static int Min(int A,int B) { return default; }
	public static int Max(int A,int B) { return default; }
	public static int Clamp(int Value,int Min,int Max) { return default; }
	public static int Wrap(int Value,int Min,int Max) { return default; }
	public static int Abs_Int(int A) { return default; }
	public static long Multiply_Int64Int64(long A,long B) { return default; }
	public static long Divide_Int64Int64(long A,long B/*=1*/) { return default; }
	public static long Percent_Int64Int64(long A,long B/*=1*/) { return default; }
	public static long Add_Int64Int64(long A,long B/*=1*/) { return default; }
	public static long Subtract_Int64Int64(long A,long B/*=1*/) { return default; }
	public static bool Less_Int64Int64(long A,long B) { return default; }
	public static bool Greater_Int64Int64(long A,long B) { return default; }
	public static bool LessEqual_Int64Int64(long A,long B) { return default; }
	public static bool GreaterEqual_Int64Int64(long A,long B) { return default; }
	public static bool EqualEqual_Int64Int64(long A,long B) { return default; }
	public static bool NotEqual_Int64Int64(long A,long B) { return default; }
	public static bool InRange_Int64Int64(long Value,long Min,long Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public static long And_Int64Int64(long A,long B) { return default; }
	public static long Xor_Int64Int64(long A,long B) { return default; }
	public static long Or_Int64Int64(long A,long B) { return default; }
	public static long Not_Int64(long A) { return default; }
	public static long SignOfInteger64(long A) { return default; }
	public static long RandomInteger64(long Max) { return default; }
	public static long RandomInteger64InRange(long Min,long Max) { return default; }
	public static long MinInt64(long A,long B) { return default; }
	public static long MaxInt64(long A,long B) { return default; }
	public static long ClampInt64(long Value,long Min,long Max) { return default; }
	public static long Abs_Int64(long A) { return default; }
	public static double MultiplyMultiply_FloatFloat(double Base,double Exp) { return default; }
	public static double Multiply_IntFloat(int A,double B) { return default; }
	public static double Percent_FloatFloat(double A,double B/*=1.0f*/) { return default; }
	public static double Fraction(double A) { return default; }
	public static double Add_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public static double Subtract_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public static double Multiply_DoubleDouble(double A,double B) { return default; }
	public static double Divide_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	public static bool Less_DoubleDouble(double A,double B) { return default; }
	public static bool Greater_DoubleDouble(double A,double B) { return default; }
	public static bool LessEqual_DoubleDouble(double A,double B) { return default; }
	public static bool GreaterEqual_DoubleDouble(double A,double B) { return default; }
	public static bool EqualEqual_DoubleDouble(double A,double B) { return default; }
	public static bool NearlyEqual_FloatFloat(double A,double B,double ErrorTolerance/*=1.0e-6*/) { return default; }
	public static bool NotEqual_DoubleDouble(double A,double B) { return default; }
	public static bool InRange_FloatFloat(double Value,double Min,double Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	public static double Hypotenuse(double Width,double Height) { return default; }
	public static double GridSnap_Float(double Location,double GridSize) { return default; }
	public static double Abs(double A) { return default; }
	public static double Sin(double A) { return default; }
	public static double Asin(double A) { return default; }
	public static double Cos(double A) { return default; }
	public static double Acos(double A) { return default; }
	public static double Tan(double A) { return default; }
	public static double Atan(double A) { return default; }
	public static double Atan2(double Y,double X) { return default; }
	public static double Exp(double A) { return default; }
	public static double Log(double A,double Base/*=1.0*/) { return default; }
	public static double Loge(double A) { return default; }
	public static double Sqrt(double A) { return default; }
	public static double Square(double A) { return default; }
	public static double RandomFloat() { return default; }
	public static double RandomFloatInRange(double Min,double Max) { return default; }
	public static double GetPI() { return default; }
	public static double GetTAU() { return default; }
	public static double DegreesToRadians(double A) { return default; }
	public static double RadiansToDegrees(double A) { return default; }
	public static double DegSin(double A) { return default; }
	public static double DegAsin(double A) { return default; }
	public static double DegCos(double A) { return default; }
	public static double DegAcos(double A) { return default; }
	public static double DegTan(double A) { return default; }
	public static double DegAtan(double A) { return default; }
	public static double DegAtan2(double Y,double X) { return default; }
	public static double ClampAngle(double AngleDegrees,double MinAngleDegrees,double MaxAngleDegrees) { return default; }
	public static double FMin(double A,double B) { return default; }
	public static double FMax(double A,double B) { return default; }
	public static double FClamp(double Value,double Min,double Max) { return default; }
	public static double FWrap(double Value,double Min,double Max) { return default; }
	public static double SafeDivide(double A,double B) { return default; }
	public static void MaxOfIntArray(TArray<int> IntArray,int IndexOfMaxValue,int MaxValue) {}
	public static void MinOfIntArray(TArray<int> IntArray,int IndexOfMinValue,int MinValue) {}
	public static void MedianOfIntArray(TArray<int> IntArray,float MedianValue) {}
	public static void AverageOfIntArray(TArray<int> IntArray,float AverageValue) {}
	public static void MaxOfFloatArray(TArray<float> FloatArray,int IndexOfMaxValue,float MaxValue) {}
	public static void MinOfFloatArray(TArray<float> FloatArray,int IndexOfMinValue,float MinValue) {}
	public static void MaxOfByteArray(TArray<byte> ByteArray,int IndexOfMaxValue,byte MaxValue) {}
	public static void MinOfByteArray(TArray<byte> ByteArray,int IndexOfMinValue,byte MinValue) {}
	public static double Lerp(double A,double B,double Alpha) { return default; }
	public static double Ease(double A,double B,double Alpha,EEasingFunc EasingFunc,double BlendExp/*=2*/,int Steps/*=2*/) { return default; }
	public static int Round(double A) { return default; }
	public static int FFloor(double A) { return default; }
	public static int FTrunc(double A) { return default; }
	public static int FCeil(double A) { return default; }
	public static long Round64(double A) { return default; }
	public static long FFloor64(double A) { return default; }
	public static long FTrunc64(double A) { return default; }
	public static long FCeil64(double A) { return default; }
	public static int FMod(double Dividend,double Divisor,double Remainder) { return default; }
	public static long FMod64(double Dividend,double Divisor,double Remainder) { return default; }
	public static double SignOfFloat(double A) { return default; }
	public static double NormalizeToRange(double Value,double RangeMin,double RangeMax) { return default; }
	public static double MapRangeUnclamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	public static double MapRangeClamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	public static double MultiplyByPi(double Value) { return default; }
	public static double FInterpEaseInOut(double A,double B,double Alpha,double Exponent) { return default; }
	public static float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond/*=1.0f*/,float InPhase/*=0.0f*/) { return default; }
	public static float FixedTurn(float InCurrent,float InDesired,float InDeltaRate) { return default; }
	public static FIntPoint IntPoint_Zero() { return default; }
	public static FIntPoint IntPoint_One() { return default; }
	public static FIntPoint IntPoint_Up() { return default; }
	public static FIntPoint IntPoint_Left() { return default; }
	public static FIntPoint IntPoint_Right() { return default; }
	public static FIntPoint IntPoint_Down() { return default; }
	public static FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint) { return default; }
	public static FIntPoint Add_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static FIntPoint Add_IntPointInt(FIntPoint A,int B) { return default; }
	public static FIntPoint Subtract_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static FIntPoint Subtract_IntPointInt(FIntPoint A,int B) { return default; }
	public static FIntPoint Multiply_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static FIntPoint Multiply_IntPointInt(FIntPoint A,int B) { return default; }
	public static FIntPoint Divide_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static FIntPoint Divide_IntPointInt(FIntPoint A,int B) { return default; }
	public static bool Equal_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static bool NotEqual_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	public static FVector2D Vector2D_One() { return default; }
	public static FVector2D Vector2D_Unit45Deg() { return default; }
	public static FVector2D Vector2D_Zero() { return default; }
	public static FVector2D MakeVector2D(double X,double Y) { return default; }
	public static void BreakVector2D(FVector2D InVec,double X,double Y) {}
	public static FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z/*=0f*/) { return default; }
	public static FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D) { return default; }
	public static FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static FVector2D Add_Vector2DFloat(FVector2D A,double B) { return default; }
	public static FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static FVector2D Subtract_Vector2DFloat(FVector2D A,double B) { return default; }
	public static FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static FVector2D Multiply_Vector2DFloat(FVector2D A,double B) { return default; }
	public static FVector2D Divide_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static FVector2D Divide_Vector2DFloat(FVector2D A,double B/*=1.0f*/) { return default; }
	public static bool EqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	public static bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static FVector2D Negated2D(FVector2D A) { return default; }
	public static void Set2D(FVector2D A,double X,double Y) {}
	public static FVector2D ClampAxes2D(FVector2D A,double MinAxisVal,double MaxAxisVal) { return default; }
	public static double CrossProduct2D(FVector2D A,FVector2D B) { return default; }
	public static double Distance2D(FVector2D V1,FVector2D V2) { return default; }
	public static double DistanceSquared2D(FVector2D V1,FVector2D V2) { return default; }
	public static double DotProduct2D(FVector2D A,FVector2D B) { return default; }
	public static FVector2D GetAbs2D(FVector2D A) { return default; }
	public static double GetAbsMax2D(FVector2D A) { return default; }
	public static double GetMax2D(FVector2D A) { return default; }
	public static double GetMin2D(FVector2D A) { return default; }
	public static FVector2D GetRotated2D(FVector2D A,float AngleDeg) { return default; }
	public static bool IsNearlyZero2D(FVector2D A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool IsZero2D(FVector2D A) { return default; }
	public static FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FVector2D NormalSafe2D(FVector2D A,float Tolerance/*=1.0e-8f*/) { return default; }
	public static FVector2D Normal2D(FVector2D A) { return default; }
	public static void Normalize2D(FVector2D A,float Tolerance/*=1.0e-8f*/) {}
	public static FVector Spherical2DToUnitCartesian(FVector2D A) { return default; }
	public static void ToDirectionAndLength2D(FVector2D A,FVector2D OutDir,double OutLength) {}
	public static FVector2D ToRounded2D(FVector2D A) { return default; }
	public static FVector2D ToSign2D(FVector2D A) { return default; }
	public static double VSize2D(FVector2D A) { return default; }
	public static double VSize2DSquared(FVector2D A) { return default; }
	public static FVector Vector_Zero() { return default; }
	public static FVector Vector_One() { return default; }
	public static FVector Vector_Forward() { return default; }
	public static FVector Vector_Backward() { return default; }
	public static FVector Vector_Up() { return default; }
	public static FVector Vector_Down() { return default; }
	public static FVector Vector_Right() { return default; }
	public static FVector Vector_Left() { return default; }
	public static FVector MakeVector(double X,double Y,double Z) { return default; }
	public static FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length/*=1.0f*/) { return default; }
	public static void Vector_Assign(FVector A,FVector InVector) {}
	public static void Vector_Set(FVector A,double X,double Y,double Z) {}
	public static void BreakVector(FVector InVec,double X,double Y,double Z) {}
	public static void BreakVector3f(FVector3f InVec,float X,float Y,float Z) {}
	public static FLinearColor Conv_VectorToLinearColor(FVector InVec) { return default; }
	public static FTransform Conv_VectorToTransform(FVector InLocation) { return default; }
	public static FVector2D Conv_VectorToVector2D(FVector InVector) { return default; }
	public static FRotator Conv_VectorToRotator(FVector InVec) { return default; }
	public static FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle) { return default; }
	public static FQuat Conv_VectorToQuaternion(FVector InVec) { return default; }
	public static FVector Vector_SlerpVectorToDirection(FVector Vector,FVector Direction,double Alpha) { return default; }
	public static FVector Vector_SlerpNormals(FVector NormalA,FVector NormalB,double Alpha) { return default; }
	public static FVector Add_VectorVector(FVector A,FVector B) { return default; }
	public static FVector Add_VectorFloat(FVector A,double B) { return default; }
	public static FVector Add_VectorInt(FVector A,int B) { return default; }
	public static FVector Subtract_VectorVector(FVector A,FVector B) { return default; }
	public static FVector Subtract_VectorFloat(FVector A,double B) { return default; }
	public static FVector Subtract_VectorInt(FVector A,int B) { return default; }
	public static FVector Multiply_VectorVector(FVector A,FVector B) { return default; }
	public static FVector Multiply_VectorFloat(FVector A,double B) { return default; }
	public static FVector Multiply_VectorInt(FVector A,int B) { return default; }
	public static FVector Divide_VectorVector(FVector A,FVector B/*=new FVector(1.0f,1.0f,1.0f)*/) { return default; }
	public static FVector Divide_VectorFloat(FVector A,double B/*=1.0f*/) { return default; }
	public static FVector Divide_VectorInt(FVector A,int B/*=1*/) { return default; }
	public static FVector NegateVector(FVector A) { return default; }
	public static bool EqualExactly_VectorVector(FVector A,FVector B) { return default; }
	public static bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqualExactly_VectorVector(FVector A,FVector B) { return default; }
	public static bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static double Dot_VectorVector(FVector A,FVector B) { return default; }
	public static FVector Cross_VectorVector(FVector A,FVector B) { return default; }
	public static FVector GreaterGreater_VectorRotator(FVector A,FRotator B) { return default; }
	public static FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis) { return default; }
	public static FVector LessLess_VectorRotator(FVector A,FRotator B) { return default; }
	public static void Vector_UnwindEuler(FVector A) {}
	public static FVector ClampVectorSize(FVector A,double Min,double Max) { return default; }
	public static FVector Vector_ClampSize2D(FVector A,double Min,double Max) { return default; }
	public static FVector Vector_ClampSizeMax(FVector A,double Max) { return default; }
	public static FVector Vector_ClampSizeMax2D(FVector A,double Max) { return default; }
	public static double GetMinElement(FVector A) { return default; }
	public static double GetMaxElement(FVector A) { return default; }
	public static double Vector_GetAbsMax(FVector A) { return default; }
	public static double Vector_GetAbsMin(FVector A) { return default; }
	public static FVector Vector_GetAbs(FVector A) { return default; }
	public static FVector Vector_ComponentMin(FVector A,FVector B) { return default; }
	public static FVector Vector_ComponentMax(FVector A,FVector B) { return default; }
	public static FVector Vector_GetSignVector(FVector A) { return default; }
	public static FVector Vector_GetProjection(FVector A) { return default; }
	public static double Vector_HeadingAngle(FVector A) { return default; }
	public static double Vector_CosineAngle2D(FVector A,FVector B) { return default; }
	public static FVector Vector_ToRadians(FVector A) { return default; }
	public static FVector Vector_ToDegrees(FVector A) { return default; }
	public static FVector2D Vector_UnitCartesianToSpherical(FVector A) { return default; }
	public static FVector GetDirectionUnitVector(FVector From,FVector To) { return default; }
	public static void GetYawPitchFromVector(FVector InVec,float Yaw,float Pitch) {}
	public static void GetAzimuthAndElevation(FVector InDirection,FTransform ReferenceFrame,float Azimuth,float Elevation) {}
	public static FVector GetVectorArrayAverage(TArray<FVector> Vectors) { return default; }
	public static FIntVector FTruncVector(FVector InVector) { return default; }
	public static double Vector_Distance(FVector V1,FVector V2) { return default; }
	public static double Vector_DistanceSquared(FVector V1,FVector V2) { return default; }
	public static double Vector_Distance2D(FVector V1,FVector V2) { return default; }
	public static double Vector_Distance2DSquared(FVector V1,FVector V2) { return default; }
	public static double VSize(FVector A) { return default; }
	public static double VSizeSquared(FVector A) { return default; }
	public static double VSizeXY(FVector A) { return default; }
	public static double VSizeXYSquared(FVector A) { return default; }
	public static bool Vector_IsNearlyZero(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool Vector_IsZero(FVector A) { return default; }
	public static bool Vector_IsNAN(FVector A) { return default; }
	public static bool Vector_IsUniform(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool Vector_IsUnit(FVector A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	public static bool Vector_IsNormal(FVector A) { return default; }
	public static FVector Normal(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static FVector Vector_Normal2D(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static FVector Vector_NormalUnsafe(FVector A) { return default; }
	public static void Vector_Normalize(FVector A,float Tolerance/*=1.0e-8f*/) {}
	public static FVector VLerp(FVector A,FVector B,float Alpha) { return default; }
	public static FVector VEase(FVector A,FVector B,float Alpha,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public static FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FVector VectorSpringInterp(FVector Current,FVector Target,FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,FVector MinValue/*=new FVector(-1.0f)*/,FVector MaxValue/*=new FVector(1.0f)*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public static FQuat QuaternionSpringInterp(FQuat Current,FQuat Target,FQuaternionSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public static FVector Vector_Reciprocal(FVector A) { return default; }
	public static FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal) { return default; }
	public static FVector MirrorVectorByNormal(FVector InVect,FVector InNormal) { return default; }
	public static FVector Vector_MirrorByPlane(FVector A,FPlane InPlane) { return default; }
	public static FVector Vector_SnappedToGrid(FVector InVect,float InGridSize) { return default; }
	public static FVector Vector_BoundedToCube(FVector InVect,float InRadius) { return default; }
	public static void Vector_AddBounded(FVector A,FVector InAddVect,float InRadius) {}
	public static FVector Vector_BoundedToBox(FVector InVect,FVector InBoxMin,FVector InBoxMax) { return default; }
	public static FVector Vector_ProjectOnToNormal(FVector V,FVector InNormal) { return default; }
	public static FVector ProjectVectorOnToVector(FVector V,FVector Target) { return default; }
	public static FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal) { return default; }
	public static FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal) { return default; }
	public static void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,FVector Segment1Point,FVector Segment2Point) {}
	public static FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	public static FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	public static float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	public static float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	public static FVector RandomUnitVector() { return default; }
	public static FVector RandomPointInBoundingBox(FVector Center,FVector HalfSize) { return default; }
	public static FVector RandomPointInBoundingBox_Box(FBox Box) { return default; }
	public static FVector RandomUnitVectorInConeInRadians(FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	public static FVector RandomUnitVectorInConeInDegrees(FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	public static FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	public static FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	public static FVector4 Vector4_Zero() { return default; }
	public static FVector4 MakeVector4(double X,double Y,double Z,double W) { return default; }
	public static void BreakVector4(FVector4 InVec,double X,double Y,double Z,double W) {}
	public static FVector Conv_Vector4ToVector(FVector4 InVector4) { return default; }
	public static FRotator Conv_Vector4ToRotator(FVector4 InVec) { return default; }
	public static FQuat Conv_Vector4ToQuaternion(FVector4 InVec) { return default; }
	public static FVector4 Add_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static FVector4 Subtract_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static FVector4 Multiply_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static FVector4 Divide_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static bool EqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static bool EqualEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	public static bool NotEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static FVector4 Vector4_Negated(FVector4 A) { return default; }
	public static void Vector4_Assign(FVector4 A,FVector4 InVector) {}
	public static void Vector4_Set(FVector4 A,double X,double Y,double Z,double W) {}
	public static FVector4 Vector4_CrossProduct3(FVector4 A,FVector4 B) { return default; }
	public static double Vector4_DotProduct(FVector4 A,FVector4 B) { return default; }
	public static double Vector4_DotProduct3(FVector4 A,FVector4 B) { return default; }
	public static bool Vector4_IsNAN(FVector4 A) { return default; }
	public static bool Vector4_IsNearlyZero3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool Vector4_IsZero(FVector4 A) { return default; }
	public static double Vector4_Size(FVector4 A) { return default; }
	public static double Vector4_SizeSquared(FVector4 A) { return default; }
	public static double Vector4_Size3(FVector4 A) { return default; }
	public static double Vector4_SizeSquared3(FVector4 A) { return default; }
	public static bool Vector4_IsUnit3(FVector4 A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	public static bool Vector4_IsNormal3(FVector4 A) { return default; }
	public static FVector4 Vector4_Normal3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	public static FVector4 Vector4_NormalUnsafe3(FVector4 A) { return default; }
	public static void Vector4_Normalize3(FVector4 A,float Tolerance/*=1.0e-8f*/) {}
	public static FVector4 Vector4_MirrorByVector3(FVector4 Direction,FVector4 SurfaceNormal) { return default; }
	public static FVector4 TransformVector4(FMatrix Matrix,FVector4 Vec4) { return default; }
	public static FRotator MakeRotator(float Roll,float Pitch,float Yaw) { return default; }
	public static FRotator MakeRotFromX(FVector X) { return default; }
	public static FRotator MakeRotFromY(FVector Y) { return default; }
	public static FRotator MakeRotFromZ(FVector Z) { return default; }
	public static FRotator MakeRotFromXY(FVector X,FVector Y) { return default; }
	public static FRotator MakeRotFromXZ(FVector X,FVector Z) { return default; }
	public static FRotator MakeRotFromYX(FVector Y,FVector X) { return default; }
	public static FRotator MakeRotFromYZ(FVector Y,FVector Z) { return default; }
	public static FRotator MakeRotFromZX(FVector Z,FVector X) { return default; }
	public static FRotator MakeRotFromZY(FVector Z,FVector Y) { return default; }
	public static FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up) { return default; }
	public static FRotator FindLookAtRotation(FVector Start,FVector Target) { return default; }
	public static FRotator FindRelativeLookAtRotation(FTransform StartTransform,FVector TargetLocation) { return default; }
	public static void BreakRotator(FRotator InRot,float Roll,float Pitch,float Yaw) {}
	public static void BreakRotIntoAxes(FRotator InRot,FVector X,FVector Y,FVector Z) {}
	public static bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static FRotator Multiply_RotatorFloat(FRotator A,float B) { return default; }
	public static FRotator Multiply_RotatorInt(FRotator A,int B) { return default; }
	public static FRotator ComposeRotators(FRotator A,FRotator B) { return default; }
	public static FRotator NegateRotator(FRotator A) { return default; }
	public static FVector GetForwardVector(FRotator InRot) { return default; }
	public static FVector GetRightVector(FRotator InRot) { return default; }
	public static FVector GetUpVector(FRotator InRot) { return default; }
	public static FVector Conv_RotatorToVector(FRotator InRot) { return default; }
	public static FTransform Conv_RotatorToTransform(FRotator InRotator) { return default; }
	public static void GetAxes(FRotator A,FVector X,FVector Y,FVector Z) {}
	public static FRotator RandomRotator(bool bRoll/*=false*/) { return default; }
	public static FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath) { return default; }
	public static FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public static FRotator NormalizedDeltaRotator(FRotator A,FRotator B) { return default; }
	public static float ClampAxis(float Angle) { return default; }
	public static float NormalizeAxis(float Angle) { return default; }
	public static FTransform Conv_MatrixToTransform(FMatrix InMatrix) { return default; }
	public static FRotator Conv_MatrixToRotator(FMatrix InMatrix) { return default; }
	public static FVector Matrix_GetOrigin(FMatrix InMatrix) { return default; }
	public static FMatrix Matrix_Identity() { return default; }
	public static FMatrix Multiply_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	public static FMatrix Add_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	public static FMatrix Multiply_MatrixFloat(FMatrix A,double B) { return default; }
	public static bool EqualEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	public static FVector4 Matrix_TransformVector4(FMatrix M,FVector4 V) { return default; }
	public static FVector4 Matrix_TransformPosition(FMatrix M,FVector V) { return default; }
	public static FVector Matrix_InverseTransformPosition(FMatrix M,FVector V) { return default; }
	public static FVector4 Matrix_TransformVector(FMatrix M,FVector V) { return default; }
	public static FVector Matrix_InverseTransformVector(FMatrix M,FVector V) { return default; }
	public static FMatrix Matrix_GetTransposed(FMatrix M) { return default; }
	public static float Matrix_GetDeterminant(FMatrix M) { return default; }
	public static float Matrix_GetRotDeterminant(FMatrix M) { return default; }
	public static FMatrix Matrix_GetInverse(FMatrix M) { return default; }
	public static FMatrix Matrix_GetTransposeAdjoint(FMatrix M) { return default; }
	public static void Matrix_RemoveScaling(FMatrix M,float Tolerance/*=1.0e-8f*/) {}
	public static FMatrix Matrix_GetMatrixWithoutScale(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	public static FVector Matrix_GetScaleVector(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	public static FMatrix Matrix_RemoveTranslation(FMatrix M) { return default; }
	public static FMatrix Matrix_ConcatenateTranslation(FMatrix M,FVector Translation) { return default; }
	public static bool Matrix_ContainsNaN(FMatrix M) { return default; }
	public static FMatrix Matrix_ScaleTranslation(FMatrix M,FVector Scale3D) { return default; }
	public static float Matrix_GetMaximumAxisScale(FMatrix M) { return default; }
	public static FMatrix Matrix_ApplyScale(FMatrix M,float Scale) { return default; }
	public static FVector Matrix_GetScaledAxis(FMatrix M,EAxis Axis) { return default; }
	public static void Matrix_GetScaledAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public static FVector Matrix_GetUnitAxis(FMatrix M,EAxis Axis) { return default; }
	public static void Matrix_GetUnitAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	public static void Matrix_SetAxis(FMatrix M,EAxis Axis,FVector AxisVector) {}
	public static void Matrix_SetOrigin(FMatrix M,FVector NewOrigin) {}
	public static FVector Matrix_GetColumn(FMatrix M,EMatrixColumns Column) { return default; }
	public static void Matrix_SetColumn(FMatrix M,EMatrixColumns Column,FVector Value) {}
	public static FRotator Matrix_GetRotator(FMatrix M) { return default; }
	public static FQuat Matrix_ToQuat(FMatrix M) { return default; }
	public static bool Matrix_GetFrustumNearPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static bool Matrix_GetFrustumFarPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static bool Matrix_GetFrustumLeftPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static bool Matrix_GetFrustumRightPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static bool Matrix_GetFrustumTopPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static bool Matrix_GetFrustumBottomPlane(FMatrix M,FPlane OutPlane) { return default; }
	public static FMatrix Matrix_Mirror(FMatrix M,EAxis MirrorAxis,EAxis FlipAxis) { return default; }
	public static FQuat Quat_Identity() { return default; }
	public static bool EqualEqual_QuatQuat(FQuat A,FQuat B,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool NotEqual_QuatQuat(FQuat A,FQuat B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	public static FQuat Add_QuatQuat(FQuat A,FQuat B) { return default; }
	public static FQuat Subtract_QuatQuat(FQuat A,FQuat B) { return default; }
	public static FQuat MakeQuat(float X,float Y,float Z,float W) { return default; }
	public static void BreakQuat(FQuat InQuat,float X,float Y,float Z,float W) {}
	public static FQuat Multiply_QuatQuat(FQuat A,FQuat B) { return default; }
	public static bool Quat_IsIdentity(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool Quat_IsNormalized(FQuat Q) { return default; }
	public static bool Quat_IsFinite(FQuat Q) { return default; }
	public static bool Quat_IsNonFinite(FQuat Q) { return default; }
	public static float Quat_AngularDistance(FQuat A,FQuat B) { return default; }
	public static void Quat_EnforceShortestArcWith(FQuat A,FQuat B) {}
	public static FVector Quat_Euler(FQuat Q) { return default; }
	public static FQuat Quat_Exp(FQuat Q) { return default; }
	public static float Quat_GetAngle(FQuat Q) { return default; }
	public static FVector Quat_GetAxisX(FQuat Q) { return default; }
	public static FVector Quat_GetAxisY(FQuat Q) { return default; }
	public static FVector Quat_GetAxisZ(FQuat Q) { return default; }
	public static FVector Quat_VectorForward(FQuat Q) { return default; }
	public static FVector Quat_VectorRight(FQuat Q) { return default; }
	public static FVector Quat_VectorUp(FQuat Q) { return default; }
	public static void Quat_Normalize(FQuat Q,float Tolerance/*=1.0e-4f*/) {}
	public static FQuat Quat_Normalized(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	public static FVector Quat_GetRotationAxis(FQuat Q) { return default; }
	public static FQuat Quat_Inversed(FQuat Q) { return default; }
	public static FQuat Quat_Log(FQuat Q) { return default; }
	public static void Quat_SetComponents(FQuat Q,float X,float Y,float Z,float W) {}
	public static void Quat_SetFromEuler(FQuat Q,FVector Euler) {}
	public static FQuat Quat_MakeFromEuler(FVector Euler) { return default; }
	public static FRotator Quat_Rotator(FQuat Q) { return default; }
	public static FQuat Conv_RotatorToQuaternion(FRotator InRot) { return default; }
	public static float Quat_Size(FQuat Q) { return default; }
	public static float Quat_SizeSquared(FQuat Q) { return default; }
	public static FVector Quat_RotateVector(FQuat Q,FVector V) { return default; }
	public static FVector Quat_UnrotateVector(FQuat Q,FVector V) { return default; }
	public static FQuat Quat_Slerp(FQuat A,FQuat B,double Alpha) { return default; }
	public static FQuat Quat_FindBetweenVectors(FVector Start,FVector End) { return default; }
	public static FQuat Quat_FindBetweenNormals(FVector StartNormal,FVector EndNormal) { return default; }
	public static FLinearColor LinearColor_White() { return default; }
	public static FLinearColor LinearColor_Gray() { return default; }
	public static FLinearColor LinearColor_Black() { return default; }
	public static FLinearColor LinearColor_Red() { return default; }
	public static FLinearColor LinearColor_Green() { return default; }
	public static FLinearColor LinearColor_Blue() { return default; }
	public static FLinearColor LinearColor_Yellow() { return default; }
	public static FLinearColor LinearColor_Transparent() { return default; }
	public static FLinearColor MakeColor(float R,float G,float B,float A/*=1.0f*/) { return default; }
	public static void BreakColor(FLinearColor InColor,float R,float G,float B,float A) {}
	public static void LinearColor_Set(FLinearColor InOutColor,FLinearColor InColor) {}
	public static void LinearColor_SetRGBA(FLinearColor InOutColor,float R,float G,float B,float A/*=1.0f*/) {}
	public static void LinearColor_SetFromHSV(FLinearColor InOutColor,float H,float S,float V,float A/*=1.0f*/) {}
	public static void LinearColor_SetFromSRGB(FLinearColor InOutColor,FColor InSRGB) {}
	public static void LinearColor_SetFromPow22(FLinearColor InOutColor,FColor InColor) {}
	public static void LinearColor_SetTemperature(FLinearColor InOutColor,float InTemperature) {}
	public static void LinearColor_SetRandomHue(FLinearColor InOutColor) {}
	public static FLinearColor Conv_DoubleToLinearColor(double InDouble) { return default; }
	public static FLinearColor HSVToRGB(float H,float S,float V,float A/*=1.0f*/) { return default; }
	public static void HSVToRGB_Vector(FLinearColor HSV,FLinearColor RGB) {}
	public static FLinearColor HSVToRGBLinear(FLinearColor HSV) { return default; }
	public static void RGBToHSV(FLinearColor InColor,float H,float S,float V,float A) {}
	public static void RGBToHSV_Vector(FLinearColor RGB,FLinearColor HSV) {}
	public static FLinearColor RGBLinearToHSV(FLinearColor RGB) { return default; }
	public static FVector Conv_LinearColorToVector(FLinearColor InLinearColor) { return default; }
	public static FColor LinearColor_ToRGBE(FLinearColor InLinearColor) { return default; }
	public static FColor Conv_LinearColorToColor(FLinearColor InLinearColor,bool InUseSRGB/*=true*/) { return default; }
	public static FColor LinearColor_Quantize(FLinearColor InColor) { return default; }
	public static FColor LinearColor_QuantizeRound(FLinearColor InColor) { return default; }
	public static FLinearColor LinearColor_Desaturated(FLinearColor InColor,float InDesaturation) { return default; }
	public static float LinearColor_Distance(FLinearColor C1,FLinearColor C2) { return default; }
	public static FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor,float InOpacity) { return default; }
	public static float LinearColor_GetLuminance(FLinearColor InColor) { return default; }
	public static float LinearColor_GetMax(FLinearColor InColor) { return default; }
	public static float LinearColor_GetMin(FLinearColor InColor) { return default; }
	public static FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	public static FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	public static bool LinearColor_IsNearEqual(FLinearColor A,FLinearColor B,float Tolerance/*=1.0e-4f*/) { return default; }
	public static bool EqualEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static bool NotEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static FLinearColor Add_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static FLinearColor Subtract_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B) { return default; }
	public static FLinearColor Divide_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	public static FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal) { return default; }
	public static FDateTime MakeDateTime(int Year,int Month,int Day,int Hour/*=0*/,int Minute/*=0*/,int Second/*=0*/,int Millisecond/*=0*/) { return default; }
	public static void BreakDateTime(FDateTime InDateTime,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond) {}
	public static FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	public static FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	public static FDateTime Add_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool Greater_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool Less_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	public static FDateTime GetDate(FDateTime A) { return default; }
	public static int GetDay(FDateTime A) { return default; }
	public static int GetDayOfYear(FDateTime A) { return default; }
	public static int GetHour(FDateTime A) { return default; }
	public static int GetHour12(FDateTime A) { return default; }
	public static int GetMillisecond(FDateTime A) { return default; }
	public static int GetMinute(FDateTime A) { return default; }
	public static int GetMonth(FDateTime A) { return default; }
	public static int GetSecond(FDateTime A) { return default; }
	public static FTimespan GetTimeOfDay(FDateTime A) { return default; }
	public static int GetYear(FDateTime A) { return default; }
	public static bool IsAfternoon(FDateTime A) { return default; }
	public static bool IsMorning(FDateTime A) { return default; }
	public static int DaysInMonth(int Year,int Month) { return default; }
	public static int DaysInYear(int Year) { return default; }
	public static bool IsLeapYear(int Year) { return default; }
	public static FDateTime DateTimeMaxValue() { return default; }
	public static FDateTime DateTimeMinValue() { return default; }
	public static FDateTime Now() { return default; }
	public static FDateTime Today() { return default; }
	public static FDateTime UtcNow() { return default; }
	public static bool DateTimeFromIsoString(string IsoString,FDateTime Result) { return default; }
	public static bool DateTimeFromString(string DateTimeString,FDateTime Result) { return default; }
	public static FTimespan TimespanMaxValue() { return default; }
	public static FTimespan TimespanMinValue() { return default; }
	public static FTimespan TimespanZeroValue() { return default; }
	public static FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds) { return default; }
	public static FTimespan MakeTimespan2(int Days,int Hours,int Minutes,int Seconds,int FractionNano) { return default; }
	public static void BreakTimespan(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int Milliseconds) {}
	public static void BreakTimespan2(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int FractionNano) {}
	public static FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar) { return default; }
	public static FTimespan Divide_TimespanFloat(FTimespan A,float Scalar) { return default; }
	public static bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static bool Greater_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static bool Less_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	public static int GetDays(FTimespan A) { return default; }
	public static FTimespan GetDuration(FTimespan A) { return default; }
	public static int GetHours(FTimespan A) { return default; }
	public static int GetMilliseconds(FTimespan A) { return default; }
	public static int GetMinutes(FTimespan A) { return default; }
	public static int GetSeconds(FTimespan A) { return default; }
	public static float GetTotalDays(FTimespan A) { return default; }
	public static float GetTotalHours(FTimespan A) { return default; }
	public static float GetTotalMilliseconds(FTimespan A) { return default; }
	public static float GetTotalMinutes(FTimespan A) { return default; }
	public static float GetTotalSeconds(FTimespan A) { return default; }
	public static FTimespan FromDays(float Days) { return default; }
	public static FTimespan FromHours(float Hours) { return default; }
	public static FTimespan FromMilliseconds(float Milliseconds) { return default; }
	public static FTimespan FromMinutes(float Minutes) { return default; }
	public static FTimespan FromSeconds(float Seconds) { return default; }
	public static float TimespanRatio(FTimespan A,FTimespan B) { return default; }
	public static bool TimespanFromString(string TimespanString,FTimespan Result) { return default; }
	public static FQualifiedFrameTime MakeQualifiedFrameTime(FFrameNumber Frame,FFrameRate FrameRate,float SubFrame/*=0.0f*/) { return default; }
	public static void BreakQualifiedFrameTime(FQualifiedFrameTime InFrameTime,FFrameNumber Frame,FFrameRate FrameRate,float SubFrame) {}
	public static FFrameRate MakeFrameRate(int Numerator,int Denominator/*=1*/) { return default; }
	public static void BreakFrameRate(FFrameRate InFrameRate,int Numerator,int Denominator) {}
	public static double Conv_ByteToDouble(byte InByte) { return default; }
	public static double Conv_IntToDouble(int InInt) { return default; }
	public static long Conv_IntToInt64(int InInt) { return default; }
	public static byte Conv_IntToByte(int InInt) { return default; }
	public static int Conv_Int64ToInt(long InInt) { return default; }
	public static float Conv_DoubleToFloat(double InDouble) { return default; }
	public static double Conv_FloatToDouble(float InFloat) { return default; }
	public static byte Conv_Int64ToByte(long InInt) { return default; }
	public static long Conv_DoubleToInt64(double InDouble) { return default; }
	public static double Conv_Int64ToDouble(long InInt) { return default; }
	public static FIntVector Conv_IntToIntVector(int InInt) { return default; }
	public static FVector Conv_IntToVector(int InInt) { return default; }
	public static bool Conv_IntToBool(int InInt) { return default; }
	public static int Conv_BoolToInt(bool InBool) { return default; }
	public static double Conv_BoolToDouble(bool InBool) { return default; }
	public static byte Conv_BoolToByte(bool InBool) { return default; }
	public static int Conv_ByteToInt(byte InByte) { return default; }
	public static long Conv_ByteToInt64(byte InByte) { return default; }
	public static FLinearColor Conv_ColorToLinearColor(FColor InColor) { return default; }
	public static FVector Conv_IntVectorToVector(FIntVector InIntVector) { return default; }
	public static FVector Conv_DoubleToVector(double InDouble) { return default; }
	public static FVector2D Conv_DoubleToVector2D(double InDouble) { return default; }
	public static FBox MakeBox(FVector Min,FVector Max) { return default; }
	public static FBox2D MakeBox2D(FVector2D Min,FVector2D Max) { return default; }
	public static FBoxSphereBounds MakeBoxSphereBounds(FVector Origin,FVector BoxExtent,float SphereRadius) { return default; }
	public static void BreakBoxSphereBounds(FBoxSphereBounds InBoxSphereBounds,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public static FRandomStream MakeRandomStream(int InitialSeed) { return default; }
	public static void BreakRandomStream(FRandomStream InRandomStream,int InitialSeed) {}
	public static string SelectString(string A,string B,bool bPickA) { return default; }
	public static int SelectInt(int A,int B,bool bPickA) { return default; }
	public static double SelectFloat(double A,double B,bool bPickA) { return default; }
	public static FVector SelectVector(FVector A,FVector B,bool bPickA) { return default; }
	public static FRotator SelectRotator(FRotator A,FRotator B,bool bPickA) { return default; }
	public static FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA) { return default; }
	public static FTransform SelectTransform(FTransform A,FTransform B,bool bPickA) { return default; }
	public static UObject SelectObject(UObject A,UObject B,bool bSelectA) { return default; }
	public static UClass SelectClass(UClass A,UClass B,bool bSelectA) { return default; }
	public static bool EqualEqual_ObjectObject(UObject A,UObject B) { return default; }
	public static bool NotEqual_ObjectObject(UObject A,UObject B) { return default; }
	public static bool EqualEqual_ClassClass(UClass A,UClass B) { return default; }
	public static bool NotEqual_ClassClass(UClass A,UClass B) { return default; }
	public static bool ClassIsChildOf(UClass TestClass,UClass ParentClass) { return default; }
	public static bool EqualEqual_NameName(string A,string B) { return default; }
	public static bool NotEqual_NameName(string A,string B) { return default; }
	public static FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale/*=new FVector(1,1,1)*/) { return default; }
	public static void BreakTransform(FTransform InTransform,FVector Location,FRotator Rotation,FVector Scale) {}
	public static bool EqualEqual_TransformTransform(FTransform A,FTransform B) { return default; }
	public static bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance/*=1.0e-4f*/,float RotationTolerance/*=1.0e-4f*/,float Scale3DTolerance/*=1.0e-4f*/) { return default; }
	public static FTransform ComposeTransforms(FTransform A,FTransform B) { return default; }
	public static FVector TransformLocation(FTransform T,FVector Location) { return default; }
	public static FVector TransformDirection(FTransform T,FVector Direction) { return default; }
	public static FRotator TransformRotation(FTransform T,FRotator Rotation) { return default; }
	public static FVector InverseTransformLocation(FTransform T,FVector Location) { return default; }
	public static FVector InverseTransformDirection(FTransform T,FVector Direction) { return default; }
	public static FRotator InverseTransformRotation(FTransform T,FRotator Rotation) { return default; }
	public static FTransform MakeRelativeTransform(FTransform A,FTransform RelativeTo) { return default; }
	public static FTransform InvertTransform(FTransform T) { return default; }
	public static FTransform TLerp(FTransform A,FTransform B,float Alpha,ELerpInterpolationMode InterpMode/*=ELerpInterpolationMode.QuatInterp*/) { return default; }
	public static FTransform TEase(FTransform A,FTransform B,float Alpha,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	public static FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed) { return default; }
	public static float Transform_Determinant(FTransform Transform) { return default; }
	public static FMatrix Conv_TransformToMatrix(FTransform Transform) { return default; }
	public static double FInterpTo(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	public static double FInterpTo_Constant(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	public static FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	public static FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	public static float FloatSpringInterp(float Current,float Target,FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,float MinValue/*=-1.0f*/,float MaxValue/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	public static void ResetFloatSpringState(FFloatSpringState SpringState) {}
	public static void ResetVectorSpringState(FVectorSpringState SpringState) {}
	public static void ResetQuaternionSpringState(FQuaternionSpringState SpringState) {}
	public static void SetFloatSpringStateVelocity(FFloatSpringState SpringState,float Velocity) {}
	public static void SetVectorSpringStateVelocity(FVectorSpringState SpringState,FVector Velocity) {}
	public static void SetQuaternionSpringStateAngularVelocity(FQuaternionSpringState SpringState,FVector AngularVelocity) {}
	public static int RandomIntegerFromStream(FRandomStream Stream,int Max) { return default; }
	public static int RandomIntegerInRangeFromStream(FRandomStream Stream,int Min,int Max) { return default; }
	public static bool RandomBoolFromStream(FRandomStream Stream) { return default; }
	public static float RandomFloatFromStream(FRandomStream Stream) { return default; }
	public static float RandomFloatInRangeFromStream(FRandomStream Stream,float Min,float Max) { return default; }
	public static FVector RandomUnitVectorFromStream(FRandomStream Stream) { return default; }
	public static FVector RandomPointInBoundingBoxFromStream(FRandomStream Stream,FVector Center,FVector HalfSize) { return default; }
	public static FVector RandomPointInBoundingBoxFromStream_Box(FRandomStream Stream,FBox Box) { return default; }
	public static FRotator RandomRotatorFromStream(FRandomStream Stream,bool bRoll) { return default; }
	public static void ResetRandomStream(FRandomStream Stream) {}
	public static void SeedRandomStream(FRandomStream Stream) {}
	public static void SetRandomStreamSeed(FRandomStream Stream,int NewSeed) {}
	public static FVector RandomUnitVectorInConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	public static FVector RandomUnitVectorInConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	public static FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	public static FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	public static float PerlinNoise1D(float Value) { return default; }
	public static void MinimumAreaRectangle(UObject WorldContextObject,TArray<FVector> InVerts,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutSideLengthX,float OutSideLengthY,bool bDebugDraw/*=false*/) {}
	public static void MinAreaRectangle(UObject WorldContextObject,TArray<FVector> InPoints,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutRectLengthX,float OutRectLengthY,bool bDebugDraw/*=false*/) {}
	public static bool PointsAreCoplanar(TArray<FVector> Points,float Tolerance/*=0.1f*/) { return default; }
	public static bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent) { return default; }
	public static bool IsPointInBox_Box(FVector Point,FBox Box) { return default; }
	public static bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent) { return default; }
	public static bool IsPointInBoxWithTransform_Box(FVector Point,FTransform BoxWorldTransform,FBox BoxExtent) { return default; }
	public static void GetSlopeDegreeAngles(FVector MyRightYAxis,FVector FloorNormal,FVector UpVector,float OutSlopePitchDegreeAngle,float OutSlopeRollDegreeAngle) {}
	public static bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,float T,FVector Intersection) { return default; }
	public static bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,float T,FVector Intersection) { return default; }
	public static float WeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float Weight) { return default; }
	public static FVector WeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float Weight) { return default; }
	public static FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float Weight) { return default; }
	public static float DynamicWeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public static FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public static FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	public static FVector_NetQuantize MakeVector_NetQuantize(double X,double Y,double Z) { return default; }
	public static FVector_NetQuantize10 MakeVector_NetQuantize10(double X,double Y,double Z) { return default; }
	public static FVector_NetQuantize100 MakeVector_NetQuantize100(double X,double Y,double Z) { return default; }
	public static FVector_NetQuantizeNormal MakeVector_NetQuantizeNormal(double X,double Y,double Z) { return default; }
	public static void BreakVector_NetQuantize(FVector_NetQuantize InVec,double X,double Y,double Z) {}
	public static void BreakVector_NetQuantize10(FVector_NetQuantize10 InVec,double X,double Y,double Z) {}
	public static void BreakVector_NetQuantize100(FVector_NetQuantize100 InVec,double X,double Y,double Z) {}
	public static void BreakVector_NetQuantizeNormal(FVector_NetQuantizeNormal InVec,double X,double Y,double Z) {}
}
