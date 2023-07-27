#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FunctionalTestUtilityLibrary.h")]
///<summary>Used to expose C++ functions to tests that we don't want to make BP accessible</summary>
public partial class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary {
// FunctionalTestUtilityLibrary
	public static UTraceQueryTestResults TraceChannelTestUtil(UObject WorldContextObject,FTraceChannelTestBatchOptions BatchOptions,FVector Start,FVector End,float SphereCapsuleRadius,float CapsuleHalfHeight,FVector BoxHalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,TArray<byte> ObjectTypes,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,bool bIgnoreSelf,EDrawDebugTrace DrawDebugType,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
}
