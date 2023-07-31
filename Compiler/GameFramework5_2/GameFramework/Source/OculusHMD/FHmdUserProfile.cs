#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OculusFunctionLibrary.h")]
public partial struct FHmdUserProfile {
	public string Name;
	public string Gender;
	public float PlayerHeight;
	public float EyeHeight;
	public float IPD;
	public FVector2D NeckToEyeDistance;
	public TArray<FHmdUserProfileField> ExtraFields;
}
