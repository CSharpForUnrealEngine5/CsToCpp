namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>DataTable that allows us to define meta data about attributes. Still a work in progress.</summary>
[CppInclude("AttributeSet.h")]
public partial struct FAttributeMetaData {
	public float BaseValue;
	public float MinValue;
	public float MaxValue;
	public string DerivedAttributeInfo;
	public bool bCanStack;
}
