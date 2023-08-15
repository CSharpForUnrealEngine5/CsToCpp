namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure for collision response templates.</summary>
[CppInclude("Engine/CollisionProfile.h")]
public partial struct FCollisionResponseTemplate {
	public FName Name;
	public ECollisionEnabled CollisionEnabled;
	public bool bCanModify;
	public FName ObjectTypeName;
	public TArray<FResponseChannel> CustomResponses;
	public string HelpMessage;
}
