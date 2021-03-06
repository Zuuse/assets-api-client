// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Zuuse.Assets.Client.Models
{
    /// <summary> The AssetMeasureInfo. </summary>
    public partial class AssetMeasureInfo
    {
        /// <summary> Initializes a new instance of AssetMeasureInfo. </summary>
        public AssetMeasureInfo()
        {
        }

        /// <summary> Initializes a new instance of AssetMeasureInfo. </summary>
        /// <param name="id"> . </param>
        /// <param name="name"> . </param>
        /// <param name="type"> . </param>
        /// <param name="minimum"> . </param>
        /// <param name="maximum"> . </param>
        /// <param name="aggregation"> . </param>
        internal AssetMeasureInfo(string id, string name, string type, int? minimum, int? maximum, string aggregation)
        {
            Id = id;
            Name = name;
            Type = type;
            Minimum = minimum;
            Maximum = maximum;
            Aggregation = aggregation;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int? Minimum { get; set; }
        public int? Maximum { get; set; }
        public string Aggregation { get; set; }
    }
}
