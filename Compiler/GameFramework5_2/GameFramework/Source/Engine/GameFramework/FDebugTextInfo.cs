#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Single entry of a debug text item to render.</summary>
[CppInclude("GameFramework/DebugTextInfo.h")]
public partial struct FDebugTextInfo {
	public AActor SrcActor;
	public FVector SrcActorOffset;
	public FVector SrcActorDesiredOffset;
	public string DebugText;
	public float TimeRemaining;
	public float Duration;
	public FColor TextColor;
	public bool bAbsoluteLocation;
	public bool bKeepAttachedToActor;
	public bool bDrawShadow;
	public FVector OrigActorLocation;
	public UFont Font;
	public float FontScale;
}
