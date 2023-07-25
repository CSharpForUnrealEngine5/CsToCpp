#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttributeSet.h")]
///<summary>DataTable that allows us to define meta data about attributes. Still a work in progress.</summary>
public partial struct FAttributeMetaData {
// AttributeMetaData
	public float BaseValue;
	public float MinValue;
	public float MaxValue;
	public string DerivedAttributeInfo;
	public bool bCanStack;
}
