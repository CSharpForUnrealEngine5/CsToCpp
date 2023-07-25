using CSharpToCpp.Utilities;

#pragma warning disable IDE0060
#pragma warning disable CA1822
#pragma warning disable CS8603

namespace GameFramework
{
    /** 
      * The base partial class of all UE objects. The type of an object is defined by its UClass.
      * This provides support functions for creating and using objects, and virtual functions that should be overridden in child classes.
      */
    [CppInclude("UObject/Object.h")]
    [CppPointer]
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

        [CppCode("Log", "GLog->Log")]
        public void Log(string message) { }

        [CppCode("Log", "GLog->Log")]
        public void Log(ELogVerbosity verbosity, string message) { }

        [CppCode("Log", "GLog->Log")]
        public void Log(string category, ELogVerbosity verbosity, string message) { }
        [CppCode("AddOnScreenDebugMessage", "GEngine->AddOnScreenDebugMessage")]
        public void AddOnScreenDebugMessage(int Key, float TimeToDisplay, FColor DisplayColor, string DebugMessage, bool bNewerOnTop, FVector2D TextScale) { }

        public T CreateDefaultSubobject<T>(string SubobjectName, bool bTransient = false) { return default(T); }

        public T NewObject<T>() { return default(T); }

        public T Cast<T>(object o) { return default(T); }
        public T CastChecked<T>(object o) { return default; }

        public virtual void BeginDestroy() { throw new NotImplementedException(); }

        public string GetFName() { throw new NotImplementedException(); }

        public static void FlushPersistentDebugLines(UWorld InWorld) { }
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

}