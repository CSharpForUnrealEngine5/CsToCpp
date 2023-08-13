namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure to identify a ColorSpace as described in an OCIO configuration file.</summary>
[CppInclude("OpenColorIOColorSpace.h")]
public partial struct FOpenColorIOColorSpace {
	public string ColorSpaceName;
	public int ColorSpaceIndex;
	public string FamilyName;
}
