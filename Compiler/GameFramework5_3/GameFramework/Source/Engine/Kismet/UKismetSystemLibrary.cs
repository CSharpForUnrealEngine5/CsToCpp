namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetSystemLibrary.h")]
public partial class UKismetSystemLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Prints a stack trace to the log, so you can see how a blueprint got to this node</summary>
	public static void StackTrace() {}
	///<summary>Return true if the object is usable : non-null and not pending kill</summary>
	public static bool IsValid(UObject Object) { return default; }
	///<summary>Return true if the class is usable : non-null and not pending kill</summary>
	public static bool IsValidClass(UClass Class) { return default; }
	///<summary>Returns the actual object name.</summary>
	public static string GetObjectName(UObject Object) { return default; }
	///<summary>Returns the full path to the specified object as a string</summary>
	public static string GetPathName(UObject Object) { return default; }
	///<summary>Returns the full path to the specified object as a Soft Object Path</summary>
	public static FSoftObjectPath GetSoftObjectPath(UObject Object) { return default; }
	///<summary>Returns the full file system path to a UObject</summary>
	public static string GetSystemPath(UObject Object) { return default; }
	///<summary>Returns the display name (or actor label), for displaying as a debugging aid.</summary>
	public static string GetDisplayName(UObject Object) { return default; }
	///<summary>Returns the display name of a class</summary>
	public static string GetClassDisplayName(UClass Class) { return default; }
	///<summary>Returns the full path to the specified class as a Soft Class Path (that can be used as a Soft Object Path)</summary>
	public static FSoftClassPath GetSoftClassPath(UClass Class) { return default; }
	///<summary>Returns the full path to the specified class as a Top Level Asset Path used by asset utilities</summary>
	public static FTopLevelAssetPath GetClassTopLevelAssetPath(UClass Class) { return default; }
	///<summary>Returns the full path to the specified struct as a Top Level Asset Path used by asset utilities</summary>
	public static FTopLevelAssetPath GetStructTopLevelAssetPath(UScriptStruct Struct) { return default; }
	///<summary>Returns the full path to the specified enum as a Top Level Asset Path used by asset utilities</summary>
	public static FTopLevelAssetPath GetEnumTopLevelAssetPath(UEnum Enum) { return default; }
	///<summary>Returns the outer object of an object.</summary>
	public static UObject GetOuterObject(UObject Object) { return default; }
	///<summary>Engine build number, for displaying to end users.</summary>
	public static string GetEngineVersion() { return default; }
	///<summary>Build version, for displaying to end users in diagnostics.</summary>
	public static string GetBuildVersion() { return default; }
	///<summary>Build configuration, for displaying to end users in diagnostics.</summary>
	public static string GetBuildConfiguration() { return default; }
	///<summary>Get the name of the current game</summary>
	public static string GetGameName() { return default; }
	///<summary>Get the directory of the current project</summary>
	public static string GetProjectDirectory() { return default; }
	///<summary>Get the content directory of the current project</summary>
	public static string GetProjectContentDirectory() { return default; }
	///<summary>Get the saved directory of the current project</summary>
	public static string GetProjectSavedDirectory() { return default; }
	///<summary>Converts passed in filename to use a relative path</summary>
	public static string ConvertToRelativePath(string Filename) { return default; }
	///<summary>Converts passed in filename to use a absolute path</summary>
	public static string ConvertToAbsolutePath(string Filename) { return default; }
	///<summary>Convert all / and \ to TEXT(&quot;/&quot;)</summary>
	public static string NormalizeFilename(string InFilename) { return default; }
	///<summary>Retrieves the game&#39;s platform-specific bundle identifier or package name of the game</summary>
	public static string GetGameBundleId() { return default; }
	///<summary>Get the current user name from the OS</summary>
	public static string GetPlatformUserName() { return default; }
	///<summary>Get the current user dir from the OS</summary>
	public static string GetPlatformUserDir() { return default; }
	///<summary>Checks if this object implements a specific interface, works for both native and blueprint interfacse</summary>
	public static bool DoesImplementInterface(UObject TestObject,UClass Interface) { return default; }
	///<summary>Get the current game time, in seconds. This stops when the game is paused and is affected by slomo.</summary>
	public static double GetGameTimeInSeconds(UObject WorldContextObject) { return default; }
	///<summary>Returns the value of GFrameCounter, a running count of the number of frames that have occurred.</summary>
	public static long GetFrameCount() { return default; }
	///<summary>Returns the current platform time in seconds. Not coupled to any gameplay or other containerization logic - this</summary>
	public static double GetPlatformTime_Seconds() { return default; }
	///<summary>Returns whether the world this object is in is the host or not</summary>
	public static bool IsServer(UObject WorldContextObject) { return default; }
	///<summary>Returns whether this is running on a dedicated server</summary>
	public static bool IsDedicatedServer(UObject WorldContextObject) { return default; }
	///<summary>Returns whether this game instance is stand alone (no networking).</summary>
	public static bool IsStandalone(UObject WorldContextObject) { return default; }
	///<summary>IsSplitScreen</summary>
	public static bool IsSplitScreen(UObject WorldContextObject) { return default; }
	///<summary>Returns whether there are currently multiple local players in the given world</summary>
	public static bool HasMultipleLocalPlayers(UObject WorldContextObject) { return default; }
	///<summary>Returns whether this is a build that is packaged for distribution</summary>
	public static bool IsPackagedForDistribution() { return default; }
	///<summary>Returns the platform specific unique device id</summary>
	public static string GetUniqueDeviceId() { return default; }
	///<summary>Returns the platform specific unique device id</summary>
	public static string GetDeviceId() { return default; }
	///<summary>Casts from an object to a class, this will only work if the object is already a class</summary>
	public static UClass Conv_ObjectToClass(UObject Object,UClass Class) { return default; }
	///<summary>Converts an interfance into an object</summary>
	public static UObject Conv_InterfaceToObject(object /*Interface*/ Interface) { return default; }
	///<summary>Builds a Soft Object Path struct from a string that contains a full /folder/packagename.object path</summary>
	public static FSoftObjectPath MakeSoftObjectPath(string PathString) { return default; }
	///<summary>Gets the path string out of a Soft Object Path</summary>
	public static void BreakSoftObjectPath(FSoftObjectPath InSoftObjectPath,string PathString) {}
	///<summary>Converts a Soft Object Path into a base Soft Object Reference, this is not guaranteed to be resolvable</summary>
	public static TSoftObjectPtr<UObject> Conv_SoftObjPathToSoftObjRef(FSoftObjectPath SoftObjectPath) { return default; }
	///<summary>Converts a Soft Object Reference into a Soft Object Path</summary>
	public static FSoftObjectPath Conv_SoftObjRefToSoftObjPath(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	///<summary>Builds a TopLevelAssetPath struct from single Path string or from PackageName and AssetName string.</summary>
	public static FTopLevelAssetPath MakeTopLevelAssetPath(string PackageName,string AssetName) { return default; }
	///<summary>Gets the path string out of a TopLevelAssetPath</summary>
	public static void BreakTopLevelAssetPath(FTopLevelAssetPath TopLevelAssetPath,string PathString) {}
	///<summary>Builds a Soft Class Path struct from a string that contains a full /folder/packagename.class path.</summary>
	public static FSoftClassPath MakeSoftClassPath(string PathString) { return default; }
	///<summary>Gets the path string out of a Soft Class Path</summary>
	public static void BreakSoftClassPath(FSoftClassPath InSoftClassPath,string PathString) {}
	///<summary>Converts a Soft Class Path into a base Soft Class Reference, this is not guaranteed to be resolvable</summary>
	public static TSoftObjectPtr<UClass> Conv_SoftClassPathToSoftClassRef(FSoftClassPath SoftClassPath) { return default; }
	///<summary>Converts a Soft Class Reference into a Soft Class Path (which can be used like a Soft Object Path)</summary>
	public static FSoftClassPath Conv_SoftObjRefToSoftClassPath(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	///<summary>Returns true if the Soft Object Reference is not null</summary>
	public static bool IsValidSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	///<summary>Converts a Soft Object Reference to a path string</summary>
	public static string Conv_SoftObjectReferenceToString(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_SoftObjectReference(TSoftObjectPtr<UObject> A,TSoftObjectPtr<UObject> B) { return default; }
	///<summary>Resolves or loads a Soft Object Reference immediately, this will cause hitches and Async Load Asset should be used if possible</summary>
	public static UObject LoadAsset_Blocking(TSoftObjectPtr<UObject> Asset) { return default; }
	///<summary>Returns true if the Soft Class Reference is not null</summary>
	public static bool IsValidSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	///<summary>Converts a Soft Class Reference to a Top Level Asset Path used by asset utilities</summary>
	public static FTopLevelAssetPath GetSoftClassTopLevelAssetPath(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	///<summary>Converts a Soft Class Reference to a path string</summary>
	public static string Conv_SoftClassReferenceToString(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_SoftClassReference(TSoftObjectPtr<UClass> A,TSoftObjectPtr<UClass> B) { return default; }
	///<summary>Resolves or loads a Soft Class Reference immediately, this will cause hitches and Async Load Class Asset should be used if possible</summary>
	public static UClass LoadClassAsset_Blocking(TSoftObjectPtr<UClass> AssetClass) { return default; }
	///<summary>Internal functions used by K2Node_LoadAsset and K2Node_ConvertAsset</summary>
	public static UObject Conv_SoftObjectReferenceToObject(TSoftObjectPtr<UObject> SoftObject) { return default; }
	///<summary>Conv_SoftClassReferenceToClass</summary>
	public static UClass Conv_SoftClassReferenceToClass(TSoftObjectPtr<UClass> SoftClass) { return default; }
	///<summary>Conv_ObjectToSoftObjectReference</summary>
	public static TSoftObjectPtr<UObject> Conv_ObjectToSoftObjectReference(UObject Object) { return default; }
	///<summary>Conv_ClassToSoftClassReference</summary>
	public static TSoftObjectPtr<UClass> Conv_ClassToSoftClassReference(UClass Class) { return default; }
	///<summary>Conv_ComponentReferenceToSoftComponentReference</summary>
	public static FSoftComponentReference Conv_ComponentReferenceToSoftComponentReference(FComponentReference ComponentReference) { return default; }
	///<summary>FOnAssetLoaded</summary>
	public void FOnAssetLoaded(UObject Loaded) {}
	///<summary>LoadAsset</summary>
	public static void LoadAsset(UObject WorldContextObject,TSoftObjectPtr<UObject> Asset,FOnAssetLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	///<summary>FOnAssetClassLoaded</summary>
	public void FOnAssetClassLoaded(UClass Loaded) {}
	///<summary>LoadAssetClass</summary>
	public static void LoadAssetClass(UObject WorldContextObject,TSoftObjectPtr<UClass> AssetClass,FOnAssetClassLoaded OnLoaded,FLatentActionInfo LatentInfo) {}
	///<summary>Creates a literal integer</summary>
	public static int MakeLiteralInt(int Value) { return default; }
	///<summary>Creates a literal 64-bit integer</summary>
	public static long MakeLiteralInt64(long Value) { return default; }
	///<summary>Creates a literal float (double-precision)</summary>
	public static double MakeLiteralDouble(double Value) { return default; }
	///<summary>Creates a literal bool</summary>
	public static bool MakeLiteralBool(bool Value) { return default; }
	///<summary>Creates a literal name</summary>
	public static FName MakeLiteralName(FName Value) { return default; }
	///<summary>Creates a literal byte</summary>
	public static byte MakeLiteralByte(byte Value) { return default; }
	///<summary>Creates a literal string</summary>
	public static string MakeLiteralString(string Value) { return default; }
	///<summary>Creates a literal FText</summary>
	public static FText MakeLiteralText(FText Value) { return default; }
	///<summary>Prints a string to the log</summary>
	public static void LogString(string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToLog/*=true*/) {}
	///<summary>Prints a string to the log, and optionally, to the screen</summary>
	public static void PrintString(UObject WorldContextObject,string InString/*=new FString(TEXT("Hello"))*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,FName Key/*=NAME_None*/) {}
	///<summary>Prints text to the log, and optionally, to the screen</summary>
	public static void PrintText(UObject WorldContextObject,FText InText/*=INVTEXT("Hello")*/,bool bPrintToScreen/*=true*/,bool bPrintToLog/*=true*/,FLinearColor TextColor/*=new FLinearColor(0.0,0.66,1.0)*/,float Duration/*=2.0f*/,FName Key/*=NAME_None*/) {}
	///<summary>Prints a warning string to the log and the screen. Meant to be used as a way to inform the user that they misused the node.</summary>
	public static void PrintWarning(string InString) {}
	///<summary>Sets the game window title</summary>
	public static void SetWindowTitle(FText Title) {}
	///<summary>Executes a console command, optionally on a specific controller</summary>
	public static void ExecuteConsoleCommand(UObject WorldContextObject,string Command,APlayerController SpecificPlayer/*=NULL*/) {}
	///<summary>Attempts to retrieve the value of the specified string console variable, if it exists.</summary>
	public static string GetConsoleVariableStringValue(string VariableName) { return default; }
	///<summary>Attempts to retrieve the value of the specified float console variable, if it exists.</summary>
	public static float GetConsoleVariableFloatValue(string VariableName) { return default; }
	///<summary>Attempts to retrieve the value of the specified integer console variable, if it exists.</summary>
	public static int GetConsoleVariableIntValue(string VariableName) { return default; }
	///<summary>Evaluates, if it exists, whether the specified integer console variable has a non-zero value (true) or not (false).</summary>
	public static bool GetConsoleVariableBoolValue(string VariableName) { return default; }
	///<summary>Exit the current game</summary>
	public static void QuitGame(UObject WorldContextObject,APlayerController SpecificPlayer,EQuitPreference QuitPreference,bool bIgnorePlatformRestrictions) {}
	///<summary>Exit the editor</summary>
	public static void QuitEditor() {}
	///<summary>Perform a latent action with a delay (specified in seconds).  Calling again while it is counting down will be ignored.</summary>
	public static void Delay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	///<summary>Perform a latent action with a delay of one tick.  Calling again while it is counting down will be ignored.</summary>
	public static void DelayUntilNextTick(UObject WorldContextObject,FLatentActionInfo LatentInfo) {}
	///<summary>Perform a latent action with a retriggerable delay (specified in seconds).  Calling again while it is counting down will reset the countdown to Duration.</summary>
	public static void RetriggerableDelay(UObject WorldContextObject,float Duration,FLatentActionInfo LatentInfo) {}
	///<summary>* Interpolate a component to the specified relative location and rotation over the course of OverTime seconds.</summary>
	public static void MoveComponentTo(USceneComponent Component,FVector TargetRelativeLocation,FRotator TargetRelativeRotation,bool bEaseOut,bool bEaseIn,float OverTime,bool bForceShortestRotationPath,EMoveComponentAction MoveAction,FLatentActionInfo LatentInfo) {}
	///<summary>Set a timer to execute delegate. Setting an existing timer will reset that timer with updated parameters.</summary>
	public static FTimerHandle K2_SetTimerDelegate(FTimerDynamicDelegate Delegate,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	///<summary>Set a timer to execute a delegate next tick.</summary>
	public static FTimerHandle K2_SetTimerForNextTickDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Clears a set timer.</summary>
	public static void K2_ClearTimerDelegate(FTimerDynamicDelegate Delegate) {}
	///<summary>Pauses a set timer at its current elapsed time.</summary>
	public static void K2_PauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	///<summary>Resumes a paused timer from its current elapsed time.</summary>
	public static void K2_UnPauseTimerDelegate(FTimerDynamicDelegate Delegate) {}
	///<summary>Returns true if a timer exists and is active for the given delegate, false otherwise.</summary>
	public static bool K2_IsTimerActiveDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Returns true if a timer exists and is paused for the given delegate, false otherwise.</summary>
	public static bool K2_IsTimerPausedDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Returns true is a timer for the given delegate exists, false otherwise.</summary>
	public static bool K2_TimerExistsDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Returns elapsed time for the given delegate (time since current countdown iteration began).</summary>
	public static float K2_GetTimerElapsedTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Returns time until the timer will next execute its delegate.</summary>
	public static float K2_GetTimerRemainingTimeDelegate(FTimerDynamicDelegate Delegate) { return default; }
	///<summary>Returns whether the timer handle is valid. This does not indicate that there is an active timer that this handle references, but rather that it once referenced a valid timer.</summary>
	public static bool K2_IsValidTimerHandle(FTimerHandle Handle) { return default; }
	///<summary>Invalidate the supplied TimerHandle and return it.</summary>
	public static FTimerHandle K2_InvalidateTimerHandle(FTimerHandle Handle) { return default; }
	///<summary>Clears a set timer.</summary>
	public static void K2_ClearTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	///<summary>Clears a set timer.</summary>
	public static void K2_ClearAndInvalidateTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	///<summary>Pauses a set timer at its current elapsed time.</summary>
	public static void K2_PauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	///<summary>Resumes a paused timer from its current elapsed time.</summary>
	public static void K2_UnPauseTimerHandle(UObject WorldContextObject,FTimerHandle Handle) {}
	///<summary>Returns true if a timer exists and is active for the given handle, false otherwise.</summary>
	public static bool K2_IsTimerActiveHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	///<summary>Returns true if a timer exists and is paused for the given handle, false otherwise.</summary>
	public static bool K2_IsTimerPausedHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	///<summary>Returns true is a timer for the given handle exists, false otherwise.</summary>
	public static bool K2_TimerExistsHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	///<summary>Returns elapsed time for the given handle (time since current countdown iteration began).</summary>
	public static float K2_GetTimerElapsedTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	///<summary>Returns time until the timer will next execute its handle.</summary>
	public static float K2_GetTimerRemainingTimeHandle(UObject WorldContextObject,FTimerHandle Handle) { return default; }
	///<summary>Set a timer to execute delegate. Setting an existing timer will reset that timer with updated parameters.</summary>
	public static FTimerHandle K2_SetTimer(UObject Object,string FunctionName,float Time,bool bLooping,float InitialStartDelay/*=0.0f*/,float InitialStartDelayVariance/*=0.0f*/) { return default; }
	///<summary>Set a timer to execute a delegate on the next tick.</summary>
	public static FTimerHandle K2_SetTimerForNextTick(UObject Object,string FunctionName) { return default; }
	///<summary>Clears a set timer.</summary>
	public static void K2_ClearTimer(UObject Object,string FunctionName) {}
	///<summary>Pauses a set timer at its current elapsed time.</summary>
	public static void K2_PauseTimer(UObject Object,string FunctionName) {}
	///<summary>Resumes a paused timer from its current elapsed time.</summary>
	public static void K2_UnPauseTimer(UObject Object,string FunctionName) {}
	///<summary>Returns true if a timer exists and is active for the given delegate, false otherwise.</summary>
	public static bool K2_IsTimerActive(UObject Object,string FunctionName) { return default; }
	///<summary>Returns true if a timer exists and is paused for the given delegate, false otherwise.</summary>
	public static bool K2_IsTimerPaused(UObject Object,string FunctionName) { return default; }
	///<summary>Returns true is a timer for the given delegate exists, false otherwise.</summary>
	public static bool K2_TimerExists(UObject Object,string FunctionName) { return default; }
	///<summary>Returns elapsed time for the given delegate (time since current countdown iteration began).</summary>
	public static float K2_GetTimerElapsedTime(UObject Object,string FunctionName) { return default; }
	///<summary>Returns time until the timer will next execute its delegate.</summary>
	public static float K2_GetTimerRemainingTime(UObject Object,string FunctionName) { return default; }
	///<summary>Set an int32 property by name</summary>
	public static void SetIntPropertyByName(UObject Object,FName PropertyName,int Value) {}
	///<summary>Set an int64 property by name</summary>
	public static void SetInt64PropertyByName(UObject Object,FName PropertyName,long Value) {}
	///<summary>Set an uint8 or enum property by name</summary>
	public static void SetBytePropertyByName(UObject Object,FName PropertyName,byte Value) {}
	///<summary>Set a double property by name</summary>
	public static void SetDoublePropertyByName(UObject Object,FName PropertyName,double Value) {}
	///<summary>Set a bool property by name</summary>
	public static void SetBoolPropertyByName(UObject Object,FName PropertyName,bool Value) {}
	///<summary>Set an OBJECT property by name</summary>
	public static void SetObjectPropertyByName(UObject Object,FName PropertyName,UObject Value) {}
	///<summary>Set a CLASS property by name</summary>
	public static void SetClassPropertyByName(UObject Object,FName PropertyName,UClass Value) {}
	///<summary>Set an INTERFACE property by name</summary>
	public static void SetInterfacePropertyByName(UObject Object,FName PropertyName,object /*Value*/ Value) {}
	///<summary>Set a NAME property by name</summary>
	public static void SetNamePropertyByName(UObject Object,FName PropertyName,FName Value) {}
	///<summary>Set a SOFTOBJECT property by name</summary>
	public static void SetSoftObjectPropertyByName(UObject Object,FName PropertyName,TSoftObjectPtr<UObject> Value) {}
	///<summary>Set a SOFTCLASS property by name</summary>
	public static void SetSoftClassPropertyByName(UObject Object,FName PropertyName,TSoftObjectPtr<UClass> Value) {}
	///<summary>Set a STRING property by name</summary>
	public static void SetStringPropertyByName(UObject Object,FName PropertyName,string Value) {}
	///<summary>Set a TEXT property by name</summary>
	public static void SetTextPropertyByName(UObject Object,FName PropertyName,FText Value) {}
	///<summary>Set a VECTOR property by name</summary>
	public static void SetVectorPropertyByName(UObject Object,FName PropertyName,FVector Value) {}
	///<summary>Set a VECTOR3F property by name</summary>
	public static void SetVector3fPropertyByName(UObject Object,FName PropertyName,FVector3f Value) {}
	///<summary>Set a ROTATOR property by name</summary>
	public static void SetRotatorPropertyByName(UObject Object,FName PropertyName,FRotator Value) {}
	///<summary>Set a LINEAR COLOR property by name</summary>
	public static void SetLinearColorPropertyByName(UObject Object,FName PropertyName,FLinearColor Value) {}
	///<summary>Set a COLOR property by name</summary>
	public static void SetColorPropertyByName(UObject Object,FName PropertyName,FColor Value) {}
	///<summary>Set a TRANSFORM property by name</summary>
	public static void SetTransformPropertyByName(UObject Object,FName PropertyName,FTransform Value) {}
	///<summary>Set a CollisionProfileName property by name</summary>
	public static void SetCollisionProfileNameProperty(UObject Object,FName PropertyName,FCollisionProfileName Value) {}
	///<summary>Set a SOFTOBJECT property by name</summary>
	public static void SetFieldPathPropertyByName(UObject Object,FName PropertyName,object Value) {}
	///<summary>Set a custom structure property by name</summary>
	public static void SetStructurePropertyByName(UObject Object,FName PropertyName,FGenericStruct Value) {}
	///<summary>Returns an array of actors that overlap the given sphere.</summary>
	public static bool SphereOverlapActors(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	///<summary>Returns an array of components that overlap the given sphere.</summary>
	public static bool SphereOverlapComponents(UObject WorldContextObject,FVector SpherePos,float SphereRadius,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	///<summary>Returns an array of actors that overlap the given axis-aligned box.</summary>
	public static bool BoxOverlapActors(UObject WorldContextObject,FVector BoxPos,FVector BoxExtent,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	///<summary>Returns an array of components that overlap the given axis-aligned box.</summary>
	public static bool BoxOverlapComponents(UObject WorldContextObject,FVector BoxPos,FVector Extent,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	///<summary>Returns an array of actors that overlap the given capsule.</summary>
	public static bool CapsuleOverlapActors(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	///<summary>Returns an array of components that overlap the given capsule.</summary>
	public static bool CapsuleOverlapComponents(UObject WorldContextObject,FVector CapsulePos,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	///<summary>Returns an array of actors that overlap the given component.</summary>
	public static bool ComponentOverlapActors(UPrimitiveComponent Component,FTransform ComponentTransform,TArray<EObjectTypeQuery> ObjectTypes,UClass ActorClassFilter,TArray<AActor> ActorsToIgnore,TArray<AActor> OutActors) { return default; }
	///<summary>Returns an array of components that overlap the given component.</summary>
	public static bool ComponentOverlapComponents(UPrimitiveComponent Component,FTransform ComponentTransform,TArray<EObjectTypeQuery> ObjectTypes,UClass ComponentClassFilter,TArray<AActor> ActorsToIgnore,TArray<UPrimitiveComponent> OutComponents) { return default; }
	///<summary>Does a collision trace along the given line and returns the first blocking hit encountered.</summary>
	public static bool LineTraceSingle(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Does a collision trace along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
	public static bool LineTraceMulti(UObject WorldContextObject,FVector Start,FVector End,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a sphere along the given line and returns the first blocking hit encountered.</summary>
	public static bool SphereTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a sphere along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
	public static bool SphereTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a box along the given line and returns the first blocking hit encountered.</summary>
	public static bool BoxTraceSingle(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a box along the given line and returns all hits encountered.</summary>
	public static bool BoxTraceMulti(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a capsule along the given line and returns the first blocking hit encountered.</summary>
	public static bool CapsuleTraceSingle(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a capsule along the given line and returns all hits encountered up to and including the first blocking hit.</summary>
	public static bool CapsuleTraceMulti(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,ETraceTypeQuery TraceChannel,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Does a collision trace along the given line and returns the first hit encountered.</summary>
	public static bool LineTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Does a collision trace along the given line and returns all hits encountered.</summary>
	public static bool LineTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a sphere along the given line and returns the first hit encountered.</summary>
	public static bool SphereTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a sphere along the given line and returns all hits encountered.</summary>
	public static bool SphereTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a box along the given line and returns the first hit encountered.</summary>
	public static bool BoxTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a box along the given line and returns all hits encountered.</summary>
	public static bool BoxTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a capsule along the given line and returns the first hit encountered.</summary>
	public static bool CapsuleTraceSingleForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweeps a capsule along the given line and returns all hits encountered.</summary>
	public static bool CapsuleTraceMultiForObjects(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,TArray<EObjectTypeQuery> ObjectTypes,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Trace a ray against the world using a specific profile and return the first blocking hit</summary>
	public static bool LineTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Trace a ray against the world using a specific profile and return overlapping hits and then first blocking hit</summary>
	public static bool LineTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a sphere against the world and return the first blocking hit using a specific profile</summary>
	public static bool SphereTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a sphere against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit</summary>
	public static bool SphereTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a box against the world and return the first blocking hit using a specific profile</summary>
	public static bool BoxTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a box against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit</summary>
	public static bool BoxTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,FVector HalfSize,FRotator Orientation,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a capsule against the world and return the first blocking hit using a specific profile</summary>
	public static bool CapsuleTraceSingleByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,FHitResult OutHit,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Sweep a capsule against the world and return all initial overlaps using a specific profile, then overlapping hits and then first blocking hit</summary>
	public static bool CapsuleTraceMultiByProfile(UObject WorldContextObject,FVector Start,FVector End,float Radius,float HalfHeight,FName ProfileName,bool bTraceComplex,TArray<AActor> ActorsToIgnore,EDrawDebugTrace DrawDebugType,TArray<FHitResult> OutHits,bool bIgnoreSelf,FLinearColor TraceColor/*=FLinearColor.Red*/,FLinearColor TraceHitColor/*=FLinearColor.Green*/,float DrawTime/*=5.0f*/) { return default; }
	///<summary>Returns an array of unique actors represented by the given list of components.</summary>
	public static void GetActorListFromComponentList(TArray<UPrimitiveComponent> ComponentList,UClass ActorClassFilter,TArray<AActor> OutActorList) {}
	///<summary>Draw a debug line</summary>
	public static void DrawDebugLine(UObject WorldContextObject,FVector LineStart,FVector LineEnd,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug circle!</summary>
	public static void DrawDebugCircle(UObject WorldContextObject,FVector Center,float Radius,int NumSegments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/,FVector YAxis/*=new FVector(0.0f,1.0f,0.0f)*/,FVector ZAxis/*=new FVector(0.0f,0.0f,1.0f)*/,bool bDrawAxis/*=false*/) {}
	///<summary>Draw a debug point</summary>
	public static void DrawDebugPoint(UObject WorldContextObject,FVector Position,float Size,FLinearColor PointColor,float Duration/*=0.0f*/) {}
	///<summary>Draw directional arrow, pointing from LineStart to LineEnd.</summary>
	public static void DrawDebugArrow(UObject WorldContextObject,FVector LineStart,FVector LineEnd,float ArrowSize,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug box</summary>
	public static void DrawDebugBox(UObject WorldContextObject,FVector Center,FVector Extent,FLinearColor LineColor,FRotator Rotation/*=FRotator.ZeroRotator*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug coordinate system.</summary>
	public static void DrawDebugCoordinateSystem(UObject WorldContextObject,FVector AxisLoc,FRotator AxisRot,float Scale/*=1.0f*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug sphere</summary>
	public static void DrawDebugSphere(UObject WorldContextObject,FVector Center,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug cylinder</summary>
	public static void DrawDebugCylinder(UObject WorldContextObject,FVector Start,FVector End,float Radius/*=100.0f*/,int Segments/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug cone</summary>
	public static void DrawDebugCone(UObject WorldContextObject,FVector Origin,FVector Direction,float Length,float AngleWidth,float AngleHeight,int NumSides,FLinearColor LineColor,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug cone</summary>
	public static void DrawDebugConeInDegrees(UObject WorldContextObject,FVector Origin,FVector Direction,float Length/*=100.0f*/,float AngleWidth/*=45.0f*/,float AngleHeight/*=45.0f*/,int NumSides/*=12*/,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug capsule</summary>
	public static void DrawDebugCapsule(UObject WorldContextObject,FVector Center,float HalfHeight,float Radius,FRotator Rotation,FLinearColor LineColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug string at a 3d world location.</summary>
	public static void DrawDebugString(UObject WorldContextObject,FVector TextLocation,string Text,AActor TestBaseActor/*=NULL*/,FLinearColor TextColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	///<summary>Removes all debug strings.</summary>
	public static void FlushDebugStrings(UObject WorldContextObject) {}
	///<summary>Draws a debug plane.</summary>
	public static void DrawDebugPlane(UObject WorldContextObject,FPlane PlaneCoordinates,FVector Location,float Size,FLinearColor PlaneColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	///<summary>Flush all persistent debug lines and shapes.</summary>
	public static void FlushPersistentDebugLines(UObject WorldContextObject) {}
	///<summary>Draws a debug frustum.</summary>
	public static void DrawDebugFrustum(UObject WorldContextObject,FTransform FrustumTransform,FLinearColor FrustumColor/*=FLinearColor.White*/,float Duration/*=0.0f*/,float Thickness/*=0.0f*/) {}
	///<summary>Draw a debug camera shape.</summary>
	public static void DrawDebugCamera(ACameraActor CameraActor,FLinearColor CameraColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	///<summary>Draws a 2D Histogram of size &#39;DrawSize&#39; based FDebugFloatHistory struct, using DrawTransform for the position in the world.</summary>
	public static void DrawDebugFloatHistoryTransform(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FTransform DrawTransform,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	///<summary>Draws a 2D Histogram of size &#39;DrawSize&#39; based FDebugFloatHistory struct, using DrawLocation for the location in the world, rotation will face camera of first player.</summary>
	public static void DrawDebugFloatHistoryLocation(UObject WorldContextObject,FDebugFloatHistory FloatHistory,FVector DrawLocation,FVector2D DrawSize,FLinearColor DrawColor/*=FLinearColor.White*/,float Duration/*=0.0f*/) {}
	///<summary>AddFloatHistorySample</summary>
	public static FDebugFloatHistory AddFloatHistorySample(float Value,FDebugFloatHistory FloatHistory) { return default; }
	///<summary>Mark as modified.</summary>
	public static void CreateCopyForUndoBuffer(UObject ObjectToModify) {}
	///<summary>Get bounds</summary>
	public static void GetComponentBounds(USceneComponent Component,FVector Origin,FVector BoxExtent,float SphereRadius) {}
	///<summary>GetActorBounds</summary>
	public static void GetActorBounds(AActor Actor,FVector Origin,FVector BoxExtent) {}
	///<summary>Get the clamped state of r.DetailMode, see console variable help (allows for scalability, cannot be used in construction scripts)</summary>
	public static int GetRenderingDetailMode() { return default; }
	///<summary>Get the clamped state of r.MaterialQualityLevel, see console variable help (allows for scalability, cannot be used in construction scripts)</summary>
	public static int GetRenderingMaterialQualityLevel() { return default; }
	///<summary>Gets the list of support fullscreen resolutions.</summary>
	public static bool GetSupportedFullscreenResolutions(TArray<FIntPoint> Resolutions) { return default; }
	///<summary>Gets the list of windowed resolutions which are convenient for the current primary display size.</summary>
	public static bool GetConvenientWindowedResolutions(TArray<FIntPoint> Resolutions) { return default; }
	///<summary>Gets the smallest Y resolution we want to support in the UI, clamped within reasons</summary>
	public static int GetMinYResolutionForUI() { return default; }
	///<summary>Gets the smallest Y resolution we want to support in the 3D view, clamped within reasons</summary>
	public static int GetMinYResolutionFor3DView() { return default; }
	///<summary>Opens the specified URL in the platform&#39;s web browser of choice</summary>
	public static void LaunchURL(string URL) {}
	///<summary>CanLaunchURL</summary>
	public static bool CanLaunchURL(string URL) { return default; }
	///<summary>Deletes all unreferenced objects, keeping only referenced objects (this command will be queued and happen at the end of the frame)</summary>
	public static void CollectGarbage() {}
	///<summary>Will show an ad banner (iAd on iOS, or AdMob on Android) on the top or bottom of screen, on top of the GL view (doesn&#39;t resize the view)</summary>
	public static void ShowAdBanner(int AdIdIndex,bool bShowOnBottomOfScreen) {}
	///<summary>Retrieves the total number of Ad IDs that can be selected between</summary>
	public static int GetAdIDCount() { return default; }
	///<summary>Hides the ad banner (iAd on iOS, or AdMob on Android). Will force close the ad if it&#39;s open</summary>
	public static void HideAdBanner() {}
	///<summary>Forces closed any displayed ad. Can lead to loss of revenue</summary>
	public static void ForceCloseAdBanner() {}
	///<summary>Will load a fullscreen interstitial AdMob ad. Call this before using ShowInterstitialAd</summary>
	public static void LoadInterstitialAd(int AdIdIndex) {}
	///<summary>Returns true if the requested interstitial ad is loaded and ready</summary>
	public static bool IsInterstitialAdAvailable() { return default; }
	///<summary>Returns true if the requested interstitial ad has been successfully requested (false if load request fails)</summary>
	public static bool IsInterstitialAdRequested() { return default; }
	///<summary>Shows the loaded interstitial ad (loaded with LoadInterstitialAd)</summary>
	public static void ShowInterstitialAd() {}
	///<summary>Displays the built-in leaderboard GUI (iOS and Android only; this function may be renamed or moved in a future release)</summary>
	public static void ShowPlatformSpecificLeaderboardScreen(string CategoryName) {}
	///<summary>Displays the built-in achievements GUI (iOS and Android only; this function may be renamed or moved in a future release)</summary>
	public static void ShowPlatformSpecificAchievementsScreen(APlayerController SpecificPlayer) {}
	///<summary>Returns whether the player is logged in to the currently active online subsystem.</summary>
	public static bool IsLoggedIn(APlayerController SpecificPlayer) { return default; }
	///<summary>Returns true if screen saver is enabled.</summary>
	public static bool IsScreensaverEnabled() { return default; }
	///<summary>Allows or inhibits screensaver</summary>
	public static void ControlScreensaver(bool bAllowScreenSaver) {}
	///<summary>Allows or inhibits system default handling of volume up and volume down buttons (Android only)</summary>
	public static void SetVolumeButtonsHandledBySystem(bool bEnabled) {}
	///<summary>Returns true if system default handling of volume up and volume down buttons enabled (Android only)</summary>
	public static bool GetVolumeButtonsHandledBySystem() { return default; }
	///<summary>Sets whether attached gamepads will block feedback from the device itself (Mobile only).</summary>
	public static void SetGamepadsBlockDeviceFeedback(bool bBlock) {}
	///<summary>Resets the gamepad to player controller id assignments (Android and iOS only)</summary>
	public static void ResetGamepadAssignments() {}
	///<summary>* Resets the gamepad assignment to player controller id (Android and iOS only)</summary>
	public static void ResetGamepadAssignmentToController(int ControllerId) {}
	///<summary>Returns true if controller id assigned to a gamepad (Android and iOS only)</summary>
	public static bool IsControllerAssignedToGamepad(int ControllerId) { return default; }
	///<summary>Returns name of controller if assigned to a gamepad (or None if not assigned) (Android and iOS only)</summary>
	public static string GetGamepadControllerName(int ControllerId) { return default; }
	///<summary>Returns glyph assigned to a gamepad button (or a null ptr if not assigned) (iOS and tvOS only)</summary>
	public static UTexture2D GetGamepadButtonGlyph(string ButtonKey,int ControllerIndex) { return default; }
	///<summary>Sets the state of the transition message rendered by the viewport. (The blue text displayed when the game is paused and so forth.)</summary>
	public static void SetSuppressViewportTransitionMessage(UObject WorldContextObject,bool bState) {}
	///<summary>Returns an array of the user&#39;s preferred languages in order of preference</summary>
	public static TArray<string> GetPreferredLanguages() { return default; }
	///<summary>Get the default language (for localization) used by this platform</summary>
	public static string GetDefaultLanguage() { return default; }
	///<summary>Get the default locale (for internationalization) used by this platform</summary>
	public static string GetDefaultLocale() { return default; }
	///<summary>Returns the currency code associated with the device&#39;s locale</summary>
	public static string GetLocalCurrencyCode() { return default; }
	///<summary>Returns the currency symbol associated with the device&#39;s locale</summary>
	public static string GetLocalCurrencySymbol() { return default; }
	///<summary>Requests permission to send remote notifications to the user&#39;s device.</summary>
	public static void RegisterForRemoteNotifications() {}
	///<summary>Requests Requests unregistering from receiving remote notifications to the user&#39;s device.</summary>
	public static void UnregisterForRemoteNotifications() {}
	///<summary>Tells the engine what the user is doing for debug, analytics, etc.</summary>
	public static void SetUserActivity(FUserActivity UserActivity) {}
	///<summary>Returns the command line that the process was launched with.</summary>
	public static string GetCommandLine() { return default; }
	///<summary>* Parses the given string into loose tokens, switches (arguments that begin with - or /) and parameters (-mySwitch=myVar)</summary>
	public static void ParseCommandLine(string InCmdLine,TArray<string> OutTokens,TArray<string> OutSwitches,TMap<string,string> OutParams) {}
	///<summary>Returns true if the string has -param in it (do not specify the leading -)</summary>
	public static bool ParseParam(string InString,string InParam) { return default; }
	///<summary>Returns &#39;value&#39; if -option=value is in the string</summary>
	public static bool ParseParamValue(string InString,string InParam,string OutValue) { return default; }
	///<summary>Returns true if running unattended (-unattended is on the command line)</summary>
	public static bool IsUnattended() { return default; }
	///<summary>Attempts to retrieve the value of a named property from the given object.</summary>
	public static bool GetEditorProperty(UObject Object,FName PropertyName,int PropertyValue) { return default; }
	///<summary>Attempts to set the value of a named property on the given object.</summary>
	public static bool SetEditorProperty(UObject Object,FName PropertyName,int PropertyValue,EPropertyAccessChangeNotifyMode ChangeNotifyMode) { return default; }
	///<summary>Begin a new undo transaction. An undo transaction is defined as all actions which take place when the user selects &quot;undo&quot; a single time.</summary>
	public static int BeginTransaction(string Context,FText Description,UObject PrimaryObject) { return default; }
	///<summary>Attempt to end the current undo transaction. Only successful if the transaction&#39;s action counter is 1.</summary>
	public static int EndTransaction() { return default; }
	///<summary>Cancel the current transaction, and no longer capture actions to be placed in the undo buffer.</summary>
	public static void CancelTransaction(int Index) {}
	///<summary>Notify the current transaction (if any) that this object is about to be modified and should be placed into the undo buffer.</summary>
	public static void TransactObject(UObject Object) {}
	///<summary>Notify the current transaction (if any) that this object is about to be modified and should be snapshot for intermediate update.</summary>
	public static void SnapshotObject(UObject Object) {}
	///<summary>Returns the Object associated with a Primary Asset Id, this will only return a valid object if it is in memory, it will not load it</summary>
	public static UObject GetObjectFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Returns the Blueprint Class associated with a Primary Asset Id, this will only return a valid object if it is in memory, it will not load it</summary>
	public static UClass GetClassFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Returns the Object Id associated with a Primary Asset Id, this works even if the asset is not loaded</summary>
	public static TSoftObjectPtr<UObject> GetSoftObjectReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Returns the Blueprint Class Id associated with a Primary Asset Id, this works even if the asset is not loaded</summary>
	public static TSoftObjectPtr<UClass> GetSoftClassReferenceFromPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Returns the Primary Asset Id for an Object, this can return an invalid one if not registered</summary>
	public static FPrimaryAssetId GetPrimaryAssetIdFromObject(UObject Object) { return default; }
	///<summary>Returns the Primary Asset Id for a Class, this can return an invalid one if not registered</summary>
	public static FPrimaryAssetId GetPrimaryAssetIdFromClass(UClass Class) { return default; }
	///<summary>Returns the Primary Asset Id for a Soft Object Reference, this can return an invalid one if not registered</summary>
	public static FPrimaryAssetId GetPrimaryAssetIdFromSoftObjectReference(TSoftObjectPtr<UObject> SoftObjectReference) { return default; }
	///<summary>Returns the Primary Asset Id for a Soft Class Reference, this can return an invalid one if not registered</summary>
	public static FPrimaryAssetId GetPrimaryAssetIdFromSoftClassReference(TSoftObjectPtr<UClass> SoftClassReference) { return default; }
	///<summary>Returns list of PrimaryAssetIds for a PrimaryAssetType</summary>
	public static void GetPrimaryAssetIdList(FPrimaryAssetType PrimaryAssetType,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	///<summary>Returns true if the Primary Asset Id is valid</summary>
	public static bool IsValidPrimaryAssetId(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Converts a Primary Asset Id to a string. The other direction is not provided because it cannot be validated</summary>
	public static string Conv_PrimaryAssetIdToString(FPrimaryAssetId PrimaryAssetId) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_PrimaryAssetId(FPrimaryAssetId A,FPrimaryAssetId B) { return default; }
	///<summary>Returns list of Primary Asset Ids for a PrimaryAssetType</summary>
	public static bool IsValidPrimaryAssetType(FPrimaryAssetType PrimaryAssetType) { return default; }
	///<summary>Converts a Primary Asset Type to a string. The other direction is not provided because it cannot be validated</summary>
	public static string Conv_PrimaryAssetTypeToString(FPrimaryAssetType PrimaryAssetType) { return default; }
	///<summary>Returns true if the values are equal (A == B)</summary>
	public static bool EqualEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	///<summary>Returns true if the values are not equal (A != B)</summary>
	public static bool NotEqual_PrimaryAssetType(FPrimaryAssetType A,FPrimaryAssetType B) { return default; }
	///<summary>Unloads a primary asset, which allows it to be garbage collected if nothing else is referencing it</summary>
	public static void UnloadPrimaryAsset(FPrimaryAssetId PrimaryAssetId) {}
	///<summary>Unloads a primary asset, which allows it to be garbage collected if nothing else is referencing it</summary>
	public static void UnloadPrimaryAssetList(TArray<FPrimaryAssetId> PrimaryAssetIdList) {}
	///<summary>Returns the list of loaded bundles for a given Primary Asset. This will return false if the asset is not loaded at all.</summary>
	public static bool GetCurrentBundleState(FPrimaryAssetId PrimaryAssetId,bool bForceCurrentState,TArray<FName> OutBundles) { return default; }
	///<summary>Returns the list of assets that are in a given bundle state. Required Bundles must be specified</summary>
	public static void GetPrimaryAssetsWithBundleState(TArray<FName> RequiredBundles,TArray<FName> ExcludedBundles,TArray<FPrimaryAssetType> ValidTypes,bool bForceCurrentState,TArray<FPrimaryAssetId> OutPrimaryAssetIdList) {}
	///<summary>Builds an ARFilter struct. You should be using ClassPaths and RecursiveClassPathsExclusionSet, ClassNames and RecursiveClassesExclusionSet are deprecated.</summary>
	public static FARFilter MakeARFilter(TArray<FName> PackageNames,TArray<FName> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<FName> ClassNames,TSet<FName> RecursiveClassesExclusionSet,bool bRecursivePaths/*=false*/,bool bRecursiveClasses/*=false*/,bool bIncludeOnlyOnDiskAssets/*=false*/) { return default; }
	///<summary>Breaks an ARFilter struct into its component pieces. You should be using ClassPaths and RecursiveClassPathsExclusionSet from this node, ClassNames and RecursiveClassesExclusionSet are deprecated.</summary>
	public static void BreakARFilter(FARFilter InARFilter,TArray<FName> PackageNames,TArray<FName> PackagePaths,TArray<FSoftObjectPath> SoftObjectPaths,TArray<FTopLevelAssetPath> ClassPaths,TSet<FTopLevelAssetPath> RecursiveClassPathsExclusionSet,TArray<FName> ClassNames,TSet<FName> RecursiveClassesExclusionSet,bool bRecursivePaths,bool bRecursiveClasses,bool bIncludeOnlyOnDiskAssets) {}
}
