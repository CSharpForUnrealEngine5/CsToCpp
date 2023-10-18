using CSharpToCpp.Utilities;

#pragma warning disable IDE0060
#pragma warning disable CA1822
#pragma warning disable CS8603
#pragma warning disable CS8618,CS8603,CS1587,CS1591

namespace GameFramework;


public partial class UObject
{
    //TODO: Serialization

    /// <summary>
    /// This is a psudeo-function that places cppCpde
    /// directly in the C++ source file
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="cppCode"></param>
    /// <returns></returns>
    public T Code<T>(string cppCode) { return default(T); }
    public string TEXT(string Text) { return Text; }

    [CppCode("GameViewport", "GEngine->GameViewport")]
    public UViewport GameViewport;

    [CppCode("Log", "GLog->Log")]
    public void Log(string message) { }

    [CppCode("Log", "GLog->Log")]
    public void Log(ELogVerbosity verbosity, string message) { }

    [CppCode("Log", "GLog->Log")]
    public void Log(string category, ELogVerbosity verbosity, string message) { }
    [CppCode("AddOnScreenDebugMessage", "GEngine->AddOnScreenDebugMessage")]
    public void AddOnScreenDebugMessage(int Key, float TimeToDisplay, FColor DisplayColor, string DebugMessage, bool bNewerOnTop, FVector2D TextScale) { }
    [CppCode("AddOnScreenDebugMessage", "GEngine->AddOnScreenDebugMessage")]
    public void AddOnScreenDebugMessage(int Key, float TimeToDisplay, FColor DisplayColor, string DebugMessage) { }

    public T CreateDefaultSubobject<T>(string SubobjectName, bool bTransient = false) { return default(T); }

    public T NewObject<T>() { return default(T); }

    public T CreateWidget<T>(UObject OwningObject) { return default(T); }

    public T Cast<T>(object o) { return default(T); }
    public T CastChecked<T>(object o) { return default; }

    public virtual void BeginDestroy() {}

    public string GetFName() { return default; }
    public string GetName() { return default; }

    public bool IsValidLowLevel() { return default; }

    public UClass GetClass() { return default; }
    /// <summary>
    ///  Add an object to the root set. This prevents the object and all
	/// its descendants from being deleted during garbage collection.
    /// </summary>
    public void AddToRoot() { }
    /// <summary>
    /// Remove an object from the root set.
    /// </summary>
    public void RemoveFromRoot() { }
    /// <summary>
    /// Returns true if this object is explicitly rooted
    /// </summary>
    /// <returns></returns>
    public bool IsRooted() { return false; }
    /// <summary>
    /// Returns the fully qualified pathname for this object as well as the name of the class, in the format:
	/// 'ClassName Outermost[.Outer].Name'.
    /// </summary>
    /// <param name="StopOuter"></param>
    /// <returns></returns>
    public string GetFullName( UObject StopOuter = null) { return ""; }
    /// <summary>
    /// Walks up the list of outers until it finds a package directly associated with the object.
    /// </summary>
    /// <returns></returns>
    public UPackage GetPackage() { return default; }
    /// <summary>
    /// Returns true if the object is contained in the specified outer. 
    /// </summary>
    /// <param name="SomeOuter"></param>
    /// <returns></returns>
    public bool IsInOuter(UObject SomeOuter) { return false; }
    /// <summary>
    /// Returns true if the object is contained in the specified package.
    /// </summary>
    /// <param name="SomePackage"></param>
    /// <returns></returns>
    public bool IsInPackage( UPackage SomePackage) { return false; }
    /// <summary>
    /// Returns true if this object is of the specified type.
    /// </summary>
    /// <param name="SomeBaseClass"></param>
    /// <returns></returns>
    public bool IsInA( UClass SomeBaseClass ) { return false; }
    /// <summary>
    /// Returns true if this object is of the specified type.
    /// </summary>
    /// <typeparam name="OtherClassType"></typeparam>
    /// <param name="SomeBase"></param>
    /// <returns></returns>
    public bool IsA<OtherClassType>(OtherClassType SomeBase) { return false; }
    /// <summary>
    /// Returns whether this component was instanced from a component/subobject template, or if it is a component/subobject template.
    /// </summary>
    /// <returns></returns>
    public bool IsDefaultSubobject() { return false; }
    public static void DrawDebugLine(UWorld InWorld, FVector LineStart, FVector LineEnd, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugPoint(UWorld InWorld, FVector Position, float Size, FColor PointColor, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    public static void DrawDebugDirectionalArrow(UWorld InWorld, FVector LineStart, FVector LineEnd, float ArrowSize, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugBox(UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    // public static void DrawDebugBox(UWorld InWorld, FVector Center, FVector Extent, FQuat& Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugCoordinateSystem(UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugCrosshairs(UWorld InWorld, FVector AxisLoc, FRotator AxisRot, float Scale, FColor Color = default(FColor), bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawDebugCircle(UWorld InWorld, FMatrix& TransformMatrix, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f, bool bDrawAxis = true) { }
    public static void DrawDebugCircle(UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f, FVector YAxis = default(FVector), FVector ZAxis = default(FVector), bool bDrawAxis = true) { }
    public static void DrawDebugCircleArc(UWorld InWorld, FVector Center, float Radius, FVector Direction, float AngleWidth, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    // public static void DrawDebug2DDonut(UWorld InWorld, FMatrix& TransformMatrix, float InnerRadius, float OuterRadius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugSphere(UWorld InWorld, FVector Center, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugCylinder(UWorld InWorld, FVector Start, FVector End, float Radius, int Segments, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugCone(UWorld InWorld, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugAltCone(UWorld InWorld, FVector Origin, FRotator Rotation, float Length, float AngleWidth, float AngleHeight, FColor DrawColor, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawDebugString(UWorld InWorld, FVector TextLocation, string Text, AActor TestBaseActor = null, FColor TextColor = default(FColor), double Duration = -1.000000, bool bDrawShadow = false, float FontScale = 1.0f) { }
    // public static void DrawDebugFrustum(UWorld InWorld, FMatrix& FrustumToWorld, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void DrawCircle(UWorld InWorld, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0) { }
    // public static void DrawDebugCapsule(UWorld InWorld, FVector Center, float HalfHeight, float Radius, FQuat& Rotation, FColor Color, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0) { }
    public static void DrawDebugCamera(UWorld InWorld, FVector Location, FRotator Rotation, float FOVDeg, float Scale = 1.0f, FColor Color = default(FColor), bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawCentripetalCatmullRomSpline(UWorld InWorld, TConstArrayView<FVector> Points, FColor Color, float Alpha = 0.5f, int NumSamplesPerSegment = 8, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    // public static void DrawCentripetalCatmullRomSpline(UWorld InWorld, TConstArrayView<FVector> Points, TConstArrayView<FColor> Colors, float Alpha = 0.5f, int NumSamplesPerSegment = 8, bool bPersistentLines = false, float LifeTime = -1.0f, int DepthPriority = 0, float Thickness = 0.0f) { }
    public static void FlushDebugStrings(UWorld InWorld) { }
    // public static void DrawDebugSolidBox(UWorld InWorld, FBox Box, FColor Color, FTransform& Transform = FTransform::Identity, bool bPersistent = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawDebugSolidBox(UWorld InWorld, FVector Center, FVector Extent, FColor Color, bool bPersistent = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawDebugSolidBox(UWorld InWorld, FVector Center, FVector Extent, FQuat Rotation, FColor Color, bool bPersistent = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawDebugMesh(UWorld InWorld, TArray<FVector> Verts, TArray<int> Indices, FColor Color, bool bPersistent = false, float LifeTime = -1.0f, int DepthPriority = 0) { }
    // public static void DrawDebugSolidPlane(UWorld InWorld, FPlane P, FVector Loc, float Size, FColor Color, bool bPersistent = false, float LifeTime = -1, int DepthPriority = 0) { }
    // public static void DrawDebugSolidPlane(UWorld InWorld, FPlane P, FVector Loc, FVector2D Extents, FColor Color, bool bPersistent = false, float LifeTime = -1, int DepthPriority = 0) { }
    // public static void DrawDebugFloatHistory(UWorld WorldRef, FDebugFloatHistoryFloatHistory, FTransformDrawTransform, FVector2DDrawSize, FColorDrawColor, boolbPersistent = false, floatLifeTime = -1.0f, intDepthPriority = 0) { }
    // public static void DrawDebugFloatHistory(UWorld WorldRef, FDebugFloatHistoryFloatHistory, FVectorDrawLocation, FVector2DDrawSize, FColorDrawColor, boolbPersistent = false, floatLifeTime = -1.0f, intDepthPriority = 0) { }
    // public static void DrawDebugCanvas2DLine(UCanvas Canvas, FVector Start, FVector End, FLinearColor& LineColor) { }
    //public static void DrawDebugCanvas2DLine(UCanvas Canvas, FVector2D StartPosition, FVector2D EndPosition, FLinearColor& LineColor, float LineThickness = 1.0f) { }
    //public static void DrawDebugCanvas2DCircle(UCanvas Canvas, FVector2D& Center, float Radius, int NumSides, FLinearColor& LineColor, float& LineThickness = 1.0f) { }
    //public static void DrawDebugCanvas2DBox(UCanvas Canvas, FBox2D& Box, FLinearColor& LineColor, float& LineThickness = 1.0f) { }
    //public static void DrawDebugCanvasLine(UCanvas Canvas, FVector Start, FVector End, FLinearColor& LineColor) { }
    //public static void DrawDebugCanvasCircle(UCanvas Canvas, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides) { }
    //public static void DrawDebugCanvasHalfCircle(UCanvas Canvas, FVector Base, FVector X, FVector Y, FColor Color, float Radius, int NumSides) { }
    //public static void DrawDebugCanvasWireSphere(UCanvas Canvas, FVector Base, FColor Color, float Radius, int NumSides) { }
    //public static void DrawDebugCanvasWireCone(UCanvas Canvas, FTransform& Transform, float ConeRadius, float ConeAngle, int ConeSides, FColor Color) { }
    //public static void DrawDebugCanvasWireBox(UCanvas Canvas, FMatrix& Transform, FBox& Box, FColor Color) { }
    //public static void DrawDebugCanvasCapsule(UCanvas Canvas, FMatrix& Transform, float HalfLength, float Radius, FColor LineColor) { }

}

public enum ELogVerbosity
{
    /** Not used */
    NoLogging = 0,

    /** Always prints a fatal error to console (and log file) and crashes (even if logging is disabled) */
    Fatal,

    /** 
     * Prints an error to console (and log file). 
     * Commandlets and the editor collect and report errors. Error messages result in commandlet failure.
     */
    Error,

    /** 
     * Prints a warning to console (and log file).
     * Commandlets and the editor collect and report warnings. Warnings can be treated as an error.
     */
    Warning,

    /** Prints a message to console (and log file) */
    Display,

    /** Prints a message to a log file (does not print to console) */
    Log,

    /** 
     * Prints a verbose message to a log file (if Verbose logging is enabled for the given category, 
     * usually used for detailed logging) 
     */
    Verbose,

    /** 
     * Prints a verbose message to a log file (if VeryVerbose logging is enabled, 
     * usually used for detailed logging that would otherwise spam output) 
     */
    VeryVerbose,

    // Log masks and special Enum values

    All = VeryVerbose,
    NumVerbosity,
    VerbosityMask = 0xf,
    SetColor = 0x40, // not actually a verbosity, used to set the color of an output device 
    BreakOnLog = 0x80
}
