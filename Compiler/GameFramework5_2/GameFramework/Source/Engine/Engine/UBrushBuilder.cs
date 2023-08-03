#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class of UnrealEd brush builders.</summary>
[CppInclude("Engine/BrushBuilder.h")]
public partial class UBrushBuilder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>BitmapFilename</summary>
	public string BitmapFilename;
	///<summary>localized FString that will be displayed as the name of this brush builder in the editor</summary>
	public string ToolTip;
	///<summary>If false, disabled the bad param notifications</summary>
	public bool NotifyBadParams;
	///<summary>Vertices</summary>
	public TArray<FVector> Vertices;
	///<summary>Polys</summary>
	public TArray<FBuilderPoly> Polys;
	///<summary>Layer</summary>
	public string Layer;
	///<summary>MergeCoplanars</summary>
	public bool MergeCoplanars;
}
