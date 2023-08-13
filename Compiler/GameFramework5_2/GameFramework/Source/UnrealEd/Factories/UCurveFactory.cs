namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Factory that creates curve assets, prompting to pick the kind of curve at creation time</summary>
[CppInclude("Factories/CurveFactory.h")]
public partial class UCurveFactory : UFactory {
	public static UClass StaticClass() {return default;}
	///<summary>The type of blueprint that will be created</summary>
	public UClass CurveClass;
}
