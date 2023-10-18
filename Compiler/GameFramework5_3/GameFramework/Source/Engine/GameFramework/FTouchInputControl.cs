namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/TouchInterface.h")]
public partial struct FTouchInputControl {
	public bool bTreatAsButton;
	public UTexture2D Image1;
	public UTexture2D Image2;
	public FVector2D Center;
	public FVector2D VisualSize;
	public FVector2D ThumbSize;
	public FVector2D InteractionSize;
	public FVector2D InputScale;
	public FKey MainInputKey;
	public FKey AltInputKey;
}
