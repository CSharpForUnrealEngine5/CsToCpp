namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Used to expose C++ functions to tests that we don&#39;t want to make BP accessible</summary>
[CppInclude("FunctionalTestUtilityLibrary.h")]
public partial class UFunctionalTestUtilityLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Helper function to trace and permute many options at once</summary>
	public static UTraceQueryTestResults TraceChannelTestUtil(UObject WorldContextObject,FTraceChannelTestBatchOptions BatchOptions,FVector Start,FVector End,float SphereCapsuleRadius,float CapsuleHalfHeight,FVector BoxHalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,TArray<EObjectTypeQuery> ObjectTypes,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,bool bIgnoreSelf,EDrawDebugTrace DrawDebugType,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
}
