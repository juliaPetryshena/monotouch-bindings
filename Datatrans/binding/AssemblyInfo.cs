using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("libdtipl.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true, LinkerFlags = "-lxml2")]
