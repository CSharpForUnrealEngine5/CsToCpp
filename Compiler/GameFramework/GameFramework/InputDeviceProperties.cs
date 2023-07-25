using CSharpToCpp.Utilities;

namespace GameFramework {

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceProperty : UObject {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UColorInputDeviceProperty : UInputDeviceProperty {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UColorInputDeviceCurveProperty : UInputDeviceProperty {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceTriggerEffect : UInputDeviceProperty {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceTriggerFeedbackProperty : UInputDeviceTriggerEffect {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceTriggerResistanceProperty : UInputDeviceTriggerEffect {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceTriggerVibrationProperty : UInputDeviceTriggerEffect {
    }

    [CppInclude("GameFramework/InputDeviceProperties.h")]
    public partial class UInputDeviceAudioBasedVibrationProperty : UInputDeviceProperty {
    }

}