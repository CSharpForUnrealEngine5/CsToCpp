#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetSystemLibrary.h")]
public partial class UKismetSystemLibrary : UBlueprintFunctionLibrary {
// KismetSystemLibrary
	public void StackTrace() {}
	public bool IsValid(UObject Object) { return default; }
	public bool IsValidClass(UClass Class) { return default; }
	public string GetObjectName(UObject Object) { return default; }
	public string GetPathName(UObject Object) { return default; }
	public FSoftObjectPath GetSoftObjectPath(UObject Object) { return default; }
	public string GetSystemPath(UObject Object) { return default; }
	public string GetDisplayName(UObject Object) { return default; }
	public string GetClassDisplayName(UClass Class) { return default; }
	public FSoftClassPath GetSoftClassPath(UClass Class) { return default; }
	public UObject GetOuterObject(UObject Object) { return default; }
	public string GetEngineVersion() { return default; }
	public string GetBuildVersion() { return default; }
	public string GetBuildConfiguration() { return default; }
	public string GetGameName() { return default; }
	public string GetProjectDirectory() { return default; }
	public string GetProjectContentDirectory() { return default; }
	public string GetProjectSavedDirectory() { return default; }
	public string ConvertToRelativePath(string Filename) { return default; }
	public string ConvertToAbsolutePath(string Filename) { return default; }
	public string NormalizeFilename(string InFilename) { return default; }
	public string GetGameBundleId() { return default; }
	public string GetPlatformUserName() { return default; }
	public string GetPlatformUserDir() { return default; }
	public bool DoesImplementInterface(UObject TestObject,UClass Interface) { return default; }
	public double GetGameTimeInSeconds(UObject WorldContextObject) { return default; }
	public long GetFrameCount() { return default; }
	public bool IsServer(UObject WorldContextObject) { return default; }
	public bool IsDedicatedServer(UObject WorldContextObject) { return default; }
	public bool IsStandalone(UObject WorldContextObject) { return default; }
	public bool IsSplitScreen(UObject WorldContextObject) { return default; }
	public bool HasMultipleLocalPlayers(UObject WorldContextObject) { return default; }
	public bool IsPackagedForDistribution() { return default; }
	public string GetUniqueDeviceId() { return default; }
	public string GetDeviceId() { return default; }
	public UClass Conv_ObjectToClass(UObject Object,UClass Class) { return default; }
	public UObject Conv_InterfaceToObject(object /*Interface*/ Interface) { return default; }
	public FSoftObjectPath MakeSoftObjectPath(string PathString) { return default; }
	public void BreakSoftObjectPath(FSoftObjectPath InSoftObjectPath,string PathString) {}
	public TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef(FSoftObjectPath SoftObjectPath) { return default; }
	public FSoftObjectPath Conv_SoftObjRefToSoftObjPath(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public FTopLevelAssetPath MakeTopLevelAssetPath(string PackageName,string AssetName) { return default; }
	public void BreakTopLevelAssetPath(FTopLevelAssetPath TopLevelAssetPath,string PathString) {}
	public FSoftClassPath MakeSoftClassPath(string PathString) { return default; }
	public void BreakSoftClassPath(FSoftClassPath InSoftClassPath,string PathString) {}
	public TSoftObjectPtr<UClass> Conv_SoftClassPathToSoftClassRef(FSoftClassPath SoftClassPath) { return default; }
	public FSoftClassPath Conv_SoftObjRefToSoftClassPath(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public bool IsValidSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public string Conv_SoftObjectReferenceToString(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public bool EqualEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	public bool NotEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	public UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset) { return default; }
	public bool IsValidSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public string Conv_SoftClassReferenceToString(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public bool EqualEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	public bool NotEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	public UClass LoadClassAsset_Blocking(TSoftObjectPtr<UClass> AssetClass) { return default; }
	public UObject Conv_SoftObjectReferenceToObject(TSoftObjectPtr<UObject> SoftObject) { return default; }
	public UClass Conv_SoftClassReferenceToClass(TSoftObjectPtr<UClass> SoftClass) { return default; }
	public TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference(UObject Object) { return default; }
	public TSoftObjectPtr<UClass> Conv_ClassToSoftClassReference(UClass Class) { return default; }
	public void FOnAssetLoaded(UObject Loaded) {}
	public void LoadAsset(UObject WorldContextObject,TSoftObjectPtr<UObject> Asset,FOnAssetLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public void FOnAssetClassLoaded(UClass Loaded) {}
	public void LoadAssetClass(UObject WorldContextObject,TSoftObjectPtr<UClass> AssetClass,FOnAssetClassLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	public int MakeLiteralInt(int Value) { return default; }
	public long MakeLiteralInt64(long Value) { return default; }
	public double MakeLiteralDouble(double Value) { return default; }
	public bool MakeLiteralBool(bool Value) { return default; }
	public string MakeLiteralName(string Value) { return default; }
	public byte MakeLiteralByte(byte Value) { return default; }
	public string MakeLiteralString(string Value) { return default; }
	public string MakeLiteralText(string Value) { return default; }
	public void LogString(string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToLog/*=true*/) {}
	public void PrintString(UObject WorldContextObject,string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,string Key/*=NAME_None*/) {}
	public void PrintText(UObject WorldContextObject,string InText/*=INVTEXT("Hello")*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,string Key/*=NAME_None*/) {}
	public void PrintWarning(string InString) {}
	public void SetWindowTitle(string Title) {}
	public void ExecuteConsoleCommand(UObject WorldContextObject,string Command,UObject SpecificPlayer/*=NULL*/) {}
	public string GetConsoleVariableStringValue(string VariableName) { return default; }
	public float GetConsoleVariableFloatValue(string VariableName) { return default; }
	public int GetConsoleVariableIntValue(string VariableName) { return default; }
	public bool GetConsoleVariableBoolValue(string VariableName) { return default; }
	public void QuitGame(UObject WorldContextObject,UObject SpecificPlayer,byte QuitPreference,bool bIgnorePlatformRestrictions) {}
	public void QuitEditor() {}
	public void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public void DelayUntilNextTick(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	public void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	public void MoveComponentTo(UObject Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,byte MoveAction,FLatentActionInfo LatentInfo) {}
	public FTimerHandle K2_SetTimerDelegate(FTimerDynamicDelegate Delegate,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	public FTimerHandle K2_SetTimerForNextTickDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	public bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	public bool K2_IsValidTimerHandle(FTimerHandle Handle) { return default; }
	public FTimerHandle K2_InvalidateTimerHandle(FTimerHandle Handle) { return default; }
	public void K2_ClearTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	public bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	public FTimerHandle K2_SetTimer(UObject Object,string FunctionName,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	public FTimerHandle K2_SetTimerForNextTick(UObject Object,string FunctionName) { return default; }
	public void K2_ClearTimer(UObject Object,string FunctionName) {}
	public void K2_PauseTimer(UObject Object,string FunctionName) {}
	public void K2_UnPauseTimer(UObject Object,string FunctionName) {}
	public bool K2_IsTimerActive(UObject Object,string FunctionName) { return default; }
	public bool K2_IsTimerPaused(UObject Object,string FunctionName) { return default; }
	public bool K2_TimerExists(UObject Object,string FunctionName) { return default; }
	public float K2_GetTimerElapsedTime(UObject Object,string FunctionName) { return default; }
	public float K2_GetTimerRemainingTime(UObject Object,string FunctionName) { return default; }
	public void SetIntPropertyByName(UObject Object,string PropertyName,int Value) {}
	public void SetInt64PropertyByName(UObject Object,string PropertyName,long Value) {}
	public void SetBytePropertyByName(UObject Object,string PropertyName,byte Value) {}
	public void SetDoublePropertyByName(UObject Object,string PropertyName,double Value) {}
	public void SetBoolPropertyByName(UObject Object,string PropertyName,bool Value) {}
	public void SetObjectPropertyByName(UObject Object,string PropertyName,UObject Value) {}
	public void SetClassPropertyByName(UObject Object,string PropertyName,UClass Value) {}
	public void SetInterfacePropertyByName(UObject Object,string PropertyName,object /*Value*/ Value) {}
	public void SetNamePropertyByName(UObject Object,string PropertyName,string Value) {}
	public void SetSoftObjectPropertyByName(UObject Object,string PropertyName,TSoftObjectPtr<UObject> Value) {}
	public void SetSoftClassPropertyByName(UObject Object,string PropertyName,TSoftObjectPtr<UClass> Value) {}
	public void SetStringPropertyByName(UObject Object,string PropertyName,string Value) {}
	public void SetTextPropertyByName(UObject Object,string PropertyName,string Value) {}
	public void SetVectorPropertyByName(UObject Object,string PropertyName,FVector Value) {}
	public void SetVector3fPropertyByName(UObject Object,string PropertyName,FVector3f Value) {}
	public void SetRotatorPropertyByName(UObject Object,string PropertyName,FRotator Value) {}
	public void SetLinearColorPropertyByName(UObject Object,string PropertyName,FLinearColor Value) {}
	public void SetColorPropertyByName(UObject Object,string PropertyName,FColor Value) {}
	public void SetTransformPropertyByName(UObject Object,string PropertyName,FTransform Value) {}
	public void SetCollisionProfileNameProperty(UObject Object,string PropertyName,FCollisionProfileName Value) {}
	public void SetFieldPathPropertyByName(UObject Object,string PropertyName,object Value) {}
	public void SetStructurePropertyByName(UObject Object,string PropertyName,FGenericStruct Value) {}
	public bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors) { return default; }
	public bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents) { return default; }
	public bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors) { return default; }
	public bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents) { return default; }
	public bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors) { return default; }
	public bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents) { return default; }
	public bool ComponentOverlapActors(UObject Component,FTransform ComponentTransform,TArray<byte> ObjectTypes,UClass ActorClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutActors) { return default; }
	public bool ComponentOverlapComponents(UObject Component,FTransform ComponentTransform,TArray<byte> ObjectTypes,UClass ComponentClassFilter,TArray<UObject> ActorsToIgnore,TArray<UObject> OutComponents) { return default; }
	public bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<byte> ObjectTypes,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,string ProfileName,bool bTraceComplex,TArray<UObject> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	public void GetActorListFromComponentList(TArray<UObject> ComponentList,UClass ActorClassFilter,TArray<UObject> OutActorList) {}
	public void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/,FVector YAxis/*=new FVector(0.0f,1.0f,0.0f)*/,FVector ZAxis/*=new FVector(0.0f,0.0f,1.0f)*/,bool bDrawAxis/*=false*/) {}
	public void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration/*=0.0f*/) {}
	public void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation/*=FRotator.ZeroRotator*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale/*=1.0f*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCone(UObject WorldContextObject,FVector Origin,FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length/*=100.0f*/,float AngleWidth/*=45.0f*/,float AngleHeight/*=45.0f*/,int NumSides/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugString(UObject WorldContextObject,FVector TextLocation,string Text,UObject TestBaseActor/*=NULL*/,FLinearColor TextColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public void FlushDebugStrings(UObject WorldContextObject) {}
	public void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public void FlushPersistentDebugLines(UObject WorldContextObject) {}
	public void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	public void DrawDebugCamera(UObject CameraActor,FLinearColor CameraColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	public FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory) { return default; }
	public void CreateCopyForUndoBuffer(UObject ObjectToModify) {}
	public void GetComponentBounds(UObject Component,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	public void GetActorBounds(UObject Actor,FVector Origin,FVector BoxExtent) {}
	public int GetRenderingDetailMode() { return default; }
	public int GetRenderingMaterialQualityLevel() { return default; }
	public bool GetSupportedFullscreenResolutions(TArray<FIntPoint> Resolutions) { return default; }
	public bool GetConvenientWindowedResolutions(TArray<FIntPoint> Resolutions) { return default; }
	public int GetMinYResolutionForUI() { return default; }
	public int GetMinYResolutionFor3DView() { return default; }
	public void LaunchURL(string URL) {}
	public bool CanLaunchURL(string URL) { return default; }
	public void CollectGarbage() {}
	public void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen) {}
	public int GetAdIDCount() { return default; }
	public void HideAdBanner() {}
	public void ForceCloseAdBanner() {}
	public void LoadInterstitialAd(int AdIdIndex) {}
	public bool IsInterstitialAdAvailable() { return default; }
	public bool IsInterstitialAdRequested() { return default; }
	public void ShowInterstitialAd() {}
	public void ShowPlatformSpecificLeaderboardScreen(string CategoryName) {}
	public void ShowPlatformSpecificAchievementsScreen(UObject SpecificPlayer) {}
	public bool IsLoggedIn(UObject SpecificPlayer) { return default; }
	public bool IsScreensaverEnabled() { return default; }
	public void ControlScreensaver(bool bAllowScreenSaver) {}
	public void SetVolumeButtonsHandledBySystem(bool bEnabled) {}
	public bool GetVolumeButtonsHandledBySystem() { return default; }
	public void SetGamepadsBlockDeviceFeedback(bool bBlock) {}
	public void ResetGamepadAssignments() {}
	public void ResetGamepadAssignmentToController(int ControllerId) {}
	public bool IsControllerAssignedToGamepad(int ControllerId) { return default; }
	public string GetGamepadControllerName(int ControllerId) { return default; }
	public UObject GetGamepadButtonGlyph(string ButtonKey,int ControllerIndex) { return default; }
	public void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState) {}
	public TArray<string> GetPreferredLanguages() { return default; }
	public string GetDefaultLanguage() { return default; }
	public string GetDefaultLocale() { return default; }
	public string GetLocalCurrencyCode() { return default; }
	public string GetLocalCurrencySymbol() { return default; }
	public void RegisterForRemoteNotifications() {}
	public void UnregisterForRemoteNotifications() {}
	public void SetUserActivity(FUserActivity UserActivity) {}
	public string GetCommandLine() { return default; }
	public void ParseCommandLine(string InCmdLine,TArray<string> OutTokens,TArray<string> OutSwitches,TMap<string,string> OutParams) {}
	public bool ParseParam(string InString,string InParam) { return default; }
	public bool ParseParamValue(string InString,string InParam,string OutValue) { return default; }
	public bool IsUnattended() { return default; }
	public bool GetEditorProperty(UObject Object,string PropertyName,int PropertyValue) { return default; }
	public bool SetEditorProperty(UObject Object,string PropertyName,int PropertyValue,EPropertyAccessChangeNotifyMode ChangeNotifyMode) { return default; }
	public int BeginTransaction(string Context,string Description,UObject PrimaryObject) { return default; }
	public int EndTransaction() { return default; }
	public void CancelTransaction(int Index) {}
	public void TransactObject(UObject Object) {}
	public void SnapshotObject(UObject Object) {}
	public UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public UClass GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public TSoftObjectPtr<UClass> GetSoftClassReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromObject(UObject Object) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromClass(UClass Class) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	public FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	public void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	public string Conv_PrimaryAssetIdToString(FPrimaryAssetId PrimaryAssetId) { return default; }
	public bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	public bool NotEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	public bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType) { return default; }
	public string Conv_PrimaryAssetTypeToString(FPrimaryAssetType PrimaryAssetType) { return default; }
	public bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	public bool NotEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	public void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId) {}
	public void UnloadPrimaryAssetList(TArray<FPrimaryAssetId> PrimaryAssetIdList) {}
	public bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId,bool bForceCurrentState,TArray<string> OutBundles) { return default; }
	public void GetPrimaryAssetsWithBundleState(TArray<string> RequiredBundles,TArray<string> ExcludedBundles,TArray<FPrimaryAssetType> ValidTypes,bool bForceCurrentState,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	public FARFilter MakeARFilter(TArray<string> PackageNames,TArray<string> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<string> ClassNames,TSet<string> RecursiveClassesExclusionSet,bool bRecursivePaths/*=false*/,bool bRecursiveClasses/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	public void BreakARFilter(FARFilter InARFilter,TArray<string> PackageNames,TArray<string> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<string> ClassNames,TSet<string> RecursiveClassesExclusionSet,bool bRecursivePaths,bool bRecursiveClasses,bool bIncludeOnlyOnDiskAssets) {}
}
