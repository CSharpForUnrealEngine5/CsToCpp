#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UTickableTranslationConstraint</summary>
[CppInclude("TransformConstraint.h")]
public partial class UTickableTranslationConstraint : UTickableTransformConstraint {
	public static UClass StaticClass() {return default;}
	///<summary>Defines the local child&#39;s translation offset in the parent space.</summary>
	public FVector OffsetTranslation;
	///<summary>Defines which translation axis is constrained.</summary>
	public FFilterOptionPerAxis AxisFilter;
}
