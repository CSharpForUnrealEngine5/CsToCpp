namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CurveExpressionsDataAsset.h")]
public partial class UCurveExpressionsDataAsset : UDataAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Expressions</summary>
	public FCurveExpressionList Expressions;
	///<summary>NamedConstants</summary>
	public TArray<FName> NamedConstants;
}
