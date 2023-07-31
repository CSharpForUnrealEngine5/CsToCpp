#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An actor used to generate collision events (begin/end overlap) in the level.</summary>
[CppInclude("Engine/TriggerBase.h")]
public partial class ATriggerBase : AActor {
	///<summary>Shape component used for collision</summary>
	public UShapeComponent CollisionComponent;
	///<summary>Billboard used to see the trigger in the editor</summary>
	public UBillboardComponent SpriteComponent;
}
