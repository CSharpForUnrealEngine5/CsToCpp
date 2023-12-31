namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Persists graphical state of the node associated with this action asset</summary>
[CppInclude("DataprepActionAsset.h")]
public partial class UDataprepActionAppearance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>bIsExpanded</summary>
	public bool bIsExpanded;
	///<summary>NodeSize</summary>
	public FVector2D NodeSize;
	///<summary>GroupId</summary>
	public int GroupId;
	///<summary>bGroupIsEnabled</summary>
	public bool bGroupIsEnabled;
}
