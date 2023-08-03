#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetMathLibrary.h")]
public partial class UKismetMathLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns a uniformly distributed random bool</summary>
	public static bool RandomBool() { return default; }
	///<summary>Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,</summary>
	public static bool RandomBoolWithWeight(float Weight) { return default; }
	///<summary>Get a random chance with the specified weight. Range of weight is 0.0 - 1.0 E.g.,</summary>
	public static bool RandomBoolWithWeightFromStream(FRandomStream RandomStream,float Weight) { return default; }
	///<summary>Returns the logical complement of the Boolean value (NOT A)</summary>
	public static bool Not_PreBool(bool A) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_BoolBool(bool A,bool B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_BoolBool(bool A,bool B) { return default; }
	///<summary>Returns the logical AND of two values (A AND B)</summary>
	public static bool BooleanAND(bool A,bool B) { return default; }
	///<summary>Returns the logical NAND of two values (A AND B)</summary>
	public static bool BooleanNAND(bool A,bool B) { return default; }
	///<summary>Returns the logical OR of two values (A OR B)</summary>
	public static bool BooleanOR(bool A,bool B) { return default; }
	///<summary>Returns the logical eXclusive OR of two values (A XOR B)</summary>
	public static bool BooleanXOR(bool A,bool B) { return default; }
	///<summary>Returns the logical Not OR of two values (A NOR B)</summary>
	public static bool BooleanNOR(bool A,bool B) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static byte Multiply_ByteByte(byte A,byte B) { return default; }
	///<summary>Division (A / B)</summary>
	public static byte Divide_ByteByte(byte A,byte B/*=1*/) { return default; }
	///<summary>Modulo (A % B)</summary>
	public static byte Percent_ByteByte(byte A,byte B/*=1*/) { return default; }
	///<summary>Addition (A + B)</summary>
	public static byte Add_ByteByte(byte A,byte B/*=1*/) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static byte Subtract_ByteByte(byte A,byte B/*=1*/) { return default; }
	///<summary>Returns the minimum value of A and B</summary>
	public static byte BMin(byte A,byte B) { return default; }
	///<summary>Returns the maximum value of A and B</summary>
	public static byte BMax(byte A,byte B) { return default; }
	///<summary>Returns true if A is less than B (A &lt; B)</summary>
	public static bool Less_ByteByte(byte A,byte B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_ByteByte(byte A,byte B) { return default; }
	///<summary>Returns true if A is less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_ByteByte(byte A,byte B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_ByteByte(byte A,byte B) { return default; }
	///<summary>Returns true if A is equal to B (A == B)</summary>
	public static bool EqualEqual_ByteByte(byte A,byte B) { return default; }
	///<summary>Returns true if A is not equal to B (A != B)</summary>
	public static bool NotEqual_ByteByte(byte A,byte B) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static int Multiply_IntInt(int A,int B) { return default; }
	///<summary>Division (A / B)</summary>
	public static int Divide_IntInt(int A,int B/*=1*/) { return default; }
	///<summary>Modulo (A % B)</summary>
	public static int Percent_IntInt(int A,int B/*=1*/) { return default; }
	///<summary>Addition (A + B)</summary>
	public static int Add_IntInt(int A,int B/*=1*/) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static int Subtract_IntInt(int A,int B/*=1*/) { return default; }
	///<summary>Returns true if A is less than B (A &lt; B)</summary>
	public static bool Less_IntInt(int A,int B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_IntInt(int A,int B) { return default; }
	///<summary>Returns true if A is less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_IntInt(int A,int B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_IntInt(int A,int B) { return default; }
	///<summary>Returns true if A is equal to B (A == B)</summary>
	public static bool EqualEqual_IntInt(int A,int B) { return default; }
	///<summary>Returns true if A is not equal to B (A != B)</summary>
	public static bool NotEqual_IntInt(int A,int B) { return default; }
	///<summary>Returns true if value is between Min and Max (V &gt;= Min &amp;&amp; V &lt;= Max)</summary>
	public static bool InRange_IntInt(int Value,int Min,int Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	///<summary>Bitwise AND (A &amp; B)</summary>
	public static int And_IntInt(int A,int B) { return default; }
	///<summary>Bitwise XOR (A ^ B)</summary>
	public static int Xor_IntInt(int A,int B) { return default; }
	///<summary>Bitwise OR (A | B)</summary>
	public static int Or_IntInt(int A,int B) { return default; }
	///<summary>Bitwise NOT (~A)</summary>
	public static int Not_Int(int A) { return default; }
	///<summary>Sign (integer, returns -1 if A &lt; 0, 0 if A is zero, and +1 if A &gt; 0)</summary>
	public static int SignOfInteger(int A) { return default; }
	///<summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
	public static int RandomInteger(int Max) { return default; }
	///<summary>Return a random integer between Min and Max (&gt;= Min and &lt;= Max)</summary>
	public static int RandomIntegerInRange(int Min,int Max) { return default; }
	///<summary>Returns the minimum value of A and B</summary>
	public static int Min(int A,int B) { return default; }
	///<summary>Returns the maximum value of A and B</summary>
	public static int Max(int A,int B) { return default; }
	///<summary>Returns Value clamped to be between A and B (inclusive)</summary>
	public static int Clamp(int Value,int Min,int Max) { return default; }
	///<summary>Returns Value between A and B (inclusive) that wraps around</summary>
	public static int Wrap(int Value,int Min,int Max) { return default; }
	///<summary>Returns the absolute (positive) value of A</summary>
	public static int Abs_Int(int A) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static long Multiply_Int64Int64(long A,long B) { return default; }
	///<summary>Division (A / B)</summary>
	public static long Divide_Int64Int64(long A,long B/*=1*/) { return default; }
	///<summary>Modulo (A % B)</summary>
	public static long Percent_Int64Int64(long A,long B/*=1*/) { return default; }
	///<summary>Addition (A + B)</summary>
	public static long Add_Int64Int64(long A,long B/*=1*/) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static long Subtract_Int64Int64(long A,long B/*=1*/) { return default; }
	///<summary>Returns true if A is less than B (A &lt; B)</summary>
	public static bool Less_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if A is less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if A is equal to B (A == B)</summary>
	public static bool EqualEqual_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if A is not equal to B (A != B)</summary>
	public static bool NotEqual_Int64Int64(long A,long B) { return default; }
	///<summary>Returns true if value is between Min and Max (V &gt;= Min &amp;&amp; V &lt;= Max)</summary>
	public static bool InRange_Int64Int64(long Value,long Min,long Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	///<summary>Bitwise AND (A &amp; B)</summary>
	public static long And_Int64Int64(long A,long B) { return default; }
	///<summary>Bitwise XOR (A ^ B)</summary>
	public static long Xor_Int64Int64(long A,long B) { return default; }
	///<summary>Bitwise OR (A | B)</summary>
	public static long Or_Int64Int64(long A,long B) { return default; }
	///<summary>Bitwise NOT (~A)</summary>
	public static long Not_Int64(long A) { return default; }
	///<summary>Sign (integer64, returns -1 if A &lt; 0, 0 if A is zero, and +1 if A &gt; 0)</summary>
	public static long SignOfInteger64(long A) { return default; }
	///<summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
	public static long RandomInteger64(long Max) { return default; }
	///<summary>Return a random integer64 between Min and Max (&gt;= Min and &lt;= Max)</summary>
	public static long RandomInteger64InRange(long Min,long Max) { return default; }
	///<summary>Returns the minimum value of A and B</summary>
	public static long MinInt64(long A,long B) { return default; }
	///<summary>Returns the maximum value of A and B</summary>
	public static long MaxInt64(long A,long B) { return default; }
	///<summary>Returns Value clamped to be between A and B (inclusive)</summary>
	public static long ClampInt64(long Value,long Min,long Max) { return default; }
	///<summary>Returns the absolute (positive) value of A</summary>
	public static long Abs_Int64(long A) { return default; }
	///<summary>Power (Base to the Exp-th power)</summary>
	public static double MultiplyMultiply_FloatFloat(double Base,double Exp) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static double Multiply_IntFloat(int A,double B) { return default; }
	///<summary>Percent_FloatFloat</summary>
	public static double Percent_FloatFloat(double A,double B/*=1.0f*/) { return default; }
	///<summary>Returns the fractional part of a float.</summary>
	public static double Fraction(double A) { return default; }
	///<summary>Addition (A + B)</summary>
	public static double Add_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static double Subtract_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static double Multiply_DoubleDouble(double A,double B) { return default; }
	///<summary>Division (A / B)</summary>
	public static double Divide_DoubleDouble(double A,double B/*=1.0*/) { return default; }
	///<summary>Returns true if A is Less than B (A &lt; B)</summary>
	public static bool Less_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if A is Less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if A is exactly equal to B (A == B)</summary>
	public static bool EqualEqual_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if A is nearly equal to B (|A - B| &lt; ErrorTolerance)</summary>
	public static bool NearlyEqual_FloatFloat(double A,double B,double ErrorTolerance/*=1.0e-6*/) { return default; }
	///<summary>Returns true if A does not equal B (A != B)</summary>
	public static bool NotEqual_DoubleDouble(double A,double B) { return default; }
	///<summary>Returns true if value is between Min and Max (V &gt;= Min &amp;&amp; V &lt;= Max)</summary>
	public static bool InRange_FloatFloat(double Value,double Min,double Max,bool InclusiveMin/*=true*/,bool InclusiveMax/*=true*/) { return default; }
	///<summary>Returns the hypotenuse of a right-angled triangle given the width and height.</summary>
	public static double Hypotenuse(double Width,double Height) { return default; }
	///<summary>Snaps a value to the nearest grid multiple. E.g.,</summary>
	public static double GridSnap_Float(double Location,double GridSize) { return default; }
	///<summary>Returns the absolute (positive) value of A</summary>
	public static double Abs(double A) { return default; }
	///<summary>Returns the sine of A (expects Radians)</summary>
	public static double Sin(double A) { return default; }
	///<summary>Returns the inverse sine (arcsin) of A (result is in Radians)</summary>
	public static double Asin(double A) { return default; }
	///<summary>Returns the cosine of A (expects Radians)</summary>
	public static double Cos(double A) { return default; }
	///<summary>Returns the inverse cosine (arccos) of A (result is in Radians)</summary>
	public static double Acos(double A) { return default; }
	///<summary>Returns the tan of A (expects Radians)</summary>
	public static double Tan(double A) { return default; }
	///<summary>Returns the inverse tan (atan) (result is in Radians)</summary>
	public static double Atan(double A) { return default; }
	///<summary>Returns the inverse tan (atan2) of A/B (result is in Radians)</summary>
	public static double Atan2(double Y,double X) { return default; }
	///<summary>Returns exponential(e) to the power A (e^A)</summary>
	public static double Exp(double A) { return default; }
	///<summary>Returns log of A base B (if B^R == A, returns R)</summary>
	public static double Log(double A,double Base/*=1.0*/) { return default; }
	///<summary>Returns natural log of A (if e^R == A, returns R)</summary>
	public static double Loge(double A) { return default; }
	///<summary>Returns square root of A</summary>
	public static double Sqrt(double A) { return default; }
	///<summary>Returns square of A (A*A)</summary>
	public static double Square(double A) { return default; }
	///<summary>Returns a random float between 0 and 1</summary>
	public static double RandomFloat() { return default; }
	///<summary>Generate a random number between Min and Max</summary>
	public static double RandomFloatInRange(double Min,double Max) { return default; }
	///<summary>Returns the value of PI</summary>
	public static double GetPI() { return default; }
	///<summary>Returns the value of TAU (= 2 * PI)</summary>
	public static double GetTAU() { return default; }
	///<summary>Returns radians value based on the input degrees</summary>
	public static double DegreesToRadians(double A) { return default; }
	///<summary>Returns degrees value based on the input radians</summary>
	public static double RadiansToDegrees(double A) { return default; }
	///<summary>Returns the sin of A (expects Degrees)</summary>
	public static double DegSin(double A) { return default; }
	///<summary>Returns the inverse sin (arcsin) of A (result is in Degrees)</summary>
	public static double DegAsin(double A) { return default; }
	///<summary>Returns the cos of A (expects Degrees)</summary>
	public static double DegCos(double A) { return default; }
	///<summary>Returns the inverse cos (arccos) of A (result is in Degrees)</summary>
	public static double DegAcos(double A) { return default; }
	///<summary>Returns the tan of A (expects Degrees)</summary>
	public static double DegTan(double A) { return default; }
	///<summary>Returns the inverse tan (atan) (result is in Degrees)</summary>
	public static double DegAtan(double A) { return default; }
	///<summary>Returns the inverse tan (atan2) of A/B (result is in Degrees)</summary>
	public static double DegAtan2(double Y,double X) { return default; }
	///<summary>Clamps an arbitrary angle to be between the given angles.  Will clamp to nearest boundary.</summary>
	public static double ClampAngle(double AngleDegrees,double MinAngleDegrees,double MaxAngleDegrees) { return default; }
	///<summary>Returns the minimum value of A and B</summary>
	public static double FMin(double A,double B) { return default; }
	///<summary>Returns the maximum value of A and B</summary>
	public static double FMax(double A,double B) { return default; }
	///<summary>Returns Value clamped between A and B (inclusive)</summary>
	public static double FClamp(double Value,double Min,double Max) { return default; }
	///<summary>Returns Value wrapped from A and B (inclusive)</summary>
	public static double FWrap(double Value,double Min,double Max) { return default; }
	///<summary>This functions returns 0 if B (the denominator) is zero</summary>
	public static double SafeDivide(double A,double B) { return default; }
	///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MaxOfIntArray(TArray<int> IntArray,int IndexOfMaxValue,int MaxValue) {}
	///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MinOfIntArray(TArray<int> IntArray,int IndexOfMinValue,int MinValue) {}
	///<summary>Returns median of all array entries. Returns value of 0 if the supplied array is empty.</summary>
	public static void MedianOfIntArray(TArray<int> IntArray,float MedianValue) {}
	///<summary>Returns average of all array entries. Returns value of 0 if the supplied array is empty.</summary>
	public static void AverageOfIntArray(TArray<int> IntArray,float AverageValue) {}
	///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MaxOfFloatArray(TArray<float> FloatArray,int IndexOfMaxValue,float MaxValue) {}
	///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MinOfFloatArray(TArray<float> FloatArray,int IndexOfMinValue,float MinValue) {}
	///<summary>Returns max of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MaxOfByteArray(TArray<byte> ByteArray,int IndexOfMaxValue,byte MaxValue) {}
	///<summary>Returns min of all array entries and the index at which it was found. Returns value of 0 and index of -1 if the supplied array is empty.</summary>
	public static void MinOfByteArray(TArray<byte> ByteArray,int IndexOfMinValue,byte MinValue) {}
	///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
	public static double Lerp(double A,double B,double Alpha) { return default; }
	///<summary>Easeing  between A and B using a specified easing function</summary>
	public static double Ease(double A,double B,double Alpha,EEasingFunc EasingFunc,double BlendExp/*=2*/,int Steps/*=2*/) { return default; }
	///<summary>Rounds A to the nearest integer (e.g., -1.6 becomes -2 and 1.6 becomes 2)</summary>
	public static int Round(double A) { return default; }
	///<summary>Rounds A down towards negative infinity / down to the previous integer (e.g., -1.6 becomes -2 and 1.6 becomes 1)</summary>
	public static int FFloor(double A) { return default; }
	///<summary>Rounds A towards zero, truncating the fractional part (e.g., -1.6 becomes -1 and 1.6 becomes 1)</summary>
	public static int FTrunc(double A) { return default; }
	///<summary>Rounds A up towards positive infinity / up to the next integer (e.g., -1.6 becomes -1 and 1.6 becomes 2)</summary>
	public static int FCeil(double A) { return default; }
	///<summary>Rounds A to the nearest integer (e.g., -1.6 becomes -2 and 1.6 becomes 2)</summary>
	public static long Round64(double A) { return default; }
	///<summary>Rounds A down towards negative infinity / down to the previous integer (e.g., -1.6 becomes -2 and 1.6 becomes 1)</summary>
	public static long FFloor64(double A) { return default; }
	///<summary>Rounds A towards zero, truncating the fractional part (e.g., -1.6 becomes -1 and 1.6 becomes 1)</summary>
	public static long FTrunc64(double A) { return default; }
	///<summary>Rounds A up towards positive infinity / up to the next integer (e.g., -1.6 becomes -1 and 1.6 becomes 2)</summary>
	public static long FCeil64(double A) { return default; }
	///<summary>Returns the number of times Divisor will go into Dividend (i.e., Dividend divided by Divisor), as well as the remainder</summary>
	public static int FMod(double Dividend,double Divisor,double Remainder) { return default; }
	///<summary>Returns the number of times Divisor will go into Dividend (i.e., Dividend divided by Divisor), as well as the remainder</summary>
	public static long FMod64(double Dividend,double Divisor,double Remainder) { return default; }
	///<summary>Sign (float, returns -1 if A &lt; 0, 0 if A is zero, and +1 if A &gt; 0)</summary>
	public static double SignOfFloat(double A) { return default; }
	///<summary>Returns Value normalized to the given range.  (e.g. 20 normalized to the range 10-&gt;50 would result in 0.25)</summary>
	public static double NormalizeToRange(double Value,double RangeMin,double RangeMax) { return default; }
	///<summary>Returns Value mapped from one range into another.  (e.g. 20 normalized from the range 10-&gt;50 to 20-&gt;40 would result in 25)</summary>
	public static double MapRangeUnclamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	///<summary>Returns Value mapped from one range into another where the Value is clamped to the Input Range.  (e.g. 0.5 normalized from the range 0-&gt;1 to 0-&gt;50 would result in 25)</summary>
	public static double MapRangeClamped(double Value,double InRangeA,double InRangeB,double OutRangeA,double OutRangeB) { return default; }
	///<summary>Multiplies the input value by pi.</summary>
	public static double MultiplyByPi(double Value) { return default; }
	///<summary>Interpolate between A and B, applying an ease in/out function.  Exp controls the degree of the curve.</summary>
	public static double FInterpEaseInOut(double A,double B,double Alpha,double Exponent) { return default; }
	///<summary>Simple function to create a pulsating scalar value</summary>
	public static float MakePulsatingValue(float InCurrentTime,float InPulsesPerSecond/*=1.0f*/,float InPhase/*=0.0f*/) { return default; }
	///<summary>Returns a new rotation component value</summary>
	public static float FixedTurn(float InCurrent,float InDesired,float InDeltaRate) { return default; }
	///<summary>Zero Int Point (0, 0)</summary>
	public static FIntPoint IntPoint_Zero() { return default; }
	///<summary>One Int Point (1, 1)</summary>
	public static FIntPoint IntPoint_One() { return default; }
	///<summary>Up Int Point (0, -1)</summary>
	public static FIntPoint IntPoint_Up() { return default; }
	///<summary>Left Int Point (-1, 0)</summary>
	public static FIntPoint IntPoint_Left() { return default; }
	///<summary>Right Int Point (1, 0)</summary>
	public static FIntPoint IntPoint_Right() { return default; }
	///<summary>Down Int Point (0, 1)</summary>
	public static FIntPoint IntPoint_Down() { return default; }
	///<summary>Converts an IntPoint to a Vector2D</summary>
	public static FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint) { return default; }
	///<summary>Returns IntPoint A added by B</summary>
	public static FIntPoint Add_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>Addition (A - B)</summary>
	public static FIntPoint Add_IntPointInt(FIntPoint A,int B) { return default; }
	///<summary>Returns IntPoint A subtracted by B</summary>
	public static FIntPoint Subtract_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static FIntPoint Subtract_IntPointInt(FIntPoint A,int B) { return default; }
	///<summary>Returns IntPoint A multiplied by B</summary>
	public static FIntPoint Multiply_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>Multiplication (A * B)</summary>
	public static FIntPoint Multiply_IntPointInt(FIntPoint A,int B) { return default; }
	///<summary>Returns IntPoint A divided by B</summary>
	public static FIntPoint Divide_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>Division (A * B)</summary>
	public static FIntPoint Divide_IntPointInt(FIntPoint A,int B) { return default; }
	///<summary>Returns true if IntPoint A is equal to IntPoint B (A == B)</summary>
	public static bool Equal_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>Returns true if IntPoint A is NOT equal to IntPoint B (A != B)</summary>
	public static bool NotEqual_IntPointIntPoint(FIntPoint A,FIntPoint B) { return default; }
	///<summary>2D one vector constant (1,1)</summary>
	public static FVector2D Vector2D_One() { return default; }
	///<summary>2D unit vector constant along the 45 degree angle or symmetrical positive axes (sqrt(.5),sqrt(.5)) or (.707,.707). https://en.wikipedia.org/wiki/Unit_vector</summary>
	public static FVector2D Vector2D_Unit45Deg() { return default; }
	///<summary>2D zero vector constant (0,0)</summary>
	public static FVector2D Vector2D_Zero() { return default; }
	///<summary>Makes a 2d vector {X, Y}</summary>
	public static FVector2D MakeVector2D(double X,double Y) { return default; }
	///<summary>Breaks a 2D vector apart into X, Y.</summary>
	public static void BreakVector2D(FVector2D InVec,double X,double Y) {}
	///<summary>Converts a Vector2D to a Vector</summary>
	public static FVector Conv_Vector2DToVector(FVector2D InVector2D,float Z/*=0f*/) { return default; }
	///<summary>Converts a Vector2D to an IntPoint</summary>
	public static FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D) { return default; }
	///<summary>Returns addition of Vector A and Vector B (A + B)</summary>
	public static FVector2D Add_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns Vector A added by B</summary>
	public static FVector2D Add_Vector2DFloat(FVector2D A,double B) { return default; }
	///<summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
	public static FVector2D Subtract_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns Vector A subtracted by B</summary>
	public static FVector2D Subtract_Vector2DFloat(FVector2D A,double B) { return default; }
	///<summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y})</summary>
	public static FVector2D Multiply_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns Vector A scaled by B</summary>
	public static FVector2D Multiply_Vector2DFloat(FVector2D A,double B) { return default; }
	///<summary>Element-wise Vector divide (Result = {A.x/B.x, A.y/B.y})</summary>
	public static FVector2D Divide_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns Vector A divided by B</summary>
	public static FVector2D Divide_Vector2DFloat(FVector2D A,double B/*=1.0f*/) { return default; }
	///<summary>Returns true if vector A is equal to vector B (A == B)</summary>
	public static bool EqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns true if vector2D A is equal to vector2D B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if vector2D A is not equal to vector2D B (A != B) within a specified error tolerance</summary>
	public static bool NotEqualExactly_Vector2DVector2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Returns true if vector2D A is not equal to vector2D B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_Vector2DVector2D(FVector2D A,FVector2D B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Gets a negated copy of the vector.</summary>
	public static FVector2D Negated2D(FVector2D A) { return default; }
	///<summary>Set the values of the vector directly.</summary>
	public static void Set2D(FVector2D A,double X,double Y) {}
	///<summary>Creates a copy of this vector with both axes clamped to the given range.</summary>
	public static FVector2D ClampAxes2D(FVector2D A,double MinAxisVal,double MaxAxisVal) { return default; }
	///<summary>Returns the cross product of two 2d vectors - see  http://mathworld.wolfram.com/CrossProduct.html</summary>
	public static double CrossProduct2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Distance between two 2D points.</summary>
	public static double Distance2D(FVector2D V1,FVector2D V2) { return default; }
	///<summary>Squared distance between two 2D points.</summary>
	public static double DistanceSquared2D(FVector2D V1,FVector2D V2) { return default; }
	///<summary>Returns the dot product of two 2d vectors - see http://mathworld.wolfram.com/DotProduct.html</summary>
	public static double DotProduct2D(FVector2D A,FVector2D B) { return default; }
	///<summary>Get a copy of this vector with absolute value of each component.</summary>
	public static FVector2D GetAbs2D(FVector2D A) { return default; }
	///<summary>Get the maximum absolute value of the vector&#39;s components.</summary>
	public static double GetAbsMax2D(FVector2D A) { return default; }
	///<summary>Get the maximum value of the vector&#39;s components.</summary>
	public static double GetMax2D(FVector2D A) { return default; }
	///<summary>Get the minimum value of the vector&#39;s components.</summary>
	public static double GetMin2D(FVector2D A) { return default; }
	///<summary>Rotates around axis (0,0,1)</summary>
	public static FVector2D GetRotated2D(FVector2D A,float AngleDeg) { return default; }
	///<summary>Checks whether vector is near to zero within a specified tolerance.</summary>
	public static bool IsNearlyZero2D(FVector2D A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Checks whether all components of the vector are exactly zero.</summary>
	public static bool IsZero2D(FVector2D A) { return default; }
	///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
	public static FVector2D Vector2DInterpTo(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Tries to reach Target at a constant rate.</summary>
	public static FVector2D Vector2DInterpTo_Constant(FVector2D Current,FVector2D Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Gets a normalized copy of the vector, checking it is safe to do so based on the length.</summary>
	public static FVector2D NormalSafe2D(FVector2D A,float Tolerance/*=1.0e-8f*/) { return default; }
	///<summary>Returns a unit normal version of the 2D vector</summary>
	public static FVector2D Normal2D(FVector2D A) { return default; }
	///<summary>Normalize this vector in-place if it is large enough, set it to (0,0) otherwise.</summary>
	public static void Normalize2D(FVector2D A,float Tolerance/*=1.0e-8f*/) {}
	///<summary>Converts spherical coordinates on the unit sphere into a Cartesian unit length vector.</summary>
	public static FVector Spherical2DToUnitCartesian(FVector2D A) { return default; }
	///<summary>Util to convert this vector into a unit direction vector and its original length.</summary>
	public static void ToDirectionAndLength2D(FVector2D A,FVector2D OutDir,double OutLength) {}
	///<summary>Get this vector as a vector where each component has been rounded to the nearest int.</summary>
	public static FVector2D ToRounded2D(FVector2D A) { return default; }
	///<summary>Get a copy of the vector as sign only.</summary>
	public static FVector2D ToSign2D(FVector2D A) { return default; }
	///<summary>Returns the length of a 2D Vector.</summary>
	public static double VSize2D(FVector2D A) { return default; }
	///<summary>Returns the squared length of a 2D Vector.</summary>
	public static double VSize2DSquared(FVector2D A) { return default; }
	///<summary>3D vector zero constant (0,0,0)</summary>
	public static FVector Vector_Zero() { return default; }
	///<summary>3D vector one constant (1,1,1)</summary>
	public static FVector Vector_One() { return default; }
	///<summary>3D vector Unreal forward direction constant (1,0,0)</summary>
	public static FVector Vector_Forward() { return default; }
	///<summary>3D vector Unreal backward direction constant (-1,0,0)</summary>
	public static FVector Vector_Backward() { return default; }
	///<summary>3D vector Unreal up direction constant (0,0,1)</summary>
	public static FVector Vector_Up() { return default; }
	///<summary>3D vector Unreal down direction constant (0,0,-1)</summary>
	public static FVector Vector_Down() { return default; }
	///<summary>3D vector Unreal right direction constant (0,1,0)</summary>
	public static FVector Vector_Right() { return default; }
	///<summary>3D vector Unreal left direction constant (0,-1,0)</summary>
	public static FVector Vector_Left() { return default; }
	///<summary>Makes a vector {X, Y, Z}</summary>
	public static FVector MakeVector(double X,double Y,double Z) { return default; }
	///<summary>Creates a directional vector from rotation values {Pitch, Yaw} supplied in degrees with specified Length</summary>
	public static FVector CreateVectorFromYawPitch(float Yaw,float Pitch,float Length/*=1.0f*/) { return default; }
	///<summary>Assign the values of the supplied vector.</summary>
	public static void Vector_Assign(FVector A,FVector InVector) {}
	///<summary>Set the values of the vector directly.</summary>
	public static void Vector_Set(FVector A,double X,double Y,double Z) {}
	///<summary>Breaks a vector apart into X, Y, Z</summary>
	public static void BreakVector(FVector InVec,double X,double Y,double Z) {}
	///<summary>BreakVector3f</summary>
	public static void BreakVector3f(FVector3f InVec,float X,float Y,float Z) {}
	///<summary>Converts a vector to LinearColor</summary>
	public static FLinearColor Conv_VectorToLinearColor(FVector InVec) { return default; }
	///<summary>Converts a vector to a transform. Uses vector as location</summary>
	public static FTransform Conv_VectorToTransform(FVector InLocation) { return default; }
	///<summary>Converts a Vector to a Vector2D using the Vector&#39;s (X, Y) coordinates</summary>
	public static FVector2D Conv_VectorToVector2D(FVector InVector) { return default; }
	///<summary>Return the FRotator orientation corresponding to the direction in which the vector points.</summary>
	public static FRotator Conv_VectorToRotator(FVector InVec) { return default; }
	///<summary>Create a rotation from an this axis and supplied angle (in degrees)</summary>
	public static FRotator RotatorFromAxisAndAngle(FVector Axis,float Angle) { return default; }
	///<summary>Return the Quaternion orientation corresponding to the direction in which the vector points.</summary>
	public static FQuat Conv_VectorToQuaternion(FVector InVec) { return default; }
	///<summary>Interpolate from a vector to the direction of another vector along a spherical path.</summary>
	public static FVector Vector_SlerpVectorToDirection(FVector Vector,FVector Direction,double Alpha) { return default; }
	///<summary>Interpolate from normalized vector A to normalized vector B along a spherical path.</summary>
	public static FVector Vector_SlerpNormals(FVector NormalA,FVector NormalB,double Alpha) { return default; }
	///<summary>Vector addition</summary>
	public static FVector Add_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Adds a float to each component of a vector</summary>
	public static FVector Add_VectorFloat(FVector A,double B) { return default; }
	///<summary>Adds an integer to each component of a vector</summary>
	public static FVector Add_VectorInt(FVector A,int B) { return default; }
	///<summary>Vector subtraction</summary>
	public static FVector Subtract_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Subtracts a float from each component of a vector</summary>
	public static FVector Subtract_VectorFloat(FVector A,double B) { return default; }
	///<summary>Subtracts an integer from each component of a vector</summary>
	public static FVector Subtract_VectorInt(FVector A,int B) { return default; }
	///<summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y, A.z*B.z})</summary>
	public static FVector Multiply_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Scales Vector A by B</summary>
	public static FVector Multiply_VectorFloat(FVector A,double B) { return default; }
	///<summary>Scales Vector A by B</summary>
	public static FVector Multiply_VectorInt(FVector A,int B) { return default; }
	///<summary>Element-wise Vector division (Result = {A.x/B.x, A.y/B.y, A.z/B.z})</summary>
	public static FVector Divide_VectorVector(FVector A,FVector B/*=new FVector(1.0f,1.0f,1.0f)*/) { return default; }
	///<summary>Vector divide by a float</summary>
	public static FVector Divide_VectorFloat(FVector A,double B/*=1.0f*/) { return default; }
	///<summary>Vector divide by an integer</summary>
	public static FVector Divide_VectorInt(FVector A,int B/*=1*/) { return default; }
	///<summary>Negate a vector.</summary>
	public static FVector NegateVector(FVector A) { return default; }
	///<summary>Returns true if vector A is equal to vector B (A == B)</summary>
	public static bool EqualExactly_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Returns true if vector A is equal to vector B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if vector A is not equal to vector B (A != B)</summary>
	public static bool NotEqualExactly_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_VectorVector(FVector A,FVector B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns the dot product of two 3d vectors - see http://mathworld.wolfram.com/DotProduct.html</summary>
	public static double Dot_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Returns the cross product of two 3d vectors - see http://mathworld.wolfram.com/CrossProduct.html</summary>
	public static FVector Cross_VectorVector(FVector A,FVector B) { return default; }
	///<summary>Returns result of vector A rotated by Rotator B</summary>
	public static FVector GreaterGreater_VectorRotator(FVector A,FRotator B) { return default; }
	///<summary>Returns result of vector A rotated by AngleDeg around Axis</summary>
	public static FVector RotateAngleAxis(FVector InVect,float AngleDeg,FVector Axis) { return default; }
	///<summary>Returns result of vector A rotated by the inverse of Rotator B</summary>
	public static FVector LessLess_VectorRotator(FVector A,FRotator B) { return default; }
	///<summary>When this vector contains Euler angles (degrees), ensure that angles are between +/-180</summary>
	public static void Vector_UnwindEuler(FVector A) {}
	///<summary>Create a copy of this vector, with its magnitude/size/length clamped between Min and Max.</summary>
	public static FVector ClampVectorSize(FVector A,double Min,double Max) { return default; }
	///<summary>Create a copy of this vector, with the 2D magnitude/size/length clamped between Min and Max. Z is unchanged.</summary>
	public static FVector Vector_ClampSize2D(FVector A,double Min,double Max) { return default; }
	///<summary>Create a copy of this vector, with its maximum magnitude/size/length clamped to MaxSize.</summary>
	public static FVector Vector_ClampSizeMax(FVector A,double Max) { return default; }
	///<summary>Create a copy of this vector, with the maximum 2D magnitude/size/length clamped to MaxSize. Z is unchanged.</summary>
	public static FVector Vector_ClampSizeMax2D(FVector A,double Max) { return default; }
	///<summary>Find the minimum element (X, Y or Z) of a vector</summary>
	public static double GetMinElement(FVector A) { return default; }
	///<summary>Find the maximum element (X, Y or Z) of a vector</summary>
	public static double GetMaxElement(FVector A) { return default; }
	///<summary>Find the maximum absolute element (abs(X), abs(Y) or abs(Z)) of a vector</summary>
	public static double Vector_GetAbsMax(FVector A) { return default; }
	///<summary>Find the minimum absolute element (abs(X), abs(Y) or abs(Z)) of a vector</summary>
	public static double Vector_GetAbsMin(FVector A) { return default; }
	///<summary>Get a copy of this vector with absolute value of each component.</summary>
	public static FVector Vector_GetAbs(FVector A) { return default; }
	///<summary>Find the minimum elements (X, Y and Z) between the two vector&#39;s components</summary>
	public static FVector Vector_ComponentMin(FVector A,FVector B) { return default; }
	///<summary>Find the maximum elements (X, Y and Z) between the two vector&#39;s components</summary>
	public static FVector Vector_ComponentMax(FVector A,FVector B) { return default; }
	///<summary>Get a copy of the vector as sign only.</summary>
	public static FVector Vector_GetSignVector(FVector A) { return default; }
	///<summary>Projects 2D components of vector based on Z.</summary>
	public static FVector Vector_GetProjection(FVector A) { return default; }
	///<summary>Convert a direction vector into a &#39;heading&#39; angle.</summary>
	public static double Vector_HeadingAngle(FVector A) { return default; }
	///<summary>Returns the cosine of the angle between this vector and another projected onto the XY plane (no Z).</summary>
	public static double Vector_CosineAngle2D(FVector A,FVector B) { return default; }
	///<summary>Converts a vector containing degree values to a vector containing radian values.</summary>
	public static FVector Vector_ToRadians(FVector A) { return default; }
	///<summary>Converts a vector containing radian values to a vector containing degree values.</summary>
	public static FVector Vector_ToDegrees(FVector A) { return default; }
	///<summary>Converts a Cartesian unit vector into spherical coordinates on the unit sphere.</summary>
	public static FVector2D Vector_UnitCartesianToSpherical(FVector A) { return default; }
	///<summary>Find the unit direction vector from one position to another or (0,0,0) if positions are the same.</summary>
	public static FVector GetDirectionUnitVector(FVector From,FVector To) { return default; }
	///<summary>Breaks a vector apart into Yaw, Pitch rotation values given in degrees. (non-clamped)</summary>
	public static void GetYawPitchFromVector(FVector InVec,float Yaw,float Pitch) {}
	///<summary>Breaks a direction vector apart into Azimuth (Yaw) and Elevation (Pitch) rotation values given in degrees. (non-clamped)</summary>
	public static void GetAzimuthAndElevation(FVector InDirection,FTransform ReferenceFrame,float Azimuth,float Elevation) {}
	///<summary>Find the average of an array of vectors</summary>
	public static FVector GetVectorArrayAverage(TArray<FVector> Vectors) { return default; }
	///<summary>Rounds A to an integer with truncation towards zero for each element in a vector.  (e.g. -1.7 truncated to -1, 2.8 truncated to 2)</summary>
	public static FIntVector FTruncVector(FVector InVector) { return default; }
	///<summary>Distance between two points.</summary>
	public static double Vector_Distance(FVector V1,FVector V2) { return default; }
	///<summary>Squared distance between two points.</summary>
	public static double Vector_DistanceSquared(FVector V1,FVector V2) { return default; }
	///<summary>Euclidean distance between two points in the XY plane (ignoring Z).</summary>
	public static double Vector_Distance2D(FVector V1,FVector V2) { return default; }
	///<summary>Squared euclidean distance between two points in the XY plane (ignoring Z).</summary>
	public static double Vector_Distance2DSquared(FVector V1,FVector V2) { return default; }
	///<summary>Returns the length of the vector</summary>
	public static double VSize(FVector A) { return default; }
	///<summary>Returns the squared length of the vector</summary>
	public static double VSizeSquared(FVector A) { return default; }
	///<summary>Returns the length of the vector&#39;s XY components.</summary>
	public static double VSizeXY(FVector A) { return default; }
	///<summary>Returns the squared length of the vector&#39;s XY components.</summary>
	public static double VSizeXYSquared(FVector A) { return default; }
	///<summary>Checks whether vector is near to zero within a specified tolerance.</summary>
	public static bool Vector_IsNearlyZero(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Checks whether all components of the vector are exactly zero.</summary>
	public static bool Vector_IsZero(FVector A) { return default; }
	///<summary>Determines if any component is not a number (NAN)</summary>
	public static bool Vector_IsNAN(FVector A) { return default; }
	///<summary>Checks whether all components of this vector are the same, within a tolerance.</summary>
	public static bool Vector_IsUniform(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Determines if vector is normalized / unit (length 1) within specified squared tolerance.</summary>
	public static bool Vector_IsUnit(FVector A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Determines if vector is normalized / unit (length 1).</summary>
	public static bool Vector_IsNormal(FVector A) { return default; }
	///<summary>Gets a normalized unit copy of the vector, ensuring it is safe to do so based on the length.</summary>
	public static FVector Normal(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Gets a normalized unit copy of the 2D components of the vector, ensuring it is safe to do so. Z is set to zero.</summary>
	public static FVector Vector_Normal2D(FVector A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Calculates normalized unit version of vector without checking for zero length.</summary>
	public static FVector Vector_NormalUnsafe(FVector A) { return default; }
	///<summary>Normalize this vector in-place if it is large enough or set it to (0,0,0) otherwise.</summary>
	public static void Vector_Normalize(FVector A,float Tolerance/*=1.0e-8f*/) {}
	///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
	public static FVector VLerp(FVector A,FVector B,float Alpha) { return default; }
	///<summary>Easing between A and B using a specified easing function</summary>
	public static FVector VEase(FVector A,FVector B,float Alpha,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
	public static FVector VInterpTo(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Tries to reach Target at a constant rate.</summary>
	public static FVector VInterpTo_Constant(FVector Current,FVector Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Uses a simple spring model to interpolate a vector from Current to Target.</summary>
	public static FVector VectorSpringInterp(FVector Current,FVector Target,FVectorSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,FVector MinValue/*=new FVector(-1.0f)*/,FVector MaxValue/*=new FVector(1.0f)*/,bool bInitializeFromTarget/*=false*/) { return default; }
	///<summary>Uses a simple spring model to interpolate a quaternion from Current to Target.</summary>
	public static FQuat QuaternionSpringInterp(FQuat Current,FQuat Target,FQuaternionSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	///<summary>Gets the reciprocal of this vector, avoiding division by zero.</summary>
	public static FVector Vector_Reciprocal(FVector A) { return default; }
	///<summary>Given a direction vector and a surface normal, returns the vector reflected across the surface normal.</summary>
	public static FVector GetReflectionVector(FVector Direction,FVector SurfaceNormal) { return default; }
	///<summary>Given a direction vector and a surface normal, returns the vector reflected across the surface normal.</summary>
	public static FVector MirrorVectorByNormal(FVector InVect,FVector InNormal) { return default; }
	///<summary>Mirrors a vector about a plane.</summary>
	public static FVector Vector_MirrorByPlane(FVector A,FPlane InPlane) { return default; }
	///<summary>Gets a copy of this vector snapped to a grid.</summary>
	public static FVector Vector_SnappedToGrid(FVector InVect,float InGridSize) { return default; }
	///<summary>Get a copy of this vector, clamped inside of an axis aligned cube centered at the origin.</summary>
	public static FVector Vector_BoundedToCube(FVector InVect,float InRadius) { return default; }
	///<summary>Add a vector to this and clamp the result to an axis aligned cube centered at the origin.</summary>
	public static void Vector_AddBounded(FVector A,FVector InAddVect,float InRadius) {}
	///<summary>Get a copy of this vector, clamped inside of the specified axis aligned cube.</summary>
	public static FVector Vector_BoundedToBox(FVector InVect,FVector InBoxMin,FVector InBoxMax) { return default; }
	///<summary>Gets a copy of this vector projected onto the input vector, which is assumed to be unit length.</summary>
	public static FVector Vector_ProjectOnToNormal(FVector V,FVector InNormal) { return default; }
	///<summary>Projects one vector (V) onto another (Target) and returns the projected vector.</summary>
	public static FVector ProjectVectorOnToVector(FVector V,FVector Target) { return default; }
	///<summary>Projects/snaps a point onto a plane defined by a point on the plane and a plane normal.</summary>
	public static FVector ProjectPointOnToPlane(FVector Point,FVector PlaneBase,FVector PlaneNormal) { return default; }
	///<summary>Projects a vector onto a plane defined by a normalized vector (PlaneNormal).</summary>
	public static FVector ProjectVectorOnToPlane(FVector V,FVector PlaneNormal) { return default; }
	///<summary>Find closest points between 2 segments.</summary>
	public static void FindNearestPointsOnLineSegments(FVector Segment1Start,FVector Segment1End,FVector Segment2Start,FVector Segment2End,FVector Segment1Point,FVector Segment2Point) {}
	///<summary>Find the closest point on a segment to a given point.</summary>
	public static FVector FindClosestPointOnSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	///<summary>Find the closest point on an infinite line to a given point.</summary>
	public static FVector FindClosestPointOnLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	///<summary>Find the distance from a point to the closest point on a segment.</summary>
	public static float GetPointDistanceToSegment(FVector Point,FVector SegmentStart,FVector SegmentEnd) { return default; }
	///<summary>Find the distance from a point to the closest point on an infinite line.</summary>
	public static float GetPointDistanceToLine(FVector Point,FVector LineOrigin,FVector LineDirection) { return default; }
	///<summary>Returns a random vector with length of 1</summary>
	public static FVector RandomUnitVector() { return default; }
	///<summary>Returns a random point within the specified bounding box using the first vector as an origin and the second as the box extents.</summary>
	public static FVector RandomPointInBoundingBox(FVector Center,FVector HalfSize) { return default; }
	///<summary>Returns a random point within the specified bounding box.</summary>
	public static FVector RandomPointInBoundingBox_Box(FBox Box) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInConeInRadians(FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInConeInDegrees(FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	///<summary>4D vector zero constant (0,0,0)</summary>
	public static FVector4 Vector4_Zero() { return default; }
	///<summary>Makes a 4D vector {X, Y, Z, W}</summary>
	public static FVector4 MakeVector4(double X,double Y,double Z,double W) { return default; }
	///<summary>Breaks a 4D vector apart into X, Y, Z, W.</summary>
	public static void BreakVector4(FVector4 InVec,double X,double Y,double Z,double W) {}
	///<summary>Converts a Vector4 to a Vector (dropping the W element)</summary>
	public static FVector Conv_Vector4ToVector(FVector4 InVector4) { return default; }
	///<summary>Return the FRotator orientation corresponding to the direction in which the vector points.</summary>
	public static FRotator Conv_Vector4ToRotator(FVector4 InVec) { return default; }
	///<summary>Return the Quaternion orientation corresponding to the direction in which the vector points.</summary>
	public static FQuat Conv_Vector4ToQuaternion(FVector4 InVec) { return default; }
	///<summary>Returns addition of Vector A and Vector B (A + B)</summary>
	public static FVector4 Add_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
	public static FVector4 Subtract_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Element-wise Vector multiplication (Result = {A.x*B.x, A.y*B.y, A.z*B.z, A.w*B.w})</summary>
	public static FVector4 Multiply_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Element-wise Vector divide (Result = {A.x/B.x, A.y/B.y, A.z/B.z, A.w/B.w})</summary>
	public static FVector4 Divide_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns true if vector A is equal to vector B (A == B)</summary>
	public static bool EqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns true if vector A is equal to vector B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
	public static bool NotEqualExactly_Vector4Vector4(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns true if vector A is not equal to vector B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_Vector4Vector4(FVector4 A,FVector4 B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Gets a negated copy of the vector. Equivalent to -Vector for scripts.</summary>
	public static FVector4 Vector4_Negated(FVector4 A) { return default; }
	///<summary>Assign the values of the supplied vector.</summary>
	public static void Vector4_Assign(FVector4 A,FVector4 InVector) {}
	///<summary>Set the values of the vector directly.</summary>
	public static void Vector4_Set(FVector4 A,double X,double Y,double Z,double W) {}
	///<summary>Returns the cross product of two vectors - see  http://mathworld.wolfram.com/CrossProduct.html</summary>
	public static FVector4 Vector4_CrossProduct3(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns the dot product of two vectors - see http://mathworld.wolfram.com/DotProduct.html</summary>
	public static double Vector4_DotProduct(FVector4 A,FVector4 B) { return default; }
	///<summary>Returns the dot product of two vectors - see http://mathworld.wolfram.com/DotProduct.html The W element is ignored.</summary>
	public static double Vector4_DotProduct3(FVector4 A,FVector4 B) { return default; }
	///<summary>Determines if any component is not a number (NAN)</summary>
	public static bool Vector4_IsNAN(FVector4 A) { return default; }
	///<summary>Checks whether vector is near to zero within a specified tolerance. The W element is ignored.</summary>
	public static bool Vector4_IsNearlyZero3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Checks whether all components of the vector are exactly zero.</summary>
	public static bool Vector4_IsZero(FVector4 A) { return default; }
	///<summary>Returns the length of the vector.</summary>
	public static double Vector4_Size(FVector4 A) { return default; }
	///<summary>Returns the squared length of the vector.</summary>
	public static double Vector4_SizeSquared(FVector4 A) { return default; }
	///<summary>Returns the length of the vector. The W element is ignored.</summary>
	public static double Vector4_Size3(FVector4 A) { return default; }
	///<summary>Returns the squared length of the vector. The W element is ignored.</summary>
	public static double Vector4_SizeSquared3(FVector4 A) { return default; }
	///<summary>Determines if vector is normalized / unit (length 1) within specified squared tolerance. The W element is ignored.</summary>
	public static bool Vector4_IsUnit3(FVector4 A,float SquaredLenthTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Determines if vector is normalized / unit (length 1). The W element is ignored.</summary>
	public static bool Vector4_IsNormal3(FVector4 A) { return default; }
	///<summary>Gets a normalized unit copy of the vector, ensuring it is safe to do so based on the length. The W element is ignored and the returned vector has W=0.</summary>
	public static FVector4 Vector4_Normal3(FVector4 A,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Calculates normalized unit version of vector without checking for zero length. The W element is ignored and the returned vector has W=0.</summary>
	public static FVector4 Vector4_NormalUnsafe3(FVector4 A) { return default; }
	///<summary>Normalize this vector in-place if it is large enough or set it to (0,0,0,0) otherwise. The W element is ignored and the returned vector has W=0.</summary>
	public static void Vector4_Normalize3(FVector4 A,float Tolerance/*=1.0e-8f*/) {}
	///<summary>Given a direction vector and a surface normal, returns the vector reflected across the surface normal.</summary>
	public static FVector4 Vector4_MirrorByVector3(FVector4 Direction,FVector4 SurfaceNormal) { return default; }
	///<summary>Transform the input vector4 by a provided matrix4x4 and returns the resulting vector4.</summary>
	public static FVector4 TransformVector4(FMatrix Matrix,FVector4 Vec4) { return default; }
	///<summary>Makes a rotator {Roll, Pitch, Yaw} from rotation values supplied in degrees</summary>
	public static FRotator MakeRotator(float Roll,float Pitch,float Yaw) { return default; }
	///<summary>Builds a rotator given only a XAxis. Y and Z are unspecified but will be orthonormal. XAxis need not be normalized.</summary>
	public static FRotator MakeRotFromX(FVector X) { return default; }
	///<summary>Builds a rotation matrix given only a YAxis. X and Z are unspecified but will be orthonormal. YAxis need not be normalized.</summary>
	public static FRotator MakeRotFromY(FVector Y) { return default; }
	///<summary>Builds a rotation matrix given only a ZAxis. X and Y are unspecified but will be orthonormal. ZAxis need not be normalized.</summary>
	public static FRotator MakeRotFromZ(FVector Z) { return default; }
	///<summary>Builds a matrix with given X and Y axes. X will remain fixed, Y may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromXY(FVector X,FVector Y) { return default; }
	///<summary>Builds a matrix with given X and Z axes. X will remain fixed, Z may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromXZ(FVector X,FVector Z) { return default; }
	///<summary>Builds a matrix with given Y and X axes. Y will remain fixed, X may be changed minimally to enforce orthogonality. Z will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromYX(FVector Y,FVector X) { return default; }
	///<summary>Builds a matrix with given Y and Z axes. Y will remain fixed, Z may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromYZ(FVector Y,FVector Z) { return default; }
	///<summary>Builds a matrix with given Z and X axes. Z will remain fixed, X may be changed minimally to enforce orthogonality. Y will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromZX(FVector Z,FVector X) { return default; }
	///<summary>Builds a matrix with given Z and Y axes. Z will remain fixed, Y may be changed minimally to enforce orthogonality. X will be computed. Inputs need not be normalized.</summary>
	public static FRotator MakeRotFromZY(FVector Z,FVector Y) { return default; }
	///<summary>Build a reference frame from three axes</summary>
	public static FRotator MakeRotationFromAxes(FVector Forward,FVector Right,FVector Up) { return default; }
	///<summary>Find a rotation for an object at Start location to point at Target location.</summary>
	public static FRotator FindLookAtRotation(FVector Start,FVector Target) { return default; }
	///<summary>Find a local rotation (range of [-180, 180]) for an object with StartTransform to point at TargetLocation.</summary>
	public static FRotator FindRelativeLookAtRotation(FTransform StartTransform,FVector TargetLocation) { return default; }
	///<summary>Breaks apart a rotator into {Roll, Pitch, Yaw} angles in degrees</summary>
	public static void BreakRotator(FRotator InRot,float Roll,float Pitch,float Yaw) {}
	///<summary>Breaks apart a rotator into its component axes</summary>
	public static void BreakRotIntoAxes(FRotator InRot,FVector X,FVector Y,FVector Z) {}
	///<summary>Returns true if rotator A is equal to rotator B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if rotator A is not equal to rotator B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_RotatorRotator(FRotator A,FRotator B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns rotator representing rotator A scaled by B</summary>
	public static FRotator Multiply_RotatorFloat(FRotator A,float B) { return default; }
	///<summary>Returns rotator representing rotator A scaled by B</summary>
	public static FRotator Multiply_RotatorInt(FRotator A,int B) { return default; }
	///<summary>Combine 2 rotations to give you the resulting rotation of first applying A, then B.</summary>
	public static FRotator ComposeRotators(FRotator A,FRotator B) { return default; }
	///<summary>Negate a rotator</summary>
	public static FRotator NegateRotator(FRotator A) { return default; }
	///<summary>Rotate the world forward vector by the given rotation</summary>
	public static FVector GetForwardVector(FRotator InRot) { return default; }
	///<summary>Rotate the world right vector by the given rotation</summary>
	public static FVector GetRightVector(FRotator InRot) { return default; }
	///<summary>Rotate the world up vector by the given rotation</summary>
	public static FVector GetUpVector(FRotator InRot) { return default; }
	///<summary>Get the X direction vector after this rotation</summary>
	public static FVector Conv_RotatorToVector(FRotator InRot) { return default; }
	///<summary>Converts Rotator to Transform</summary>
	public static FTransform Conv_RotatorToTransform(FRotator InRotator) { return default; }
	///<summary>Get the reference frame direction vectors (axes) described by this rotation</summary>
	public static void GetAxes(FRotator A,FVector X,FVector Y,FVector Z) {}
	///<summary>Generates a random rotation, with optional random roll.</summary>
	public static FRotator RandomRotator(bool bRoll/*=false*/) { return default; }
	///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
	public static FRotator RLerp(FRotator A,FRotator B,float Alpha,bool bShortestPath) { return default; }
	///<summary>Easing between A and B using a specified easing function</summary>
	public static FRotator REase(FRotator A,FRotator B,float Alpha,bool bShortestPath,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	///<summary>Normalized A-B</summary>
	public static FRotator NormalizedDeltaRotator(FRotator A,FRotator B) { return default; }
	///<summary>Clamps an angle to the range of [0, 360].</summary>
	public static float ClampAxis(float Angle) { return default; }
	///<summary>Clamps an angle to the range of [-180, 180].</summary>
	public static float NormalizeAxis(float Angle) { return default; }
	///<summary>Converts a Matrix to a Transform</summary>
	public static FTransform Conv_MatrixToTransform(FMatrix InMatrix) { return default; }
	///<summary>Converts a Matrix to a Rotator</summary>
	public static FRotator Conv_MatrixToRotator(FMatrix InMatrix) { return default; }
	///<summary>Get the origin of the co-ordinate system</summary>
	public static FVector Matrix_GetOrigin(FMatrix InMatrix) { return default; }
	///<summary>Identity matrix</summary>
	public static FMatrix Matrix_Identity() { return default; }
	///<summary>Gets the result of multiplying a Matrix to this.</summary>
	public static FMatrix Multiply_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	///<summary>Gets the result of adding a matrix to this.</summary>
	public static FMatrix Add_MatrixMatrix(FMatrix A,FMatrix B) { return default; }
	///<summary>Multiplies all values of the matrix by a float.</summary>
	public static FMatrix Multiply_MatrixFloat(FMatrix A,double B) { return default; }
	///<summary>Checks whether another Matrix is equal to this, within specified tolerance.</summary>
	public static bool EqualEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Checks whether another Matrix is not equal to this, within specified tolerance.</summary>
	public static bool NotEqual_MatrixMatrix(FMatrix A,FMatrix B,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Transform a vector by the matrix.</summary>
	public static FVector4 Matrix_TransformVector4(FMatrix M,FVector4 V) { return default; }
	///<summary>Transform a location - will take into account translation part of the FMatrix.</summary>
	public static FVector4 Matrix_TransformPosition(FMatrix M,FVector V) { return default; }
	///<summary>Inverts the matrix and then transforms V - correctly handles scaling in this matrix.</summary>
	public static FVector Matrix_InverseTransformPosition(FMatrix M,FVector V) { return default; }
	///<summary>Transform a direction vector - will not take into account translation part of the FMatrix.</summary>
	public static FVector4 Matrix_TransformVector(FMatrix M,FVector V) { return default; }
	///<summary>Transform a direction vector by the inverse of this matrix - will not take into account translation part.</summary>
	public static FVector Matrix_InverseTransformVector(FMatrix M,FVector V) { return default; }
	///<summary>Transpose.</summary>
	public static FMatrix Matrix_GetTransposed(FMatrix M) { return default; }
	///<summary>@return determinant of this matrix.</summary>
	public static float Matrix_GetDeterminant(FMatrix M) { return default; }
	///<summary>@return the determinant of rotation 3x3 matrix</summary>
	public static float Matrix_GetRotDeterminant(FMatrix M) { return default; }
	///<summary>Get the inverse of the Matrix. Handles nil matrices.</summary>
	public static FMatrix Matrix_GetInverse(FMatrix M) { return default; }
	///<summary>Get the Transose Adjoint of the Matrix.</summary>
	public static FMatrix Matrix_GetTransposeAdjoint(FMatrix M) { return default; }
	///<summary>Remove any scaling from this matrix (ie magnitude of each row is 1) with error Tolerance</summary>
	public static void Matrix_RemoveScaling(FMatrix M,float Tolerance/*=1.0e-8f*/) {}
	///<summary>Returns matrix after RemoveScaling with error Tolerance</summary>
	public static FMatrix Matrix_GetMatrixWithoutScale(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	///<summary>return a 3D scale vector calculated from this matrix (where each component is the magnitude of a row vector) with error Tolerance.</summary>
	public static FVector Matrix_GetScaleVector(FMatrix M,float Tolerance/*=1.0e-8f*/) { return default; }
	///<summary>Remove any translation from this matrix</summary>
	public static FMatrix Matrix_RemoveTranslation(FMatrix M) { return default; }
	///<summary>Returns a matrix with an additional translation concatenated.</summary>
	public static FMatrix Matrix_ConcatenateTranslation(FMatrix M,FVector Translation) { return default; }
	///<summary>Returns true if any element of this matrix is NaN</summary>
	public static bool Matrix_ContainsNaN(FMatrix M) { return default; }
	///<summary>Scale the translation part of the matrix by the supplied vector.</summary>
	public static FMatrix Matrix_ScaleTranslation(FMatrix M,FVector Scale3D) { return default; }
	///<summary>@return the maximum magnitude of any row of the matrix.</summary>
	public static float Matrix_GetMaximumAxisScale(FMatrix M) { return default; }
	///<summary>Apply Scale to this matrix</summary>
	public static FMatrix Matrix_ApplyScale(FMatrix M,float Scale) { return default; }
	///<summary>get axis of this matrix scaled by the scale of the matrix</summary>
	public static FVector Matrix_GetScaledAxis(FMatrix M,EAxis Axis) { return default; }
	///<summary>get axes of this matrix scaled by the scale of the matrix</summary>
	public static void Matrix_GetScaledAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	///<summary>get unit length axis of this matrix</summary>
	public static FVector Matrix_GetUnitAxis(FMatrix M,EAxis Axis) { return default; }
	///<summary>get unit length axes of this matrix</summary>
	public static void Matrix_GetUnitAxes(FMatrix M,FVector X,FVector Y,FVector Z) {}
	///<summary>set an axis of this matrix</summary>
	public static void Matrix_SetAxis(FMatrix M,EAxis Axis,FVector AxisVector) {}
	///<summary>Set the origin of the coordinate system to the given vector</summary>
	public static void Matrix_SetOrigin(FMatrix M,FVector NewOrigin) {}
	///<summary>get a column of this matrix</summary>
	public static FVector Matrix_GetColumn(FMatrix M,EMatrixColumns Column) { return default; }
	///<summary>Matrix_SetColumn</summary>
	public static void Matrix_SetColumn(FMatrix M,EMatrixColumns Column,FVector Value) {}
	///<summary>Get the rotator representation of this matrix</summary>
	public static FRotator Matrix_GetRotator(FMatrix M) { return default; }
	///<summary>Transform a rotation matrix into a quaternion.</summary>
	public static FQuat Matrix_ToQuat(FMatrix M) { return default; }
	///<summary>Get the near plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumNearPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Get the far plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumFarPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Get the left plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumLeftPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Get the right plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumRightPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Get the top plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumTopPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Get the bottom plane of the Frustum of this matrix</summary>
	public static bool Matrix_GetFrustumBottomPlane(FMatrix M,FPlane OutPlane) { return default; }
	///<summary>Utility for mirroring this transform across a certain plane, and flipping one of the axis as well.</summary>
	public static FMatrix Matrix_Mirror(FMatrix M,EAxis MirrorAxis,EAxis FlipAxis) { return default; }
	///<summary>Identity quaternion constant</summary>
	public static FQuat Quat_Identity() { return default; }
	///<summary>Returns true if Quaternion A is equal to Quaternion B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_QuatQuat(FQuat A,FQuat B,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if Quat A is not equal to Quat B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_QuatQuat(FQuat A,FQuat B,float ErrorTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns addition of Vector A and Vector B (A + B)</summary>
	public static FQuat Add_QuatQuat(FQuat A,FQuat B) { return default; }
	///<summary>Returns subtraction of Vector B from Vector A (A - B)</summary>
	public static FQuat Subtract_QuatQuat(FQuat A,FQuat B) { return default; }
	///<summary>Makes a quat {X, Y, Z, W}</summary>
	public static FQuat MakeQuat(float X,float Y,float Z,float W) { return default; }
	///<summary>Breaks a quat apart into X, Y, Z, W</summary>
	public static void BreakQuat(FQuat InQuat,float X,float Y,float Z,float W) {}
	///<summary>Gets the result of multiplying two quaternions (A * B).</summary>
	public static FQuat Multiply_QuatQuat(FQuat A,FQuat B) { return default; }
	///<summary>Checks whether this Quaternion is an Identity Quaternion.</summary>
	public static bool Quat_IsIdentity(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Return true if this quaternion is normalized</summary>
	public static bool Quat_IsNormalized(FQuat Q) { return default; }
	///<summary>Determine if all the values  are finite (not NaN nor Inf) in this Quat.</summary>
	public static bool Quat_IsFinite(FQuat Q) { return default; }
	///<summary>Determine if there are any non-finite values (NaN or Inf) in this Quat.</summary>
	public static bool Quat_IsNonFinite(FQuat Q) { return default; }
	///<summary>Find the angular distance/difference between two rotation quaternions.</summary>
	public static float Quat_AngularDistance(FQuat A,FQuat B) { return default; }
	///<summary>Modify the quaternion to ensure that the delta between it and B represents the shortest possible rotation angle.</summary>
	public static void Quat_EnforceShortestArcWith(FQuat A,FQuat B) {}
	///<summary>Convert a Quaternion into floating-point Euler angles (in degrees).</summary>
	public static FVector Quat_Euler(FQuat Q) { return default; }
	///<summary>Used in combination with Log().</summary>
	public static FQuat Quat_Exp(FQuat Q) { return default; }
	///<summary>Get the angle of this quaternion</summary>
	public static float Quat_GetAngle(FQuat Q) { return default; }
	///<summary>Get the forward direction (X axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_GetAxisX(FQuat Q) { return default; }
	///<summary>Get the right direction (Y axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_GetAxisY(FQuat Q) { return default; }
	///<summary>Get the up direction (Z axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_GetAxisZ(FQuat Q) { return default; }
	///<summary>Get the forward direction (X axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_VectorForward(FQuat Q) { return default; }
	///<summary>Get the right direction (Y axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_VectorRight(FQuat Q) { return default; }
	///<summary>Get the up direction (Z axis) after it has been rotated by this Quaternion.</summary>
	public static FVector Quat_VectorUp(FQuat Q) { return default; }
	///<summary>Normalize this quaternion if it is large enough as compared to the supplied tolerance.</summary>
	public static void Quat_Normalize(FQuat Q,float Tolerance/*=1.0e-4f*/) {}
	///<summary>Get a normalized copy of this quaternion.</summary>
	public static FQuat Quat_Normalized(FQuat Q,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Get the axis of rotation of the Quaternion.</summary>
	public static FVector Quat_GetRotationAxis(FQuat Q) { return default; }
	///<summary>Return an inversed copy of this quaternion.</summary>
	public static FQuat Quat_Inversed(FQuat Q) { return default; }
	///<summary>Quaternion with W=0 and V=theta*v. Used in combination with Exp().</summary>
	public static FQuat Quat_Log(FQuat Q) { return default; }
	///<summary>Set X, Y, Z, W components of Quaternion.</summary>
	public static void Quat_SetComponents(FQuat Q,float X,float Y,float Z,float W) {}
	///<summary>Convert a vector of floating-point Euler angles (in degrees) into a Quaternion.</summary>
	public static void Quat_SetFromEuler(FQuat Q,FVector Euler) {}
	///<summary>Convert a vector of floating-point Euler angles (in degrees) into a Quaternion.</summary>
	public static FQuat Quat_MakeFromEuler(FVector Euler) { return default; }
	///<summary>Converts to Rotator representation of this Quaternion.</summary>
	public static FRotator Quat_Rotator(FQuat Q) { return default; }
	///<summary>Converts to Quaternion representation of this Rotator.</summary>
	public static FQuat Conv_RotatorToQuaternion(FRotator InRot) { return default; }
	///<summary>Get the length of the quaternion.</summary>
	public static float Quat_Size(FQuat Q) { return default; }
	///<summary>Get the squared length of the quaternion.</summary>
	public static float Quat_SizeSquared(FQuat Q) { return default; }
	///<summary>Rotate a vector by this quaternion.</summary>
	public static FVector Quat_RotateVector(FQuat Q,FVector V) { return default; }
	///<summary>Rotate a vector by the inverse of this quaternion.</summary>
	public static FVector Quat_UnrotateVector(FQuat Q,FVector V) { return default; }
	///<summary>Spherical interpolation between Quaternions. Result is normalized.</summary>
	public static FQuat Quat_Slerp(FQuat A,FQuat B,double Alpha) { return default; }
	///<summary>Generates the &#39;smallest&#39; (geodesic) rotation around a sphere between two vectors of arbitrary length.</summary>
	public static FQuat Quat_FindBetweenVectors(FVector Start,FVector End) { return default; }
	///<summary>Generates the &#39;smallest&#39; (geodesic) rotation around a sphere between two normals (assumed to be unit length).</summary>
	public static FQuat Quat_FindBetweenNormals(FVector StartNormal,FVector EndNormal) { return default; }
	///<summary>White linear color</summary>
	public static FLinearColor LinearColor_White() { return default; }
	///<summary>Grey linear color</summary>
	public static FLinearColor LinearColor_Gray() { return default; }
	///<summary>Black linear color</summary>
	public static FLinearColor LinearColor_Black() { return default; }
	///<summary>Red linear color</summary>
	public static FLinearColor LinearColor_Red() { return default; }
	///<summary>Green linear color</summary>
	public static FLinearColor LinearColor_Green() { return default; }
	///<summary>Blue linear color</summary>
	public static FLinearColor LinearColor_Blue() { return default; }
	///<summary>Yellow linear color</summary>
	public static FLinearColor LinearColor_Yellow() { return default; }
	///<summary>Transparent linear color - black with 0 opacity/alpha</summary>
	public static FLinearColor LinearColor_Transparent() { return default; }
	///<summary>Make a color from individual color components (RGB space)</summary>
	public static FLinearColor MakeColor(float R,float G,float B,float A/*=1.0f*/) { return default; }
	///<summary>Breaks apart a color into individual RGB components (as well as alpha)</summary>
	public static void BreakColor(FLinearColor InColor,float R,float G,float B,float A) {}
	///<summary>Assign contents of InColor</summary>
	public static void LinearColor_Set(FLinearColor InOutColor,FLinearColor InColor) {}
	///<summary>Assign individual linear RGBA components.</summary>
	public static void LinearColor_SetRGBA(FLinearColor InOutColor,float R,float G,float B,float A/*=1.0f*/) {}
	///<summary>Assigns an HSV color to a linear space RGB color</summary>
	public static void LinearColor_SetFromHSV(FLinearColor InOutColor,float H,float S,float V,float A/*=1.0f*/) {}
	///<summary>Assigns an FColor coming from an observed sRGB output, into a linear color.</summary>
	public static void LinearColor_SetFromSRGB(FLinearColor InOutColor,FColor InSRGB) {}
	///<summary>Assigns an FColor coming from an observed Pow(1/2.2) output, into a linear color.</summary>
	public static void LinearColor_SetFromPow22(FLinearColor InOutColor,FColor InColor) {}
	///<summary>Converts temperature in Kelvins of a black body radiator to RGB chromaticity.</summary>
	public static void LinearColor_SetTemperature(FLinearColor InOutColor,float InTemperature) {}
	///<summary>Sets to a random color. Choses a quite nice color based on a random hue.</summary>
	public static void LinearColor_SetRandomHue(FLinearColor InOutColor) {}
	///<summary>Converts a float into a LinearColor, where each RGB element is that float</summary>
	public static FLinearColor Conv_DoubleToLinearColor(double InDouble) { return default; }
	///<summary>Make a color from individual color components (HSV space; Hue is [0..360) while Saturation and Value are 0..1)</summary>
	public static FLinearColor HSVToRGB(float H,float S,float V,float A/*=1.0f*/) { return default; }
	///<summary>Converts a HSV linear color (where H is in R (0..360), S is in G (0..1), and V is in B (0..1)) to RGB</summary>
	public static void HSVToRGB_Vector(FLinearColor HSV,FLinearColor RGB) {}
	///<summary>Converts a HSV linear color (where H is in R, S is in G, and V is in B) to linear RGB</summary>
	public static FLinearColor HSVToRGBLinear(FLinearColor HSV) { return default; }
	///<summary>Breaks apart a color into individual HSV components (as well as alpha) (Hue is [0..360) while Saturation and Value are 0..1)</summary>
	public static void RGBToHSV(FLinearColor InColor,float H,float S,float V,float A) {}
	///<summary>Converts a RGB linear color to HSV (where H is in R (0..360), S is in G (0..1), and V is in B (0..1))</summary>
	public static void RGBToHSV_Vector(FLinearColor RGB,FLinearColor HSV) {}
	///<summary>Converts a RGB linear color to HSV (where H is in R, S is in G, and V is in B)</summary>
	public static FLinearColor RGBLinearToHSV(FLinearColor RGB) { return default; }
	///<summary>Converts a LinearColor to a vector</summary>
	public static FVector Conv_LinearColorToVector(FLinearColor InLinearColor) { return default; }
	///<summary>Converts from linear to 8-bit RGBE as outlined in Gregory Ward&#39;s Real Pixels article, Graphics Gems II, page 80.</summary>
	public static FColor LinearColor_ToRGBE(FLinearColor InLinearColor) { return default; }
	///<summary>Quantizes the linear color and returns the result as a FColor with optional sRGB conversion and quality as goal.</summary>
	public static FColor Conv_LinearColorToColor(FLinearColor InLinearColor,bool InUseSRGB/*=true*/) { return default; }
	///<summary>Quantizes the linear color and returns the result as an 8-bit color.  This bypasses the SRGB conversion.</summary>
	public static FColor LinearColor_Quantize(FLinearColor InColor) { return default; }
	///<summary>Quantizes the linear color with rounding and returns the result as an 8-bit color.  This bypasses the SRGB conversion.</summary>
	public static FColor LinearColor_QuantizeRound(FLinearColor InColor) { return default; }
	///<summary>Returns a desaturated color, with 0 meaning no desaturation and 1 == full desaturation</summary>
	public static FLinearColor LinearColor_Desaturated(FLinearColor InColor,float InDesaturation) { return default; }
	///<summary>Euclidean distance between two color points.</summary>
	public static float LinearColor_Distance(FLinearColor C1,FLinearColor C2) { return default; }
	///<summary>Returns a copy of this color using the specified opacity/alpha.</summary>
	public static FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor,float InOpacity) { return default; }
	///<summary>Returns the perceived brightness of a color on a display taking into account the impact on the human eye per color channel: green &gt; red &gt; blue.</summary>
	public static float LinearColor_GetLuminance(FLinearColor InColor) { return default; }
	///<summary>Returns the maximum color channel value in this color structure</summary>
	public static float LinearColor_GetMax(FLinearColor InColor) { return default; }
	///<summary>Returns the minimum color channel value in this color structure</summary>
	public static float LinearColor_GetMin(FLinearColor InColor) { return default; }
	///<summary>Interpolate Linear Color from Current to Target. Scaled by distance to Target, so it has a strong start speed and ease out.</summary>
	public static FLinearColor CInterpTo(FLinearColor Current,FLinearColor Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1)</summary>
	public static FLinearColor LinearColorLerp(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	///<summary>Linearly interpolates between two colors by the specified Alpha amount (100% of A when Alpha=0 and 100% of B when Alpha=1).  The interpolation is performed in HSV color space taking the shortest path to the new color&#39;s hue.  This can give better results than a normal lerp, but is much more expensive.  The incoming colors are in RGB space, and the output color will be RGB.  The alpha value will also be interpolated.</summary>
	public static FLinearColor LinearColorLerpUsingHSV(FLinearColor A,FLinearColor B,float Alpha) { return default; }
	///<summary>Returns true if linear color A is equal to linear color B (A == B) within a specified error tolerance</summary>
	public static bool LinearColor_IsNearEqual(FLinearColor A,FLinearColor B,float Tolerance/*=1.0e-4f*/) { return default; }
	///<summary>Returns true if linear color A is equal to linear color B (A == B) within a specified error tolerance</summary>
	public static bool EqualEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Returns true if linear color A is not equal to linear color B (A != B) within a specified error tolerance</summary>
	public static bool NotEqual_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Element-wise addition of two linear colors (R+R, G+G, B+B, A+A)</summary>
	public static FLinearColor Add_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Element-wise subtraction of two linear colors (R-R, G-G, B-B, A-A)</summary>
	public static FLinearColor Subtract_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Element-wise multiplication of two linear colors (R*R, G*G, B*B, A*A)</summary>
	public static FLinearColor Multiply_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Element-wise multiplication of a linear color by a float (F*R, F*G, F*B, F*A)</summary>
	public static FLinearColor Multiply_LinearColorFloat(FLinearColor A,float B) { return default; }
	///<summary>Element-wise multiplication of two linear colors (R/R, G/G, B/B, A/A)</summary>
	public static FLinearColor Divide_LinearColorLinearColor(FLinearColor A,FLinearColor B) { return default; }
	///<summary>Creates a plane with a facing direction of Normal at the given Point</summary>
	public static FPlane MakePlaneFromPointAndNormal(FVector Point,FVector Normal) { return default; }
	///<summary>Makes a DateTime struct</summary>
	public static FDateTime MakeDateTime(int Year,int Month,int Day,int Hour/*=0*/,int Minute/*=0*/,int Second/*=0*/,int Millisecond/*=0*/) { return default; }
	///<summary>Breaks a DateTime into its components</summary>
	public static void BreakDateTime(FDateTime InDateTime,int Year,int Month,int Day,int Hour,int Minute,int Second,int Millisecond) {}
	///<summary>Addition (A + B)</summary>
	public static FDateTime Add_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static FDateTime Subtract_DateTimeTimespan(FDateTime A,FTimespan B) { return default; }
	///<summary>Addition (A + B)</summary>
	public static FDateTime Add_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static FTimespan Subtract_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if A is less than B (A &lt; B)</summary>
	public static bool Less_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns true if A is less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_DateTimeDateTime(FDateTime A,FDateTime B) { return default; }
	///<summary>Returns the date component of A</summary>
	public static FDateTime GetDate(FDateTime A) { return default; }
	///<summary>Returns the day component of A (1 to 31)</summary>
	public static int GetDay(FDateTime A) { return default; }
	///<summary>Returns the day of year of A</summary>
	public static int GetDayOfYear(FDateTime A) { return default; }
	///<summary>Returns the hour component of A (24h format)</summary>
	public static int GetHour(FDateTime A) { return default; }
	///<summary>Returns the hour component of A (12h format)</summary>
	public static int GetHour12(FDateTime A) { return default; }
	///<summary>Returns the millisecond component of A</summary>
	public static int GetMillisecond(FDateTime A) { return default; }
	///<summary>Returns the minute component of A</summary>
	public static int GetMinute(FDateTime A) { return default; }
	///<summary>Returns the month component of A</summary>
	public static int GetMonth(FDateTime A) { return default; }
	///<summary>Returns the second component of A</summary>
	public static int GetSecond(FDateTime A) { return default; }
	///<summary>Returns the time elapsed since midnight of A</summary>
	public static FTimespan GetTimeOfDay(FDateTime A) { return default; }
	///<summary>Returns the year component of A</summary>
	public static int GetYear(FDateTime A) { return default; }
	///<summary>Returns whether A&#39;s time is in the afternoon</summary>
	public static bool IsAfternoon(FDateTime A) { return default; }
	///<summary>Returns whether A&#39;s time is in the morning</summary>
	public static bool IsMorning(FDateTime A) { return default; }
	///<summary>Returns the number of days in the given year and month</summary>
	public static int DaysInMonth(int Year,int Month) { return default; }
	///<summary>Returns the number of days in the given year</summary>
	public static int DaysInYear(int Year) { return default; }
	///<summary>Returns whether given year is a leap year</summary>
	public static bool IsLeapYear(int Year) { return default; }
	///<summary>Returns the maximum date and time value</summary>
	public static FDateTime DateTimeMaxValue() { return default; }
	///<summary>Returns the minimum date and time value</summary>
	public static FDateTime DateTimeMinValue() { return default; }
	///<summary>Returns the local date and time on this computer</summary>
	public static FDateTime Now() { return default; }
	///<summary>Returns the local date on this computer</summary>
	public static FDateTime Today() { return default; }
	///<summary>Returns the UTC date and time on this computer</summary>
	public static FDateTime UtcNow() { return default; }
	///<summary>Converts a date string in ISO-8601 format to a DateTime object</summary>
	public static bool DateTimeFromIsoString(string IsoString,FDateTime Result) { return default; }
	///<summary>Converts a date string to a DateTime object</summary>
	public static bool DateTimeFromString(string DateTimeString,FDateTime Result) { return default; }
	///<summary>Returns the maximum time span value</summary>
	public static FTimespan TimespanMaxValue() { return default; }
	///<summary>Returns the minimum time span value</summary>
	public static FTimespan TimespanMinValue() { return default; }
	///<summary>Returns a zero time span value</summary>
	public static FTimespan TimespanZeroValue() { return default; }
	///<summary>Makes a Timespan struct</summary>
	public static FTimespan MakeTimespan(int Days,int Hours,int Minutes,int Seconds,int Milliseconds) { return default; }
	///<summary>Makes a Timespan struct</summary>
	public static FTimespan MakeTimespan2(int Days,int Hours,int Minutes,int Seconds,int FractionNano) { return default; }
	///<summary>Breaks a Timespan into its components</summary>
	public static void BreakTimespan(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int Milliseconds) {}
	///<summary>Breaks a Timespan into its components</summary>
	public static void BreakTimespan2(FTimespan InTimespan,int Days,int Hours,int Minutes,int Seconds,int FractionNano) {}
	///<summary>Addition (A + B)</summary>
	public static FTimespan Add_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Subtraction (A - B)</summary>
	public static FTimespan Subtract_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Scalar multiplication (A * s)</summary>
	public static FTimespan Multiply_TimespanFloat(FTimespan A,float Scalar) { return default; }
	///<summary>Scalar division (A / s)</summary>
	public static FTimespan Divide_TimespanFloat(FTimespan A,float Scalar) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns true if A is greater than B (A &gt; B)</summary>
	public static bool Greater_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns true if A is greater than or equal to B (A &gt;= B)</summary>
	public static bool GreaterEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns true if A is less than B (A &lt; B)</summary>
	public static bool Less_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns true if A is less than or equal to B (A &lt;= B)</summary>
	public static bool LessEqual_TimespanTimespan(FTimespan A,FTimespan B) { return default; }
	///<summary>Returns the days component of A</summary>
	public static int GetDays(FTimespan A) { return default; }
	///<summary>Returns the absolute value of A</summary>
	public static FTimespan GetDuration(FTimespan A) { return default; }
	///<summary>Returns the hours component of A</summary>
	public static int GetHours(FTimespan A) { return default; }
	///<summary>Returns the milliseconds component of A</summary>
	public static int GetMilliseconds(FTimespan A) { return default; }
	///<summary>Returns the minutes component of A</summary>
	public static int GetMinutes(FTimespan A) { return default; }
	///<summary>Returns the seconds component of A</summary>
	public static int GetSeconds(FTimespan A) { return default; }
	///<summary>Returns the total number of days in A</summary>
	public static float GetTotalDays(FTimespan A) { return default; }
	///<summary>Returns the total number of hours in A</summary>
	public static float GetTotalHours(FTimespan A) { return default; }
	///<summary>Returns the total number of milliseconds in A</summary>
	public static float GetTotalMilliseconds(FTimespan A) { return default; }
	///<summary>Returns the total number of minutes in A</summary>
	public static float GetTotalMinutes(FTimespan A) { return default; }
	///<summary>Returns the total number of seconds in A</summary>
	public static float GetTotalSeconds(FTimespan A) { return default; }
	///<summary>Returns a time span that represents the specified number of days</summary>
	public static FTimespan FromDays(float Days) { return default; }
	///<summary>Returns a time span that represents the specified number of hours</summary>
	public static FTimespan FromHours(float Hours) { return default; }
	///<summary>Returns a time span that represents the specified number of milliseconds</summary>
	public static FTimespan FromMilliseconds(float Milliseconds) { return default; }
	///<summary>Returns a time span that represents the specified number of minutes</summary>
	public static FTimespan FromMinutes(float Minutes) { return default; }
	///<summary>Returns a time span that represents the specified number of seconds</summary>
	public static FTimespan FromSeconds(float Seconds) { return default; }
	///<summary>Returns the ratio between two time spans (A / B), handles zero values</summary>
	public static float TimespanRatio(FTimespan A,FTimespan B) { return default; }
	///<summary>Converts a time span string to a Timespan object</summary>
	public static bool TimespanFromString(string TimespanString,FTimespan Result) { return default; }
	///<summary>Creates a FQualifiedFrameTime out of a frame number, frame rate, and optional 0-1 clamped subframe.</summary>
	public static FQualifiedFrameTime MakeQualifiedFrameTime(FFrameNumber Frame,FFrameRate FrameRate,float SubFrame/*=0.0f*/) { return default; }
	///<summary>Breaks a FQualifiedFrameTime into its component parts again.</summary>
	public static void BreakQualifiedFrameTime(FQualifiedFrameTime InFrameTime,FFrameNumber Frame,FFrameRate FrameRate,float SubFrame) {}
	///<summary>Creates a FFrameRate from a Numerator and a Denominator. Enforces that the Denominator is at least one.</summary>
	public static FFrameRate MakeFrameRate(int Numerator,int Denominator/*=1*/) { return default; }
	///<summary>Breaks a FFrameRate into a numerator and denominator.</summary>
	public static void BreakFrameRate(FFrameRate InFrameRate,int Numerator,int Denominator) {}
	///<summary>Converts a byte to a float</summary>
	public static double Conv_ByteToDouble(byte InByte) { return default; }
	///<summary>Converts an integer to a float</summary>
	public static double Conv_IntToDouble(int InInt) { return default; }
	///<summary>Converts an integer to a 64 bit integer</summary>
	public static long Conv_IntToInt64(int InInt) { return default; }
	///<summary>Converts an integer to a byte (if the integer is too large, returns the low 8 bits)</summary>
	public static byte Conv_IntToByte(int InInt) { return default; }
	///<summary>Converts a 64 bit integer to a 32 bit integer (if the integer is too large, returns the low 32 bits)</summary>
	public static int Conv_Int64ToInt(long InInt) { return default; }
	///<summary>Converts a 64 bit floating point to a 32 bit floating point (if the float is too large, returns the low 32 bits)</summary>
	public static float Conv_DoubleToFloat(double InDouble) { return default; }
	///<summary>Converts a 32 bit floating point to a 64 bit floating point</summary>
	public static double Conv_FloatToDouble(float InFloat) { return default; }
	///<summary>Converts a 64 bit integer to a byte (if the integer is too large, returns the low 8 bits)</summary>
	public static byte Conv_Int64ToByte(long InInt) { return default; }
	///<summary>Converts a float to a 64 bit integer</summary>
	public static long Conv_DoubleToInt64(double InDouble) { return default; }
	///<summary>Converts a 64 bit integer to a float</summary>
	public static double Conv_Int64ToDouble(long InInt) { return default; }
	///<summary>Converts an integer to an IntVector</summary>
	public static FIntVector Conv_IntToIntVector(int InInt) { return default; }
	///<summary>Converts an integer to a FVector</summary>
	public static FVector Conv_IntToVector(int InInt) { return default; }
	///<summary>Converts a int to a bool</summary>
	public static bool Conv_IntToBool(int InInt) { return default; }
	///<summary>Converts a bool to an int</summary>
	public static int Conv_BoolToInt(bool InBool) { return default; }
	///<summary>Converts a bool to a float (0.0 or 1.0)</summary>
	public static double Conv_BoolToDouble(bool InBool) { return default; }
	///<summary>Converts a bool to a byte</summary>
	public static byte Conv_BoolToByte(bool InBool) { return default; }
	///<summary>Converts a byte to an integer</summary>
	public static int Conv_ByteToInt(byte InByte) { return default; }
	///<summary>Converts a byte to an integer</summary>
	public static long Conv_ByteToInt64(byte InByte) { return default; }
	///<summary>Converts a color to LinearColor</summary>
	public static FLinearColor Conv_ColorToLinearColor(FColor InColor) { return default; }
	///<summary>Converts an IntVector to a vector</summary>
	public static FVector Conv_IntVectorToVector(FIntVector InIntVector) { return default; }
	///<summary>Converts a double into a vector, where each element is that float</summary>
	public static FVector Conv_DoubleToVector(double InDouble) { return default; }
	///<summary>Convert a float into a vector, where each element is that float</summary>
	public static FVector2D Conv_DoubleToVector2D(double InDouble) { return default; }
	///<summary>Makes an FBox from Min and Max and sets IsValid to true</summary>
	public static FBox MakeBox(FVector Min,FVector Max) { return default; }
	///<summary>Makes an FBox2D from Min and Max and sets IsValid to true</summary>
	public static FBox2D MakeBox2D(FVector2D Min,FVector2D Max) { return default; }
	///<summary>Makes an FBoxSphereBounds given an origin, extent, and radius</summary>
	public static FBoxSphereBounds MakeBoxSphereBounds(FVector Origin,FVector BoxExtent,float SphereRadius) { return default; }
	///<summary>Breaks an FBoxSphereBounds into origin, extent, and radius</summary>
	public static void BreakBoxSphereBounds(FBoxSphereBounds InBoxSphereBounds,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	///<summary>Makes a SRand-based random number generator</summary>
	public static FRandomStream MakeRandomStream(int InitialSeed) { return default; }
	///<summary>Breaks apart a random number generator</summary>
	public static void BreakRandomStream(FRandomStream InRandomStream,int InitialSeed) {}
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static string SelectString(string A,string B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static int SelectInt(int A,int B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static double SelectFloat(double A,double B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static FVector SelectVector(FVector A,FVector B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static FRotator SelectRotator(FRotator A,FRotator B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static FLinearColor SelectColor(FLinearColor A,FLinearColor B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static FTransform SelectTransform(FTransform A,FTransform B,bool bPickA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static UObject SelectObject(UObject A,UObject B,bool bSelectA) { return default; }
	///<summary>If bPickA is true, A is returned, otherwise B is</summary>
	public static UClass SelectClass(UClass A,UClass B,bool bSelectA) { return default; }
	///<summary>Returns true if A and B are equal (A == B)</summary>
	public static bool EqualEqual_ObjectObject(UObject A,UObject B) { return default; }
	///<summary>Returns true if A and B are not equal (A != B)</summary>
	public static bool NotEqual_ObjectObject(UObject A,UObject B) { return default; }
	///<summary>Returns true if A and B are equal (A == B)</summary>
	public static bool EqualEqual_ClassClass(UClass A,UClass B) { return default; }
	///<summary>Returns true if A and B are not equal (A != B)</summary>
	public static bool NotEqual_ClassClass(UClass A,UClass B) { return default; }
	///<summary>Determine if a class is a child of another class.</summary>
	public static bool ClassIsChildOf(UClass TestClass,UClass ParentClass) { return default; }
	///<summary>Returns true if A and B are equal (A == B)</summary>
	public static bool EqualEqual_NameName(string A,string B) { return default; }
	///<summary>Returns true if A and B are not equal (A != B)</summary>
	public static bool NotEqual_NameName(string A,string B) { return default; }
	///<summary>Make a transform from location, rotation and scale</summary>
	public static FTransform MakeTransform(FVector Location,FRotator Rotation,FVector Scale/*=new FVector(1,1,1)*/) { return default; }
	///<summary>Breaks apart a transform into location, rotation and scale</summary>
	public static void BreakTransform(FTransform InTransform,FVector Location,FRotator Rotation,FVector Scale) {}
	///<summary>Returns true if transform A is equal to transform B</summary>
	public static bool EqualEqual_TransformTransform(FTransform A,FTransform B) { return default; }
	///<summary>Returns true if transform A is nearly equal to B</summary>
	public static bool NearlyEqual_TransformTransform(FTransform A,FTransform B,float LocationTolerance/*=1.0e-4f*/,float RotationTolerance/*=1.0e-4f*/,float Scale3DTolerance/*=1.0e-4f*/) { return default; }
	///<summary>Compose two transforms in order: A * B.</summary>
	public static FTransform ComposeTransforms(FTransform A,FTransform B) { return default; }
	///<summary>Transform a position by the supplied transform.</summary>
	public static FVector TransformLocation(FTransform T,FVector Location) { return default; }
	///<summary>Transform a direction vector by the supplied transform - will not change its length.</summary>
	public static FVector TransformDirection(FTransform T,FVector Direction) { return default; }
	///<summary>Transform a rotator by the supplied transform.</summary>
	public static FRotator TransformRotation(FTransform T,FRotator Rotation) { return default; }
	///<summary>Transform a position by the inverse of the supplied transform.</summary>
	public static FVector InverseTransformLocation(FTransform T,FVector Location) { return default; }
	///<summary>Transform a direction vector by the inverse of the supplied transform - will not change its length.</summary>
	public static FVector InverseTransformDirection(FTransform T,FVector Direction) { return default; }
	///<summary>Transform a rotator by the inverse of the supplied transform.</summary>
	public static FRotator InverseTransformRotation(FTransform T,FRotator Rotation) { return default; }
	///<summary>Computes a relative transform of one transform compared to another.</summary>
	public static FTransform MakeRelativeTransform(FTransform A,FTransform RelativeTo) { return default; }
	///<summary>Returns the inverse of the given transform T.</summary>
	public static FTransform InvertTransform(FTransform T) { return default; }
	///<summary>Linearly interpolates between A and B based on Alpha (100% of A when Alpha=0 and 100% of B when Alpha=1).</summary>
	public static FTransform TLerp(FTransform A,FTransform B,float Alpha,ELerpInterpolationMode InterpMode/*=ELerpInterpolationMode.QuatInterp*/) { return default; }
	///<summary>Ease between A and B using a specified easing function.</summary>
	public static FTransform TEase(FTransform A,FTransform B,float Alpha,EEasingFunc EasingFunc,float BlendExp/*=2f*/,int Steps/*=2*/) { return default; }
	///<summary>Tries to reach Target transform based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
	public static FTransform TInterpTo(FTransform Current,FTransform Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Calculates the determinant of the transform (converts to FMatrix internally)</summary>
	public static float Transform_Determinant(FTransform Transform) { return default; }
	///<summary>Converts a Transform to a Matrix with scale</summary>
	public static FMatrix Conv_TransformToMatrix(FTransform Transform) { return default; }
	///<summary>Tries to reach Target based on distance from Current position, giving a nice smooth feeling when tracking a position.</summary>
	public static double FInterpTo(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	///<summary>Tries to reach Target at a constant rate.</summary>
	public static double FInterpTo_Constant(double Current,double Target,double DeltaTime,double InterpSpeed) { return default; }
	///<summary>Tries to reach Target rotation based on Current rotation, giving a nice smooth feeling when rotating to Target rotation.</summary>
	public static FRotator RInterpTo(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Tries to reach Target rotation at a constant rate.</summary>
	public static FRotator RInterpTo_Constant(FRotator Current,FRotator Target,float DeltaTime,float InterpSpeed) { return default; }
	///<summary>Uses a simple spring model to interpolate a float from Current to Target.</summary>
	public static float FloatSpringInterp(float Current,float Target,FFloatSpringState SpringState,float Stiffness,float CriticalDampingFactor,float DeltaTime,float Mass/*=1.0f*/,float TargetVelocityAmount/*=1.0f*/,bool bClamp/*=false*/,float MinValue/*=-1.0f*/,float MaxValue/*=1.0f*/,bool bInitializeFromTarget/*=false*/) { return default; }
	///<summary>Resets the state of a float spring</summary>
	public static void ResetFloatSpringState(FFloatSpringState SpringState) {}
	///<summary>Resets the state of a vector spring</summary>
	public static void ResetVectorSpringState(FVectorSpringState SpringState) {}
	///<summary>Resets the state of a quaternion spring</summary>
	public static void ResetQuaternionSpringState(FQuaternionSpringState SpringState) {}
	///<summary>Sets the state velocity of a float spring</summary>
	public static void SetFloatSpringStateVelocity(FFloatSpringState SpringState,float Velocity) {}
	///<summary>Sets the state velocity of a vector spring</summary>
	public static void SetVectorSpringStateVelocity(FVectorSpringState SpringState,FVector Velocity) {}
	///<summary>Sets the state angular velocity of a quaternion spring</summary>
	public static void SetQuaternionSpringStateAngularVelocity(FQuaternionSpringState SpringState,FVector AngularVelocity) {}
	///<summary>Returns a uniformly distributed random number between 0 and Max - 1</summary>
	public static int RandomIntegerFromStream(FRandomStream Stream,int Max) { return default; }
	///<summary>Return a random integer between Min and Max (&gt;= Min and &lt;= Max)</summary>
	public static int RandomIntegerInRangeFromStream(FRandomStream Stream,int Min,int Max) { return default; }
	///<summary>Returns a random bool</summary>
	public static bool RandomBoolFromStream(FRandomStream Stream) { return default; }
	///<summary>Returns a random float between 0 and 1</summary>
	public static float RandomFloatFromStream(FRandomStream Stream) { return default; }
	///<summary>Generate a random number between Min and Max</summary>
	public static float RandomFloatInRangeFromStream(FRandomStream Stream,float Min,float Max) { return default; }
	///<summary>Returns a random vector with length of 1.0</summary>
	public static FVector RandomUnitVectorFromStream(FRandomStream Stream) { return default; }
	///<summary>Returns a random point within the specified bounding box using the first vector as an origin and the second as the half size of the AABB.</summary>
	public static FVector RandomPointInBoundingBoxFromStream(FRandomStream Stream,FVector Center,FVector HalfSize) { return default; }
	///<summary>Returns a random point within the specified bounding box.</summary>
	public static FVector RandomPointInBoundingBoxFromStream_Box(FRandomStream Stream,FBox Box) { return default; }
	///<summary>Create a random rotation</summary>
	public static FRotator RandomRotatorFromStream(FRandomStream Stream,bool bRoll) { return default; }
	///<summary>Reset a random stream</summary>
	public static void ResetRandomStream(FRandomStream Stream) {}
	///<summary>Create a new random seed for a random stream</summary>
	public static void SeedRandomStream(FRandomStream Stream) {}
	///<summary>Set the seed of a random stream to a specific number</summary>
	public static void SetRandomStreamSeed(FRandomStream Stream,int NewSeed) {}
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInRadians) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float ConeHalfAngleInDegrees) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInRadians,float MaxPitchInRadians) { return default; }
	///<summary>Returns a random vector with length of 1, within the specified cone, with uniform random distribution.</summary>
	public static FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(FRandomStream Stream,FVector ConeDir,float MaxYawInDegrees,float MaxPitchInDegrees) { return default; }
	///<summary>Generates a 1D Perlin noise from the given value.  Returns a continuous random value between -1.0 and 1.0.</summary>
	public static float PerlinNoise1D(float Value) { return default; }
	///<summary>MinimumAreaRectangle</summary>
	public static void MinimumAreaRectangle(UObject WorldContextObject,TArray<FVector> InVerts,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutSideLengthX,float OutSideLengthY,bool bDebugDraw/*=false*/) {}
	///<summary>Finds the minimum area rectangle that encloses a set of coplanar points.</summary>
	public static void MinAreaRectangle(UObject WorldContextObject,TArray<FVector> InPoints,FVector SampleSurfaceNormal,FVector OutRectCenter,FRotator OutRectRotation,float OutRectLengthX,float OutRectLengthY,bool bDebugDraw/*=false*/) {}
	///<summary>Determines whether a given set of points are coplanar, with a tolerance. Any three points or less are always coplanar.</summary>
	public static bool PointsAreCoplanar(TArray<FVector> Points,float Tolerance/*=0.1f*/) { return default; }
	///<summary>Determines whether the given point is in a box. Includes points on the box.</summary>
	public static bool IsPointInBox(FVector Point,FVector BoxOrigin,FVector BoxExtent) { return default; }
	///<summary>Determines whether the given point is in a box. Includes points on the box.</summary>
	public static bool IsPointInBox_Box(FVector Point,FBox Box) { return default; }
	///<summary>Determines whether a given point is in a box with a given transform. Includes points on the box.</summary>
	public static bool IsPointInBoxWithTransform(FVector Point,FTransform BoxWorldTransform,FVector BoxExtent) { return default; }
	///<summary>Determines whether a given point is in a box with a given transform. Includes points on the box.</summary>
	public static bool IsPointInBoxWithTransform_Box(FVector Point,FTransform BoxWorldTransform,FBox BoxExtent) { return default; }
	///<summary>Returns Slope Pitch and Roll angles in degrees based on the following information:</summary>
	public static void GetSlopeDegreeAngles(FVector MyRightYAxis,FVector FloorNormal,FVector UpVector,float OutSlopePitchDegreeAngle,float OutSlopeRollDegreeAngle) {}
	///<summary>Computes the intersection point between a line and a plane.</summary>
	public static bool LinePlaneIntersection(FVector LineStart,FVector LineEnd,FPlane APlane,float T,FVector Intersection) { return default; }
	///<summary>Computes the intersection point between a line and a plane.</summary>
	public static bool LinePlaneIntersection_OriginNormal(FVector LineStart,FVector LineEnd,FVector PlaneOrigin,FVector PlaneNormal,float T,FVector Intersection) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and the weight</summary>
	public static float WeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float Weight) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and the weight</summary>
	public static FVector WeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float Weight) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and the weight</summary>
	public static FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float Weight) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and a weight range.</summary>
	public static float DynamicWeightedMovingAverage_Float(float CurrentSample,float PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and a weight range.</summary>
	public static FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample,FVector PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	///<summary>Calculates the new value in a weighted moving average series using the previous value and a weight range.</summary>
	public static FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample,FRotator PreviousSample,float MaxDistance,float MinWeight,float MaxWeight) { return default; }
	///<summary>NetQuantized vector make/breaks</summary>
	public static FVector_NetQuantize MakeVector_NetQuantize(double X,double Y,double Z) { return default; }
	///<summary>MakeVector_NetQuantize10</summary>
	public static FVector_NetQuantize10 MakeVector_NetQuantize10(double X,double Y,double Z) { return default; }
	///<summary>MakeVector_NetQuantize100</summary>
	public static FVector_NetQuantize100 MakeVector_NetQuantize100(double X,double Y,double Z) { return default; }
	///<summary>MakeVector_NetQuantizeNormal</summary>
	public static FVector_NetQuantizeNormal MakeVector_NetQuantizeNormal(double X,double Y,double Z) { return default; }
	///<summary>BreakVector_NetQuantize</summary>
	public static void BreakVector_NetQuantize(FVector_NetQuantize InVec,double X,double Y,double Z) {}
	///<summary>BreakVector_NetQuantize10</summary>
	public static void BreakVector_NetQuantize10(FVector_NetQuantize10 InVec,double X,double Y,double Z) {}
	///<summary>BreakVector_NetQuantize100</summary>
	public static void BreakVector_NetQuantize100(FVector_NetQuantize100 InVec,double X,double Y,double Z) {}
	///<summary>BreakVector_NetQuantizeNormal</summary>
	public static void BreakVector_NetQuantizeNormal(FVector_NetQuantizeNormal InVec,double X,double Y,double Z) {}
}
