namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for custom profiles.</summary>
[CppInclude("Engine/CollisionProfile.h")]
public partial struct FCustomProfile {
	public string Name;
	public TArray<FResponseChannel> CustomResponses;
}
