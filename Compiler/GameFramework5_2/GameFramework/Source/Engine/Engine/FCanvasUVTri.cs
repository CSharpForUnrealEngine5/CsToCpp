namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple 2d triangle with UVs</summary>
[CppInclude("Engine/EngineTypes.h")]
public partial struct FCanvasUVTri {
	public FVector2D V0_Pos;
	public FVector2D V0_UV;
	public FLinearColor V0_Color;
	public FVector2D V1_Pos;
	public FVector2D V1_UV;
	public FLinearColor V1_Color;
	public FVector2D V2_Pos;
	public FVector2D V2_UV;
	public FLinearColor V2_Color;
}
