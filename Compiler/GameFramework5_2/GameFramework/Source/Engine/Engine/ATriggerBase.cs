#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/TriggerBase.h")]
///<summary>An actor used to generate collision events (begin/end overlap) in the level.</summary>
public partial class ATriggerBase : AActor {
// TriggerBase
	public UShapeComponent CollisionComponent;
	public UBillboardComponent SpriteComponent;
}
