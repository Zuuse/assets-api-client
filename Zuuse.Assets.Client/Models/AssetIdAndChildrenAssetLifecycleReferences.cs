// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Assets.Client.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class AssetIdAndChildrenAssetLifecycleReferences
    {
        /// <summary>
        /// Initializes a new instance of the
        /// AssetIdAndChildrenAssetLifecycleReferences class.
        /// </summary>
        public AssetIdAndChildrenAssetLifecycleReferences()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// AssetIdAndChildrenAssetLifecycleReferences class.
        /// </summary>
        public AssetIdAndChildrenAssetLifecycleReferences(System.Guid? id = default(System.Guid?), IList<AssetLifecycleReference> children = default(IList<AssetLifecycleReference>))
        {
            Id = id;
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Children")]
        public IList<AssetLifecycleReference> Children { get; set; }

    }
}
