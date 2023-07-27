#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetSystemLibrary.h")]
public partial class UKismetSystemLibrary : UBlueprintFunctionLibrary {
// KismetSystemLibrary
	public static void StackTrace() {}
	public static bool IsValid(UObject Object) { return default; }
	public static bool IsValidClass(UClass Class) { return default; }
	public static string GetObjectName(UObject Object) { return default; }
	public static string GetPathName(UObject Object) { return default; }
	public static FSoftObjectPath GetSoftObjectPath(UObject Object) { return default; }
	public static string GetSystemPath(UObject Object) { return default; }
	public static string GetDisplayName(UObject Object) { return default; }
	public static string GetClassDisplayName(UClass Class) { return default; }
	public static FSoftClassPath GetSoftClassPath(UClass Class) { return default; }
	public static UObject GetOuterObject(UObject Object) { return default; }
	public static string GetEngineVersion() { return default; }
	public static string GetBuildVersion() { return default; }
	public static string GetBuildConfiguration() { return default; }
	public static string GetGameName() { return default; }
	public static string GetProjectDirectory() { return default; }
	public static string GetProjectContentDirectory() { return default; }
	public static string GetProjectSavedDirectory() { return default; }
	public static string ConvertToRelativePath(string Filename) { return default; }
	public static string ConvertToAbsolutePath(string Filename) { return default; }
	public static string NormalizeFilename(string InFilename) { return default; }
	public static string GetGameBundleId() { return default; }
	public static string GetPlatformUserName() { return default; }
	public static string GetPlatformUserDir() { return default; }
	public static bool DoesImplementInterface(UObject TestObject,UClass Interface) { return default; }
	public static double GetGameTimeInSeconds(UObject WorldContextObject) { return default; }
	public static long GetFrameCount() { return default; }
	public static bool IsServer(UObject WorldContextObject) { return default; }
	public static bool IsDedicatedServer(UObject WorldContextObject) { return default; }
	public static bool IsStandalone(UObject WorldContextObject) { return default; }
	public static bool IsSplitScreen(UObject WorldContextObject) { return default; }
	public static bool HasMultipleLocalPlayers(UObject WorldContextObject) { return default; }
	public static bool IsPackagedForDistribution() { return default; }
	public static string GetUniqueDeviceId() { return default; }
	public static string GetDeviceId() { return default; }
	public static UClass Conv_ObjectToClass(UObject Object,UClass Class) { return default; }
	public static UObject Conv_InterfaceToObject(object /*Interface*/ Interface) { return default; }
	public static FSoftObjectPath MakeSoftObjectPath(string PathString) { return default; }
	public static void BreakSoftObjectPath(FSoftObjectPath InSoftObjectPath,string PathString) {}
	public static TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef(FSoftObjectPath SoftObjectPath) { return default; }
	public static FSoftObjectPath Conv_SoftObjRefToSoftObjPath(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public static FTopLevelAssetPath MakeTopLevelAssetPath(string PackageName,string AssetName) { return default; }
	public static void BreakTopLevelAssetPath(FTopLevelAssetPath TopLevelAssetPath,string PathString) {}
	public static FSoftClassPath MakeSoftClassPath(string PathString) { return default; }
	public static void BreakSoftClassPath(FSoftClassPath InSoftClassPath,string PathString) {}
	public static TSoftObjectPtr<UClass> Conv_SoftClassPathToSoftClassRef(FSoftClassPath SoftClassPath) { return default; }
	public static FSoftClassPath Conv_SoftObjRefToSoftClassPath(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public static bool IsValidSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public static string Conv_SoftObjectReferenceToString(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public static bool EqualEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	public static bool NotEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	public static UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset) { return default; }
	public static bool IsValidSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public static string Conv_SoftClassReferenceToString(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public static bool EqualEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	public static bool NotEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	public static UClass LoadClassAsset_Blocking(TSoftObjectPtr<UClass> AssetClass) { return default; }
	public static UObject Conv_SoftObjectReferenceToObject(TSoftObjectPtr<UObject> SoftObject) { return default; }
	public static UClass Conv_SoftClassReferenceToClass(TSoftObjectPtr<UClass> SoftClass) { return default; }
	public static TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference(UObject Object) { return default; }
	public static TSoftObjectPtr<UClass> Conv_ClassToSoftClassReference(UClass Class) { return default; }
	public  void FOnAssetLoaded(UObject Loaded) {}
	public static void LoadAsset(UObject WorldContextObject,TSoftObjectPtr<UObject> Asset,FOnAssetLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public  void FOnAssetClassLoaded(UClass Loaded) {}
	public static void LoadAssetClass(UObject WorldContextObject,TSoftObjectPtr<UClass> AssetClass,FOnAssetClassLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public static int MakeLiteralInt(int Value) { return default; }
	public static long MakeLiteralInt64(long Value) { return default; }
	public static double MakeLiteralDouble(double Value) { return default; }
	public static bool MakeLiteralBool(bool Value) { return default; }
	public static string MakeLiteralName(string Value) { return default; }
	public static byte MakeLiteralByte(byte Value) { return default; }
	public static string MakeLiteralString(string Value) { return default; }
	public static string MakeLiteralText(string Value) { return default; }
	public static void LogString(string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToLog/*=true*/) {}
	public static void PrintString(UObject WorldContextObject,string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,string Key/*=NAME_None*/) {}
	public static void PrintText(UObject WorldContextObject,string InText/*=INVTEXT("Hello")*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,string Key/*=NAME_None*/) {}
	public static void PrintWarning(string InString) {}
	public static void SetWindowTitle(string Title) {}
	public static void ExecuteConsoleCommand(UObject WorldContextObject,string Command,APlayerController SpecificPlayer/*=NULL*/) {}
	public static string GetConsoleVariableStringValue(string VariableName) { return default; }
	public static float GetConsoleVariableFloatValue(string VariableName) { return default; }
	public static int GetConsoleVariableIntValue(string VariableName) { return default; }
	public static bool GetConsoleVariableBoolValue(string VariableName) { return default; }
	public static void QuitGame(UObject WorldContextObject,APlayerController SpecificPlayer,EQuitPreference QuitPreference,bool bIgnorePlatformRestrictions) {}
	public static void QuitEditor() {}
	public static void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public static void DelayUntilNextTick(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	public static void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public static void MoveComponentTo(USceneComponent Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,EMoveComponentAction MoveAction,FLatentActionInfo LatentInfo) {}
	public static FTimerHandle K2_SetTimerDelegate(FTimerDynamicDelegate Delegate,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	public static FTimerHandle K2_SetTimerForNextTickDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public static void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public static void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public static bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public static bool K2_IsValidTimerHandle(FTimerHandle Handle) { return default; }
	public static FTimerHandle K2_InvalidateTimerHandle(FTimerHandle Handle) { return default; }
	public static void K2_ClearTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public static void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public static void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public static bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public static bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public static bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public static FTimerHandle K2_SetTimer(UObject Object,string FunctionName,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	public static FTimerHandle K2_SetTimerForNextTick(UObject Object,string FunctionName) { return default; }
	public static void K2_ClearTimer(UObject Object,string FunctionName) {}
	public static void K2_PauseTimer(UObject Object,string FunctionName) {}
	public static void K2_UnPauseTimer(UObject Object,string FunctionName) {}
	public static bool K2_IsTimerActive(UObject Object,string FunctionName) { return default; }
	public static bool K2_IsTimerPaused(UObject Object,string FunctionName) { return default; }
	public static bool K2_TimerExists(UObject Object,string FunctionName) { return default; }
	public static float K2_GetTimerElapsedTime(UObject Object,string FunctionName) { return default; }
	public static float K2_GetTimerRemainingTime(UObject Object,string FunctionName) { return default; }
	public static void SetIntPropertyByName(UObject Object,string PropertyName,int Value) {}
	public static void SetInt64PropertyByName(UObject Object,string PropertyName,long Value) {}
	public static void SetBytePropertyByName(UObject Object,string PropertyName,byte Value) {}
	public static void SetDoublePropertyByName(UObject Object,string PropertyName,double Value) {}
	public static void SetBoolPropertyByName(UObject Object,string PropertyName,bool Value) {}
	public static void SetObjectPropertyByName(UObject Object,string PropertyName,UObject Value) {}
	public static void SetClassPropertyByName(UObject Object,string PropertyName,UClass Value) {}
	public static void SetInterfacePropertyByName(UObject Object,string PropertyName,object /*Value*/ Value) {}
	public static void SetNamePropertyByName(UObject Object,string PropertyName,string Value) {}
	public static void SetSoftObjectPropertyByName(UObject Object,string PropertyName,TSoftObjectPtr<UObject> Value) {}
	public static void SetSoftClassPropertyByName(UObject Object,string PropertyName,TSoftObjectPtr<UClass> Value) {}
	public static void SetStringPropertyByName(UObject Object,string PropertyName,string Value) {}
	public static void SetTextPropertyByName(UObject Object,string PropertyName,string Value) {}
	public static void SetVectorPropertyByName(UObject Object,string PropertyName,FVector Value) {}
	public static void SetVector3fPropertyByName(UObject Object,string PropertyName,FVector3f Value) {}
	public static void SetRotatorPropertyByName(UObject Object,string PropertyName,FRotator Value) {}
	public static void SetLinearColorPropertyByName(UObject Object,string PropertyName,FLinearColor Value) {}
	public static void SetColorPropertyByName(UObject Object,string PropertyName,FColor Value) {}
	public static void SetTransformPropertyByName(UObject Object,string PropertyName,FTransform Value) {}
	public static void SetCollisionProfileNameProperty(UObject Object,string PropertyName,FCollisionProfileName Value) {}
	public static void SetFieldPathPropertyByName(UObject Object,string PropertyName,object Value) {}
	public static void SetStructurePropertyByName(UObject Object,string PropertyName,FGenericStruct Value) {}
	public static bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	public static bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	public static bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	public static bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	public static bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	public static bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	public static bool ComponentOverlapActors(UPrimitiveComponent Component,FTransform ComponentTransform,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	public static bool ComponentOverlapComponents(UPrimitiveComponent Component,FTransform ComponentTransform,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	public static bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public static void GetActorListFromComponentList(TArray<UPrimitiveComponent> ComponentList,UClass ActorClassFilter,TArray<AActor> OutActorList) {}
	public static void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/,FVector YAxis/*=new FVector(0.0f,1.0f,0.0f)*/,FVector ZAxis/*=new FVector(0.0f,0.0f,1.0f)*/,bool bDrawAxis/*=false*/) {}
	public static void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration/*=0.0f*/) {}
	public static void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation/*=FRotator.ZeroRotator*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale/*=1.0f*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCone(UObject WorldContextObject,FVector Origin,FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length/*=100.0f*/,float AngleWidth/*=45.0f*/,float AngleHeight/*=45.0f*/,int NumSides/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugString(UObject WorldContextObject,FVector TextLocation,string Text,AActor TestBaseActor/*=NULL*/,FLinearColor TextColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public static void FlushDebugStrings(UObject WorldContextObject) {}
	public static void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public static void FlushPersistentDebugLines(UObject WorldContextObject) {}
	public static void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public static void DrawDebugCamera(ACameraActor CameraActor,FLinearColor CameraColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public static FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory) { return default; }
	public static void CreateCopyForUndoBuffer(UObject ObjectToModify) {}
	public static void GetComponentBounds(USceneComponent Component,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public static void GetActorBounds(AActor Actor,FVector Origin,FVector BoxExtent) {}
	public static int GetRenderingDetailMode() { return default; }
	public static int GetRenderingMaterialQualityLevel() { return default; }
	public static bool GetSupportedFullscreenResolutions(TArray<FIntPoint> Resolutions) { return default; }
	public static bool GetConvenientWindowedResolutions(TArray<FIntPoint> Resolutions) { return default; }
	public static int GetMinYResolutionForUI() { return default; }
	public static int GetMinYResolutionFor3DView() { return default; }
	public static void LaunchURL(string URL) {}
	public static bool CanLaunchURL(string URL) { return default; }
	public static void CollectGarbage() {}
	public static void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen) {}
	public static int GetAdIDCount() { return default; }
	public static void HideAdBanner() {}
	public static void ForceCloseAdBanner() {}
	public static void LoadInterstitialAd(int AdIdIndex) {}
	public static bool IsInterstitialAdAvailable() { return default; }
	public static bool IsInterstitialAdRequested() { return default; }
	public static void ShowInterstitialAd() {}
	public static void ShowPlatformSpecificLeaderboardScreen(string CategoryName) {}
	public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer) {}
	public static bool IsLoggedIn(APlayerController SpecificPlayer) { return default; }
	public static bool IsScreensaverEnabled() { return default; }
	public static void ControlScreensaver(bool bAllowScreenSaver) {}
	public static void SetVolumeButtonsHandledBySystem(bool bEnabled) {}
	public static bool GetVolumeButtonsHandledBySystem() { return default; }
	public static void SetGamepadsBlockDeviceFeedback(bool bBlock) {}
	public static void ResetGamepadAssignments() {}
	public static void ResetGamepadAssignmentToController(int ControllerId) {}
	public static bool IsControllerAssignedToGamepad(int ControllerId) { return default; }
	public static string GetGamepadControllerName(int ControllerId) { return default; }
	public static UTexture2D GetGamepadButtonGlyph(string ButtonKey,int ControllerIndex) { return default; }
	public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState) {}
	public static TArray<string> GetPreferredLanguages() { return default; }
	public static string GetDefaultLanguage() { return default; }
	public static string GetDefaultLocale() { return default; }
	public static string GetLocalCurrencyCode() { return default; }
	public static string GetLocalCurrencySymbol() { return default; }
	public static void RegisterForRemoteNotifications() {}
	public static void UnregisterForRemoteNotifications() {}
	public static void SetUserActivity(FUserActivity UserActivity) {}
	public static string GetCommandLine() { return default; }
	public static void ParseCommandLine(string InCmdLine,TArray<string> OutTokens,TArray<string> OutSwitches,TMap<string,string> OutParams) {}
	public static bool ParseParam(string InString,string InParam) { return default; }
	public static bool ParseParamValue(string InString,string InParam,string OutValue) { return default; }
	public static bool IsUnattended() { return default; }
	public static bool GetEditorProperty(UObject Object,string PropertyName,int PropertyValue) { return default; }
	public static bool SetEditorProperty(UObject Object,string PropertyName,int PropertyValue,EPropertyAccessChangeNotifyMode ChangeNotifyMode) { return default; }
	public static int BeginTransaction(string Context,string Description,UObject PrimaryObject) { return default; }
	public static int EndTransaction() { return default; }
	public static void CancelTransaction(int Index) {}
	public static void TransactObject(UObject Object) {}
	public static void SnapshotObject(UObject Object) {}
	public static UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static UClass GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static TSoftObjectPtr<UClass> GetSoftClassReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static FPrimaryAssetId GetPrimaryAssetIdFromObject(UObject Object) { return default; }
	public static FPrimaryAssetId GetPrimaryAssetIdFromClass(UClass Class) { return default; }
	public static FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public static FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public static void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public static bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static string Conv_PrimaryAssetIdToString(FPrimaryAssetId PrimaryAssetId) { return default; }
	public static bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	public static bool NotEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	public static bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType) { return default; }
	public static string Conv_PrimaryAssetTypeToString(FPrimaryAssetType PrimaryAssetType) { return default; }
	public static bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	public static bool NotEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	public static void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId) {}
	public static void UnloadPrimaryAssetList(TArray<FPrimaryAssetId> PrimaryAssetIdList) {}
	public static bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId,bool bForceCurrentState,TArray<string> OutBundles) { return default; }
	public static void GetPrimaryAssetsWithBundleState(TArray<string> RequiredBundles,TArray<string> ExcludedBundles,TArray<FPrimaryAssetType> ValidTypes,bool bForceCurrentState,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public static FARFilter MakeARFilter(TArray<string> PackageNames,TArray<string> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<string> ClassNames,TSet<string> RecursiveClassesExclusionSet,bool bRecursivePaths/*=false*/,bool bRecursiveClasses/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public static void BreakARFilter(FARFilter InARFilter,TArray<string> PackageNames,TArray<string> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<string> ClassNames,TSet<string> RecursiveClassesExclusionSet,bool bRecursivePaths,bool bRecursiveClasses,bool bIncludeOnlyOnDiskAssets) {}
}
