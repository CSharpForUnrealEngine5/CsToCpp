#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for collision response templates.</summary>
[CppInclude("Engine/CollisionProfile.h")]
public partial struct FCollisionResponseTemplate {
	public string Name;
	public ECollisionEnabled CollisionEnabled;
	public bool bCanModify;
	public string ObjectTypeName;
	public TArray<FResponseChannel> CustomResponses;
	public string HelpMessage;
}
