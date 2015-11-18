using System;
using ObjCRuntime;

[assembly: LinkWith ("Charts.a",
                     LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.Arm64,
                     SmartLink = true,
                     ForceLoad = true,
                     LinkerFlags = "-lz",
                     Frameworks = "AVFoundation CoreMedia SystemConfiguration CoreGraphics",
                     IsCxx = true)]
