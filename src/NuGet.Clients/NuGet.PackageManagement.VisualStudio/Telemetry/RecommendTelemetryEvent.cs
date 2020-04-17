// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using NuGet.Common;

namespace NuGet.PackageManagement.Telemetry
{
    public class RecommendTelemetryEvent : TelemetryEvent
    {
        public RecommendTelemetryEvent(int recommendedCount, double duration) : base("RecommendPackages")
        {
            base["RecommendedCount"] = recommendedCount;
            base["Duration"] = duration;
        }
    }
}
