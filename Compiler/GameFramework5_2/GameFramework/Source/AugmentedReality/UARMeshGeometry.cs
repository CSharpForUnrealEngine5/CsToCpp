#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARTrackable.h")]
public partial class UARMeshGeometry : UARTrackedGeometry {
	public static UClass StaticClass() {return default;}
	///<summary>Try to determine the classification of the object at a world space location</summary>
	public  bool GetObjectClassificationAtLocation(FVector InWorldLocation,EARObjectClassification OutClassification,FVector OutClassificationLocation,float MaxLocationDiff/*=10.0f*/) { return default; }
}
