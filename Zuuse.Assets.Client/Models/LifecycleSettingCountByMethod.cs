// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Zuuse.Assets.Client.Models
{
    /// <summary> The LifecycleSettingCountByMethod. </summary>
    public partial class LifecycleSettingCountByMethod
    {
        /// <summary> Initializes a new instance of LifecycleSettingCountByMethod. </summary>
        internal LifecycleSettingCountByMethod()
        {
        }

        /// <summary> Initializes a new instance of LifecycleSettingCountByMethod. </summary>
        /// <param name="lifecycleMethodId"> . </param>
        /// <param name="settingCount"> . </param>
        internal LifecycleSettingCountByMethod(int? lifecycleMethodId, int? settingCount)
        {
            LifecycleMethodId = lifecycleMethodId;
            SettingCount = settingCount;
        }

        public int? LifecycleMethodId { get; }
        public int? SettingCount { get; }
    }
}
