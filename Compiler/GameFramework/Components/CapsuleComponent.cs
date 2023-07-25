using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("Components/CapsuleComponent.h")]
    public partial class UCapsuleComponent : UShapeComponent {
        public void InitCapsuleSize(float InRadius, float InHalfHeight) { }
    }

}