namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A function library that provides static/Blueprint functions associated with GoogleARCore session.</summary>
[CppInclude("GoogleARCoreFunctionLibrary.h")]
public partial class UGoogleARCoreSessionFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Create an ARCandidateImage object from the raw pixel data and add it to the ARCandidateImageList of the given \c UARSessionConfig object.</summary>
	public static UARCandidateImage AddRuntimeCandidateImageFromRawbytes(UARSessionConfig SessionConfig,TArray<byte> ImageGrayscalePixels,int ImageWidth,int ImageHeight,string FriendlyName,float PhysicalWidth,UTexture2D CandidateTexture/*=nullptr*/) { return default; }
}
