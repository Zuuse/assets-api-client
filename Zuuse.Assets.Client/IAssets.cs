// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Zuuse.Assets.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Assets operations.
    /// </summary>
    public partial interface IAssets
    {
        /// <summary>
        /// Retrieve a single asset by Guid
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The asset Guid to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Asset>> GetAssetWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post a single asset
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The Id of the asset
        /// </param>
        /// <param name='asset'>
        /// The Asset to insert/update. contained in the httppost body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<string>> PostAssetWithHttpMessagesAsync(string client, string id, Asset asset, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a single asset by Guid, will only return assets that are
        /// active in the hierarchy
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The asset Guid to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Asset>> GetActiveInHierarchyAssetByIdWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the partial location/function asset tree from the asset
        /// itself to its top level location/function parent
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The asset Guid to retrieve.
        /// </param>
        /// <param name='taxonomyType'>
        /// The type of tree to build. Possible values include: 'Location',
        /// 'Function'
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<AssetIdAndChildrenAssetReferences>>> GetParentsOfAssetWithHttpMessagesAsync(string client, string id, string taxonomyType, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the partial assetlifecycle tree from the asset itself to
        /// its top level location/function parent
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='id'>
        /// The asset Guid to retrieve.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<AssetIdAndChildrenAssetReferences>>> GetLifecycleStateParentsOfAssetWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the count of all lifecycle settings grouped by method type
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<LifecycleSettingCountByMethod>>> GetCountsOfLifecycleSettingsWithHttpMessagesAsync(string client, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets the hierarchial active state of the asset
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='id'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<bool?>> GetInheritedIsActiveStateOfAssetWithHttpMessagesAsync(string client, string id, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Post a list of assets
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='assets'>
        /// List of assets to post, contained in the httppost body
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<string>>> PostAssetsWithHttpMessagesAsync(string client, IList<Asset> assets, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a summary of Asset Guids
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='ids'>
        /// Optionally supply the Asset IDs to get summaries for, space
        /// separated.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<SyncSummaryElement>>> GetAssetSummaryWithHttpMessagesAsync(string client, string ids = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieve a collection of assets by space separated Guids
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='terms'>
        /// Space separated Guids of assets ids
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<Asset>>> SearchAssetsWithHttpMessagesAsync(string client, string terms, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the functional taxonomy for all assets, such as the
        /// Omniclass hierarchy.
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='depth'>
        /// Optionally prunes the functional taxonomy to only include the
        /// indicated levels.
        /// </param>
        /// <param name='inactive'>
        /// Optionally returns inactive assets as well as active ones
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TaxonomyLevelDescriptor>>> GetFunctionalTaxonomyWithHttpMessagesAsync(string client, int? depth = default(int?), bool? inactive = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the functional taxonomy for all assets, such as the
        /// Omniclass hierarchy.
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='depth'>
        /// Optionally prunes the functional taxonomy to only include the
        /// indicated levels.
        /// </param>
        /// <param name='inactive'>
        /// Optionally returns inactive assets as well as active ones
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TaxonomyLevelDescriptor>>> GetLocationTaxonomyWithHttpMessagesAsync(string client, int? depth = default(int?), bool? inactive = default(bool?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the children for the supplied asset IDs, such as the
        /// Omniclass hierarchy.
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='assetIds'>
        /// Space separated Guids of assets ids
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TaxonomyLevelDescriptor>>> GetChildrenForAssetsWithHttpMessagesAsync(string client, string assetIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the children for the supplied asset locations by name.
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='layerIndex'>
        /// </param>
        /// <param name='layer0'>
        /// </param>
        /// <param name='layer1'>
        /// </param>
        /// <param name='layer2'>
        /// </param>
        /// <param name='layer3'>
        /// </param>
        /// <param name='layer4'>
        /// </param>
        /// <param name='layer5'>
        /// </param>
        /// <param name='layer6'>
        /// </param>
        /// <param name='layer7'>
        /// </param>
        /// <param name='layer8'>
        /// </param>
        /// <param name='layer9'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TaxonomyLevelDescriptor>>> SearchAssetLocationsByNameWithHttpMessagesAsync(string client, int? layerIndex = default(int?), string layer0 = default(string), string layer1 = default(string), string layer2 = default(string), string layer3 = default(string), string layer4 = default(string), string layer5 = default(string), string layer6 = default(string), string layer7 = default(string), string layer8 = default(string), string layer9 = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the children for the supplied asset IDs, such as the
        /// Omniclass hierarchy.
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='layerIndex'>
        /// </param>
        /// <param name='layer0'>
        /// </param>
        /// <param name='layer1'>
        /// </param>
        /// <param name='layer2'>
        /// </param>
        /// <param name='layer3'>
        /// </param>
        /// <param name='layer4'>
        /// </param>
        /// <param name='layer5'>
        /// </param>
        /// <param name='layer6'>
        /// </param>
        /// <param name='layer7'>
        /// </param>
        /// <param name='layer8'>
        /// </param>
        /// <param name='layer9'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<TaxonomyLevelDescriptor>>> SearchAssetFunctionsByNameWithHttpMessagesAsync(string client, int? layerIndex = default(int?), string layer0 = default(string), string layer1 = default(string), string layer2 = default(string), string layer3 = default(string), string layer4 = default(string), string layer5 = default(string), string layer6 = default(string), string layer7 = default(string), string layer8 = default(string), string layer9 = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all physical children for provided VirtualAssetID
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='virtualAssetId'>
        /// Guid of the virtualAsset you want the children of
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<string>>> GetAllPhysicalChildrenAssetIdsOfVirtualAssetWithHttpMessagesAsync(string client, string virtualAssetId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns all physical children for provided VirtualAssetID
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='virtualAssetId'>
        /// Guid of the virtualAsset you want the children of
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<string>>> GetAllPhysicalChildrenAssetsOfVirtualAssetWithHttpMessagesAsync(string client, string virtualAssetId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the AssetLifecycleReference for the Children of provided asset,
        /// if Guid.Empty will get the functional Roots children
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='assetId'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<AssetLifecycleReference>>> GetAssetLifecycleReferencesForChildrenWithHttpMessagesAsync(string client, string assetId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Update the AssetLifecycleStatistic of provided asset to provided
        /// state
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='assetId'>
        /// </param>
        /// <param name='lifecycleState'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> UpdateAssetLifecycleStatisticsWithHttpMessagesAsync(string client, string assetId, int lifecycleState, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Returns the asset template with configuration settings for an
        /// asset, including function and location taxonomy data as well as
        /// numeric and text attributes.
        /// </summary>
        /// <param name='client'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AssetTemplate>> GetAssetTemplateWithHttpMessagesAsync(string client, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Saves or updates an asset template
        /// </summary>
        /// <param name='client'>
        /// The name of the client account
        /// </param>
        /// <param name='template'>
        /// The template object to be persisted
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AssetTemplate>> PostAssetTemplateWithHttpMessagesAsync(string client, AssetTemplate template, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Get the root asset for the list of assets
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='assetIds'>
        /// Space separated Guids of assets ids
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Asset>> GetRootAssetForIdsWithHttpMessagesAsync(string client, string assetIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gets a list of Asset counts using parent asset Id's
        /// </summary>
        /// <param name='client'>
        /// The name of the client account.
        /// </param>
        /// <param name='assetIds'>
        /// Space separated Guids of assets ids
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<PhysicalAssetCountForTaxonomy>>> GetPhysicalAssetCountForIdsWithHttpMessagesAsync(string client, string assetIds, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
